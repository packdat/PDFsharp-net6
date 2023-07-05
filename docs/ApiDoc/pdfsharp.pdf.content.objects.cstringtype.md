# CStringType

Namespace: PdfSharp.Pdf.Content.Objects

Type of the parsed string.

```csharp
public enum CStringType
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ValueType](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype) → [Enum](https://docs.microsoft.com/en-us/dotnet/api/system.enum) → [CStringType](./pdfsharp.pdf.content.objects.cstringtype)<br>
Implements [IComparable](https://docs.microsoft.com/en-us/dotnet/api/system.icomparable), [IFormattable](https://docs.microsoft.com/en-us/dotnet/api/system.iformattable), [IConvertible](https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible)

## Fields

| Name | Value | Description |
| --- | --: | --- |
| String | 0 | The string has the format "(...)". |
| HexString | 1 | The string has the format "&lt;...&gt;". |
| UnicodeString | 2 | The string... TODO. |
| UnicodeHexString | 3 | The string... TODO. |
| Dictionary | 4 | HACK: The string is the content of a dictionary. Currently there is no parser for dictionaries in Content Streams. |
