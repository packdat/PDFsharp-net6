# XBitmapEncoder

Namespace: PdfSharp.Drawing

Provides functionality to save a bitmap image in a specific format.

```csharp
public abstract class XBitmapEncoder
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [XBitmapEncoder](./pdfsharp.drawing.xbitmapencoder)

## Properties

### **Source**

Gets or sets the bitmap source to be encoded.

```csharp
public XBitmapSource Source { get; set; }
```

#### Property Value

[XBitmapSource](./pdfsharp.drawing.xbitmapsource)<br>

## Methods

### **GetPngEncoder()**

Gets a new instance of the PNG image encoder.

```csharp
public static XBitmapEncoder GetPngEncoder()
```

#### Returns

[XBitmapEncoder](./pdfsharp.drawing.xbitmapencoder)<br>

### **Save(Stream)**

When overridden in a derived class saves the image on the specified stream
 in the respective format.

```csharp
public abstract void Save(Stream stream)
```

#### Parameters

`stream` [Stream](https://docs.microsoft.com/en-us/dotnet/api/system.io.stream)<br>
