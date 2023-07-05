# OpCodeName

Namespace: PdfSharp.Pdf.Content.Objects

The names of the op-codes.

```csharp
public enum OpCodeName
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ValueType](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype) → [Enum](https://docs.microsoft.com/en-us/dotnet/api/system.enum) → [OpCodeName](./pdfsharp.pdf.content.objects.opcodename)<br>
Implements [IComparable](https://docs.microsoft.com/en-us/dotnet/api/system.icomparable), [IFormattable](https://docs.microsoft.com/en-us/dotnet/api/system.iformattable), [IConvertible](https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible)

## Fields

| Name | Value | Description |
| --- | --: | --- |
| b | 1 | Close, fill, and stroke path using nonzero winding number rule. |
| B | 2 | Fill and stroke path using nonzero winding number rule. |
| bx | 3 | Close, fill, and stroke path using even-odd rule. |
| Bx | 4 | Fill and stroke path using even-odd rule. |
| BDC | 5 | (PDF 1.2) Begin marked-content sequence with property list. |
| BI | 6 | Begin inline image object. |
| BMC | 7 | (PDF 1.2) Begin marked-content sequence. |
| BT | 8 | Begin text object. |
| BX | 9 | (PDF 1.1) Begin compatibility section. |
| DP | 18 | (PDF 1.2) Define marked-content point with property list. |
| EMC | 20 | (PDF 1.2) End marked-content sequence. |
| EX | 22 | (PDF 1.1) End compatibility section. |
| MP | 39 | (PDF 1.2) Define marked-content point |
| QuoteSingle | 72 | Move to next line and show text. |
| QuoteDbl | 73 | Set word and character spacing, move to next line, and show text. |
