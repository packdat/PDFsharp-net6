# PdfContents

Namespace: PdfSharp.Pdf.Advanced

Represents an array of PDF content streams of a page.

```csharp
public sealed class PdfContents : PdfSharp.Pdf.PdfArray, System.ICloneable, System.Collections.Generic.IEnumerable`1[[PdfSharp.Pdf.PdfItem, PdfSharp, Version=0.1.2.0, Culture=neutral, PublicKeyToken=null]], System.Collections.IEnumerable
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [PdfItem](./pdfsharp.pdf.pdfitem) → [PdfObject](./pdfsharp.pdf.pdfobject) → [PdfArray](./pdfsharp.pdf.pdfarray) → [PdfContents](./pdfsharp.pdf.advanced.pdfcontents)<br>
Implements [ICloneable](https://docs.microsoft.com/en-us/dotnet/api/system.icloneable), [IEnumerable&lt;PdfItem&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1), [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.ienumerable)

## Properties

### **Elements**

Gets the collection containing the elements of this object.

```csharp
public ArrayElements Elements { get; }
```

#### Property Value

[ArrayElements](./pdfsharp.pdf.pdfarray.arrayelements)<br>

### **Owner**

Gets the PdfDocument this object belongs to.

```csharp
public PdfDocument Owner { get; }
```

#### Property Value

[PdfDocument](./pdfsharp.pdf.pdfdocument)<br>

### **IsIndirect**

Indicates whether the object is an indirect object.

```csharp
public bool IsIndirect { get; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **Internals**

Gets the PdfInternals object of this document, that grants access to some internal structures
 which are not part of the public interface of PdfDocument.

```csharp
public PdfObjectInternals Internals { get; }
```

#### Property Value

[PdfObjectInternals](./pdfsharp.pdf.advanced.pdfobjectinternals)<br>

### **Reference**

Gets the indirect reference of this object. If the value is null, this object is a direct object.

```csharp
public PdfReference Reference { get; internal set; }
```

#### Property Value

[PdfReference](./pdfsharp.pdf.advanced.pdfreference)<br>

### **ReferenceNotNull**

Gets the indirect reference of this object. Throws if it is null.

```csharp
public PdfReference ReferenceNotNull { get; }
```

#### Property Value

[PdfReference](./pdfsharp.pdf.advanced.pdfreference)<br>

#### Exceptions

[InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/system.invalidoperationexception)<br>
The indirect reference must be not null here.

## Constructors

### **PdfContents(PdfDocument)**

Initializes a new instance of the [PdfContents](./pdfsharp.pdf.advanced.pdfcontents) class.

```csharp
public PdfContents(PdfDocument document)
```

#### Parameters

`document` [PdfDocument](./pdfsharp.pdf.pdfdocument)<br>
The document.

## Methods

### **AppendContent()**

Appends a new content stream and returns it.

```csharp
public PdfContent AppendContent()
```

#### Returns

[PdfContent](./pdfsharp.pdf.advanced.pdfcontent)<br>

### **PrependContent()**

Prepends a new content stream and returns it.

```csharp
public PdfContent PrependContent()
```

#### Returns

[PdfContent](./pdfsharp.pdf.advanced.pdfcontent)<br>

### **CreateSingleContent()**

Creates a single content stream with the bytes from the array of the content streams.
 This operation does not modify any of the content streams in this array.

```csharp
public PdfContent CreateSingleContent()
```

#### Returns

[PdfContent](./pdfsharp.pdf.advanced.pdfcontent)<br>

### **ReplaceContent(CSequence)**

Replaces the current content of the page with the specified content sequence.

```csharp
public PdfContent ReplaceContent(CSequence cseq)
```

#### Parameters

`cseq` [CSequence](./pdfsharp.pdf.content.objects.csequence)<br>

#### Returns

[PdfContent](./pdfsharp.pdf.advanced.pdfcontent)<br>

### **WriteObject(PdfWriter)**

```csharp
internal void WriteObject(PdfWriter writer)
```

#### Parameters

`writer` [PdfWriter](./pdfsharp.pdf.io.pdfwriter)<br>

### **GetEnumerator()**

Gets the enumerator.

```csharp
public IEnumerator<PdfContent> GetEnumerator()
```

#### Returns

[IEnumerator&lt;PdfContent&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerator-1)<br>
