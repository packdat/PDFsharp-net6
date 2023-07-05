# CInteger

Namespace: PdfSharp.Pdf.Content.Objects

Represents an integer value in a PDF content stream.

```csharp
public class CInteger : CNumber, System.ICloneable
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [CObject](./pdfsharp.pdf.content.objects.cobject) → [CNumber](./pdfsharp.pdf.content.objects.cnumber) → [CInteger](./pdfsharp.pdf.content.objects.cinteger)<br>
Implements [ICloneable](https://docs.microsoft.com/en-us/dotnet/api/system.icloneable)

## Properties

### **Value**

Gets or sets the value.

```csharp
public int Value { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

## Constructors

### **CInteger()**

```csharp
public CInteger()
```

## Methods

### **Clone()**

Creates a new object that is a copy of the current instance.

```csharp
public CInteger Clone()
```

#### Returns

[CInteger](./pdfsharp.pdf.content.objects.cinteger)<br>

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
