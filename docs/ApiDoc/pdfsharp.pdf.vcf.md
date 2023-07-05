# VCF

Namespace: PdfSharp.Pdf

Value creation flags. Specifies whether and how a value that does not exist is created.

```csharp
public enum VCF
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ValueType](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype) → [Enum](https://docs.microsoft.com/en-us/dotnet/api/system.enum) → [VCF](./pdfsharp.pdf.vcf)<br>
Implements [IComparable](https://docs.microsoft.com/en-us/dotnet/api/system.icomparable), [IFormattable](https://docs.microsoft.com/en-us/dotnet/api/system.iformattable), [IConvertible](https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible)

## Fields

| Name | Value | Description |
| --- | --: | --- |
| None | 0 | Don't create the value. |
| Create | 1 | Create the value as direct object. |
| CreateIndirect | 2 | Create the value as indirect object. |
