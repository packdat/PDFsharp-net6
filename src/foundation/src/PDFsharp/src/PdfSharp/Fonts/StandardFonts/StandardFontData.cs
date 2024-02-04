namespace PdfSharp.Fonts.StandardFonts
{
    /// <summary>
    /// Provides the data for the 14 Standard-Fonts defined in the PDF-specification.<br></br>
    /// Pdf spec. 1.7, Chapter 9.6.2.2: Standard Type 1 Fonts (Standard 14 Fonts)<br></br>
    /// Mainly intended for existing documents which use one or more of the standard-fonts without embedding them.<br></br>
    /// Used in conjunction with the <see cref="DocumentFontResolver"/>
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
            if (string.IsNullOrWhiteSpace(fontName))
                return null;

            // if the name comes from a resource-dictionary...
            if (fontName.StartsWith("/"))
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
            if (string.IsNullOrWhiteSpace(fontName))
                return false;
            return FontNames.Contains(fontName.TrimStart('/'));
        }

        /// <summary>
        /// Get the names of the supported standard-fonts
        /// </summary>
        public static IEnumerable<string> FontNames => fontData.Keys;        

        private static readonly Dictionary<string, byte[]> fontData = new()
        {
            { StandardFontNames.Courier, Courier.FontData },
            { StandardFontNames.CourierBold, CourierBold.FontData },
            { StandardFontNames.CourierItalic, CourierItalic.FontData },
            { StandardFontNames.CourierBoldItalic, CourierBoldItalic.FontData },

            { StandardFontNames.Helvetica, Helvetica.FontData },
            { StandardFontNames.HelveticaBold, HelveticaBold.FontData },
            { StandardFontNames.HelveticaItalic, HelveticaItalic.FontData },
            { StandardFontNames.HelveticaBoldItalic, HelveticaBoldItalic.FontData },

            { StandardFontNames.Times, TimesRoman.FontData },
            { StandardFontNames.TimesBold, TimesRomanBold.FontData },
            { StandardFontNames.TimesItalic, TimesRomanItalic.FontData },
            { StandardFontNames.TimesBoldItalic, TimesRomanBoldItalic.FontData },

            { StandardFontNames.ZapfDingbats, ZapfDingbats.FontData },
            { StandardFontNames.Symbol, Symbol.FontData }
        };
    }
}
