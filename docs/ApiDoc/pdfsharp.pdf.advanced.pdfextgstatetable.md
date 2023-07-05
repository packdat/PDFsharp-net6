# PdfExtGStateTable

Namespace: PdfSharp.Pdf.Advanced

Contains all used ExtGState objects of a document.

```csharp
public sealed class PdfExtGStateTable : PdfResourceTable
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [PdfResourceTable](./pdfsharp.pdf.advanced.pdfresourcetable) → [PdfExtGStateTable](./pdfsharp.pdf.advanced.pdfextgstatetable)

## Constructors

### **PdfExtGStateTable(PdfDocument)**

Initializes a new instance of this class, which is a singleton for each document.

```csharp
public PdfExtGStateTable(PdfDocument document)
```

#### Parameters

`document` [PdfDocument](./pdfsharp.pdf.pdfdocument)<br>

## Methods

### **GetExtGStateStroke(Double, Boolean)**

Gets a PdfExtGState with the key 'CA' set to the specified alpha value.

```csharp
public PdfExtGState GetExtGStateStroke(double alpha, bool overprint)
```

#### Parameters

`alpha` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`overprint` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

#### Returns

[PdfExtGState](./pdfsharp.pdf.advanced.pdfextgstate)<br>

### **GetExtGStateNonStroke(Double, Boolean)**

Gets a PdfExtGState with the key 'ca' set to the specified alpha value.

```csharp
public PdfExtGState GetExtGStateNonStroke(double alpha, bool overprint)
```

#### Parameters

`alpha` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`overprint` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

#### Returns

[PdfExtGState](./pdfsharp.pdf.advanced.pdfextgstate)<br>
