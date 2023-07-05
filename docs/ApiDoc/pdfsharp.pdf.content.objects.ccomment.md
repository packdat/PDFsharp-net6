# CComment

Namespace: PdfSharp.Pdf.Content.Objects

Represents a comment in a PDF content stream.

```csharp
public class CComment : CObject, System.ICloneable
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [CObject](./pdfsharp.pdf.content.objects.cobject) → [CComment](./pdfsharp.pdf.content.objects.ccomment)<br>
Implements [ICloneable](https://docs.microsoft.com/en-us/dotnet/api/system.icloneable)

## Properties

### **Text**

Gets or sets the comment text.

```csharp
public string Text { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

## Constructors

### **CComment()**

```csharp
public CComment()
```

## Methods

### **Clone()**

Creates a new object that is a copy of the current instance.

```csharp
public CComment Clone()
```

#### Returns

[CComment](./pdfsharp.pdf.content.objects.ccomment)<br>

### **Copy()**

Implements the copy mechanism of this class.

```csharp
protected CObject Copy()
```

#### Returns

[CObject](./pdfsharp.pdf.content.objects.cobject)<br>

### **ToString()**

Returns a string that represents the current comment.

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
