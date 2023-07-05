# CNumber

Namespace: PdfSharp.Pdf.Content.Objects

Represents the base class for numerical objects in a PDF content stream.

```csharp
public abstract class CNumber : CObject, System.ICloneable
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [CObject](./pdfsharp.pdf.content.objects.cobject) → [CNumber](./pdfsharp.pdf.content.objects.cnumber)<br>
Implements [ICloneable](https://docs.microsoft.com/en-us/dotnet/api/system.icloneable)

## Methods

### **Clone()**

Creates a new object that is a copy of the current instance.

```csharp
public CNumber Clone()
```

#### Returns

[CNumber](./pdfsharp.pdf.content.objects.cnumber)<br>

### **Copy()**

Implements the copy mechanism of this class.

```csharp
protected CObject Copy()
```

#### Returns

[CObject](./pdfsharp.pdf.content.objects.cobject)<br>
