# CString

Namespace: PdfSharp.Pdf.Content.Objects

Represents a string value in a PDF content stream.

```csharp
public class CString : CObject, System.ICloneable
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [CObject](./pdfsharp.pdf.content.objects.cobject) → [CString](./pdfsharp.pdf.content.objects.cstring)<br>
Implements [ICloneable](https://docs.microsoft.com/en-us/dotnet/api/system.icloneable)

## Properties

### **Value**

Gets or sets the value.

```csharp
public string Value { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **CStringType**

Gets or sets the type of the content string.

```csharp
public CStringType CStringType { get; set; }
```

#### Property Value

[CStringType](./pdfsharp.pdf.content.objects.cstringtype)<br>

## Constructors

### **CString()**

```csharp
public CString()
```

## Methods

### **Clone()**

Creates a new object that is a copy of the current instance.

```csharp
public CString Clone()
```

#### Returns

[CString](./pdfsharp.pdf.content.objects.cstring)<br>

### **Copy()**

Implements the copy mechanism of this class.

```csharp
protected CObject Copy()
```

#### Returns

[CObject](./pdfsharp.pdf.content.objects.cobject)<br>

### **ToString()**

Returns a string that represents the current value.

```csharp
public string ToString()
```

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **WriteObject(ContentWriter)**

```csharp
internal void WriteObject(ContentWriter writer)
```

#### Parameters

`writer` [ContentWriter](./pdfsharp.pdf.content.contentwriter)<br>
