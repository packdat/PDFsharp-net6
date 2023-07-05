# PdfTextStringEncoding

Namespace: PdfSharp.Pdf

Specifies how text strings are encoded. A text string is any text used outside of a page content 
 stream, e.g. document information, outline text, annotation text etc.

```csharp
public enum PdfTextStringEncoding
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ValueType](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype) → [Enum](https://docs.microsoft.com/en-us/dotnet/api/system.enum) → [PdfTextStringEncoding](./pdfsharp.pdf.pdftextstringencoding)<br>
Implements [IComparable](https://docs.microsoft.com/en-us/dotnet/api/system.icomparable), [IFormattable](https://docs.microsoft.com/en-us/dotnet/api/system.iformattable), [IConvertible](https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible)

## Fields

| Name | Value | Description |
| --- | --: | --- |
| PDFDocEncoding | 0 | Specifies that hypertext uses PDF DocEncoding. |
| Unicode | 1 | Specifies that hypertext uses Unicode encoding. |
