# PdfDocumentOpenMode

Namespace: PdfSharp.Pdf.IO

Determines how a PDF document is opened.

```csharp
public enum PdfDocumentOpenMode
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ValueType](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype) → [Enum](https://docs.microsoft.com/en-us/dotnet/api/system.enum) → [PdfDocumentOpenMode](./pdfsharp.pdf.io.pdfdocumentopenmode)<br>
Implements [IComparable](https://docs.microsoft.com/en-us/dotnet/api/system.icomparable), [IFormattable](https://docs.microsoft.com/en-us/dotnet/api/system.iformattable), [IConvertible](https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible)

## Fields

| Name | Value | Description |
| --- | --: | --- |
| Modify | 0 | The PDF stream is completely read into memory and can be modified. Pages can be deleted or inserted, but it is not possible to extract pages. This mode is useful for modifying an existing PDF document. |
| Import | 1 | The PDF stream is opened for importing pages from it. A document opened in this mode cannot be modified. |
| ReadOnly | 2 | The PDF stream is completely read into memory, but cannot be modified. This mode preserves the original internal structure of the document and is useful for analyzing existing PDF files. |
| InformationOnly | 3 | The PDF stream is partially read for information purposes only. The only valid operation is to call the Info property at the imported document. This option is very fast and needs less memory and is e.g. useful for browsing information about a collection of PDF documents in a user interface. |
