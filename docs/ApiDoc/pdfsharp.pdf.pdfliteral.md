# PdfLiteral

Namespace: PdfSharp.Pdf

Represents text that is written 'as it is' into the PDF stream. This class can lead to invalid PDF files.
 E.g. strings in a literal are not encrypted when the document is saved with a password.

```csharp
public sealed class PdfLiteral : PdfItem, System.ICloneable
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [PdfItem](./pdfsharp.pdf.pdfitem) → [PdfLiteral](./pdfsharp.pdf.pdfliteral)<br>
Implements [ICloneable](https://docs.microsoft.com/en-us/dotnet/api/system.icloneable)

## Properties

### **Value**

Gets the value as literal string.

```csharp
public string Value { get; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

## Constructors

### **PdfLiteral()**

Initializes a new instance of the [PdfLiteral](./pdfsharp.pdf.pdfliteral) class.

```csharp
public PdfLiteral()
```

### **PdfLiteral(String)**

Initializes a new instance with the specified string.

```csharp
public PdfLiteral(string value)
```

#### Parameters

`value` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **PdfLiteral(String, Object[])**

Initializes a new instance with the culture invariant formatted specified arguments.

```csharp
public PdfLiteral(string format, Object[] args)
```

#### Parameters

`format` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`args` [Object[]](https://docs.microsoft.com/en-us/dotnet/api/system.object)<br>

## Methods

### **FromMatrix(XMatrix)**

Creates a literal from an XMatrix

```csharp
public static PdfLiteral FromMatrix(XMatrix matrix)
```

#### Parameters

`matrix` [XMatrix](./pdfsharp.drawing.xmatrix)<br>

#### Returns

[PdfLiteral](./pdfsharp.pdf.pdfliteral)<br>

### **ToString()**

Returns a string that represents the current value.

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
