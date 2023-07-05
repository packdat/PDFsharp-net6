# COperator

Namespace: PdfSharp.Pdf.Content.Objects

Represents an operator a PDF content stream.

```csharp
public class COperator : CObject, System.ICloneable
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [CObject](./pdfsharp.pdf.content.objects.cobject) → [COperator](./pdfsharp.pdf.content.objects.coperator)<br>
Implements [ICloneable](https://docs.microsoft.com/en-us/dotnet/api/system.icloneable)

## Properties

### **Name**

Gets or sets the name of the operator

```csharp
public string Name { get; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The name.

### **Operands**

Gets or sets the operands.

```csharp
public CSequence Operands { get; }
```

#### Property Value

[CSequence](./pdfsharp.pdf.content.objects.csequence)<br>
The operands.

### **OpCode**

Gets the operator description for this instance.

```csharp
public OpCode OpCode { get; }
```

#### Property Value

[OpCode](./pdfsharp.pdf.content.objects.opcode)<br>

## Methods

### **Clone()**

Creates a new object that is a copy of the current instance.

```csharp
public COperator Clone()
```

#### Returns

[COperator](./pdfsharp.pdf.content.objects.coperator)<br>

### **Copy()**

Implements the copy mechanism of this class.

```csharp
protected CObject Copy()
```

#### Returns

[CObject](./pdfsharp.pdf.content.objects.cobject)<br>

### **ToString()**

Returns a string that represents the current operator.

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
