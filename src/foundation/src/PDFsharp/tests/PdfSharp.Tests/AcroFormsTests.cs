﻿using FluentAssertions;
using PdfSharp.Drawing;
using PdfSharp.Fonts;
using PdfSharp.Fonts.OpenType;
using PdfSharp.Fonts.StandardFonts;
using PdfSharp.Pdf;
using PdfSharp.Pdf.AcroForms;
using PdfSharp.Pdf.IO;
using System.Diagnostics;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace PdfSharp.Tests
{
    public class AcroFormsTests : TraceListener
    {
        private readonly ITestOutputHelper output;

        public AcroFormsTests(ITestOutputHelper outputHelper)
        { 
            output = outputHelper;
        }

        [Fact]
        public void CanImportForm()
        {
            using var fs = File.OpenRead(Path.Combine("assets", "DocumentWithAcroForm.pdf"));
            var inputDocument = PdfReader.Open(fs, PdfDocumentOpenMode.Import);

            PdfPage? lastPage = null;
            // import into new document
            var copiedDocument = new PdfDocument();
            foreach (var page in inputDocument.Pages)
            {
                copiedDocument.AddPage(page);
                lastPage = page;
            }
            // import AcroForm
            copiedDocument.ImportAcroForm(inputDocument.AcroForm!);

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
            GlobalFontSettings.ResetFontResolvers();
            GlobalFontSettings.FontResolver = new DocumentFontResolver();

            var files = new[] { "DocumentWithAcroForm.pdf", "DemoFormWithCombs.pdf" };
            var copiedDocument = new PdfDocument();
            var importedFields = new List<PdfAcroField>();
            foreach (var file in files)
            {
                using var fs = File.OpenRead(Path.Combine("assets", file));
                var inputDocument = PdfReader.Open(fs, PdfDocumentOpenMode.Import);
                foreach (var page in inputDocument.Pages)
                    copiedDocument.AddPage(page);
                copiedDocument.ImportAcroForm(inputDocument.AcroForm!);
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
            GlobalFontSettings.ResetFontResolvers();
            GlobalFontSettings.FontResolver = new DocumentFontResolver();

            var files = new[] { "DocumentWithAcroForm.pdf", "DocumentWithAcroForm.pdf" };
            var copiedDocument = new PdfDocument();
            var importedFields = new List<PdfAcroField>();
            foreach (var file in files)
            {
                using var fs = File.OpenRead(Path.Combine("assets", file));
                var inputDocument = PdfReader.Open(fs, PdfDocumentOpenMode.Import);
                foreach (var page in inputDocument.Pages)
                    copiedDocument.AddPage(page);
                copiedDocument.ImportAcroForm(inputDocument.AcroForm!);
                importedFields.AddRange(GetAllFields(inputDocument));
            }
            var fieldsInCopiedDocument = GetAllFields(copiedDocument);
            fieldsInCopiedDocument.Count.Should().Be(importedFields.Count);
            // root field names should be distinct
            var rootNames = copiedDocument.AcroForm!.Fields.Names;
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
            GlobalFontSettings.ResetFontResolvers();
            GlobalFontSettings.FontResolver = new DocumentFontResolver();

            using var fs = File.OpenRead(Path.Combine("assets", "DocumentWithAcroForm.pdf"));
            var inputDocument = PdfReader.Open(fs, PdfDocumentOpenMode.Import);

            // import into new document
            var copiedDocument = new PdfDocument();
            foreach (var page in inputDocument.Pages)
                copiedDocument.AddPage(page);
            copiedDocument.ImportAcroForm(inputDocument.AcroForm!);

            var fieldsInCopiedDocument = GetAllFields(copiedDocument);
            // fill all fields
            FillFields(fieldsInCopiedDocument);

            // flatten the form. after that, AcroForm should be null and all annotations should be removed
            // (this is true for the tested document, other documents may contain annotations not related to Form-Fields)
            copiedDocument.FlattenAcroForm();
            copiedDocument.AcroForm.Should().BeNull();
            copiedDocument.Pages[0].Annotations.Count.Should().Be(0);

            using var fsOut = File.Create(Path.Combine(Path.GetTempPath(), "FilledForm.flattened.pdf"));
            copiedDocument.Save(fsOut);
        }

        [Fact]
        public void CanFlattenCreatedForm()
        {
            CanCreateNewForm();     // create the form

            GlobalFontSettings.ResetFontResolvers();
            GlobalFontSettings.FontResolver = new DocumentFontResolver();

            using var fs = File.OpenRead(Path.Combine(Path.GetTempPath(), "CreatedForm.pdf"));
            var inputDocument = PdfReader.Open(fs, PdfDocumentOpenMode.Import);

            // import into new document
            var copiedDocument = new PdfDocument();
            foreach (var page in inputDocument.Pages)
                copiedDocument.AddPage(page);
            copiedDocument.ImportAcroForm(inputDocument.AcroForm!);

            copiedDocument.FlattenAcroForm();
            copiedDocument.AcroForm.Should().BeNull();
            copiedDocument.Pages[0].Annotations.Count.Should().Be(0);

            using var fsOut = File.Create(Path.Combine(Path.GetTempPath(), "CreatedForm.flattened.pdf"));
            copiedDocument.Save(fsOut);

            // don't know what to assert here, have to check with "real" eyes
            // (we mainly want to check the behavior of the AcroFieldRenderers)
        }

        [Fact]
        public void CanCreateNewForm()
        {
            // test some special characters
            // Note: Current limitations regarding CJK/Arabic, etc. still applies
            // make sure you use a font that supports the used characters !
            const string firstNameValue = "Sebastién";
            const string lastNameValue = "Süßölgefäß";  // yep, that's a valid german word

            GlobalFontSettings.ResetFontResolvers();
            // we use one of the 14 standard-fonts here (Helvetica)
            GlobalFontSettings.FontResolver = new DocumentFontResolver();

            var document = new PdfDocument();
            var page1 = document.AddPage();
            var page2 = document.AddPage();
            var acroForm = document.GetOrCreateAcroForm();
            var textFont = new XFont(StandardFontNames.Helvetica, 12, XFontStyleEx.Regular,
                new XPdfFontOptions(PdfFontEncoding.Unicode, PdfFontEmbedding.Full));

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
                // Note: Chromium-based browsers (ie. Edge/Chrome) do not render fields without a name
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
                // as an alternative, you can also use field.SelectedIndex
                field.Value = "male";
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
                    annot.PlaceOnPage(page1, new PdfRectangle(new XRect(x + 100, y, 100, 20)));
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
                    annot.PlaceOnPage(page1, new PdfRectangle(new XRect(x + 100, y, 100, 5 * textFont.Height)));
                });
            });

            y += 100;
            // PushButton fields
            acroForm.AddPushButtonField(button =>
            {
                button.Name = "SubmitButton";
                button.Caption = "Submit";
                button.Font = textFont;
                button.AddAnnotation(annot =>
                {
                    // TODO: these properties should be part of the field and propagated down to the annotations
                    annot.Highlighting = Pdf.Annotations.PdfWidgetAnnotation.HighlightingMode.Invert;
                    annot.BorderColor = XColors.Gray;
                    annot.BackColor = XColors.LightBlue;
                    annot.Border.Width = 2;
                    annot.Border.BorderStyle = Pdf.Annotations.enums.PdfAnnotationBorderStyle.Solid;
                    annot.PlaceOnPage(page1, new PdfRectangle(new XRect(x, y, 100, 20)));
                });
            });

            y += 40;
            // Signature fields
            acroForm.AddSignatureField(field =>
            {
                field.Name = "Signature";
                field.AddAnnotation(annot =>
                {
                    annot.BackColor = XColors.White;
                    annot.BorderColor = XColors.Gray;
                    annot.Border.Width = 1;
                    annot.Border.BorderStyle = Pdf.Annotations.enums.PdfAnnotationBorderStyle.Solid;
                    annot.PlaceOnPage(page1, new PdfRectangle(new XRect(x, y, 160, 60)));
                });
            });

            var filePath = Path.Combine(Path.GetTempPath(), "CreatedForm.pdf");
            using var fsOut = File.Create(filePath);
            document.Save(fsOut, true);
            fsOut.Close();

            // read back and validate
            document = PdfReader.Open(filePath, PdfDocumentOpenMode.Modify);
            var fields = GetAllFields(document);

            fields.Count.Should().Be(11);
            fields.Should().Contain(field =>
                field.FullyQualifiedName == "FirstName"
                && field.GetType() == typeof(PdfTextField)
                && ((PdfTextField)field).Text == firstNameValue
                && field.ForeColor == XColors.DarkRed
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
                && ((PdfRadioButtonField)field).Options.SequenceEqual(new[] { "male", "female", "unspecified" })
                && ((PdfRadioButtonField)field).Value == "male");
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
                && ((PdfListBoxField)field).Value.Count() == 1
                && ((PdfListBoxField)field).Value.ElementAt(0) == "Red"
                && field.Annotations.Elements.Count == 1);
            fields.Should().Contain(field =>
                field.FullyQualifiedName == "SubmitButton"
                && field.GetType() == typeof(PdfPushButtonField)
                && ((PdfPushButtonField)field).Caption == "Submit"
                && field.Annotations.Elements.Count == 1
                && field.Annotations.Elements[0].Border.Width == 2
                && field.Annotations.Elements[0].Border.BorderStyle == Pdf.Annotations.enums.PdfAnnotationBorderStyle.Solid
                && field.Annotations.Elements[0].Highlighting == Pdf.Annotations.PdfWidgetAnnotation.HighlightingMode.Invert
                && field.Annotations.Elements[0].BorderColor == XColors.Gray
                && field.Annotations.Elements[0].BackColor == XColors.LightBlue);
        }

        [Fact]
        public void CanDeleteFields()
        {
            CanCreateNewForm();

            var filePath = Path.Combine(Path.GetTempPath(), "CreatedForm.pdf");
            var document = PdfReader.Open(filePath, PdfDocumentOpenMode.Modify);
            var startFields = document.AcroForm!.GetAllFields().ToList();
            var startAnnotsCount = document.Pages[0].Annotations.Elements.Count;
            foreach (var field in startFields)
            {
                if (field is PdfPushButtonField)
                    field.Remove();
                if (field is PdfSignatureField)
                    field.Remove();
            }
            var endFields = document.AcroForm!.GetAllFields().ToList();
            var endAnnotsCount = document.Pages[0].Annotations.Elements.Count;
            endFields.Count.Should().Be(startFields.Count - 2);
            endAnnotsCount.Should().Be(startAnnotsCount - 2);

            filePath = Path.Combine(Path.GetTempPath(), "CreatedForm-removed.pdf");
            document.Save(filePath);
        }

        [Theory]
        //[InlineData("C:\\Temp\\TestPdf\\PdfSharp-Issues\\46")]
        [InlineData("C:\\Temp\\TestPdf")]
        public void CollectPageCount(string basePath)
        {
            Trace.Listeners.Add(this);

            Directory.Exists(basePath).Should().BeTrue("Folder with Pdf-files should exist");
            var allFiles = Directory.EnumerateFiles(basePath, "*.pdf", SearchOption.AllDirectories);
            allFiles.Count().Should().BeGreaterThan(0, "Folder should contain at least one Pdf-file");

            var sb = new StringBuilder();
            sb.AppendLine("Path\tPage count\tException\tMessage");

            foreach (var file in allFiles)
            {
#if NET6_0_OR_GREATER
                var relativePath = Path.GetRelativePath(basePath, file);
#else
                var relativePath = file.Substring(basePath.Length);
#endif
                output.WriteLine("Processing: {0}", file);
                try
                {
                    var document = PdfReader.Open(file, PdfDocumentOpenMode.Import);
                    sb.AppendFormat("{0}\t{1}", relativePath, document.PageCount);
                }
                catch(Exception ex)
                {
                    sb.AppendFormat("{0}\t\t{1}\t{2}", relativePath, ex.GetType().Name, ex.Message);
                }
                sb.AppendLine();
            }
            File.WriteAllText(Path.Combine(basePath, "PageCounts2.csv"), sb.ToString());
        }

        [Theory]
        [InlineData("c:\\Temp\\TestPdf")]
        public void TestListOfFiles(string basePath)
        {
            Trace.Listeners.Add(this);

            Directory.Exists(basePath).Should().BeTrue("Folder with Pdf-files should exist");
            var allFiles = Directory.EnumerateFiles(basePath, "*.pdf", SearchOption.AllDirectories);
            allFiles.Count().Should().BeGreaterThan(0, "Folder should contain at least one Pdf-file");

            DocumentFontResolver.RegisterFolder(@"c:\windows\fonts");

            foreach (var file in allFiles)
            {
                GlobalFontSettings.FontResolver = new DocumentFontResolver();
                output.WriteLine("Processing: {0}", file);
                VerifyPdfCanBeFilled(file);

                GlobalFontSettings.ResetFontResolvers();
            }
        }

        [Theory]
        [InlineData(@"c:\Temp\TestPdf\issue #70.PDF")]
        public void TestSpecificFile(string filePath)
        {
            DocumentFontResolver.RegisterFallbackFont(StandardFontNames.Helvetica);
            GlobalFontSettings.FontResolver = new DocumentFontResolver();
            DocumentFontResolver.RegisterFolder(@"c:\windows\fonts");
            VerifyPdfCanBeFilled(filePath).Should().BeTrue();
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
                    comboBoxField.SelectedIndex = Math.Min(1, comboBoxField.Options.Count - 1);
                else if (field is PdfCheckBoxField checkboxField)
                    checkboxField.Checked = true;
                else if (field is PdfRadioButtonField radioButtonField)
                    radioButtonField.SelectedIndex = Math.Min(1, radioButtonField.Options.Count - 1);
                else if (field is PdfListBoxField listBoxField)
                    listBoxField.SelectedIndices = new[] { Math.Min(1, listBoxField.Options.Count - 1) };
            }
        }

        private static IList<PdfAcroField> GetAllFields(PdfDocument doc)
        {
            return (doc.AcroForm?.GetAllFields() ?? Array.Empty<PdfAcroField>()).ToList();
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
                    radioButton.SelectedIndex.Should().Be(Math.Min(1, radioButton.Options.Count - 1));
                }
                else if (field is PdfComboBoxField comboBox)
                {
                    comboBox.SelectedIndex.Should().Be(Math.Min(1, comboBox.Options.Count - 1));
                }
                else if (field is PdfListBoxField listBox)
                {
                    listBox.Options.Count.Should().BeGreaterThan(0);
                    listBox.SelectedIndices.Count().Should().BeGreaterThan(0);
                    listBox.SelectedIndices.First().Should().Be(Math.Min(1, listBox.Options.Count - 1));
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
                if (field.ReadOnly)
                    continue;
                fieldVerifier(field);
            }
        }

        public override void Write(string? message)
        {
            if (message != null)
                output.WriteLine(message);
        }

        public override void WriteLine(string? message)
        {
            if (message != null)
                output.WriteLine(message);
        }
    }
}
