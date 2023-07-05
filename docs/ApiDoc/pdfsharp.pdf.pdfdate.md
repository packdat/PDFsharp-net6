# PdfDate

Namespace: PdfSharp.Pdf

Represents a direct date value.

```csharp
public sealed class PdfDate : PdfItem, System.ICloneable
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [PdfItem](./pdfsharp.pdf.pdfitem) → [PdfDate](./pdfsharp.pdf.pdfdate)<br>
Implements [ICloneable](https://docs.microsoft.com/en-us/dotnet/api/system.icloneable)

## Properties

### **Value**

Gets the value as DateTime.

```csharp
public DateTime Value { get; }
```

#### Property Value

[DateTime](https://docs.microsoft.com/en-us/dotnet/api/system.datetime)<br>

## Constructors

### **PdfDate()**

Initializes a new instance of the [PdfDate](./pdfsharp.pdf.pdfdate) class.

```csharp
public PdfDate()
```

### **PdfDate(String)**

Initializes a new instance of the [PdfDate](./pdfsharp.pdf.pdfdate) class.

```csharp
public PdfDate(string value)
```

#### Parameters

`value` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **PdfDate(DateTime)**

Initializes a new instance of the [PdfDate](./pdfsharp.pdf.pdfdate) class.

```csharp
public PdfDate(DateTime value)
```

#### Parameters

`value` [DateTime](https://docs.microsoft.com/en-us/dotnet/api/system.datetime)<br>

## Methods

### **ToString()**

Returns the value in the PDF date format.

```csharp
public string ToString()
```

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **WriteObject(PdfWriter)**

Writes the value in the PDF date format.

```csharp
internal void WriteObject(PdfWriter writer)
```

#### Parameters

`writer` [PdfWriter](./pdfsharp.pdf.io.pdfwriter)<br>
