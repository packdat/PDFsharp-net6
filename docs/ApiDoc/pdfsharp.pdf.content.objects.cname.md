# CName

Namespace: PdfSharp.Pdf.Content.Objects

Represents a name in a PDF content stream.

```csharp
public class CName : CObject, System.ICloneable
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [CObject](./pdfsharp.pdf.content.objects.cobject) → [CName](./pdfsharp.pdf.content.objects.cname)<br>
Implements [ICloneable](https://docs.microsoft.com/en-us/dotnet/api/system.icloneable)

## Properties

### **Name**

Gets or sets the name. Names must start with a slash.

```csharp
public string Name { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

## Constructors

### **CName()**

Initializes a new instance of the [CName](./pdfsharp.pdf.content.objects.cname) class.

```csharp
public CName()
```

### **CName(String)**

Initializes a new instance of the [CName](./pdfsharp.pdf.content.objects.cname) class.

```csharp
public CName(string name)
```

#### Parameters

`name` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The name.

## Methods

### **Clone()**

Creates a new object that is a copy of the current instance.

```csharp
public CName Clone()
```

#### Returns

[CName](./pdfsharp.pdf.content.objects.cname)<br>

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
