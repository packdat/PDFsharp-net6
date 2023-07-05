# XSmoothingMode

Namespace: PdfSharp.Drawing

Specifies whether smoothing (or anti-aliasing) is applied to lines and curves
 and the edges of filled areas.

```csharp
public enum XSmoothingMode
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ValueType](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype) → [Enum](https://docs.microsoft.com/en-us/dotnet/api/system.enum) → [XSmoothingMode](./pdfsharp.drawing.xsmoothingmode)<br>
Implements [IComparable](https://docs.microsoft.com/en-us/dotnet/api/system.icomparable), [IFormattable](https://docs.microsoft.com/en-us/dotnet/api/system.iformattable), [IConvertible](https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible)

## Fields

| Name | Value | Description |
| --- | --: | --- |
| Invalid | -1 | Specifies an invalid mode. |
| Default | 0 | Specifies the default mode. |
| HighSpeed | 1 | Specifies high-speed, low-quality rendering. |
| HighQuality | 2 | Specifies high-quality, low-speed rendering. |
| None | 3 | Specifies no anti-aliasing. |
| AntiAlias | 4 | Specifies anti-aliased rendering. |
