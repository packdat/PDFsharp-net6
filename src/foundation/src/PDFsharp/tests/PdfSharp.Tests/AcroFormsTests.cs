using FluentAssertions;
using PdfSharp.Drawing;
using PdfSharp.Fonts;
using PdfSharp.Pdf;
using PdfSharp.Pdf.AcroForms;
using PdfSharp.Pdf.IO;
using PdfSharp.Snippets.Font;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xunit;
using Xunit.Abstractions;

namespace PdfSharp.Tests
{
    public class AcroFormsTests
    {
        private readonly ITestOutputHelper output;

        public AcroFormsTests(ITestOutputHelper outputHelper)
        { 
            output = outputHelper;
        }

        [Fact]
        public void CanImportForm()
        {
            // required for now (when using the CORE lib)
            //GlobalFontSettings.FontResolver = new DocumentFontResolver();

            using var fs = File.OpenRead(Path.Combine("assets", "DocumentWithAcroForm.pdf"));
            var inputDocument = PdfReader.Open(fs, PdfDocumentOpenMode.Import);

            //var fieldFont = new XFont("Helvetica", 12);
            PdfPage lastPage = null;
            // import into new document
            var copiedDocument = new PdfDocument();
            foreach (var page in inputDocument.Pages)
            {
                copiedDocument.AddPage(page);
                lastPage = page;
            }
            // create dummy form to add all chars to the font
            // PdfSharp seems to always create a font-subset that contains only those chars that are actually drawn.
            // while this is ok for static text, it is s problem for AcroFields where a user may enter different text.
            // it would be nice if we had the option to embed the FULL font.
            //var form = new XForm(copiedDocument, 1, 1);
            //using (var gfx = XGraphics.FromForm(form))
            //{
            //    var sb = new StringBuilder(256);
            //    for (var i = 32; i < 256; i++)
            //        sb.Append((char)i);
            //    gfx.DrawString(sb.ToString(), fieldFont, XBrushes.Black, new XPoint(0, 10));
            //}
            // import AcroForm
            copiedDocument.ImportAcroForm(inputDocument.AcroForm, (originalField, importedField) =>
            {
                // TODO: use DeterminedFontSize from original field
                //importedField.Font = fieldFont;
            });

            copiedDocument.AcroForm.Should().NotBeNull();

            var fieldsInInputDocument = GetAllFields(inputDocument);
            var fieldsInCopiedDocument = GetAllFields(copiedDocument);
            fieldsInCopiedDocument.Count.Should().Be(fieldsInInputDocument.Count);

            // fill all fields
            FillFields(fieldsInCopiedDocument);

            var outFileName = Path.Combine(Path.GetTempPath(), "FilledForm.pdf");
            using var fsOut = File.Create(outFileName);
            copiedDocument.Save(fsOut);
            fsOut.Close();

            VerifyFieldsFilledWithDefaultValues(outFileName);
        }

        [Fact]
        public void CanImportMultipleForms()
        {
            // required for now (when using the CORE lib)
            GlobalFontSettings.FontResolver = new FailsafeFontResolver();

            var files = new[] { "DocumentWithAcroForm.pdf", "DemoFormWithCombs.pdf" };
            var copiedDocument = new PdfDocument();
            var importedFields = new List<PdfAcroField>();
            foreach (var file in files)
            {
                using var fs = File.OpenRead(Path.Combine("assets", file));
                var inputDocument = PdfReader.Open(fs, PdfDocumentOpenMode.Import);
                foreach (var page in inputDocument.Pages)
                    copiedDocument.AddPage(page);
                copiedDocument.ImportAcroForm(inputDocument.AcroForm);
                importedFields.AddRange(GetAllFields(inputDocument));
            }
            var fieldsInCopiedDocument = GetAllFields(copiedDocument);
            fieldsInCopiedDocument.Count.Should().Be(importedFields.Count);

            FillFields(fieldsInCopiedDocument);

            var outFileName = Path.Combine(Path.GetTempPath(), "FilledForm.multiple.pdf");
            using var fsOut = File.Create(outFileName);
            copiedDocument.Save(fsOut);
            fsOut.Close();

            VerifyFieldsFilledWithDefaultValues(outFileName);
        }

