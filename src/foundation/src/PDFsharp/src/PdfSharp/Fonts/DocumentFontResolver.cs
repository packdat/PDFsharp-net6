using PdfSharp.Drawing;
using PdfSharp.Fonts.OpenType;
using PdfSharp.Fonts.StandardFonts;
using PdfSharp.Pdf;
using PdfSharp.Pdf.AcroForms;
using PdfSharp.Pdf.Advanced;

namespace PdfSharp.Fonts
{
    /// <summary>
    /// Resolves the 14 standard-fonts and/or fonts in existing documents.<br></br>
    /// </summary>
    public class DocumentFontResolver : IFontResolver
    {
        private static readonly Dictionary<string, byte[]> localFonts = new();
        private static readonly Dictionary<string, string> registeredFontFiles = new(StringComparer.OrdinalIgnoreCase);
        private static string? fallbackFontName;

        private readonly PdfDocument? document;
        private readonly PdfAcroField? acroField;

        /// <summary>
        /// Registers a new font
        /// </summary>
        /// <param name="fontName">The name of the font</param>
        /// <param name="fontData">The font-data</param>
        /// <param name="isBold">Specifies, whether the font is bold</param>
        /// <param name="isItalic">Specifies, whether the font is italic</param>
        public static void Register(string fontName, byte[] fontData, bool isBold = false, bool isItalic = false)
        {
            var localName = MakeLocalName(fontName, isBold, isItalic);
            localFonts[localName] = fontData;
            // get the name stored in the font itself
            var fontSource = XFontSource.GetOrCreateFrom(fontData, false);
            var typeFace = new OpenTypeFontface(fontSource);
            if (!string.IsNullOrEmpty(typeFace.FullFaceName))
            {
                localName = MakeLocalName(typeFace.FullFaceName, isBold, isItalic);
                localFonts[localName] = fontData;
            }    
        }

#if !WPF
        /// <summary>
        /// Registers all (TrueType)-fonts from the specified folder and all sub-folders.<br></br>
        /// In an <see cref="XFont"/>, these fonts may be referenced by their filename or their full face-name.
        /// </summary>
        /// <param name="folderPath">The base path to load fonts from</param>
        /// <returns>The number of fonts that were found</returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public static int RegisterFolder(string folderPath)
        {
            if (string.IsNullOrEmpty(folderPath))
                throw new ArgumentNullException(nameof(folderPath), "Folder name may not be null or empty");
            if (!Directory.Exists(folderPath))
                throw new ArgumentException($"The folder {folderPath} does not exist", nameof(folderPath));

            var fontFiles = Directory.GetFiles(folderPath, "*.ttf", SearchOption.AllDirectories);
            var count = 0;
            foreach (var file in fontFiles)
            {
                try
                {
                    var data = File.ReadAllBytes(file);
                    // create Font-source without caching it
                    var fontSource = XFontSource.GetOrCreateFrom(data, false);
                    var font = new OpenTypeFontface(fontSource);
                    var fileName = Path.GetFileNameWithoutExtension(file);
                    registeredFontFiles[fileName] = file;
                    registeredFontFiles[font.FullFaceName] = file;
                    count++;
                }
                catch
                {
                }
            }
            return count;
        }
#endif

        /// <summary>
        /// Registers one of the <see cref="StandardFontNames"/> as the fallback font
        /// </summary>
        /// <param name="standardFontName"></param>
        /// <exception cref="ArgumentException"></exception>
        public static void RegisterFallbackFont(string standardFontName)
        {
            if (StandardFontData.IsStandardFont(standardFontName))
                fallbackFontName = standardFontName;
            else
                throw new ArgumentException($"'{standardFontName}' is not one of the standard font names");
        }

        /// <summary>
        /// Creates a new instance of the <see cref="DocumentFontResolver"/>
        /// </summary>
        /// <param name="document"></param>
        public DocumentFontResolver(PdfDocument? document = null)
        {
            this.document = document;
        }

        /// <summary>
        /// Internal constructor used by <see cref="PdfAcroField"/> to resolve fonts in an existing document.
        /// </summary>
        /// <param name="field"></param>
        internal DocumentFontResolver(PdfAcroField field)
        {
            document = field.Owner;
            acroField = field;
        }

        /// <summary>
        /// Gets the data for the specified font.
        /// </summary>
        /// <param name="faceName">Name of the font</param>
        /// <returns>Font data or null, if no font with the specified name could be found</returns>
        public byte[]? GetFont(string faceName)
        {
            var result = Resolve(faceName, false, false);
            if (result.Item1 == null && !string.IsNullOrEmpty(fallbackFontName))
                result = Resolve(fallbackFontName, false, false);
            return result.Item1;
        }

        /// <summary>
        /// Get a <see cref="FontResolverInfo"/> for the specified font
        /// </summary>
        /// <param name="familyName">Name of the font</param>
        /// <param name="isBold"></param>
        /// <param name="isItalic"></param>
        /// <returns>A <see cref="FontResolverInfo"/> or null, if no font with the specified name could be found</returns>
        public FontResolverInfo? ResolveTypeface(string familyName, bool isBold, bool isItalic)
        {
            var result = Resolve(familyName, isBold, isItalic);
            if (result.Item2 == null && !string.IsNullOrEmpty(fallbackFontName))
                result = Resolve(fallbackFontName, isBold, isItalic);
            return result.Item2;
        }

