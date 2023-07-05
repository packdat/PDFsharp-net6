# CObject

Namespace: PdfSharp.Pdf.Content.Objects

Base class for all PDF content stream objects.

```csharp
public abstract class CObject : System.ICloneable
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [CObject](./pdfsharp.pdf.content.objects.cobject)<br>
Implements [ICloneable](https://docs.microsoft.com/en-us/dotnet/api/system.icloneable)

## Methods

### **Clone()**

Creates a new object that is a copy of the current instance.

```csharp
public CObject Clone()
```

#### Returns

[CObject](./pdfsharp.pdf.content.objects.cobject)<br>

### **Copy()**

Implements the copy mechanism. Must be overridden in derived classes.

```csharp
protected CObject Copy()
```

#### Returns

[CObject](./pdfsharp.pdf.content.objects.cobject)<br>

### **WriteObject(ContentWriter)**



```csharp
internal abstract void WriteObject(ContentWriter writer)
```

#### Parameters

`writer` [ContentWriter](./pdfsharp.pdf.content.contentwriter)<br>
