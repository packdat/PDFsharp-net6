# XLineJoin

Namespace: PdfSharp.Drawing

Specifies how to join consecutive line or curve segments in a figure or subpath.

```csharp
public enum XLineJoin
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ValueType](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype) → [Enum](https://docs.microsoft.com/en-us/dotnet/api/system.enum) → [XLineJoin](./pdfsharp.drawing.xlinejoin)<br>
Implements [IComparable](https://docs.microsoft.com/en-us/dotnet/api/system.icomparable), [IFormattable](https://docs.microsoft.com/en-us/dotnet/api/system.iformattable), [IConvertible](https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible)

## Fields

| Name | Value | Description |
| --- | --: | --- |
| Miter | 0 | Specifies a mitered join. This produces a sharp corner or a clipped corner, depending on whether the length of the miter exceeds the miter limit. |
| Round | 1 | Specifies a circular join. This produces a smooth, circular arc between the lines. |
| Bevel | 2 | Specifies a beveled join. This produces a diagonal corner. |
