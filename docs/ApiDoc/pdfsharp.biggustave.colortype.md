# ColorType

Namespace: PdfSharp.BigGustave

Describes the interpretation of the image data.

```csharp
public enum ColorType
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ValueType](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype) → [Enum](https://docs.microsoft.com/en-us/dotnet/api/system.enum) → [ColorType](./pdfsharp.biggustave.colortype)<br>
Implements [IComparable](https://docs.microsoft.com/en-us/dotnet/api/system.icomparable), [IFormattable](https://docs.microsoft.com/en-us/dotnet/api/system.iformattable), [IConvertible](https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible)

## Fields

| Name | Value | Description |
| --- | --: | --- |
| None | 0 | Grayscale. |
| PaletteUsed | 1 | Colors are stored in a palette rather than directly in the data. |
| ColorUsed | 2 | The image uses color. |
| AlphaChannelUsed | 4 | The image has an alpha channel. |
