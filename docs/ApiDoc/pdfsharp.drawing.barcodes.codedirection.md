# CodeDirection

Namespace: PdfSharp.Drawing.BarCodes

Specifies the drawing direction of the code.

```csharp
public enum CodeDirection
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ValueType](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype) → [Enum](https://docs.microsoft.com/en-us/dotnet/api/system.enum) → [CodeDirection](./pdfsharp.drawing.barcodes.codedirection)<br>
Implements [IComparable](https://docs.microsoft.com/en-us/dotnet/api/system.icomparable), [IFormattable](https://docs.microsoft.com/en-us/dotnet/api/system.iformattable), [IConvertible](https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible)

## Fields

| Name | Value | Description |
| --- | --: | --- |
| LeftToRight | 0 | Does not rotate the code. |
| BottomToTop | 1 | Rotates the code 180° at the anchor position. |
| RightToLeft | 2 | Rotates the code 180° at the anchor position. |
| TopToBottom | 3 | Rotates the code 180° at the anchor position. |
