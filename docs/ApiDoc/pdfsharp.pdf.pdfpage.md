# PdfPage

Namespace: PdfSharp.Pdf

Represents a page in a PDF document.

```csharp
public sealed class PdfPage : PdfDictionary, System.ICloneable, System.Collections.Generic.IEnumerable`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib, Version=6.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e],[PdfSharp.Pdf.PdfItem, PdfSharp, Version=0.1.3.0, Culture=neutral, PublicKeyToken=null]], System.Private.CoreLib, Version=6.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e]], System.Collections.IEnumerable, PdfSharp.Pdf.Advanced.IContentStream
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [PdfItem](./pdfsharp.pdf.pdfitem) → [PdfObject](./pdfsharp.pdf.pdfobject) → [PdfDictionary](./pdfsharp.pdf.pdfdictionary) → [PdfPage](./pdfsharp.pdf.pdfpage)<br>
Implements [ICloneable](https://docs.microsoft.com/en-us/dotnet/api/system.icloneable), [IEnumerable&lt;KeyValuePair&lt;String, PdfItem&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1), [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.ienumerable), [IContentStream](./pdfsharp.pdf.advanced.icontentstream)

## Properties

### **Tag**

Gets or sets a user defined object that contains arbitrary information associated with this PDF page.
 The tag is not used by PDFsharp.

```csharp
public object Tag { get; set; }
```

#### Property Value

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)<br>

### **Orientation**

Gets or sets the orientation of the page. The default value PageOrientation.Portrait.
 If an imported page has a /Rotate value that matches the formula 90 + n * 180 the 
 orientation is set to PageOrientation.Landscape.

```csharp
public PageOrientation Orientation { get; set; }
```

#### Property Value

[PageOrientation](./pdfsharp.pageorientation)<br>

### **Size**

Gets or sets one of the predefined standard sizes like.

```csharp
public PageSize Size { get; set; }
```

#### Property Value

[PageSize](./pdfsharp.pagesize)<br>

### **TrimMargins**

Gets or sets the trim margins.

```csharp
public TrimMargins TrimMargins { get; set; }
```

#### Property Value

[TrimMargins](./pdfsharp.pdf.trimmargins)<br>

### **MediaBox**

Gets or sets the media box directly. XGraphics is not prepared to work with a media box
 with an origin other than (0,0).

```csharp
public PdfRectangle MediaBox { get; set; }
```

#### Property Value

[PdfRectangle](./pdfsharp.pdf.pdfrectangle)<br>

### **CropBox**

Gets or sets the crop box.

```csharp
public PdfRectangle CropBox { get; set; }
```

#### Property Value

[PdfRectangle](./pdfsharp.pdf.pdfrectangle)<br>

### **BleedBox**

Gets or sets the bleed box.

```csharp
public PdfRectangle BleedBox { get; set; }
```

#### Property Value

[PdfRectangle](./pdfsharp.pdf.pdfrectangle)<br>

### **ArtBox**

Gets or sets the art box.

```csharp
public PdfRectangle ArtBox { get; set; }
```

#### Property Value

[PdfRectangle](./pdfsharp.pdf.pdfrectangle)<br>

### **TrimBox**

Gets or sets the trim box.

```csharp
public PdfRectangle TrimBox { get; set; }
```

#### Property Value

[PdfRectangle](./pdfsharp.pdf.pdfrectangle)<br>

### **Height**

Gets or sets the height of the page. If orientation is Landscape, this function applies to
 the width.

```csharp
public XUnit Height { get; set; }
```

#### Property Value

[XUnit](./pdfsharp.drawing.xunit)<br>

### **Width**

Gets or sets the width of the page. If orientation is Landscape, this function applies to
 the height.

```csharp
public XUnit Width { get; set; }
```

#### Property Value

[XUnit](./pdfsharp.drawing.xunit)<br>

### **Rotate**

Gets or sets the /Rotate entry of the PDF page. The value is the number of degrees by which the page 
 should be rotated clockwise when displayed or printed. The value must be a multiple of 90.
 PDFsharp does not set this value, but for imported pages this value can be set and must be taken
 into account when adding graphic to such a page.

