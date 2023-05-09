using PdfSharp.Fonts.StandardFonts;
using PdfSharp.Pdf;
using PdfSharp.Pdf.AcroForms;
using PdfSharp.Pdf.Advanced;

namespace PdfSharp.Fonts
{
    /// <summary>
    /// Resolves standard-fonts and/or fonts in existing documents.<br></br>
    /// </summary>
    public class DocumentFontResolver : IFontResolver
    {
        private readonly PdfDocument? document;
        private readonly PdfAcroField? acroField;

        /// <summary>
        /// Creates a new instance of the <see cref="DocumentFontResolver"/>
        /// </summary>
        /// <param name="document"></param>
        public DocumentFontResolver(PdfDocument? document = null)
        {
            this.document = document;
        }

        /// <summary>
        /// Internal constructor used by <see cref="PdfAcroField"/>
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
            var data = StandardFontData.GetFontData(faceName);
            if (data != null)
            {
                return data;
            }
            if (document == null)
                return null;

            if (!faceName.StartsWith('/'))
                faceName = "/" + faceName;

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
                    var fontRef = fontList?.Elements.GetReference(faceName);
                    if (fontRef != null)
                    {
                        var fontDict = fontRef.Value as PdfDictionary;
                        var descriptor = fontDict?.Elements.GetDictionary(PdfFont.Keys.FontDescriptor);
                        if (descriptor != null)
                        {
                            var fileRef = descriptor.Elements.GetDictionary(PdfFontDescriptor.Keys.FontFile2);
                            var fontData = fileRef?.Stream.UnfilteredValue;
                            if (fontData != null)
                            {
                                return fontData;
                            }
                        }
                    }
                }
            }
            return null;
        }

        /// <summary>
        /// Get a <see cref="FontResolverInfo"/> for the specified font
        /// </summary>
        /// <param name="familyName">Name of the font</param>
        /// <param name="isBold"></param>
        /// <param name="isItalic"></param>
        /// <returns>A <see cref="FontResolverInfo"/> or null, if no font with the specified name could be found</returns>
        public FontResolverInfo? ResolveTypeface(string familyName, Boolean isBold, Boolean isItalic)
        {
            var data = StandardFontData.GetFontData(familyName);
            if (data != null)
            {
                return new FontResolverInfo(familyName, isBold, isItalic);
            }
            if (document == null)
                return null;

            if (!familyName.StartsWith('/'))
                familyName = "/" + familyName;

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
                    var fontRef = fontList?.Elements.GetReference(familyName);
                    if (fontRef != null)
                    {
                        var fontDict = fontRef.Value as PdfDictionary;
                        var descriptor = fontDict?.Elements.GetDictionary(PdfFont.Keys.FontDescriptor);
                        if (descriptor != null)
                        {
                            var fileRef = descriptor.Elements.GetDictionary(PdfFontDescriptor.Keys.FontFile2);
                            if (fileRef != null)
                            {
                                return new FontResolverInfo(familyName.TrimStart('/'), isBold, isItalic);
                            }
                        }
                    }
                }
            }
            return null;
        }
    }
}
