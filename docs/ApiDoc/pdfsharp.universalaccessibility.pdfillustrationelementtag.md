# PdfIllustrationElementTag

Namespace: PdfSharp.UniversalAccessibility

PDF Illustration Element tags for Universal Accessibility.

```csharp
public enum PdfIllustrationElementTag
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ValueType](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype) → [Enum](https://docs.microsoft.com/en-us/dotnet/api/system.enum) → [PdfIllustrationElementTag](./pdfsharp.universalaccessibility.pdfillustrationelementtag)<br>
Implements [IComparable](https://docs.microsoft.com/en-us/dotnet/api/system.icomparable), [IFormattable](https://docs.microsoft.com/en-us/dotnet/api/system.iformattable), [IConvertible](https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible)

## Fields

| Name | Value | Description |
| --- | --: | --- |
| Figure | 0 | (Figure) An item of graphical content. Its placement may be specified with the Placementlayout attribute. |
| Formula | 1 | (Formula) A mathematical formula. |
| Form | 2 | (Form) A widget annotation representing an interactive form field. If the element contains a Role attribute, it may contain content items that represent the value of the (non-interactive) form field. If the element omits a Role attribute, its only child is an object reference identifying the widget annotation.  The annotations’ appearance stream defines the rendering of the form element. |
