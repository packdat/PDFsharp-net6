# PDFsharp & MigraDoc 6.0

This branch contains code that is meant to be a proposal to ease the handling of AcroFields.  

To view the changes in action, check out these tests:  
[AcroFieldsTest](src/foundation/src/PDFsharp/tests/PdfSharp.Tests/AcroFieldTests.cs)  
[AcroFormsTests](src/foundation/src/PDFsharp/tests/PdfSharp.Tests/AcroFormsTests.cs)  

Auto-generated Api-documentation is available [here](docs/ApiDoc/index.md)  

Notable changes:
- The 14 standard-fonts defined in the Pdf-Specification are now embedded in the library.
To use them, utilize the new [DocumentFontResolver](docs/ApiDoc/pdfsharp.fonts.documentfontresolver.md), e.g.
  ```csharp
  GlobalFontSettings.FontResolver = new DocumentFontResolver();
  var textFont = new XFont(StandardFontNames.Helvetica, 12, XFontStyleEx.Regular, new XPdfFontOptions(PdfFontEncoding.Unicode, PdfFontEmbedding.Full));
  ```
  Take note of the new *FontEmbedding* option **Full**.  
  This makes sure, the font is embedded **in full** and not just a subset thereof.  
  (by default, PdfSharp **always** creates font-subsets containing only the characters which are actually rendered, which makes this "feature" problematic for AcroFields whose content can be changed by the end-user)

- Filling an existing Pdf does no longer result in unnecessarily adding a **Courier New** font to the document.
This is possible thanks to the mentioned `DocumentFontResolver` which also resolves fonts in existing documents. (hence the name)
- A new method was added to import AcroFields from existing documents.
Check out `ImportAcroForm` [here](docs/ApiDoc/pdfsharp.pdf.pdfdocument.md#importacroformpdfacroform-actionpdfacrofield-pdfacrofield)
- An new method `GetOrCreateAcroForm` was added which allows creating new AcroForms.
Check it out [here](docs/ApiDoc/pdfsharp.pdf.pdfdocument.md#getorcreateacroform)
- New methods were added that allow creating new AcroForms from scratch.
Check them out [here](docs/ApiDoc/pdfsharp.pdf.acroforms.pdfacroform.md#addtextfieldactionpdftextfield)  
Example:
  ```csharp
  var document = new PdfDocument();
  var page1 = document.AddPage();
  var page2 = document.AddPage();
  var acroForm = document.GetOrCreateAcroForm();

  var lastNameField = acroForm.AddTextField(field =>
  {
      field.Name = "LastName";
      field.Font = textFont;
      field.Text = lastNameValue;
      // note we're creating 2 annotations, one on each page
      field.AddAnnotation(annot =>
      {
          annot.PlaceOnPage(page1, new PdfRectangle(new XRect(x, y, 100, 20)));
      });
      field.AddAnnotation(annot =>
      {
          annot.PlaceOnPage(page2, new PdfRectangle(new XRect(x, y, 100, 20)));
      });
  });
  ```
  See full example in method `CanCreateNewForm` [here](src/foundation/src/PDFsharp/tests/PdfSharp.Tests/AcroFormsTests.cs)
- There is now a distinction between a *field* (which is only metadata regarding the Pdf-Specification) and it's *appearance* (which is the **visual** part of a field).  
The *appearances* of AcroFields are defined by [PdfWidgetAnnotations](docs/ApiDoc/pdfsharp.pdf.annotations.pdfwidgetannotation.md).  
A field may have multiple annotations (e.g. a contract-number that is repeated on every page of a contract-document; each *visual* is a `PdfWidgetAnnotation` associated with the same `PdfAcroField`).  
The annotations of fields can be retrieved by `PdfAcroField.Annotations`
- Each field type has it's own *renderer* which is used to create the visual appearances for the fields.
These renderers may be overridden by the user to customize the rendering.  
(**Note**: Signature-fields are still on the to-do list.)  
Check out [PdfAcroFieldRenderer](docs/ApiDoc/pdfsharp.pdf.acroforms.rendering.pdfacrofieldrenderer.md) as a starting point.  
An instance of this class is available in `PdfAcroForm.FieldRenderer`  
- `PdfAcroForm` has a new method `GetAllFields` for easily retrieving the complete field-hierarchy as a flattened collection.
- AcroForms can be flattened by the new method `PdfDocument.FlattenAcroForm`  

<br>

## Help wanted !

<br>

As i have little to no experience regarding `PdfSignatureFields` i would be greatful, if anyone could provide ideas (or better yet: **code**) that would make working with these kind of fields more user-friendly.  
I'm also looking for ideas/code for rendering these fields.  

<br>
<br>

---
Version **6.0.0-preview-2**  
Published **2023-04-25**

This is the second preview of the **PDFsharp** project, the main project of PDFsharp & MigraDoc 6.0 with updates for C# 10 and .NET 6.0.

PDFsharp: Copyright (c) 2005-2023 empira Software GmbH, Troisdorf (Cologne Area, Germany)  
MigraDoc: Copyright (c) 2001-2023 empira Software GmbH, Troisdorf (Cologne Area, Germany)  
Published Open Source under the [MIT License](https://docs.pdfsharp.net/LICENSE.html)

For more information see [docs.pdfsharp.net](https://docs.pdfsharp.net/)

## Read this FIRST

Project documentation can be found on our DOCS site: <https://docs.pdfsharp.net>.

### Download assets first

Assets like bitmaps, fonts, or PDF files are not part of the repository anymore.
You must download them before compiling the solution for the first time.
Use `download-assets.ps1` in the `dev` folder to create `assets` folder required for some unit tests and needed by some projects.

Execute `./dev/download-assets.ps1`

### Build the solution

`dotnet build` should build the solution without any warnings or errors.

* You need the latest .NET SDK version installed
* If you got an exception from `GitVersion.MsBuild` let us know.  
  You can set a tag to define a valid version, e.g.: `git tag v6.0.0` to make it work.

### Central package management

The solution uses central package management.
Version numbers for all referenced packages are stored in file `Directory.Packages.props` in the `src` folder.
When adding new packages, add the required version here.

## Authors

PDFsharp and MigraDoc was mainly written by the following software developers.
With support of a lot of community developers who found issues and fixed bugs.

### Original PDFsharp developers

Stefan Lange  
Niklas Schneider  
David Stephensen

### Original MigraDoc developers

Klaus Potzesny  
Niklas Schneider  
Stefan Lange

### Current PDFsharp and MigraDoc developers

Stefan Lange  
Thomas Hövel  
Martin Ossendorf  
Andreas Seifert
