# PdfBoolean

Namespace: PdfSharp.Pdf

Represents a direct boolean value.

```csharp
public sealed class PdfBoolean : PdfItem, System.ICloneable
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [PdfItem](./pdfsharp.pdf.pdfitem) → [PdfBoolean](./pdfsharp.pdf.pdfboolean)<br>
Implements [ICloneable](https://docs.microsoft.com/en-us/dotnet/api/system.icloneable)

## Fields

### **True**

A pre-defined value that represents `true`.

```csharp
public static PdfBoolean True;
```

### **False**

A pre-defined value that represents `false`.

```csharp
public static PdfBoolean False;
```

## Properties

### **Value**

Gets the value of this instance as boolean value.

```csharp
public bool Value { get; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

## Constructors

### **PdfBoolean()**

Initializes a new instance of the [PdfBoolean](./pdfsharp.pdf.pdfboolean) class.

```csharp
public PdfBoolean()
```

### **PdfBoolean(Boolean)**

Initializes a new instance of the [PdfBoolean](./pdfsharp.pdf.pdfboolean) class.

```csharp
public PdfBoolean(bool value)
```

#### Parameters

`value` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

## Methods

### **ToString()**

Returns 'false' or 'true'.

```csharp
public string ToString()
```

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **WriteObject(PdfWriter)**

Writes 'true' or 'false'.

```csharp
internal void WriteObject(PdfWriter writer)
```

#### Parameters

`writer` [PdfWriter](./pdfsharp.pdf.io.pdfwriter)<br>
