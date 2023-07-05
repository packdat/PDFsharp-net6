# PdfFlateEncodeMode

Namespace: PdfSharp.Pdf

Sets the mode for the Deflater (FlateEncoder).

```csharp
public enum PdfFlateEncodeMode
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ValueType](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype) → [Enum](https://docs.microsoft.com/en-us/dotnet/api/system.enum) → [PdfFlateEncodeMode](./pdfsharp.pdf.pdfflateencodemode)<br>
Implements [IComparable](https://docs.microsoft.com/en-us/dotnet/api/system.icomparable), [IFormattable](https://docs.microsoft.com/en-us/dotnet/api/system.iformattable), [IConvertible](https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible)

## Fields

| Name | Value | Description |
| --- | --: | --- |
| Default | 0 | The default mode. |
| BestSpeed | 1 | Fast encoding, but larger PDF files. |
| BestCompression | 2 | Best compression, but takes more time. |