        [Fact]
        public void CanImportSameFormMultipleTimes()
        {
            // required for now (when using the CORE lib)
            GlobalFontSettings.FontResolver = new FailsafeFontResolver();

            var files = new[] { "DocumentWithAcroForm.pdf", "DocumentWithAcroForm.pdf" };
            var copiedDocument = new PdfDocument();
            var importedFields = new List<PdfAcroField>();
            foreach (var file in files)
            {
                using var fs = File.OpenRead(Path.Combine("assets", file));
                var inputDocument = PdfReader.Open(fs, PdfDocumentOpenMode.Import);
                foreach (var page in inputDocument.Pages)
                    copiedDocument.AddPage(page);
                copiedDocument.ImportAcroForm(inputDocument.AcroForm);
                importedFields.AddRange(GetAllFields(inputDocument));
            }
            var fieldsInCopiedDocument = GetAllFields(copiedDocument);
            fieldsInCopiedDocument.Count.Should().Be(importedFields.Count);
            // root field names should be distinct
            var rootNames = copiedDocument.AcroForm.Fields.Names;
            rootNames.Distinct().Count().Should().Be(rootNames.Length);

            FillFields(fieldsInCopiedDocument);

            var outFileName = Path.Combine(Path.GetTempPath(), "FilledForm.multiple.pdf");
            using var fsOut = File.Create(outFileName);
            copiedDocument.Save(fsOut);
            fsOut.Close();

            VerifyFieldsFilledWithDefaultValues(outFileName);
        }

        [Fact]
        public void CanFlattenForm()
        {
            // required for now (when using the CORE lib)
            GlobalFontSettings.FontResolver = new FailsafeFontResolver();

            using var fs = File.OpenRead(Path.Combine("assets", "DocumentWithAcroForm.pdf"));
            var inputDocument = PdfReader.Open(fs, PdfDocumentOpenMode.Import);

            // import into new document
            var copiedDocument = new PdfDocument();
            foreach (var page in inputDocument.Pages)
                copiedDocument.AddPage(page);
            copiedDocument.ImportAcroForm(inputDocument.AcroForm);

            var fieldsInCopiedDocument = GetAllFields(copiedDocument);
            // fill all fields
            FillFields(fieldsInCopiedDocument);

            //GlobalFontSettings.FontResolver = new DocumentFontResolver(copiedDocument);
            //using (var gfx = XGraphics.FromPdfPage(copiedDocument.Pages[0]))
            //{
            //    var font = new XFont("Arial", 14);
            //    var brush = new XSolidBrush(XColors.Black);
            //    gfx.DrawString("Hello there !", font, brush, 50, 400);
            //}

            // flatten the form. after that, AcroForm should be null and all annotations should be removed
            // (this is true for the tested document, other documents may contain annotations not related to Form-Fields)
            copiedDocument.AcroForm.Flatten();
            copiedDocument.AcroForm.Should().BeNull();
            copiedDocument.Pages[0].Annotations.Count.Should().Be(0);

            using var fsOut = File.Create(Path.Combine(Path.GetTempPath(), "FilledForm.flattened.pdf"));
            copiedDocument.Save(fsOut);
        }

