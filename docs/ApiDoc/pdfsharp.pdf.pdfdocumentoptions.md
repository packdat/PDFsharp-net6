# PdfDocumentOptions

Namespace: PdfSharp.Pdf

Holds information how to handle the document when it is saved as PDF stream.

```csharp
public sealed class PdfDocumentOptions
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [PdfDocumentOptions](./pdfsharp.pdf.pdfdocumentoptions)

## Properties

### **ColorMode**

Gets or sets the color mode.

```csharp
public PdfColorMode ColorMode { get; set; }
```

#### Property Value

[PdfColorMode](./pdfsharp.pdf.pdfcolormode)<br>

### **CompressContentStreams**

Gets or sets a value indicating whether to compress content streams of PDF pages.

```csharp
public bool CompressContentStreams { get; set; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **NoCompression**

Gets or sets a value indicating that all objects are not compressed.

```csharp
public bool NoCompression { get; set; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **FlateEncodeMode**

Gets or sets the flate encode mode. Besides the balanced default mode you can set modes for best compression (slower) or best speed (larger files).

```csharp
public PdfFlateEncodeMode FlateEncodeMode { get; set; }
```

#### Property Value

[PdfFlateEncodeMode](./pdfsharp.pdf.pdfflateencodemode)<br>

### **EnableCcittCompressionForBilevelImages**

Gets or sets a value indicating whether to compress bilevel images using CCITT compression.
 With true, PDFsharp will try FlateDecode CCITT and will use the smallest one or a combination of both.
 With false, PDFsharp will always use FlateDecode only - files may be a few bytes larger, but file creation is faster.

```csharp
public bool EnableCcittCompressionForBilevelImages { get; set; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **UseFlateDecoderForJpegImages**

Gets or sets a value indicating whether to compress JPEG images with the FlateDecode filter.

```csharp
public PdfUseFlateDecoderForJpegImages UseFlateDecoderForJpegImages { get; set; }
```

#### Property Value

[PdfUseFlateDecoderForJpegImages](./pdfsharp.pdf.pdfuseflatedecoderforjpegimages)<br>
