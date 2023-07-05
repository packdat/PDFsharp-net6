# PdfStringEncoding

Namespace: PdfSharp.Pdf

Determines the encoding of a PdfString or PdfStringObject.

```csharp
public enum PdfStringEncoding
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ValueType](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype) → [Enum](https://docs.microsoft.com/en-us/dotnet/api/system.enum) → [PdfStringEncoding](./pdfsharp.pdf.pdfstringencoding)<br>
Implements [IComparable](https://docs.microsoft.com/en-us/dotnet/api/system.icomparable), [IFormattable](https://docs.microsoft.com/en-us/dotnet/api/system.iformattable), [IConvertible](https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible)

## Fields

| Name | Value | Description |
| --- | --: | --- |
| RawEncoding | 0 | The characters of the string are actually bytes with an unknown or context specific meaning or encoding. With this encoding the 8 high bits of each character is zero. |
| StandardEncoding | 1 | Not yet used by PDFsharp. |
| PDFDocEncoding | 2 | The characters of the string are actually bytes with PDF document encoding. With this encoding the 8 high bits of each character is zero. |
| WinAnsiEncoding | 3 | The characters of the string are actually bytes with Windows ANSI encoding. With this encoding the 8 high bits of each character is zero. |
| MacRomanEncoding | 5 | Not yet used by PDFsharp. |
| MacExpertEncoding | 5 | Not yet used by PDFsharp. |
| Unicode | 6 | The characters of the string are Unicode characters. |
