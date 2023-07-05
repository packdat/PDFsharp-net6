# PdfWriterLayout

Namespace: PdfSharp.Pdf.IO

Determines how the PDF output stream is formatted. Even all formats create valid PDF files,
 only Compact or Standard should be used for production purposes.

```csharp
public enum PdfWriterLayout
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ValueType](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype) → [Enum](https://docs.microsoft.com/en-us/dotnet/api/system.enum) → [PdfWriterLayout](./pdfsharp.pdf.io.pdfwriterlayout)<br>
Implements [IComparable](https://docs.microsoft.com/en-us/dotnet/api/system.icomparable), [IFormattable](https://docs.microsoft.com/en-us/dotnet/api/system.iformattable), [IConvertible](https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible)

## Fields

| Name | Value | Description |
| --- | --: | --- |
| Compact | 0 | The PDF stream contains no unnecessary characters. This is default in release build. |
| Standard | 1 | The PDF stream contains some superfluous line feeds but is more readable. |
| Indented | 2 | The PDF stream is indented to reflect the nesting levels of the objects. This is useful for analyzing PDF files, but increases the size of the file significantly. |
| Verbose | 3 | The PDF stream is indented to reflect the nesting levels of the objects and contains additional information about the PDFsharp objects. Furthermore, content streams are not deflated. This  is useful for debugging purposes only and increases the size of the file significantly. |
