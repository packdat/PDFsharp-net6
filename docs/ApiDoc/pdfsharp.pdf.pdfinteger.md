# PdfInteger

Namespace: PdfSharp.Pdf

Represents a direct integer value.

```csharp
public sealed class PdfInteger : PdfNumber, System.ICloneable, System.IConvertible
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [PdfItem](./pdfsharp.pdf.pdfitem) → [PdfNumber](./pdfsharp.pdf.pdfnumber) → [PdfInteger](./pdfsharp.pdf.pdfinteger)<br>
Implements [ICloneable](https://docs.microsoft.com/en-us/dotnet/api/system.icloneable), [IConvertible](https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible)

## Properties

### **Value**

Gets the value as integer.

```csharp
public int Value { get; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

## Constructors

### **PdfInteger()**

Initializes a new instance of the [PdfInteger](./pdfsharp.pdf.pdfinteger) class.

```csharp
public PdfInteger()
```

### **PdfInteger(Int32)**

Initializes a new instance of the [PdfInteger](./pdfsharp.pdf.pdfinteger) class.

```csharp
public PdfInteger(int value)
```

#### Parameters

`value` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The value.

## Methods

### **ToString()**

Returns the integer as string.

```csharp
public string ToString()
```

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **WriteObject(PdfWriter)**

Writes the integer as string.

```csharp
internal void WriteObject(PdfWriter writer)
```

#### Parameters

`writer` [PdfWriter](./pdfsharp.pdf.io.pdfwriter)<br>

### **GetTypeCode()**

Returns TypeCode for 32-bit integers.

```csharp
public TypeCode GetTypeCode()
```

#### Returns

[TypeCode](https://docs.microsoft.com/en-us/dotnet/api/system.typecode)<br>
