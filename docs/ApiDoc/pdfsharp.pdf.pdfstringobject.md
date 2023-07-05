# PdfStringObject

Namespace: PdfSharp.Pdf

Represents an indirect text string value. This type is not used by PDFsharp. If it is imported from
 an external PDF file, the value is converted into a direct object.

```csharp
public sealed class PdfStringObject : PdfObject, System.ICloneable
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [PdfItem](./pdfsharp.pdf.pdfitem) → [PdfObject](./pdfsharp.pdf.pdfobject) → [PdfStringObject](./pdfsharp.pdf.pdfstringobject)<br>
Implements [ICloneable](https://docs.microsoft.com/en-us/dotnet/api/system.icloneable)

## Properties

### **Length**

Gets the number of characters in this string.

```csharp
public int Length { get; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **Encoding**

Gets or sets the encoding.

```csharp
public PdfStringEncoding Encoding { get; set; }
```

#### Property Value

[PdfStringEncoding](./pdfsharp.pdf.pdfstringencoding)<br>

### **HexLiteral**

Gets a value indicating whether the string is a hexadecimal literal.

```csharp
public bool HexLiteral { get; set; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **Value**

Gets or sets the value as string

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

### **PdfStringObject()**

Initializes a new instance of the [PdfStringObject](./pdfsharp.pdf.pdfstringobject) class.

```csharp
public PdfStringObject()
```

### **PdfStringObject(PdfDocument, String)**

Initializes a new instance of the [PdfStringObject](./pdfsharp.pdf.pdfstringobject) class.

```csharp
public PdfStringObject(PdfDocument document, string value)
```

#### Parameters

`document` [PdfDocument](./pdfsharp.pdf.pdfdocument)<br>
The document.

`value` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The value.

### **PdfStringObject(String, PdfStringEncoding)**

Initializes a new instance of the [PdfStringObject](./pdfsharp.pdf.pdfstringobject) class.

```csharp
public PdfStringObject(string value, PdfStringEncoding encoding)
```

#### Parameters

`value` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The value.

`encoding` [PdfStringEncoding](./pdfsharp.pdf.pdfstringencoding)<br>
The encoding.

## Methods

### **ToString()**

Returns the string.

```csharp
public string ToString()
```

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **WriteObject(PdfWriter)**

Writes the string literal with encoding DOCEncoded.

```csharp
internal void WriteObject(PdfWriter writer)
```

#### Parameters

`writer` [PdfWriter](./pdfsharp.pdf.io.pdfwriter)<br>
