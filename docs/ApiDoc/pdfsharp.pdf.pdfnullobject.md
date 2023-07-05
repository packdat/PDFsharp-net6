# PdfNullObject

Namespace: PdfSharp.Pdf

Represents an indirect null value. This type is not used by PDFsharp, but at least
 one tool from Adobe creates PDF files with a null object.

```csharp
public sealed class PdfNullObject : PdfObject, System.ICloneable
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [PdfItem](./pdfsharp.pdf.pdfitem) → [PdfObject](./pdfsharp.pdf.pdfobject) → [PdfNullObject](./pdfsharp.pdf.pdfnullobject)<br>
Implements [ICloneable](https://docs.microsoft.com/en-us/dotnet/api/system.icloneable)

## Properties

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

### **PdfNullObject()**

Initializes a new instance of the [PdfNullObject](./pdfsharp.pdf.pdfnullobject) class.

```csharp
public PdfNullObject()
```

### **PdfNullObject(PdfDocument)**

Initializes a new instance of the [PdfNullObject](./pdfsharp.pdf.pdfnullobject) class.

```csharp
public PdfNullObject(PdfDocument document)
```

#### Parameters

`document` [PdfDocument](./pdfsharp.pdf.pdfdocument)<br>
The document.

## Methods

### **ToString()**

Returns the string "null".

```csharp
public string ToString()
```

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **WriteObject(PdfWriter)**

Writes the keyword «null».

```csharp
internal void WriteObject(PdfWriter writer)
```

#### Parameters

`writer` [PdfWriter](./pdfsharp.pdf.io.pdfwriter)<br>
