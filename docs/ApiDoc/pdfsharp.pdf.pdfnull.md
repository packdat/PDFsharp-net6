# PdfNull

Namespace: PdfSharp.Pdf

Represents a indirect reference that is not in the cross reference table.

```csharp
public sealed class PdfNull : PdfItem, System.ICloneable
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [PdfItem](./pdfsharp.pdf.pdfitem) → [PdfNull](./pdfsharp.pdf.pdfnull)<br>
Implements [ICloneable](https://docs.microsoft.com/en-us/dotnet/api/system.icloneable)

## Fields

### **Value**

The only instance of this class.

```csharp
public static PdfNull Value;
```

## Methods

### **ToString()**

Returns a [String](https://docs.microsoft.com/en-us/dotnet/api/system.string) that represents the current [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object).

```csharp
public string ToString()
```

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
A [String](https://docs.microsoft.com/en-us/dotnet/api/system.string) that represents the current [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object).

### **WriteObject(PdfWriter)**

```csharp
internal void WriteObject(PdfWriter writer)
```

#### Parameters

`writer` [PdfWriter](./pdfsharp.pdf.io.pdfwriter)<br>
