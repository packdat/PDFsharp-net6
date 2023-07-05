# XBitmapImage

Namespace: PdfSharp.Drawing

Defines a pixel-based bitmap image.

```csharp
public sealed class XBitmapImage : XBitmapSource, System.IDisposable
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [XImage](./pdfsharp.drawing.ximage) → [XBitmapSource](./pdfsharp.drawing.xbitmapsource) → [XBitmapImage](./pdfsharp.drawing.xbitmapimage)<br>
Implements [IDisposable](https://docs.microsoft.com/en-us/dotnet/api/system.idisposable)

## Properties

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

### **CreateBitmap(Int32, Int32)**

Creates a default 24-bit ARGB bitmap with the specified pixel size.

```csharp
public static XBitmapSource CreateBitmap(int width, int height)
```

#### Parameters

`width` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

`height` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

#### Returns

[XBitmapSource](./pdfsharp.drawing.xbitmapsource)<br>