        private static string MakeLocalName(string fontName, bool isBold, bool isItalic)
        {
            return XGlyphTypeface.ComputeKey(fontName, isBold, isItalic);
        }

        private Tuple<byte[]?, FontResolverInfo?> Resolve(string fontName, bool isBold, bool isItalic)
        {
            var localName = MakeLocalName(fontName, isBold, isItalic);
            if (localFonts.TryGetValue(localName, out var localData))
                return new Tuple<byte[]?, FontResolverInfo?>(localData, new FontResolverInfo(fontName, isBold, isItalic));
            if (registeredFontFiles.TryGetValue(fontName, out var fileName))
            {
                var fileData = System.IO.File.ReadAllBytes(fileName);
                return new Tuple<byte[]?, FontResolverInfo?>(fileData, new FontResolverInfo(fontName, isBold, isItalic));
            }
            var data = StandardFontData.GetFontData(fontName);
            if (data != null)
            {
                Register(fontName, data, isBold, isItalic);
                return new Tuple<byte[]?, FontResolverInfo?>(data, new FontResolverInfo(fontName, isBold, isItalic));
            }
            if (document == null)
                return new Tuple<byte[]?, FontResolverInfo?>(null, null);

            // in a document, fonts are referenced by their name
            if (!fontName.StartsWith("/"))
                fontName = "/" + fontName;

            var possibleResources = new List<PdfDictionary?>
            {
                document.AcroForm?.Elements.GetDictionary(PdfAcroForm.Keys.DR),
                acroField?.Elements.GetDictionary(PdfAcroForm.Keys.DR)
            };
            foreach (var page in document.Pages)
            {
                possibleResources.Add(page.Resources);
            }
            foreach (var resources in possibleResources)
            {
                if (resources != null && resources.Elements.ContainsKey("/Font"))
                {
                    var fontList = resources.Elements.GetDictionary("/Font");
                    var fontRef = fontList?.Elements.GetReference(fontName);
                    if (fontRef != null)
                    {
                        var fontDict = fontRef.Value as PdfDictionary;
                        var descriptor = fontDict?.Elements.GetDictionary(PdfFont.Keys.FontDescriptor);
                        if (descriptor != null)
                        {
                            var fileRef = descriptor.Elements.GetDictionary(PdfFontDescriptor.Keys.FontFile2);
                            if (fileRef != null)
                            {
                                var fontData = fileRef?.Stream.UnfilteredValue;
                                return new Tuple<byte[]?, FontResolverInfo?>(fontData, new FontResolverInfo(fontName.TrimStart('/'), isBold, isItalic));
                            }
                            // font is not embedded. if we have a FontFamily, try to resolve that (it may be a registered font)
                            var familyName = descriptor.Elements.GetString(PdfFontDescriptor.Keys.FontFamily);
                            // try this only, if names differ (avoid stack overflow)
                            if (!string.IsNullOrEmpty(familyName) && familyName.TrimStart('/') != fontName.TrimStart('/'))
                            {
#if DEBUG_
                                Debug.WriteLine($"Resolve: {document?.FullPath ?? "null document"} - {fontName} -> {familyName}");
#endif
                                return Resolve(familyName.TrimStart('/'), isBold, isItalic);
                            }
                        }
                    }
                    else if (fontList != null)
                    {
                        // may be a Type0 Font, dig a bit deeper
                        foreach (var key in fontList.Elements.Keys)
                        {
                            if (fontList.Elements.GetObject(key) is PdfDictionary value)
                            {
                                var baseFont = value.Elements.GetName(PdfType0Font.Keys.BaseFont);
                                if (baseFont == fontName)
                                {
                                    var descendantFonts = value.Elements.GetArray(PdfType0Font.Keys.DescendantFonts);
                                    if (descendantFonts != null)
                                    {
                                        foreach (var descendantFont in descendantFonts.Elements)
                                        {
                                            var fontDict = descendantFont is PdfReference fref
                                                ? fref.Value as PdfDictionary
                                                : descendantFont as PdfDictionary;
                                            var descriptor = fontDict?.Elements.GetDictionary(PdfFont.Keys.FontDescriptor);
                                            if (descriptor != null)
                                            {
                                                var fileRef = descriptor.Elements.GetDictionary(PdfFontDescriptor.Keys.FontFile2);
                                                if (fileRef != null)
                                                {
                                                    var fontData = fileRef?.Stream.UnfilteredValue;
                                                    return new Tuple<byte[]?, FontResolverInfo?>(fontData, new FontResolverInfo(fontName.TrimStart('/'), isBold, isItalic));
                                                }
                                            }
                                        }
                                    }
                                    else if (value.Elements.ContainsKey(PdfFont.Keys.FontDescriptor))
                                    {
                                        var descriptor = value?.Elements.GetDictionary(PdfFont.Keys.FontDescriptor);
                                        if (descriptor != null)
                                        {
                                            var fileRef = descriptor.Elements.GetDictionary(PdfFontDescriptor.Keys.FontFile2);
                                            if (fileRef != null)
                                            {
                                                var fontData = fileRef?.Stream.UnfilteredValue;
                                                return new Tuple<byte[]?, FontResolverInfo?>(fontData, new FontResolverInfo(fontName.TrimStart('/'), isBold, isItalic));
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return new Tuple<byte[]?, FontResolverInfo?>(null, null);
        }
    }
}
