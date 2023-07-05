# PdfNameObject

Namespace: PdfSharp.Pdf

Represents an indirect name value. This type is not used by PDFsharp. If it is imported from
 an external PDF file, the value is converted into a direct object. Acrobat sometime uses indirect
 names to save space, because an indirect reference to a name may be shorter than a long name.

```csharp
public sealed class PdfNameObject : PdfObject, System.ICloneable
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [PdfItem](./pdfsharp.pdf.pdfitem) → [PdfObject](./pdfsharp.pdf.pdfobject) → [PdfNameObject](./pdfsharp.pdf.pdfnameobject)<br>
Implements [ICloneable](https://docs.microsoft.com/en-us/dotnet/api/system.icloneable)

## Properties

### **Value**

Gets or sets the name value.

```csharp
public string Value { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

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

### **PdfNameObject()**

Initializes a new instance of the [PdfNameObject](./pdfsharp.pdf.pdfnameobject) class.

```csharp
public PdfNameObject()
```

### **PdfNameObject(PdfDocument, String)**

Initializes a new instance of the [PdfNameObject](./pdfsharp.pdf.pdfnameobject) class.

```csharp
public PdfNameObject(PdfDocument document, string value)
```

#### Parameters

`document` [PdfDocument](./pdfsharp.pdf.pdfdocument)<br>
The document.

`value` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The value.

## Methods

### **Equals(Object)**

Determines whether the specified object is equal to the current object.

```csharp
public bool Equals(object obj)
```

#### Parameters

`obj` [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **GetHashCode()**

Serves as a hash function for this type.

```csharp
public int GetHashCode()
```

#### Returns

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **ToString()**

Returns the name. The string always begins with a slash.

```csharp
public string ToString()
```

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **WriteObject(PdfWriter)**

Writes the name including the leading slash.

```csharp
internal void WriteObject(PdfWriter writer)
```

#### Parameters

`writer` [PdfWriter](./pdfsharp.pdf.io.pdfwriter)<br>
