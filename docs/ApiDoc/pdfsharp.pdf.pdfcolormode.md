# PdfColorMode

Namespace: PdfSharp.Pdf

Specifies what color model is used in a PDF document.

```csharp
public enum PdfColorMode
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ValueType](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype) → [Enum](https://docs.microsoft.com/en-us/dotnet/api/system.enum) → [PdfColorMode](./pdfsharp.pdf.pdfcolormode)<br>
Implements [IComparable](https://docs.microsoft.com/en-us/dotnet/api/system.icomparable), [IFormattable](https://docs.microsoft.com/en-us/dotnet/api/system.iformattable), [IConvertible](https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible)

## Fields

| Name | Value | Description |
| --- | --: | --- |
| Undefined | 0 | All color values are written as specified in the XColor objects they come from. |
| Rgb | 1 | All colors are converted to RGB. |
| Cmyk | 2 | All colors are converted to CMYK. |
