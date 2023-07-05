# XGraphicsPdfPageOptions

Namespace: PdfSharp.Drawing

Specifies how the content of an existing PDF page and new content is combined.

```csharp
public enum XGraphicsPdfPageOptions
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ValueType](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype) → [Enum](https://docs.microsoft.com/en-us/dotnet/api/system.enum) → [XGraphicsPdfPageOptions](./pdfsharp.drawing.xgraphicspdfpageoptions)<br>
Implements [IComparable](https://docs.microsoft.com/en-us/dotnet/api/system.icomparable), [IFormattable](https://docs.microsoft.com/en-us/dotnet/api/system.iformattable), [IConvertible](https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible)

## Fields

| Name | Value | Description |
| --- | --: | --- |
| Append | 0 | The new content is inserted behind the old content, and any subsequent drawing is done above the existing graphic. |
| Prepend | 1 | The new content is inserted before the old content, and any subsequent drawing is done beneath the existing graphic. |
| Replace | 2 | The new content entirely replaces the old content, and any subsequent drawing is done on a blank page. |