        [Fact]
        public void CanCreateNewForm()
        {
            // test some special characters
            // Note: Current limitations regarding CJK/Arabic, etc. still applies
            // make sure you use a font that supports the used characters !
            const string firstNameValue = "Sebastién";
            const string lastNameValue = "Süßölgefäß";  // yep, that's a valid german word

            // required for now (when using the CORE lib)
            GlobalFontSettings.FontResolver = new FailsafeFontResolver();

            var document = new PdfDocument();
            var page1 = document.AddPage();
            var page2 = document.AddPage();
            var acroForm = document.GetOrCreateAcroForm();
            var textFont = new XFont("Arial", 12);
            double x = 40, y = 80;
            var page1Renderer = XGraphics.FromPdfPage(page1);
            var page2Renderer = XGraphics.FromPdfPage(page2);
            page1Renderer.DrawString("Name of Subject", textFont, XBrushes.Black, x, y);
            page2Renderer.DrawString("For Demo purposes. Modify the fields and observe the field on the first page is modified as well.",
                textFont, XBrushes.Black, x, y);

            y += 10;
            // Text fields
            var firstNameField = acroForm.AddTextField(field =>
            {
                field.Name = "FirstName";
                field.Font = textFont;
                field.ForeColor = XColors.DarkRed;
                field.Text = firstNameValue;
                // place annotation on both pages
                // if the document is opened in a PdfReader and one of the Annotations is changed (e.g. by typing inside it),
                // the other Annotation will be changed as well (as they belong to the same field)
                field.AddAnnotation(annot =>
                {
                    annot.PlaceOnPage(page1, new PdfRectangle(new XRect(x, y, 100, 20)));
                });
                field.AddAnnotation(annot =>
                {
                    // Note: The border is currently always solid and 1 unit wide
                    annot.BorderColor = XColors.Green;
                    annot.BackColor = XColors.DarkGray;
                    annot.PlaceOnPage(page2, new PdfRectangle(new XRect(x, y, 100, 20)));
                });
            });
            var lastNameField = acroForm.AddTextField(field =>
            {
                field.Name = "LastName";
                field.Font = textFont;
                field.Text = lastNameValue;
                field.AddAnnotation(annot =>
                {
                    annot.PlaceOnPage(page1, new PdfRectangle(new XRect(x + 10 + 100, y, 100, 20)));
                });
                field.AddAnnotation(annot =>
                {
                    annot.PlaceOnPage(page2, new PdfRectangle(new XRect(x + 10 + 100, y, 100, 20)));
                });
            });

            y += 40;
            // Checkbox fields
            page1Renderer.DrawString("Subject's interests", textFont, XBrushes.Black, x, y);
            y += 10;
            var cbx1 = acroForm.AddCheckBoxField(field =>
            {
                field.Name = "Interest_cooking";
                field.AddAnnotation(annot =>
                {
                    annot.PlaceOnPage(page1, new PdfRectangle(new XRect(x, y, 12, 12)));
                });
            });
            page1Renderer.DrawString("Cooking", textFont, XBrushes.Black, x + 20, y + 10);
            y += 20;
            var cbx2 = acroForm.AddCheckBoxField(field =>
            {
                field.Name = "Interest_coding";
                field.Checked = true;
                field.AddAnnotation(annot =>
                {
                    annot.PlaceOnPage(page1, new PdfRectangle(new XRect(x, y, 12, 12)));
                });
            });
            page1Renderer.DrawString("Coding", textFont, XBrushes.Black, x + 20, y + 10);
            y += 20;
            var cbx3 = acroForm.AddCheckBoxField(field =>
            {
                field.Name = "Interest_cycling";
                field.AddAnnotation(annot =>
                {
                    annot.PlaceOnPage(page1, new PdfRectangle(new XRect(x, y, 12, 12)));
                });
            });
            page1Renderer.DrawString("Cycling", textFont, XBrushes.Black, x + 20, y + 10);

            y += 40;
            // RadioButton fields
            page1Renderer.DrawString("Subject's gender", textFont, XBrushes.Black, x, y);
            y += 10;
            // used as parent-field for the radio-button (testing field-nesting)
            var groupGender = acroForm.AddGenericField(field =>
            {
                field.Name = "Group_Gender";
            });
            acroForm.AddRadioButtonField(field =>
            {
                field.Name = "Gender";
                // add individual buttons
                field.AddAnnotation("male", annot =>
                {
                    annot.PlaceOnPage(page1, new PdfRectangle(new XRect(x, y, 12, 12)));
                });
                page1Renderer.DrawString("Male", textFont, XBrushes.Black, x + 20, y + 10);
                y += 20;
                field.AddAnnotation("female", annot =>
                {
                    annot.PlaceOnPage(page1, new PdfRectangle(new XRect(x, y, 12, 12)));
                });
                page1Renderer.DrawString("Female", textFont, XBrushes.Black, x + 20, y + 10);
                y += 20;
                field.AddAnnotation("unspecified", annot =>
                {
                    annot.PlaceOnPage(page1, new PdfRectangle(new XRect(x, y, 12, 12)));
                });
                page1Renderer.DrawString("Unspecified", textFont, XBrushes.Black, x + 20, y + 10);
                // must be a name-object ! (starting with a slash)
                // as an alternative, you can also use field.SelectedIndex
                field.Value = "/male";
                groupGender.AddChild(field);
            });

            y += 40;
            // ComboBox fields
            page1Renderer.DrawString("Select a number:", textFont, XBrushes.Black, x, y + 10);
            acroForm.AddComboBoxField(field =>
            {
                field.Name = "SelectedNumber";
                field.Options = new[] { "One", "Two", "Three", "Four", "Five" };
                field.SelectedIndex = 2;    // select "Three"
                field.Font = textFont;
                field.AddAnnotation(annot =>
                {
                    annot.PlaceOnPage(page1, new PdfRectangle(new XRect(x + 100, y, 100, 16)));
                });
            });

            y += 40;
            // ListBox fields
            page1Renderer.DrawString("Select a color:", textFont, XBrushes.Black, x, y + 10);
            acroForm.AddListBoxField(field =>
            {
                field.Name = "SelectedColor";
                field.Options = new[] { "Blue", "Red", "Green", "Black", "White" };
                field.SelectedIndices = new[] { 1 };    // select "Red"
                field.Font = textFont;
                field.AddAnnotation(annot =>
                {
                    annot.PlaceOnPage(page1, new PdfRectangle(new XRect(x + 100, y, 100, 80)));
                });
            });
            // TODO: Signature fields

            var filePath = Path.Combine(Path.GetTempPath(), "CreatedForm.pdf");
            using var fsOut = File.Create(filePath);
            document.Save(fsOut, true);
            fsOut.Close();

            // read back and validate
            document = PdfReader.Open(filePath, PdfDocumentOpenMode.Modify);
            var fields = GetAllFields(document);

            fields.Count.Should().Be(9);
            fields.Should().Contain(field =>
                field.FullyQualifiedName == "FirstName"
                && field.GetType() == typeof(PdfTextField)
                && ((PdfTextField)field).Text == firstNameValue
                && field.Annotations.Elements.Count == 2
                && field.Annotations.Elements[1].BorderColor == XColors.Green
                && field.Annotations.Elements[1].BackColor == XColors.DarkGray);
            fields.Should().Contain(field =>
                field.FullyQualifiedName == "LastName"
                && field.GetType() == typeof(PdfTextField)
                && ((PdfTextField)field).Text == lastNameValue
                && field.Annotations.Elements.Count == 2);
            fields.Should().Contain(field =>
                field.FullyQualifiedName == "Interest_cooking"
                && field.GetType() == typeof(PdfCheckBoxField)
                && !((PdfCheckBoxField)field).Checked
                && field.Annotations.Elements.Count == 1);
            fields.Should().Contain(field =>
                field.FullyQualifiedName == "Interest_coding"
                && field.GetType() == typeof(PdfCheckBoxField)
                && ((PdfCheckBoxField)field).Checked
                && field.Annotations.Elements.Count == 1);
            fields.Should().Contain(field =>
                field.FullyQualifiedName == "Interest_cycling"
                && field.GetType() == typeof(PdfCheckBoxField)
                && !((PdfCheckBoxField)field).Checked
                && field.Annotations.Elements.Count == 1);
            fields.Should().Contain(field =>
                field.FullyQualifiedName == "Group_Gender"
                && field.GetType() == typeof(PdfGenericField)
                && field.HasChildFields
                && field.Annotations.Elements.Count == 0
                && field.Fields.Elements.Count == 1);
            fields.Should().Contain(field =>
                field.FullyQualifiedName == "Group_Gender.Gender"
                && field.GetType() == typeof(PdfRadioButtonField)
                && ((PdfRadioButtonField)field).SelectedIndex == 0
                && field.Annotations.Elements.Count == 3
                && ((PdfRadioButtonField)field).Options.SequenceEqual(new[] { "/male", "/female", "/unspecified" })
                && field.Value.ToString() == "/male");
            fields.Should().Contain(field =>
                field.FullyQualifiedName == "SelectedNumber"
                && field.GetType() == typeof(PdfComboBoxField)
                && ((PdfComboBoxField)field).SelectedIndex == 2
                && ((PdfComboBoxField)field).Options.SequenceEqual(new[] { "One", "Two", "Three", "Four", "Five" })
                && field.Value is PdfString
                && ((PdfString)field.Value).Value == "Three"
                && field.Annotations.Elements.Count == 1);
            fields.Should().Contain(field =>
                field.FullyQualifiedName == "SelectedColor"
                && field.GetType() == typeof(PdfListBoxField)
                && ((PdfListBoxField)field).SelectedIndices.Count() == 1
                && ((PdfListBoxField)field).SelectedIndices.Contains(1)
                && ((PdfListBoxField)field).Options.SequenceEqual(new[] { "Blue", "Red", "Green", "Black", "White" })
                && ((PdfString)((PdfListBoxField)field).Value).Value == "Red"
                && field.Annotations.Elements.Count == 1);
        }

