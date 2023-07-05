# PdfPageLayout

Namespace: PdfSharp.Pdf

Specifies the page layout to be used by a viewer when the document is opened.

```csharp
public enum PdfPageLayout
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ValueType](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype) → [Enum](https://docs.microsoft.com/en-us/dotnet/api/system.enum) → [PdfPageLayout](./pdfsharp.pdf.pdfpagelayout)<br>
Implements [IComparable](https://docs.microsoft.com/en-us/dotnet/api/system.icomparable), [IFormattable](https://docs.microsoft.com/en-us/dotnet/api/system.iformattable), [IConvertible](https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible)

## Fields

| Name | Value | Description |
| --- | --: | --- |
| SinglePage | 0 | Display one page at a time. |
| OneColumn | 1 | Display the pages in one column. |
| TwoColumnLeft | 2 | Display the pages in two columns, with odd-numbered pages on the left. |
| TwoColumnRight | 3 | Display the pages in two columns, with odd-numbered pages on the right. |
| TwoPageLeft | 4 | (PDF 1.5) Display the pages two at a time, with odd-numbered pages on the left. |
| TwoPageRight | 5 | (PDF 1.5) Display the pages two at a time, with odd-numbered pages on the right. |
