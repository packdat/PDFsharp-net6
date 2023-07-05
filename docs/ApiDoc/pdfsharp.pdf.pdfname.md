# PdfName

Namespace: PdfSharp.Pdf

Represents a PDF name value.

```csharp
public sealed class PdfName : PdfItem, System.ICloneable
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [PdfItem](./pdfsharp.pdf.pdfitem) → [PdfName](./pdfsharp.pdf.pdfname)<br>
Implements [ICloneable](https://docs.microsoft.com/en-us/dotnet/api/system.icloneable)

## Fields

### **Empty**

Represents the empty name.

```csharp
public static PdfName Empty;
```

## Properties

### **Value**

Gets the name as a string.

```csharp
public string Value { get; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Comparer**

Gets the comparer for this type.

```csharp
public static PdfXNameComparer Comparer { get; }
```

#### Property Value

[PdfXNameComparer](./pdfsharp.pdf.pdfname.pdfxnamecomparer)<br>

## Constructors

### **PdfName()**

Initializes a new instance of the [PdfName](./pdfsharp.pdf.pdfname) class.

```csharp
public PdfName()
```

### **PdfName(String)**

Initializes a new instance of the [PdfName](./pdfsharp.pdf.pdfname) class.
 Parameter value always must start with a '/'.

```csharp
public PdfName(string value)
```

#### Parameters

`value` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

## Methods

### **Equals(Object)**

Determines whether the specified object is equal to this name.

```csharp
public bool Equals(object obj)
```

#### Parameters

`obj` [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **GetHashCode()**

Returns the hash code for this instance.

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

### **AddSlash(String)**

Adds the slash to a string, that is needed at the beginning of a PDFName string.

```csharp
public static string AddSlash(string value)
```

#### Parameters

`value` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **RemoveSlash(String)**

Removes the slash from a string, that is needed at the beginning of a PDFName string.

```csharp
public static string RemoveSlash(string value)
```

#### Parameters

`value` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **WriteObject(PdfWriter)**

Writes the name including the leading slash.

```csharp
internal void WriteObject(PdfWriter writer)
```

#### Parameters

`writer` [PdfWriter](./pdfsharp.pdf.io.pdfwriter)<br>
