using FluentAssertions;
using PdfSharp.Drawing;
using PdfSharp.Fonts;
using PdfSharp.Fonts.StandardFonts;
using PdfSharp.Pdf;
using PdfSharp.Pdf.Advanced;
using PdfSharp.Pdf.Content;
using PdfSharp.Pdf.Content.Objects;
using PdfSharp.Snippets.Font;
using PdfSharp.TestHelper;
using System.IO;
using System.Linq;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace PdfSharp.Tests
{
    public class BasicTests
    {
        private readonly ITestOutputHelper output;

        public BasicTests(ITestOutputHelper outputHelper)
        {
            output = outputHelper;
        }

        [Fact]
        public void Create_Hello_World_BasicTests()
        {
            GlobalFontSettings.FontResolver ??= NewFontResolver.Get();

            // Create a new PDF document.
            var document = new PdfDocument();
            document.Info.Title = "Created with PDFsharp";

            // Create an empty page in this document.
            var page = document.AddPage();

            // Get an XGraphics object for drawing on this page.
            var gfx = XGraphics.FromPdfPage(page);

            // Draw two lines with a red default pen.
            var width = page.Width;
            var height = page.Height;
            gfx.DrawLine(XPens.Red, 0, 0, width, height);
            gfx.DrawLine(XPens.Red, width, 0, 0, height);

            // Draw a circle with a red pen which is 1.5 point thick.
            var r = width / 5;
            gfx.DrawEllipse(new XPen(XColors.Red, 1.5), XBrushes.White, new XRect(width / 2 - r, height / 2 - r, 2 * r, 2 * r));

            bool newFontResolver = GlobalFontSettings.FontResolver!.GetType()!.FullName!.EndsWith("NewFontResolver");

            // Create a font.
            var font = new XFont(newFontResolver ? "Times New Roman" : "segoe wp", 20, XFontStyleEx.BoldItalic);

            // Draw the text.
            gfx.DrawString("Hello, dotnet 6.0!", font, XBrushes.Black,
                new XRect(0, 0, page.Width, page.Height), XStringFormats.Center);

            // Save the document...
            string filename = PdfFileHelper.CreateTempFileName("HelloWorld");
            document.Save(filename);
            // ...and start a viewer.
            PdfFileHelper.StartPdfViewerIfDebugging(filename);
        }

        [Theory]
        [InlineData("q (text) Tj Q ")]  // this works
        [InlineData("q (text) Tj Q")]   // this doesn't
        [InlineData("Q")]   // check special case
        public void Content_Can_Be_Parsed_And_Reconstructed(string contentString)
        {
            var contentBytes = Encoding.UTF8.GetBytes(contentString);

            var sequence = ContentReader.ReadContent(contentBytes);
            using var ms = new MemoryStream();
            var cw = new ContentWriter(ms);
            foreach (var obj in sequence)
            {
                obj.WriteObject(cw);
            }
            var newContent = new PdfContent(new PdfDictionary());
            newContent.CreateStream(ms.ToArray());

            // ContentWriter adds a newline after each operator
            newContent.Stream.ToString().Should().Be(contentString.Length == 1 ? "Q\n" : "q\n(text)Tj\nQ\n");
            // is this intended ? ToString() writes only operator-names but not the operands...
            var s = sequence.ToString();    // result: "qTjQ"
        }

        [Fact]
        public void Content_Can_Be_Manually_Constructed()
        {
            var sequence = new CSequence();
            var op = OpCodes.OperatorFromName("q");
            sequence.Add(op);
            op = OpCodes.OperatorFromName("Tj");
            op.Operands.Add(new CString() { CStringType = CStringType.String, Value = "text" });
            sequence.Add(op);
            op = OpCodes.OperatorFromName("Q");
            sequence.Add(op);

            using var ms = new MemoryStream();
            var cw = new ContentWriter(ms);
            foreach (var obj in sequence)
            {
                obj.WriteObject(cw);
            }
            var newContent = new PdfContent(new PdfDictionary());
            newContent.CreateStream(ms.ToArray());

            // ContentWriter adds a newline after each operator
            newContent.Stream.ToString().Should().Be("q\n(text)Tj\nQ\n");
        }

        /// <summary>
        /// PdfReference 1.7, Chapter 7.3.4.3 states:<br></br>
        /// If the final digit of a hexadecimal string is missing — that is, if there is an 
        /// odd number of digits — the final digit shall be assumed to be 0. 
        /// </summary>
        [Theory]
        [InlineData("<7465787420> Tj")]  // this works
        [InlineData("<746578742> Tj")]   // this doesn't
        public void Can_Parse_Hex_String_With_Odd_Length(string contentString)
        {
            var contentBytes = Encoding.UTF8.GetBytes(contentString);

            var sequence = ContentReader.ReadContent(contentBytes);
            using var ms = new MemoryStream();
            var cw = new ContentWriter(ms);
            foreach (var obj in sequence)
            {
                obj.WriteObject(cw);
            }
            var newContent = new PdfContent(new PdfDictionary());
            newContent.CreateStream(ms.ToArray());

            // ContentWriter adds a newline after each operator
            newContent.Stream.ToString().Should().Be("(text )Tj\n");
        }

        [Fact]
        public void RenderGlyphsOfStandardFonts()
        {
            GlobalFontSettings.FontResolver = new DocumentFontResolver();

            foreach (var fontName in StandardFontData.FontNames)
            {
                using var document = new PdfDocument();

                var stdFont = new XFont(fontName, 16);
                var helveticaFont = new XFont("Helvetica", 12);
                var headerFont = new XFont("Helvetica", 36);
                var brush = new XSolidBrush(XColors.Black);
                var left = 60.0;
                var top = 60.0;
                var bottom = 60.0;
                var gapX = 80.0;
                var gapY = 20.0;
                var x = left;
                var y = top;
                var page = document.AddPage();
                var gfx = XGraphics.FromPdfPage(page);
                gfx.DrawString(fontName, headerFont, brush, x, y);
                y += 50;
                var glyphList = stdFont.GetGlyphList();
                if (glyphList.Any())
                {
                    for (var i = 0; i < glyphList.Count; i++)
                    {
                        var c = glyphList[i];
                        gfx.DrawString(((int)c).ToString("X"), helveticaFont, brush, x, y);
                        gfx.DrawString(c.ToString(), stdFont, brush, x + 40, y);
                        x += gapX;
                        if (x + gapX >= page.Width.Point)
                        {
                            x = left;
                            y += gapY;
                            if (y >= page.Height.Point - bottom)
                            {
                                gfx.Dispose();
                                page = document.AddPage();
                                gfx = XGraphics.FromPdfPage(page);
                                x = left;
                                y = top;
                            }
                        }
                    }
                    gfx.Dispose();
                }
                else
                    output.WriteLine($"Font {fontName} has no glyphs");

                var outFileName = Path.Combine(Path.GetTempPath(), $"StandardFonts_{fontName}.pdf");
                document.Save(outFileName);
            }
        }
    }
}
