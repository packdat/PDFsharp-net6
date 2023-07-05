# PdfItem

Namespace: PdfSharp.Pdf

The base class of all PDF objects and simple PDF types.

```csharp
public abstract class PdfItem : System.ICloneable
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [PdfItem](./pdfsharp.pdf.pdfitem)<br>
Implements [ICloneable](https://docs.microsoft.com/en-us/dotnet/api/system.icloneable)

## Methods

### **Clone()**

Creates a copy of this object.

```csharp
public PdfItem Clone()
```

#### Returns

[PdfItem](./pdfsharp.pdf.pdfitem)<br>

### **Copy()**

Implements the copy mechanism. Must be overridden in derived classes.

```csharp
protected object Copy()
```

#### Returns

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)<br>

### **WriteObject(PdfWriter)**

When overridden in a derived class, appends a raw string representation of this object
 to the specified PdfWriter.

```csharp
internal abstract void WriteObject(PdfWriter writer)
```

#### Parameters

`writer` [PdfWriter](./pdfsharp.pdf.io.pdfwriter)<br>