```csharp
public int Rotate { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **Contents**

Gets the array of content streams of the page.

```csharp
public PdfContents Contents { get; }
```

#### Property Value

[PdfContents](./pdfsharp.pdf.advanced.pdfcontents)<br>

### **HasAnnotations**

Gets the annotations array of this page.

```csharp
public bool HasAnnotations { get; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **Annotations**

Gets the annotations array of this page.

```csharp
public PdfAnnotations Annotations { get; }
```

#### Property Value

[PdfAnnotations](./pdfsharp.pdf.annotations.pdfannotations)<br>

### **CustomValues**

Gets or sets the custom values.

```csharp
public PdfCustomValues CustomValues { get; set; }
```

#### Property Value

[PdfCustomValues](./pdfsharp.pdf.pdfcustomvalues)<br>

### **Resources**

Gets the PdfResources object of this page.

```csharp
public PdfResources Resources { get; }
```

#### Property Value

[PdfResources](./pdfsharp.pdf.advanced.pdfresources)<br>

### **Elements**

Gets the dictionary containing the elements of this dictionary.

```csharp
public DictionaryElements Elements { get; }
```

#### Property Value

[DictionaryElements](./pdfsharp.pdf.pdfdictionary.dictionaryelements)<br>

### **Stream**

Gets or sets the PDF stream belonging to this dictionary. Returns null if the dictionary has
 no stream. To create the stream, call the CreateStream function.

```csharp
public PdfStream Stream { get; set; }
```

#### Property Value

[PdfStream](./pdfsharp.pdf.pdfdictionary.pdfstream)<br>

### **Owner**

Gets the PdfDocument this object belongs to.

```csharp
public PdfDocument Owner { get; }
```

#### Property Value

[PdfDocument](./pdfsharp.pdf.pdfdocument)<br>

### **IsIndirect**

Indicates whether the object is an indirect object.

```csharp
public bool IsIndirect { get; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **Internals**

Gets the PdfInternals object of this document, that grants access to some internal structures
 which are not part of the public interface of PdfDocument.

```csharp
public PdfObjectInternals Internals { get; }
```

#### Property Value

[PdfObjectInternals](./pdfsharp.pdf.advanced.pdfobjectinternals)<br>

### **Reference**

Gets the indirect reference of this object. If the value is null, this object is a direct object.

```csharp
public PdfReference Reference { get; internal set; }
```

#### Property Value

[PdfReference](./pdfsharp.pdf.advanced.pdfreference)<br>

### **ReferenceNotNull**

Gets the indirect reference of this object. Throws if it is null.

```csharp
public PdfReference ReferenceNotNull { get; }
```

#### Property Value

[PdfReference](./pdfsharp.pdf.advanced.pdfreference)<br>

#### Exceptions

[InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/system.invalidoperationexception)<br>
The indirect reference must be not null here.

## Constructors

### **PdfPage()**

Initializes a new page. The page must be added to a document before it can be used.
 Depending on the IsMetric property of the current region the page size is set to 
 A4 or Letter respectively. If this size is not appropriate it should be changed before
 any drawing operations are performed on the page.

```csharp
public PdfPage()
```

### **PdfPage(PdfDocument)**

Initializes a new instance of the [PdfPage](./pdfsharp.pdf.pdfpage) class.

```csharp
public PdfPage(PdfDocument document)
```

#### Parameters

`document` [PdfDocument](./pdfsharp.pdf.pdfdocument)<br>
The document.

## Methods

### **Close()**

Closes the page. A closed page cannot be modified anymore, and it is not possible to
 get an XGraphics object for a closed page. Closing a page is not required, but may save
 resources if the document has many pages.

```csharp
public void Close()
```

### **AddDocumentLink(PdfRectangle, Int32)**

Adds an internal document link.

```csharp
public PdfLinkAnnotation AddDocumentLink(PdfRectangle rect, int destinationPage)
```

#### Parameters

`rect` [PdfRectangle](./pdfsharp.pdf.pdfrectangle)<br>
The link area in default page coordinates.

`destinationPage` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The destination page.

#### Returns

[PdfLinkAnnotation](./pdfsharp.pdf.annotations.pdflinkannotation)<br>

### **AddDocumentLink(PdfRectangle, String)**

Adds an internal document link.

```csharp
public PdfLinkAnnotation AddDocumentLink(PdfRectangle rect, string destinationName)
```

#### Parameters

`rect` [PdfRectangle](./pdfsharp.pdf.pdfrectangle)<br>
The link area in default page coordinates.

`destinationName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The Named Destination's name.

#### Returns

[PdfLinkAnnotation](./pdfsharp.pdf.annotations.pdflinkannotation)<br>

### **AddDocumentLink(PdfRectangle, String, String, Nullable&lt;Boolean&gt;)**

Adds an external document link.

```csharp
public PdfLinkAnnotation AddDocumentLink(PdfRectangle rect, string documentPath, string destinationName, Nullable<bool> newWindow)
```

#### Parameters

`rect` [PdfRectangle](./pdfsharp.pdf.pdfrectangle)<br>
The link area in default page coordinates.

`documentPath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The path to the target document.

`destinationName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The Named Destination's name in the target document.

`newWindow` [Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>
True, if the destination document shall be opened in a new window. If not set, the viewer application should behave in accordance with the current user preference.

#### Returns

[PdfLinkAnnotation](./pdfsharp.pdf.annotations.pdflinkannotation)<br>

### **AddEmbeddedDocumentLink(PdfRectangle, String, Nullable&lt;Boolean&gt;)**

Adds an embedded document link.

```csharp
public PdfLinkAnnotation AddEmbeddedDocumentLink(PdfRectangle rect, string destinationPath, Nullable<bool> newWindow)
```

#### Parameters

`rect` [PdfRectangle](./pdfsharp.pdf.pdfrectangle)<br>
The link area in default page coordinates.

`destinationPath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The path to the named destination through the embedded documents.
 The path is separated by '\' and the last segment is the name of the named destination.
 The other segments describe the route from the current (root or embedded) document to the embedded document holding the destination.
 ".." references to the parent, other strings refer to a child with this name in the EmbeddedFiles name dictionary.

`newWindow` [Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>
True, if the destination document shall be opened in a new window.
 If not set, the viewer application should behave in accordance with the current user preference.

#### Returns

[PdfLinkAnnotation](./pdfsharp.pdf.annotations.pdflinkannotation)<br>

### **AddEmbeddedDocumentLink(PdfRectangle, String, String, Nullable&lt;Boolean&gt;)**

Adds an external embedded document link.

```csharp
public PdfLinkAnnotation AddEmbeddedDocumentLink(PdfRectangle rect, string documentPath, string destinationPath, Nullable<bool> newWindow)
```

#### Parameters

`rect` [PdfRectangle](./pdfsharp.pdf.pdfrectangle)<br>
The link area in default page coordinates.

`documentPath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The path to the target document.

`destinationPath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The path to the named destination through the embedded documents in the target document.
 The path is separated by '\' and the last segment is the name of the named destination.
 The other segments describe the route from the root document to the embedded document.
 Each segment name refers to a child with this name in the EmbeddedFiles name dictionary.

`newWindow` [Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>
True, if the destination document shall be opened in a new window.
 If not set, the viewer application should behave in accordance with the current user preference.

#### Returns

[PdfLinkAnnotation](./pdfsharp.pdf.annotations.pdflinkannotation)<br>

### **AddWebLink(PdfRectangle, String)**

Adds a link to the Web.

```csharp
public PdfLinkAnnotation AddWebLink(PdfRectangle rect, string url)
```

#### Parameters

`rect` [PdfRectangle](./pdfsharp.pdf.pdfrectangle)<br>
The rect.

`url` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The URL.

#### Returns

[PdfLinkAnnotation](./pdfsharp.pdf.annotations.pdflinkannotation)<br>

### **AddFileLink(PdfRectangle, String)**

Adds a link to a file.

```csharp
public PdfLinkAnnotation AddFileLink(PdfRectangle rect, string fileName)
```

#### Parameters

`rect` [PdfRectangle](./pdfsharp.pdf.pdfrectangle)<br>
The rect.

`fileName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
Name of the file.

#### Returns

[PdfLinkAnnotation](./pdfsharp.pdf.annotations.pdflinkannotation)<br>

### **GetFontName(XFont, PdfFont&)**

Gets the resource name of the specified font within this page.

```csharp
internal string GetFontName(XFont font, PdfFont& pdfFont)
```

#### Parameters

`font` [XFont](./pdfsharp.drawing.xfont)<br>

`pdfFont` [PdfFont&](./pdfsharp.pdf.advanced.pdffont&)<br>

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **TryGetFontName(String, PdfFont&)**

Tries to get the resource name of the specified font data within this page.
 Returns null if no such font exists.

```csharp
internal string TryGetFontName(string idName, PdfFont& pdfFont)
```

#### Parameters

`idName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`pdfFont` [PdfFont&](./pdfsharp.pdf.advanced.pdffont&)<br>

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **GetFontName(String, Byte[], PdfFont&)**

Gets the resource name of the specified font data within this page.

```csharp
internal string GetFontName(string idName, Byte[] fontData, PdfFont& pdfFont)
```

#### Parameters

`idName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`fontData` [Byte[]](https://docs.microsoft.com/en-us/dotnet/api/system.byte)<br>

`pdfFont` [PdfFont&](./pdfsharp.pdf.advanced.pdffont&)<br>

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **GetImageName(XImage)**

Gets the resource name of the specified image within this page.

```csharp
internal string GetImageName(XImage image)
```

#### Parameters

`image` [XImage](./pdfsharp.drawing.ximage)<br>

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **GetFormName(XForm)**

Gets the resource name of the specified form within this page.

```csharp
internal string GetFormName(XForm form)
```

#### Parameters

`form` [XForm](./pdfsharp.drawing.xform)<br>

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **WriteObject(PdfWriter)**

```csharp
internal void WriteObject(PdfWriter writer)
```

#### Parameters

`writer` [PdfWriter](./pdfsharp.pdf.io.pdfwriter)<br>

### **InheritValues(PdfDictionary, InheritedValues)**

Inherit values from parent node.

```csharp
internal static void InheritValues(PdfDictionary page, InheritedValues values)
```

#### Parameters

`page` [PdfDictionary](./pdfsharp.pdf.pdfdictionary)<br>

`values` [InheritedValues](./pdfsharp.pdf.pdfpage.inheritedvalues)<br>

### **InheritValues(PdfDictionary, InheritedValues&)**

Add all inheritable values from the specified page to the specified values structure.

```csharp
internal static void InheritValues(PdfDictionary page, InheritedValues& values)
```

#### Parameters

`page` [PdfDictionary](./pdfsharp.pdf.pdfdictionary)<br>

`values` [InheritedValues&](./pdfsharp.pdf.pdfpage.inheritedvalues&)<br>

### **PrepareForSave()**

```csharp
internal void PrepareForSave()
```
