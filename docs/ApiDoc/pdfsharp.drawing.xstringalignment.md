# XStringAlignment

Namespace: PdfSharp.Drawing

Specifies the alignment of a text string relative to its layout rectangle.

```csharp
public enum XStringAlignment
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ValueType](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype) → [Enum](https://docs.microsoft.com/en-us/dotnet/api/system.enum) → [XStringAlignment](./pdfsharp.drawing.xstringalignment)<br>
Implements [IComparable](https://docs.microsoft.com/en-us/dotnet/api/system.icomparable), [IFormattable](https://docs.microsoft.com/en-us/dotnet/api/system.iformattable), [IConvertible](https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible)

## Fields

| Name | Value | Description |
| --- | --: | --- |
| Near | 0 | Specifies the text be aligned near the layout. In a left-to-right layout, the near position is left. In a right-to-left layout, the near position is right. |
| Center | 1 | Specifies that text is aligned in the center of the layout rectangle. |
| Far | 2 | Specifies that text is aligned far from the origin position of the layout rectangle. In a left-to-right layout, the far position is right. In a right-to-left layout, the far position is left. |
