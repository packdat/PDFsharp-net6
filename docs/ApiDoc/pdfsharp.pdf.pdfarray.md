# PdfArray

Namespace: PdfSharp.Pdf

Represents a PDF array object.

```csharp
public class PdfArray : PdfObject, System.ICloneable, System.Collections.Generic.IEnumerable`1[[PdfSharp.Pdf.PdfItem, PdfSharp, Version=0.1.3.0, Culture=neutral, PublicKeyToken=null]], System.Collections.IEnumerable
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [PdfItem](./pdfsharp.pdf.pdfitem) → [PdfObject](./pdfsharp.pdf.pdfobject) → [PdfArray](./pdfsharp.pdf.pdfarray)<br>
Implements [ICloneable](https://docs.microsoft.com/en-us/dotnet/api/system.icloneable), [IEnumerable&lt;PdfItem&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1), [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.ienumerable)

## Properties

### **Elements**

Gets the collection containing the elements of this object.

```csharp
public ArrayElements Elements { get; }
```

#### Property Value

[ArrayElements](./pdfsharp.pdf.pdfarray.arrayelements)<br>

### **Owner**

Gets the PdfDocument this object belongs to.

```csharp
public PdfDocument Owner { get; }
```

#### Property Value

[PdfDocument](./pdfsharp.pdf.pdfdocument)<br>

### **IsIndirect**

Indicates whether the object is an indirect object.

```csharp
public bool IsIndirect { get; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **Internals**

Gets the PdfInternals object of this document, that grants access to some internal structures
 which are not part of the public interface of PdfDocument.

```csharp
public PdfObjectInternals Internals { get; }
```

#### Property Value

[PdfObjectInternals](./pdfsharp.pdf.advanced.pdfobjectinternals)<br>

### **Reference**

Gets the indirect reference of this object. If the value is null, this object is a direct object.

```csharp
public PdfReference Reference { get; internal set; }
```

#### Property Value

[PdfReference](./pdfsharp.pdf.advanced.pdfreference)<br>

### **ReferenceNotNull**

Gets the indirect reference of this object. Throws if it is null.

```csharp
public PdfReference ReferenceNotNull { get; }
```

#### Property Value

[PdfReference](./pdfsharp.pdf.advanced.pdfreference)<br>

#### Exceptions

[InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/system.invalidoperationexception)<br>
The indirect reference must be not null here.

## Constructors

### **PdfArray()**

Initializes a new instance of the [PdfArray](./pdfsharp.pdf.pdfarray) class.

```csharp
public PdfArray()
```

### **PdfArray(PdfDocument)**

Initializes a new instance of the [PdfArray](./pdfsharp.pdf.pdfarray) class.

```csharp
public PdfArray(PdfDocument document)
```

#### Parameters

`document` [PdfDocument](./pdfsharp.pdf.pdfdocument)<br>
The document.

### **PdfArray(PdfDocument, PdfItem[])**

Initializes a new instance of the [PdfArray](./pdfsharp.pdf.pdfarray) class.

```csharp
public PdfArray(PdfDocument document, PdfItem[] items)
```

#### Parameters

`document` [PdfDocument](./pdfsharp.pdf.pdfdocument)<br>
The document.

`items` [PdfItem[]](./pdfsharp.pdf.pdfitem)<br>
The items.

## Methods

### **Clone()**

Creates a copy of this array. Direct elements are deep copied.
 Indirect references are not modified.

```csharp
public PdfArray Clone()
```

#### Returns

[PdfArray](./pdfsharp.pdf.pdfarray)<br>

### **Copy()**

Implements the copy mechanism.

```csharp
protected object Copy()
```

#### Returns

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)<br>

### **GetEnumerator()**

Returns an enumerator that iterates through a collection.

```csharp
public IEnumerator<PdfItem> GetEnumerator()
```

#### Returns

[IEnumerator&lt;PdfItem&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerator-1)<br>

### **ToString()**

Returns a string with the content of this object in a readable form. Useful for debugging purposes only.

```csharp
public string ToString()
```

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **WriteObject(PdfWriter)**

```csharp
internal void WriteObject(PdfWriter writer)
```

#### Parameters

`writer` [PdfWriter](./pdfsharp.pdf.io.pdfwriter)<br>