        [Theory]
        [InlineData("c:\\Temp\\TestPdf")]
        public void TestListOfFiles(string basePath)
        {
            Directory.Exists(basePath).Should().BeTrue("Folder with Pdf-files should exist");
            var allFiles = Directory.EnumerateFiles(basePath, "*.pdf", SearchOption.AllDirectories);
            allFiles.Count().Should().BeGreaterThan(0, "Folder should contain at least one Pdf-file");

            // required for now (when using the CORE lib)
            GlobalFontSettings.FontResolver = new FailsafeFontResolver();

            foreach (var file in allFiles)
            {
                VerifyPdfCanBeFilled(file);
            }
        }

        private bool VerifyPdfCanBeFilled(string filePath)
        {
            try
            {
                var document = PdfReader.Open(filePath, PdfDocumentOpenMode.Modify);
                if (document.AcroForm == null || document.AcroForm.Fields.Count == 0)
                    return true;

                var fieldsInDocument = GetAllFields(document);
                // fill all fields
                FillFields(fieldsInDocument);

                var outPath = Path.Combine(Path.GetTempPath(), "out.pdf");
                document.Save(outPath);

                VerifyFieldsFilledWithDefaultValues(outPath);
                return true;
            }
            catch (Exception ex)
            {
                var message = string.Format("{0}:{1}{2}{1}{1}", filePath, Environment.NewLine, ex);
                output.WriteLine(message);
            }
            return false;
        }

