# PdfAnnotations

Namespace: PdfSharp.Pdf.Annotations

Represents the annotations array of a page.

```csharp
public sealed class PdfAnnotations : PdfSharp.Pdf.PdfArray, System.ICloneable, System.Collections.Generic.IEnumerable`1[[PdfSharp.Pdf.PdfItem, PdfSharp, Version=0.1.3.0, Culture=neutral, PublicKeyToken=null]], System.Collections.IEnumerable
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [PdfItem](./pdfsharp.pdf.pdfitem) → [PdfObject](./pdfsharp.pdf.pdfobject) → [PdfArray](./pdfsharp.pdf.pdfarray) → [PdfAnnotations](./pdfsharp.pdf.annotations.pdfannotations)<br>
Implements [ICloneable](https://docs.microsoft.com/en-us/dotnet/api/system.icloneable), [IEnumerable&lt;PdfItem&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1), [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.ienumerable)

## Properties

### **Count**

Gets the number of annotations in this collection.

```csharp
public int Count { get; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **Item**

```csharp
public PdfAnnotation Item { get; }
```

#### Property Value

[PdfAnnotation](./pdfsharp.pdf.annotations.pdfannotation)<br>

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

## Methods

### **Add(PdfAnnotation)**

Adds the specified annotation.

```csharp
public void Add(PdfAnnotation annotation)
```

#### Parameters

`annotation` [PdfAnnotation](./pdfsharp.pdf.annotations.pdfannotation)<br>
The annotation.

### **Remove(PdfAnnotation)**

Removes an annotation from the document.

```csharp
public void Remove(PdfAnnotation annotation)
```

#### Parameters

`annotation` [PdfAnnotation](./pdfsharp.pdf.annotations.pdfannotation)<br>

### **Clear()**

Removes all the annotations from the current page.

```csharp
public void Clear()
```

### **FixImportedAnnotation(PdfPage)**

Fixes the /P element in imported annotation.

```csharp
internal static void FixImportedAnnotation(PdfPage page)
```

#### Parameters

`page` [PdfPage](./pdfsharp.pdf.pdfpage)<br>

### **GetEnumerator()**

Returns an enumerator that iterates through a collection.

```csharp
public IEnumerator<PdfItem> GetEnumerator()
```

#### Returns

[IEnumerator&lt;PdfItem&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerator-1)<br>
