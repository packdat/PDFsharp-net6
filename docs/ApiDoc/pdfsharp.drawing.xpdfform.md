# XPdfForm

Namespace: PdfSharp.Drawing

Represents a so called 'PDF form external object', which is typically an imported page of an external
 PDF document. XPdfForm objects are used like images to draw an existing PDF page of an external
 document in the current document. XPdfForm objects can only be placed in PDF documents. If you try
 to draw them using a XGraphics based on an GDI+ context no action is taken if no placeholder image
 is specified. Otherwise, the place holder is drawn.

```csharp
public class XPdfForm : XForm, System.IDisposable, PdfSharp.Pdf.Advanced.IContentStream
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [XImage](./pdfsharp.drawing.ximage) → [XForm](./pdfsharp.drawing.xform) → [XPdfForm](./pdfsharp.drawing.xpdfform)<br>
Implements [IDisposable](https://docs.microsoft.com/en-us/dotnet/api/system.idisposable), [IContentStream](./pdfsharp.pdf.advanced.icontentstream)

## Properties

### **PlaceHolder**

Gets or sets an image that is used for drawing if the current XGraphics object cannot handle
 PDF forms. A place holder is useful for showing a preview of a page on the display, because
 PDFsharp cannot render native PDF objects.

```csharp
public XImage PlaceHolder { get; set; }
```

#### Property Value

[XImage](./pdfsharp.drawing.ximage)<br>

### **Page**

Gets the underlying PdfPage (if one exists).

```csharp
public PdfPage Page { get; }
```

#### Property Value

[PdfPage](./pdfsharp.pdf.pdfpage)<br>

### **PageCount**

Gets the number of pages in the PDF form.

```csharp
public int PageCount { get; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **Width**

#### Caution

Use either PixelWidth or PointWidth. Temporarily obsolete because of rearrangements for WPF.

---

Gets the width in point of the page identified by the property PageNumber.

```csharp
public double Width { get; }
```

#### Property Value

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **Height**

#### Caution

Use either PixelHeight or PointHeight. Temporarily obsolete because of rearrangements for WPF.

---

Gets the height in point of the page identified by the property PageNumber.

```csharp
public double Height { get; }
```

#### Property Value

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **PointWidth**

Gets the width in point of the page identified by the property PageNumber.

```csharp
public double PointWidth { get; }
```

#### Property Value

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **PointHeight**

Gets the height in point of the page identified by the property PageNumber.

```csharp
public double PointHeight { get; }
```

#### Property Value

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **PixelWidth**

Gets the width in point of the page identified by the property PageNumber.

```csharp
public int PixelWidth { get; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **PixelHeight**

Gets the height in point of the page identified by the property PageNumber.

```csharp
public int PixelHeight { get; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **Size**

Get the size of the page identified by the property PageNumber.

```csharp
public XSize Size { get; }
```

#### Property Value

[XSize](./pdfsharp.drawing.xsize)<br>

### **Transform**

Gets or sets the transformation matrix.

```csharp
public XMatrix Transform { get; set; }
```

#### Property Value

[XMatrix](./pdfsharp.drawing.xmatrix)<br>

### **PageNumber**

Gets or sets the page number in the external PDF document this object refers to. The page number
 is one-based, i.e. it is in the range from 1 to PageCount. The default value is 1.

```csharp
public int PageNumber { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **PageIndex**

Gets or sets the page index in the external PDF document this object refers to. The page index
 is zero-based, i.e. it is in the range from 0 to PageCount - 1. The default value is 0.

```csharp
public int PageIndex { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **ViewBox**

Gets the view box of the form.

```csharp
public XRect ViewBox { get; }
```

#### Property Value

[XRect](./pdfsharp.drawing.xrect)<br>

### **HorizontalResolution**

Gets 72, the horizontal resolution by design of a form object.

```csharp
public double HorizontalResolution { get; }
```

#### Property Value

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **VerticalResolution**

Gets 72 always, the vertical resolution by design of a form object.

```csharp
public double VerticalResolution { get; }
```

#### Property Value

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **BoundingBox**

Gets or sets the bounding box.

```csharp
public XRect BoundingBox { get; set; }
```

#### Property Value

[XRect](./pdfsharp.drawing.xrect)<br>

### **Interpolate**

Gets or sets a flag indicating whether image interpolation is to be performed.

```csharp
public bool Interpolate { get; set; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **Format**

Gets the format of the image.

```csharp
public XImageFormat Format { get; }
```

#### Property Value

[XImageFormat](./pdfsharp.drawing.ximageformat)<br>

## Methods

### **FromFile(String)**

Creates an XPdfForm from a file.

```csharp
public static XPdfForm FromFile(string path)
```

#### Parameters

`path` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

#### Returns

[XPdfForm](./pdfsharp.drawing.xpdfform)<br>

### **FromStream(Stream)**

Creates an XPdfForm from a stream.

```csharp
public static XPdfForm FromStream(Stream stream)
```

#### Parameters

`stream` [Stream](https://docs.microsoft.com/en-us/dotnet/api/system.io.stream)<br>

#### Returns

[XPdfForm](./pdfsharp.drawing.xpdfform)<br>

### **Finish()**

Sets the form in the state FormState.Finished.

```csharp
internal void Finish()
```

### **Dispose(Boolean)**

Frees the memory occupied by the underlying imported PDF document, even if other XPdfForm objects
 refer to this document. A reuse of this object doesn't fail, because the underlying PDF document
 is re-imported if necessary.

```csharp
protected void Dispose(bool disposing)
```

#### Parameters

`disposing` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **ExtractPageNumber(String, Int32&)**

Extracts the page number if the path has the form 'MyFile.pdf#123' and returns
 the actual path without the number sign and the following digits.

```csharp
public static string ExtractPageNumber(string path, Int32& pageNumber)
```

#### Parameters

`path` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`pageNumber` [Int32&](https://docs.microsoft.com/en-us/dotnet/api/system.int32&)<br>

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