        private static void FillFields(IList<PdfAcroField> fields)
        {
            foreach (var field in fields)
            {
                if (field.ReadOnly)
                    continue;
                // Values for the fields:
                // - TextFields: name of field
                // - CheckBoxes: checked
                // - RadioButtons: second option is checked (if there is only one option, this is checked)
                // - ChoiceFields (List, Combo): second option is selected (if there is only one option, this is selected)
                if (field is PdfTextField textField)
                    textField.Text = field.Name;
                else if (field is PdfComboBoxField comboBoxField)
                    comboBoxField.SelectedIndex = Math.Min(1, comboBoxField.Options.Count);
                else if (field is PdfCheckBoxField checkboxField)
                    checkboxField.Checked = true;
                else if (field is PdfRadioButtonField radioButtonField)
                    radioButtonField.SelectedIndex = Math.Min(1, radioButtonField.Options.Count);
                else if (field is PdfListBoxField listBoxField)
                    listBoxField.SelectedIndices = new[] { Math.Min(1, listBoxField.Options.Count) };
            }
        }

        private static IList<PdfAcroField> GetAllFields(PdfDocument doc)
        {
            var fields = new List<PdfAcroField>();
            for (var i = 0; i < doc.AcroForm.Fields.Elements.Count; i++)
            {
                var field = doc.AcroForm.Fields[i];
                TraverseFields(field, ref fields);
            }
            return fields;
        }

        private static void TraverseFields(PdfAcroField parentField, ref List<PdfAcroField> fieldList)
        {
            fieldList.Add(parentField);
            for (var i = 0; i < parentField.Fields.Elements.Count; i++)
            {
                var field = parentField.Fields[i];
                if (!string.IsNullOrEmpty(field.Name))
                    TraverseFields(field, ref fieldList);
            }
        }

        /// <summary>
        /// Verifies, that the specified document has the expected field-values as set by <see cref="FillFields(IList{PdfAcroField})"/>
        /// </summary>
        /// <param name="documentFilePath"></param>
        private static void VerifyFieldsFilledWithDefaultValues(string documentFilePath)
        {
            VerifyFilledFields(documentFilePath, field =>
            {
                if (field is PdfTextField textField)
                {
                    textField.Text.Should().Be(textField.Name);
                }
                else if (field is PdfCheckBoxField checkBox)
                {
                    checkBox.Checked.Should().BeTrue();
                }
                else if (field is PdfRadioButtonField radioButton)
                {
                    radioButton.Options.Count.Should().BeGreaterThan(0);
                    radioButton.SelectedIndex.Should().Be(Math.Min(1, radioButton.Options.Count));
                }
                else if (field is PdfComboBoxField comboBox)
                {
                    comboBox.SelectedIndex.Should().Be(Math.Min(1, comboBox.Options.Count));
                }
                else if (field is PdfListBoxField listBox)
                {
                    listBox.Options.Count.Should().BeGreaterThan(0);
                    listBox.SelectedIndices.Count().Should().BeGreaterThan(0);
                    listBox.SelectedIndices.First().Should().Be(Math.Min(1, listBox.Options.Count));
                }
            });
        }

        private static void VerifyFilledFields(string documentFilePath, Action<PdfAcroField> fieldVerifier)
        {
            using var fs = File.OpenRead(documentFilePath);
            var inputDocument = PdfReader.Open(fs, PdfDocumentOpenMode.Modify);
            var allFields = GetAllFields(inputDocument);
            foreach (var field in allFields)
            {
                fieldVerifier(field);
            }
        }
    }
}
