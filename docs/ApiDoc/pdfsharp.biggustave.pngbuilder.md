# PngBuilder

Namespace: PdfSharp.BigGustave

Used to construct PNG images. Call [PngBuilder.Create(Int32, Int32, Boolean)](./pdfsharp.biggustave.pngbuilder#createint32-int32-boolean) to make a new builder.

```csharp
public class PngBuilder
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [PngBuilder](./pdfsharp.biggustave.pngbuilder)

## Methods

### **Create(Int32, Int32, Boolean)**

Create a builder for a PNG with the given width and size.

```csharp
public static PngBuilder Create(int width, int height, bool hasAlphaChannel)
```

#### Parameters

`width` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

`height` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

`hasAlphaChannel` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

#### Returns

[PngBuilder](./pdfsharp.biggustave.pngbuilder)<br>

### **FromPng(Png)**

Create a builder from a [Png](./pdfsharp.biggustave.png).

```csharp
public static PngBuilder FromPng(Png png)
```

#### Parameters

`png` [Png](./pdfsharp.biggustave.png)<br>

#### Returns

[PngBuilder](./pdfsharp.biggustave.pngbuilder)<br>

### **FromPngBytes(Byte[])**

Create a builder from the bytes of the specified PNG image.

```csharp
public static PngBuilder FromPngBytes(Byte[] png)
```

#### Parameters

`png` [Byte[]](https://docs.microsoft.com/en-us/dotnet/api/system.byte)<br>

#### Returns

[PngBuilder](./pdfsharp.biggustave.pngbuilder)<br>

### **FromBgra32Pixels(Byte[], Int32, Int32, Boolean)**

Create a builder from the bytes in the BGRA32 pixel format.
 https://docs.microsoft.com/en-us/dotnet/api/system.windows.media.pixelformats.bgra32

```csharp
public static PngBuilder FromBgra32Pixels(Byte[] data, int width, int height, bool useAlphaChannel)
```

#### Parameters

`data` [Byte[]](https://docs.microsoft.com/en-us/dotnet/api/system.byte)<br>
The pixels in BGRA32 format.

`width` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The width in pixels.

`height` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The height in pixels.

`useAlphaChannel` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
Whether to include an alpha channel in the output.

#### Returns

[PngBuilder](./pdfsharp.biggustave.pngbuilder)<br>

### **FromBgra32Pixels(Stream, Int32, Int32, Boolean)**

Create a builder from the bytes in the BGRA32 pixel format.
 https://docs.microsoft.com/en-us/dotnet/api/system.windows.media.pixelformats.bgra32

```csharp
public static PngBuilder FromBgra32Pixels(Stream data, int width, int height, bool useAlphaChannel)
```

#### Parameters

`data` [Stream](https://docs.microsoft.com/en-us/dotnet/api/system.io.stream)<br>
The pixels in BGRA32 format.

`width` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The width in pixels.

`height` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The height in pixels.

`useAlphaChannel` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
Whether to include an alpha channel in the output.

#### Returns

[PngBuilder](./pdfsharp.biggustave.pngbuilder)<br>

### **SetPixel(Byte, Byte, Byte, Int32, Int32)**

Sets the RGB pixel value for the given column (x) and row (y).

```csharp
public PngBuilder SetPixel(byte r, byte g, byte b, int x, int y)
```

#### Parameters

`r` [Byte](https://docs.microsoft.com/en-us/dotnet/api/system.byte)<br>

`g` [Byte](https://docs.microsoft.com/en-us/dotnet/api/system.byte)<br>

`b` [Byte](https://docs.microsoft.com/en-us/dotnet/api/system.byte)<br>

`x` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

`y` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

#### Returns

[PngBuilder](./pdfsharp.biggustave.pngbuilder)<br>

### **SetPixel(Pixel, Int32, Int32)**

Set the pixel value for the given column (x) and row (y).

```csharp
public PngBuilder SetPixel(Pixel pixel, int x, int y)
```

#### Parameters

`pixel` [Pixel](./pdfsharp.biggustave.pixel)<br>

`x` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

`y` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

#### Returns

[PngBuilder](./pdfsharp.biggustave.pngbuilder)<br>

### **StoreText(String, String)**

Allows you to store arbitrary text data in the "iTXt" international textual data
 chunks of the generated PNG image.

```csharp
public PngBuilder StoreText(string keyword, string text)
```

#### Parameters

`keyword` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
A keyword identifying the text data between 1-79 characters in length.
 Must not start with, end with, or contain consecutive whitespace characters.
 Only characters in the range 32 - 126 and 161 - 255 are permitted.

`text` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The text data to store. Encoded as UTF-8 that may not contain zero (0) bytes but can be zero-length.

#### Returns

[PngBuilder](./pdfsharp.biggustave.pngbuilder)<br>

### **Save(SaveOptions)**

Get the bytes of the PNG file for this builder.

```csharp
public Byte[] Save(SaveOptions options)
```

#### Parameters

`options` [SaveOptions](./pdfsharp.biggustave.pngbuilder.saveoptions)<br>

#### Returns

[Byte[]](https://docs.microsoft.com/en-us/dotnet/api/system.byte)<br>

### **Save(Stream, SaveOptions)**

Write the PNG file bytes to the provided stream.

```csharp
public void Save(Stream outputStream, SaveOptions options)
```

#### Parameters

`outputStream` [Stream](https://docs.microsoft.com/en-us/dotnet/api/system.io.stream)<br>

`options` [SaveOptions](./pdfsharp.biggustave.pngbuilder.saveoptions)<br>
