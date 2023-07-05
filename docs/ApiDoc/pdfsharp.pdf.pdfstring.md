# PdfString

Namespace: PdfSharp.Pdf

Represents a direct text string value.

```csharp
public sealed class PdfString : PdfItem, System.ICloneable
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [PdfItem](./pdfsharp.pdf.pdfitem) → [PdfString](./pdfsharp.pdf.pdfstring)<br>
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

Gets the encoding.

```csharp
public PdfStringEncoding Encoding { get; }
```

#### Property Value

[PdfStringEncoding](./pdfsharp.pdf.pdfstringencoding)<br>

### **HexLiteral**

Gets a value indicating whether the string is a hexadecimal literal.

```csharp
public bool HexLiteral { get; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **Value**

Gets the string value.

```csharp
public string Value { get; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

## Constructors

### **PdfString()**

Initializes a new instance of the [PdfString](./pdfsharp.pdf.pdfstring) class.

```csharp
public PdfString()
```

### **PdfString(String)**

Initializes a new instance of the [PdfString](./pdfsharp.pdf.pdfstring) class.

```csharp
public PdfString(string value)
```

#### Parameters

`value` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The value.

### **PdfString(String, PdfStringEncoding)**

Initializes a new instance of the [PdfString](./pdfsharp.pdf.pdfstring) class.

```csharp
public PdfString(string value, PdfStringEncoding encoding)
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

### **ToStringFromPdfDocEncoded()**

Hack for document encoded bookmarks.

```csharp
public string ToStringFromPdfDocEncoded()
```

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **WriteObject(PdfWriter)**

Writes the string DocEncoded.

```csharp
internal void WriteObject(PdfWriter writer)
```

#### Parameters

`writer` [PdfWriter](./pdfsharp.pdf.io.pdfwriter)<br>
