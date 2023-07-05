# PdfBooleanObject

Namespace: PdfSharp.Pdf

Represents an indirect boolean value. This type is not used by PDFsharp. If it is imported from
 an external PDF file, the value is converted into a direct object.

```csharp
public sealed class PdfBooleanObject : PdfObject, System.ICloneable
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [PdfItem](./pdfsharp.pdf.pdfitem) → [PdfObject](./pdfsharp.pdf.pdfobject) → [PdfBooleanObject](./pdfsharp.pdf.pdfbooleanobject)<br>
Implements [ICloneable](https://docs.microsoft.com/en-us/dotnet/api/system.icloneable)

## Properties

### **Value**

Gets the value of this instance as boolean value.

```csharp
public bool Value { get; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

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

### **PdfBooleanObject()**

Initializes a new instance of the [PdfBooleanObject](./pdfsharp.pdf.pdfbooleanobject) class.

```csharp
public PdfBooleanObject()
```

### **PdfBooleanObject(Boolean)**

Initializes a new instance of the [PdfBooleanObject](./pdfsharp.pdf.pdfbooleanobject) class.

```csharp
public PdfBooleanObject(bool value)
```

#### Parameters

`value` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **PdfBooleanObject(PdfDocument, Boolean)**

Initializes a new instance of the [PdfBooleanObject](./pdfsharp.pdf.pdfbooleanobject) class.

```csharp
public PdfBooleanObject(PdfDocument document, bool value)
```

#### Parameters

`document` [PdfDocument](./pdfsharp.pdf.pdfdocument)<br>

`value` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

## Methods

### **ToString()**

Returns "false" or "true".

```csharp
public string ToString()
```

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **WriteObject(PdfWriter)**

Writes the keyword «false» or «true».

```csharp
internal void WriteObject(PdfWriter writer)
```

#### Parameters

`writer` [PdfWriter](./pdfsharp.pdf.io.pdfwriter)<br>
