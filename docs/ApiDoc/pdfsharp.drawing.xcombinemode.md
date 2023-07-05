# XCombineMode

Namespace: PdfSharp.Drawing

Specifies how different clipping regions can be combined.

```csharp
public enum XCombineMode
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ValueType](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype) → [Enum](https://docs.microsoft.com/en-us/dotnet/api/system.enum) → [XCombineMode](./pdfsharp.drawing.xcombinemode)<br>
Implements [IComparable](https://docs.microsoft.com/en-us/dotnet/api/system.icomparable), [IFormattable](https://docs.microsoft.com/en-us/dotnet/api/system.iformattable), [IConvertible](https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible)

## Fields

| Name | Value | Description |
| --- | --: | --- |
| Replace | 0 | One clipping region is replaced by another. |
| Intersect | 1 | Two clipping regions are combined by taking their intersection. |
| Union | 2 | Not yet implemented in PDFsharp. |
| Xor | 3 | Not yet implemented in PDFsharp. |
| Exclude | 4 | Not yet implemented in PDFsharp. |
| Complement | 5 | Not yet implemented in PDFsharp. |
