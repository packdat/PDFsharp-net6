﻿// PDFsharp - A .NET library for processing PDF
// See the LICENSE file in the solution root for more information.

using System.Diagnostics;
using FluentAssertions;
using PdfSharp.Drawing;
using PdfSharp.Fonts;
using PdfSharp.Fonts.Internal;
using PdfSharp.Pdf;
using PdfSharp.Snippets.Font;
using PdfSharp.TestHelper;
using Xunit;

namespace PdfSharp.Tests.Drawing
{
    public class GlyphHelperTests
    {
        static GlyphHelperTests()
        {
            GlobalFontSettings.FontResolver ??= SnippetsFontResolver.Get();
        }

        const int Euro = '€';
        const int SmilingFaceWithHearts = 0x_0001_F970;  // 😍
        const int RedRose = 0x_0001_F339;  // 🌹

        [Fact]
        public void GlyphIndexFromCodePoint_Test()
        {
            var font1 = new XFont("Arial", 10);
            var glyphIndex1 = GlyphHelper.GlyphIndexFromCodePoint(Euro, font1);
            glyphIndex1.Should().Be(188);

            glyphIndex1 = GlyphHelper.GlyphIndexFromCodePoint(SmilingFaceWithHearts, font1);
            glyphIndex1.Should().Be(0);

            var font2 = new XFont("Segoe UI Emoji", 10);
            var glyphIndex2 = GlyphHelper.GlyphIndexFromCodePoint(Euro, font2);
            glyphIndex2.Should().Be(189);

            glyphIndex2 = GlyphHelper.GlyphIndexFromCodePoint(SmilingFaceWithHearts, font2);
            glyphIndex2.Should().Be(10441);
        }

        [Fact]
        public void GlyphIndicesFromString_Test()
        {
            const string s1 = "Hallo";
            const string s2 = "🦀 - 🦀 😀 🥰 😀 🥰";

            var font = new XFont("Segoe UI Emoji", 10);

            var glyphIndexs = GlyphHelper.GlyphIndicesFromString(s1, font);
            glyphIndexs.Length.Should().Be(s1.Length);

            glyphIndexs = GlyphHelper.GlyphIndicesFromString(s2, font);
            glyphIndexs.Length.Should().Be(s2.Length - 6);
        }

      
        [Fact]
        public void Glyphs_from_invalid_ANSI_codes()
        {
            // Ensure no glyph ids for non ANSI characters.

            var font = new XFont("Arial", 10);

            var glyphIndex1 = GlyphHelper.GlyphIndexFromCodePoint('A', font);
            glyphIndex1.Should().NotBe(0);

            var glyphIndex2 = GlyphHelper.GlyphIndexFromCodePoint('\u0081', font);
            glyphIndex2.Should().Be(0);

            var glyphIndex3 = GlyphHelper.GlyphIndexFromCodePoint('\u008D', font);
            glyphIndex3.Should().Be(0);

            var glyphIndex4 = GlyphHelper.GlyphIndexFromCodePoint('\u008F', font);
            glyphIndex4.Should().Be(0);

            var glyphIndex5 = GlyphHelper.GlyphIndexFromCodePoint('\u0090', font);
            glyphIndex5.Should().Be(0);

            var glyphIndex6 = GlyphHelper.GlyphIndexFromCodePoint('\u009D', font);
            glyphIndex6.Should().Be(0);

            var glyphIndex7 = GlyphHelper.GlyphIndexFromCodePoint('-', font);
            var glyphIndex8 = GlyphHelper.GlyphIndexFromCodePoint('\u00AD', font);  // soft hyphen
            glyphIndex8.Should().Be(glyphIndex7);
        }

        [Fact]
        public void GlyphIndices_From_String()
        {
            var font = new XFont("Arial", 10);

            const string s1 = "A\u00a9\ud83c\udf39";
            var r1 = GlyphHelper.GlyphIndicesFromString(s1, font);
            r1.Length.Should().Be(3);

            _ = "Ä ä Ö ö ß Ü ü | „“ ’ ‚‘ »« ›‹ – | · × ² ³ ½ € † … | ✔ ✘ ↯ ± − × ÷ ⋅ √ ≠ ≤ ≥ ≡ | ® © ← ↑ → ↓ ↔ ↕ ∅ |";
        }
    }
}
