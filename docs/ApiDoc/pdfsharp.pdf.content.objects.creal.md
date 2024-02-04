# CReal

Namespace: PdfSharp.Pdf.Content.Objects

Represents a real value in a PDF content stream.

```csharp
public class CReal : CNumber, System.ICloneable
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [CObject](./pdfsharp.pdf.content.objects.cobject) → [CNumber](./pdfsharp.pdf.content.objects.cnumber) → [CReal](./pdfsharp.pdf.content.objects.creal)<br>
Implements [ICloneable](https://docs.microsoft.com/en-us/dotnet/api/system.icloneable)

## Properties

### **Value**

Gets or sets the value.

```csharp
public double Value { get; set; }
```

#### Property Value

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

## Constructors

### **CReal()**

```csharp
public CReal()
```

## Methods

### **Clone()**

Creates a new object that is a copy of the current instance.

```csharp
public CReal Clone()
```

#### Returns

[CReal](./pdfsharp.pdf.content.objects.creal)<br>

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