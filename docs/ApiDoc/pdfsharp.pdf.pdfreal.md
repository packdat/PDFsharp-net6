# PdfReal

Namespace: PdfSharp.Pdf

Represents a direct real value.

```csharp
public sealed class PdfReal : PdfNumber, System.ICloneable
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [PdfItem](./pdfsharp.pdf.pdfitem) → [PdfNumber](./pdfsharp.pdf.pdfnumber) → [PdfReal](./pdfsharp.pdf.pdfreal)<br>
Implements [ICloneable](https://docs.microsoft.com/en-us/dotnet/api/system.icloneable)

## Properties

### **Value**

Gets the value as double.

```csharp
public double Value { get; }
```

#### Property Value

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

## Constructors

### **PdfReal()**

Initializes a new instance of the [PdfReal](./pdfsharp.pdf.pdfreal) class.

```csharp
public PdfReal()
```

### **PdfReal(Double)**

Initializes a new instance of the [PdfReal](./pdfsharp.pdf.pdfreal) class.

```csharp
public PdfReal(double value)
```

#### Parameters

`value` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The value.

## Methods

### **ToString()**

Returns the real number as string.

```csharp
public string ToString()
```

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **WriteObject(PdfWriter)**

Writes the real value with up to three digits.

```csharp
internal void WriteObject(PdfWriter writer)
```

#### Parameters

`writer` [PdfWriter](./pdfsharp.pdf.io.pdfwriter)<br>
