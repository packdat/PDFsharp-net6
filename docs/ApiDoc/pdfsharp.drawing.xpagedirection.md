# XPageDirection

Namespace: PdfSharp.Drawing

Specifies the direction of the y-axis.

```csharp
public enum XPageDirection
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ValueType](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype) → [Enum](https://docs.microsoft.com/en-us/dotnet/api/system.enum) → [XPageDirection](./pdfsharp.drawing.xpagedirection)<br>
Implements [IComparable](https://docs.microsoft.com/en-us/dotnet/api/system.icomparable), [IFormattable](https://docs.microsoft.com/en-us/dotnet/api/system.iformattable), [IConvertible](https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible)

## Fields

| Name | Value | Description |
| --- | --: | --- |
| Downwards | 0 | Increasing Y values go downwards. This is the default. |
| Upwards | 1 | Increasing Y values go upwards. This is only possible when drawing on a PDF page. It is not implemented when drawing on a System.Drawing.Graphics object. |
