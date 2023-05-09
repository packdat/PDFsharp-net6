namespace PdfSharp.Fonts.StandardFonts
{
    /// <summary>
    /// Provides the data for the 14 Standard-Fonts defined in the PDF-specification.<br></br>
    /// Pdf spec. 1.7, Chapter 9.6.2.2: Standard Type 1 Fonts (Standard 14 Fonts)
    /// </summary>
    public static class StandardFontData
    {
        /// <summary>
        /// Gets the data for the specified font
        /// </summary>
        /// <param name="fontName">Name of the font</param>
        /// <returns>Font-data or null if a font with the specified name could not be found</returns>
        public static byte[]? GetFontData(string fontName)
        {
            if (string.IsNullOrEmpty(fontName))
                return null;

            // if the name comes from a resource-dictionary...
            if (fontName.StartsWith('/'))
                fontName = fontName.TrimStart('/');

            if (fontData.TryGetValue(fontName, out var data))
                return data;
            return null;
        }

        /// <summary>
        /// Indicates, whether the specified <paramref name="fontName"/> is one of the 14 Standard-Fonts
        /// </summary>
        /// <param name="fontName">Font-name to check</param>
        /// <returns>true, if <paramref name="fontName"/> is one of the 14 Standard-Fonts, otherwise false</returns>
        public static bool IsStandardFont(string fontName)
        {
            return FontNames.Contains(fontName.TrimStart('/'));
        }

        /// <summary>
        /// Get the names of the supported standard-fonts
        /// </summary>
        public static IEnumerable<string> FontNames => fontData.Keys;        

        private static readonly Dictionary<string, byte[]> fontData = new()
        {
            { "Courier", Courier.FontData },
            { "Courier-Bold", CourierBold.FontData },
            { "Courier-Oblique", CourierItalic.FontData },
            { "Courier-BoldOblique", CourierBoldItalic.FontData },

            { "Helvetica", Helvetica.FontData },
            { "Helvetica-Bold", HelveticaBold.FontData },
            { "Helvetica-Oblique", HelveticaItalic.FontData },
            { "Helvetica-BoldOblique", HelveticaBoldItalic.FontData },

            { "Times-Roman", TimesRoman.FontData },
            { "Times-Bold", TimesRomanBold.FontData },
            { "Times-Italic", TimesRomanItalic.FontData },
            { "Times-BoldItalic", TimesRomanBoldItalic.FontData },

            { "ZapfDingbats", ZapfDingbats.FontData },
            { "Symbol", Symbol.FontData }
        };
    }
}
