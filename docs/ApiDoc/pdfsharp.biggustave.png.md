# Png

Namespace: PdfSharp.BigGustave

A PNG image. Call [Png.Open(Stream, IChunkVisitor)](./pdfsharp.biggustave.png#openstream-ichunkvisitor) to open from file or bytes.

```csharp
public class Png
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [Png](./pdfsharp.biggustave.png)

## Properties

### **Header**

The header data from the PNG image.

```csharp
public ImageHeader Header { get; }
```

#### Property Value

[ImageHeader](./pdfsharp.biggustave.imageheader)<br>

### **Width**

The width of the image in pixels.

```csharp
public int Width { get; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **Height**

The height of the image in pixels.

```csharp
public int Height { get; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **HasAlphaChannel**

Whether the image has an alpha (transparency) layer.

```csharp
public bool HasAlphaChannel { get; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

## Methods

### **GetPixelIndex(Int32, Int32)**

Get the palette index at the given column and row (x, y).

```csharp
public int GetPixelIndex(int x, int y)
```

#### Parameters

`x` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The x coordinate (column).

`y` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The y coordinate (row).

#### Returns

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The palette index of the pixel at the coordinate.

**Remarks:**

Pixel values are generated on demand from the underlying data to prevent holding many items in memory at once, so consumers
 should cache values if they're going to be looped over many times.

### **GetPalette()**

Gets the color palette.

```csharp
public Palette GetPalette()
```

#### Returns

[Palette](./pdfsharp.biggustave.palette)<br>

### **GetPixel(Int32, Int32)**

Get the pixel at the given column and row (x, y).

```csharp
public Pixel GetPixel(int x, int y)
```

#### Parameters

`x` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The x coordinate (column).

`y` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The y coordinate (row).

#### Returns

[Pixel](./pdfsharp.biggustave.pixel)<br>
The pixel at the coordinate.

**Remarks:**

Pixel values are generated on demand from the underlying data to prevent holding many items in memory at once, so consumers
 should cache values if they're going to be looped over many times.

### **Open(Stream, IChunkVisitor)**

Read the PNG image from the stream.

```csharp
public static Png Open(Stream stream, IChunkVisitor chunkVisitor)
```

#### Parameters

`stream` [Stream](https://docs.microsoft.com/en-us/dotnet/api/system.io.stream)<br>
The stream containing PNG data to be read.

`chunkVisitor` [IChunkVisitor](./pdfsharp.biggustave.ichunkvisitor)<br>
Optional: A visitor which is called whenever a chunk is read by the library.

#### Returns

[Png](./pdfsharp.biggustave.png)<br>
The [Png](./pdfsharp.biggustave.png) data from the stream.

### **Open(Stream, PngOpenerSettings)**

Read the PNG image from the stream.

```csharp
public static Png Open(Stream stream, PngOpenerSettings settings)
```

#### Parameters

`stream` [Stream](https://docs.microsoft.com/en-us/dotnet/api/system.io.stream)<br>
The stream containing PNG data to be read.

`settings` [PngOpenerSettings](./pdfsharp.biggustave.pngopenersettings)<br>
Settings to apply when opening the PNG.

#### Returns

[Png](./pdfsharp.biggustave.png)<br>
The [Png](./pdfsharp.biggustave.png) data from the stream.

### **Open(Byte[], IChunkVisitor)**

Read the PNG image from the bytes.

```csharp
public static Png Open(Byte[] bytes, IChunkVisitor chunkVisitor)
```

#### Parameters

`bytes` [Byte[]](https://docs.microsoft.com/en-us/dotnet/api/system.byte)<br>
The bytes of the PNG data to be read.

`chunkVisitor` [IChunkVisitor](./pdfsharp.biggustave.ichunkvisitor)<br>
Optional: A visitor which is called whenever a chunk is read by the library.

#### Returns

[Png](./pdfsharp.biggustave.png)<br>
The [Png](./pdfsharp.biggustave.png) data from the bytes.

### **Open(Byte[], PngOpenerSettings)**

Read the PNG image from the bytes.

```csharp
public static Png Open(Byte[] bytes, PngOpenerSettings settings)
```

#### Parameters

`bytes` [Byte[]](https://docs.microsoft.com/en-us/dotnet/api/system.byte)<br>
The bytes of the PNG data to be read.

`settings` [PngOpenerSettings](./pdfsharp.biggustave.pngopenersettings)<br>
Settings to apply when opening the PNG.

#### Returns

[Png](./pdfsharp.biggustave.png)<br>
The [Png](./pdfsharp.biggustave.png) data from the bytes.

### **Open(String, IChunkVisitor)**

Read the PNG from the file path.

```csharp
public static Png Open(string filePath, IChunkVisitor chunkVisitor)
```

#### Parameters

`filePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The path to the PNG file to open.

`chunkVisitor` [IChunkVisitor](./pdfsharp.biggustave.ichunkvisitor)<br>
Optional: A visitor which is called whenever a chunk is read by the library.

#### Returns

[Png](./pdfsharp.biggustave.png)<br>
The [Png](./pdfsharp.biggustave.png) data from the file.

**Remarks:**

This will open the file to obtain a [FileStream](https://docs.microsoft.com/en-us/dotnet/api/system.io.filestream) so will lock the file during reading.

### **Open(String, PngOpenerSettings)**

Read the PNG from the file path.

```csharp
public static Png Open(string filePath, PngOpenerSettings settings)
```

#### Parameters

`filePath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The path to the PNG file to open.

`settings` [PngOpenerSettings](./pdfsharp.biggustave.pngopenersettings)<br>
Settings to apply when opening the PNG.

#### Returns

[Png](./pdfsharp.biggustave.png)<br>
The [Png](./pdfsharp.biggustave.png) data from the file.

**Remarks:**

This will open the file to obtain a [FileStream](https://docs.microsoft.com/en-us/dotnet/api/system.io.filestream) so will lock the file during reading.
