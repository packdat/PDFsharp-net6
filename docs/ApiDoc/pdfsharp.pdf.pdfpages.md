# PdfPages

Namespace: PdfSharp.Pdf

Represents the pages of the document.

```csharp
public sealed class PdfPages : PdfDictionary, System.ICloneable, System.Collections.Generic.IEnumerable`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib, Version=6.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e],[PdfSharp.Pdf.PdfItem, PdfSharp, Version=0.1.3.0, Culture=neutral, PublicKeyToken=null]], System.Private.CoreLib, Version=6.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e]], System.Collections.IEnumerable, System.Collections.Generic.IEnumerable`1[[PdfSharp.Pdf.PdfPage, PdfSharp, Version=0.1.3.0, Culture=neutral, PublicKeyToken=null]]
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [PdfItem](./pdfsharp.pdf.pdfitem) → [PdfObject](./pdfsharp.pdf.pdfobject) → [PdfDictionary](./pdfsharp.pdf.pdfdictionary) → [PdfPages](./pdfsharp.pdf.pdfpages)<br>
Implements [ICloneable](https://docs.microsoft.com/en-us/dotnet/api/system.icloneable), [IEnumerable&lt;KeyValuePair&lt;String, PdfItem&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1), [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.ienumerable), [IEnumerable&lt;PdfPage&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)

## Properties

### **Count**

Gets the number of pages.

```csharp
public int Count { get; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **Item**

```csharp
public PdfPage Item { get; }
```

#### Property Value

[PdfPage](./pdfsharp.pdf.pdfpage)<br>

### **PagesArray**

Gets a PdfArray containing all pages of this document. The array must not be modified.

```csharp
public PdfArray PagesArray { get; }
```

#### Property Value

[PdfArray](./pdfsharp.pdf.pdfarray)<br>

### **Elements**

Gets the dictionary containing the elements of this dictionary.

```csharp
public DictionaryElements Elements { get; }
```

#### Property Value

[DictionaryElements](./pdfsharp.pdf.pdfdictionary.dictionaryelements)<br>

### **Stream**

Gets or sets the PDF stream belonging to this dictionary. Returns null if the dictionary has
 no stream. To create the stream, call the CreateStream function.

```csharp
public PdfStream Stream { get; set; }
```

#### Property Value

[PdfStream](./pdfsharp.pdf.pdfdictionary.pdfstream)<br>

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

### **FindPage(PdfObjectID)**

Finds a page by its id. Transforms it to PdfPage if necessary.

```csharp
internal PdfPage FindPage(PdfObjectID id)
```

#### Parameters

`id` [PdfObjectID](./pdfsharp.pdf.pdfobjectid)<br>

#### Returns

[PdfPage](./pdfsharp.pdf.pdfpage)<br>

### **Add()**

Creates a new PdfPage, adds it to the end of this document, and returns it.

```csharp
public PdfPage Add()
```

#### Returns

[PdfPage](./pdfsharp.pdf.pdfpage)<br>

### **Add(PdfPage)**

Adds the specified PdfPage to the end of this document and maybe returns a new PdfPage object.
 The value returned is a new object if the added page comes from a foreign document.

```csharp
public PdfPage Add(PdfPage page)
```

#### Parameters

`page` [PdfPage](./pdfsharp.pdf.pdfpage)<br>

#### Returns

[PdfPage](./pdfsharp.pdf.pdfpage)<br>

### **Insert(Int32)**

Creates a new PdfPage, inserts it at the specified position into this document, and returns it.

```csharp
public PdfPage Insert(int index)
```

#### Parameters

`index` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

#### Returns

[PdfPage](./pdfsharp.pdf.pdfpage)<br>

### **Insert(Int32, PdfPage)**

Inserts the specified PdfPage at the specified position to this document and maybe returns a new PdfPage object.
 The value returned is a new object if the inserted page comes from a foreign document.

```csharp
public PdfPage Insert(int index, PdfPage page)
```

#### Parameters

`index` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

`page` [PdfPage](./pdfsharp.pdf.pdfpage)<br>

#### Returns

[PdfPage](./pdfsharp.pdf.pdfpage)<br>

### **InsertRange(Int32, PdfDocument, Int32, Int32)**

Inserts pages of the specified document into this document.

```csharp
public void InsertRange(int index, PdfDocument document, int startIndex, int pageCount)
```

#### Parameters

`index` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The index in this document where to insert the page .

`document` [PdfDocument](./pdfsharp.pdf.pdfdocument)<br>
The document to be inserted.

`startIndex` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The index of the first page to be inserted.

`pageCount` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The number of pages to be inserted.

### **InsertRange(Int32, PdfDocument)**

Inserts all pages of the specified document into this document.

```csharp
public void InsertRange(int index, PdfDocument document)
```

#### Parameters

`index` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The index in this document where to insert the page .

`document` [PdfDocument](./pdfsharp.pdf.pdfdocument)<br>
The document to be inserted.

### **InsertRange(Int32, PdfDocument, Int32)**

Inserts all pages of the specified document into this document.

```csharp
public void InsertRange(int index, PdfDocument document, int startIndex)
```

#### Parameters

`index` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The index in this document where to insert the page .

`document` [PdfDocument](./pdfsharp.pdf.pdfdocument)<br>
The document to be inserted.

`startIndex` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The index of the first page to be inserted.

### **Remove(PdfPage)**

Removes the specified page from the document.

```csharp
public void Remove(PdfPage page)
```

#### Parameters

`page` [PdfPage](./pdfsharp.pdf.pdfpage)<br>

### **RemoveAt(Int32)**

Removes the specified page from the document.

```csharp
public void RemoveAt(int index)
```

#### Parameters

`index` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **MovePage(Int32, Int32)**

Moves a page within the page sequence.

```csharp
public void MovePage(int oldIndex, int newIndex)
```

#### Parameters

`oldIndex` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The page index before this operation.

`newIndex` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The page index after this operation.

### **FlattenPageTree()**

Replaces the page tree by a flat array of indirect references to the pages objects.

```csharp
internal void FlattenPageTree()
```

### **PrepareForSave()**

Prepares the document for saving.

```csharp
internal void PrepareForSave()
```

### **GetEnumerator()**

Gets the enumerator.

```csharp
public IEnumerator<PdfPage> GetEnumerator()
```

#### Returns

[IEnumerator&lt;PdfPage&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerator-1)<br>
