# PdfAnnotationBorderStyle

Namespace: PdfSharp.Pdf.Annotations.enums

Specifies the border-style for a [PdfAnnotation](./pdfsharp.pdf.annotations.pdfannotation)

```csharp
public enum PdfAnnotationBorderStyle
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ValueType](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype) → [Enum](https://docs.microsoft.com/en-us/dotnet/api/system.enum) → [PdfAnnotationBorderStyle](./pdfsharp.pdf.annotations.enums.pdfannotationborderstyle)<br>
Implements [IComparable](https://docs.microsoft.com/en-us/dotnet/api/system.icomparable), [IFormattable](https://docs.microsoft.com/en-us/dotnet/api/system.iformattable), [IConvertible](https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible)

## Fields

| Name | Value | Description |
| --- | --: | --- |
| None | 0 | No border |
| Solid | 1 | A solid rectangle surrounding the annotation. |
| Dashed | 2 | A dashed rectangle surrounding the annotation. The dash pattern may be specified by the D entry of the border-style dictionary. |
| Beveled | 3 | A simulated embossed rectangle that appears to be raised above the surface of the page. |
| Inset | 4 | A simulated engraved rectangle that appears to be recessed below the surface of the page. |
| Underline | 5 | A single line along the bottom of the annotation rectangle. |
