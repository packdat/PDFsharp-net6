# XImage

Namespace: PdfSharp.Drawing

Defines an object used to draw image files (bmp, png, jpeg, gif) and PDF forms.
 An abstract base class that provides functionality for the Bitmap and Metafile descended classes.

```csharp
public class XImage : System.IDisposable
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [XImage](./pdfsharp.drawing.ximage)<br>
Implements [IDisposable](https://docs.microsoft.com/en-us/dotnet/api/system.idisposable)

## Properties

### **Width**

#### Caution

Use either PixelWidth or PointWidth. Temporarily obsolete because of rearrangements for WPF. Currently same as PixelWidth, but will become PointWidth in future releases of PDFsharp.

---

Gets the width of the image.

```csharp
public double Width { get; }
```

#### Property Value

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **Height**

#### Caution

Use either PixelHeight or PointHeight. Temporarily obsolete because of rearrangements for WPF. Currently same as PixelHeight, but will become PointHeight in future releases of PDFsharp.

---

Gets the height of the image.

```csharp
public double Height { get; }
```

#### Property Value

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **PointWidth**

Gets the width of the image in point.

```csharp
public double PointWidth { get; }
```

#### Property Value

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **PointHeight**

Gets the height of the image in point.

```csharp
public double PointHeight { get; }
```

#### Property Value

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **PixelWidth**

Gets the width of the image in pixels.

```csharp
public int PixelWidth { get; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **PixelHeight**

Gets the height of the image in pixels.

```csharp
public int PixelHeight { get; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **Size**

Gets the size in point of the image.

```csharp
public XSize Size { get; }
```

#### Property Value

[XSize](./pdfsharp.drawing.xsize)<br>

### **HorizontalResolution**

Gets the horizontal resolution of the image.

```csharp
public double HorizontalResolution { get; }
```

#### Property Value

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **VerticalResolution**

Gets the vertical resolution of the image.

```csharp
public double VerticalResolution { get; }
```

#### Property Value

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

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

Creates an image from the specified file.

```csharp
public static XImage FromFile(string path)
```

#### Parameters

`path` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The path to a BMP, PNG, JPEG, or PDF file.

#### Returns

[XImage](./pdfsharp.drawing.ximage)<br>

### **FromStream(Stream)**

Creates an image from the specified stream.<br>

```csharp
public static XImage FromStream(Stream stream)
```

#### Parameters

`stream` [Stream](https://docs.microsoft.com/en-us/dotnet/api/system.io.stream)<br>
The stream containing a BMP, PNG, JPEG, or PDF file.

#### Returns

[XImage](./pdfsharp.drawing.ximage)<br>

### **FromImportedImage(ImportedImage)**

#### Caution

THHO4THHO Internal test code.

---

Creates an image.

```csharp
internal static XImage FromImportedImage(ImportedImage image)
```

#### Parameters

`image` [ImportedImage](./pdfsharp.drawing.importedimage)<br>
The imported image.

#### Returns

[XImage](./pdfsharp.drawing.ximage)<br>

### **ExistsFile(String)**

Tests if a file exist. Supports PDF files with page number suffix.

```csharp
public static bool ExistsFile(string path)
```

#### Parameters

`path` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The path to a BMP, PNG, GIF, JPEG, TIFF, or PDF file.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **Initialize()**

```csharp
internal void Initialize()
```

### **Dispose()**

Under construction

```csharp
public void Dispose()
```

### **Dispose(Boolean)**

Disposes underlying GDI+ object.

```csharp
protected void Dispose(bool disposing)
```

#### Parameters

`disposing` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **AssociateWithGraphics(XGraphics)**

```csharp
internal void AssociateWithGraphics(XGraphics gfx)
```

#### Parameters

`gfx` [XGraphics](./pdfsharp.drawing.xgraphics)<br>

### **DisassociateWithGraphics()**

```csharp
internal void DisassociateWithGraphics()
```

### **DisassociateWithGraphics(XGraphics)**

```csharp
internal void DisassociateWithGraphics(XGraphics gfx)
```

#### Parameters

`gfx` [XGraphics](./pdfsharp.drawing.xgraphics)<br>
