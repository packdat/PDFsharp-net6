# XForm

Namespace: PdfSharp.Drawing

Represents a graphical object that can be used to render retained graphics on it.
 In GDI+ it is represented by a Metafile, in WPF by a DrawingVisual, and in PDF by a Form XObjects.

```csharp
public class XForm : XImage, System.IDisposable, PdfSharp.Pdf.Advanced.IContentStream
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [XImage](./pdfsharp.drawing.ximage) → [XForm](./pdfsharp.drawing.xform)<br>
Implements [IDisposable](https://docs.microsoft.com/en-us/dotnet/api/system.idisposable), [IContentStream](./pdfsharp.pdf.advanced.icontentstream)

## Properties

### **Width**

#### Caution

Use either PixelWidth or PointWidth. Temporarily obsolete because of rearrangements for WPF. Currently same as PixelWidth, but will become PointWidth in future releases of PDFsharp.

---

Get the width of the page identified by the property PageNumber.

```csharp
public double Width { get; }
```

#### Property Value

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **Height**

#### Caution

Use either PixelHeight or PointHeight. Temporarily obsolete because of rearrangements for WPF. Currently same as PixelHeight, but will become PointHeight in future releases of PDFsharp.

---

Get the width of the page identified by the property PageNumber.

```csharp
public double Height { get; }
```

#### Property Value

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **PointWidth**

Get the width in point of this image.

```csharp
public double PointWidth { get; }
```

#### Property Value

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **PointHeight**

Get the height in point of this image.

```csharp
public double PointHeight { get; }
```

#### Property Value

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **PixelWidth**

Get the width of the page identified by the property PageNumber.

```csharp
public int PixelWidth { get; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **PixelHeight**

Get the height of the page identified by the property PageNumber.

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

### **Transform**

Gets or sets the transformation matrix.

```csharp
public XMatrix Transform { get; set; }
```

#### Property Value

[XMatrix](./pdfsharp.drawing.xmatrix)<br>

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

## Constructors

### **XForm(PdfDocument, XRect)**

Initializes a new instance of the [XForm](./pdfsharp.drawing.xform) class that represents a page of a PDF document.

```csharp
public XForm(PdfDocument document, XRect viewBox)
```

#### Parameters

`document` [PdfDocument](./pdfsharp.pdf.pdfdocument)<br>
The PDF document.

`viewBox` [XRect](./pdfsharp.drawing.xrect)<br>
The view box of the page.

### **XForm(PdfDocument, XSize)**

Initializes a new instance of the [XForm](./pdfsharp.drawing.xform) class that represents a page of a PDF document.

```csharp
public XForm(PdfDocument document, XSize size)
```

#### Parameters

`document` [PdfDocument](./pdfsharp.pdf.pdfdocument)<br>
The PDF document.

`size` [XSize](./pdfsharp.drawing.xsize)<br>
The size of the page.

### **XForm(PdfDocument, XUnit, XUnit)**

Initializes a new instance of the [XForm](./pdfsharp.drawing.xform) class that represents a page of a PDF document.

```csharp
public XForm(PdfDocument document, XUnit width, XUnit height)
```

#### Parameters

`document` [PdfDocument](./pdfsharp.pdf.pdfdocument)<br>
The PDF document.

`width` [XUnit](./pdfsharp.drawing.xunit)<br>
The width of the page.

`height` [XUnit](./pdfsharp.drawing.xunit)<br>
The height of the page

## Methods

### **DrawingFinished()**

This function should be called when drawing the content of this form is finished.
 The XGraphics object used for drawing the content is disposed by this function and 
 cannot be used for any further drawing operations.
 PDFsharp automatically calls this function when this form was used the first time
 in a DrawImage function.

```csharp
public void DrawingFinished()
```

### **AssociateGraphics(XGraphics)**

Called from XGraphics constructor that creates an instance that work on this form.

```csharp
internal void AssociateGraphics(XGraphics gfx)
```

#### Parameters

`gfx` [XGraphics](./pdfsharp.drawing.xgraphics)<br>

### **Dispose(Boolean)**

Disposes this instance.

```csharp
protected void Dispose(bool disposing)
```

#### Parameters

`disposing` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **Finish()**

Sets the form in the state FormState.Finished.

```csharp
internal void Finish()
```

### **GetFontName(XFont, PdfFont&)**

Gets the resource name of the specified font within this form.

```csharp
internal string GetFontName(XFont font, PdfFont& pdfFont)
```

#### Parameters

`font` [XFont](./pdfsharp.drawing.xfont)<br>

`pdfFont` [PdfFont&](./pdfsharp.pdf.advanced.pdffont&)<br>

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **TryGetFontName(String, PdfFont&)**

Tries to get the resource name of the specified font data within this form.
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

Gets the resource name of the specified font data within this form.

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

Gets the resource name of the specified image within this form.

```csharp
internal string GetImageName(XImage image)
```

#### Parameters

`image` [XImage](./pdfsharp.drawing.ximage)<br>

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **GetFormName(XForm)**

Gets the resource name of the specified form within this form.

```csharp
internal string GetFormName(XForm form)
```

#### Parameters

`form` [XForm](./pdfsharp.drawing.xform)<br>

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
