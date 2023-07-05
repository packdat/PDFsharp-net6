# PdfPageMode

Namespace: PdfSharp.Pdf

Specifies how the document should be displayed by a viewer when opened.

```csharp
public enum PdfPageMode
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ValueType](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype) → [Enum](https://docs.microsoft.com/en-us/dotnet/api/system.enum) → [PdfPageMode](./pdfsharp.pdf.pdfpagemode)<br>
Implements [IComparable](https://docs.microsoft.com/en-us/dotnet/api/system.icomparable), [IFormattable](https://docs.microsoft.com/en-us/dotnet/api/system.iformattable), [IConvertible](https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible)

## Fields

| Name | Value | Description |
| --- | --: | --- |
| UseNone | 0 | Neither document outline nor thumbnail images visible. |
| UseOutlines | 1 | Document outline visible. |
| UseThumbs | 2 | Thumbnail images visible. |
| FullScreen | 3 | Full-screen mode, with no menu bar, windowcontrols, or any other window visible. |
| UseOC | 4 | (PDF 1.5) Optional content group panel visible. |
| UseAttachments | 5 | (PDF 1.6) Attachments panel visible. |
