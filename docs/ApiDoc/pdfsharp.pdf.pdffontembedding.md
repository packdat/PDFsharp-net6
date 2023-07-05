# PdfFontEmbedding

Namespace: PdfSharp.Pdf

Specifies the embedding options of an XFont when converted into PDF.
 Font embedding is not optional anymore. So Always is the only option.

```csharp
public enum PdfFontEmbedding
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ValueType](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype) → [Enum](https://docs.microsoft.com/en-us/dotnet/api/system.enum) → [PdfFontEmbedding](./pdfsharp.pdf.pdffontembedding)<br>
Implements [IComparable](https://docs.microsoft.com/en-us/dotnet/api/system.icomparable), [IFormattable](https://docs.microsoft.com/en-us/dotnet/api/system.iformattable), [IConvertible](https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible)

## Fields

| Name | Value | Description |
| --- | --: | --- |
| Always | 0 | All fonts are embedded. |
| Full | 256 | Embed the full font, not a subset |
| None | 257 | Fonts are not embedded. This is not an option anymore. |
| Default | 258 | Unicode fonts are embedded, WinAnsi fonts are not embedded. |
| Automatic | 259 | Not yet implemented. |
