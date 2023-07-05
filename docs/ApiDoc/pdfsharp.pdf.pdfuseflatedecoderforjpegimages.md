# PdfUseFlateDecoderForJpegImages

Namespace: PdfSharp.Pdf

Specifies whether to compress JPEG images with the FlateDecode filter.

```csharp
public enum PdfUseFlateDecoderForJpegImages
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ValueType](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype) → [Enum](https://docs.microsoft.com/en-us/dotnet/api/system.enum) → [PdfUseFlateDecoderForJpegImages](./pdfsharp.pdf.pdfuseflatedecoderforjpegimages)<br>
Implements [IComparable](https://docs.microsoft.com/en-us/dotnet/api/system.icomparable), [IFormattable](https://docs.microsoft.com/en-us/dotnet/api/system.iformattable), [IConvertible](https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible)

## Fields

| Name | Value | Description |
| --- | --: | --- |
| Automatic | 0 | PDFsharp will try FlateDecode and use it if it leads to a reduction in PDF file size. When FlateEncodeMode is set to BestCompression, this is more likely to reduce the file size, but it takes considerably more time to create the PDF file. |
| Never | 1 | PDFsharp will never use FlateDecode - files may be a few bytes larger, but file creation is faster. |
| Always | 2 | PDFsharp will always use FlateDecode, even if this leads to larger files; this option is meant for testing purposes only and should not be used for production code. |
