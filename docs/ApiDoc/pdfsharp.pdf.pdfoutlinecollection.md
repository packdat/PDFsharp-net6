# PdfOutlineCollection

Namespace: PdfSharp.Pdf

Represents a collection of outlines.

```csharp
public class PdfOutlineCollection : PdfObject, System.ICloneable, System.Collections.Generic.ICollection`1[[PdfSharp.Pdf.PdfOutline, PdfSharp, Version=0.1.2.0, Culture=neutral, PublicKeyToken=null]], System.Collections.Generic.IEnumerable`1[[PdfSharp.Pdf.PdfOutline, PdfSharp, Version=0.1.2.0, Culture=neutral, PublicKeyToken=null]], System.Collections.IEnumerable, System.Collections.Generic.IList`1[[PdfSharp.Pdf.PdfOutline, PdfSharp, Version=0.1.2.0, Culture=neutral, PublicKeyToken=null]]
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [PdfItem](./pdfsharp.pdf.pdfitem) → [PdfObject](./pdfsharp.pdf.pdfobject) → [PdfOutlineCollection](./pdfsharp.pdf.pdfoutlinecollection)<br>
Implements [ICloneable](https://docs.microsoft.com/en-us/dotnet/api/system.icloneable), [ICollection&lt;PdfOutline&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1), [IEnumerable&lt;PdfOutline&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1), [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.ienumerable), [IList&lt;PdfOutline&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1)

## Properties

### **HasOutline**

#### Caution

Use 'Count > 0' - HasOutline will throw exception.

---

Indicates whether the outline collection has at least one entry.

```csharp
public bool HasOutline { get; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **Count**

Gets the number of entries in this collection.

```csharp
public int Count { get; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **IsReadOnly**

Returns false.

```csharp
public bool IsReadOnly { get; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **Item**

```csharp
public PdfOutline Item { get; set; }
```

#### Property Value

[PdfOutline](./pdfsharp.pdf.pdfoutline)<br>

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

### **Remove(PdfOutline)**

Removes the first occurrence of a specific item from the collection.

```csharp
public bool Remove(PdfOutline item)
```

#### Parameters

`item` [PdfOutline](./pdfsharp.pdf.pdfoutline)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **Add(PdfOutline)**

Adds the specified outline.

```csharp
public void Add(PdfOutline outline)
```

#### Parameters

`outline` [PdfOutline](./pdfsharp.pdf.pdfoutline)<br>

### **Clear()**

Removes all elements form the collection.

```csharp
public void Clear()
```

### **Contains(PdfOutline)**

Determines whether the specified element is in the collection.

```csharp
public bool Contains(PdfOutline item)
```

#### Parameters

`item` [PdfOutline](./pdfsharp.pdf.pdfoutline)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **CopyTo(PdfOutline[], Int32)**

Copies the collection to an array, starting at the specified index of the target array.

```csharp
public void CopyTo(PdfOutline[] array, int arrayIndex)
```

#### Parameters

`array` [PdfOutline[]](./pdfsharp.pdf.pdfoutline)<br>

`arrayIndex` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **Add(String, PdfPage, Boolean, PdfOutlineStyle, XColor)**

Adds the specified outline entry.

```csharp
public PdfOutline Add(string title, PdfPage destinationPage, bool opened, PdfOutlineStyle style, XColor textColor)
```

#### Parameters

`title` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The outline text.

`destinationPage` [PdfPage](./pdfsharp.pdf.pdfpage)<br>
The destination page.

`opened` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
Specifies whether the node is displayed expanded (opened) or collapsed.

`style` [PdfOutlineStyle](./pdfsharp.pdf.pdfoutlinestyle)<br>
The font style used to draw the outline text.

`textColor` [XColor](./pdfsharp.drawing.xcolor)<br>
The color used to draw the outline text.

#### Returns

[PdfOutline](./pdfsharp.pdf.pdfoutline)<br>

### **Add(String, PdfPage, Boolean, PdfOutlineStyle)**

Adds the specified outline entry.

```csharp
public PdfOutline Add(string title, PdfPage destinationPage, bool opened, PdfOutlineStyle style)
```

#### Parameters

`title` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The outline text.

`destinationPage` [PdfPage](./pdfsharp.pdf.pdfpage)<br>
The destination page.

`opened` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
Specifies whether the node is displayed expanded (opened) or collapsed.

`style` [PdfOutlineStyle](./pdfsharp.pdf.pdfoutlinestyle)<br>
The font style used to draw the outline text.

#### Returns

[PdfOutline](./pdfsharp.pdf.pdfoutline)<br>

### **Add(String, PdfPage, Boolean)**

Adds the specified outline entry.

```csharp
public PdfOutline Add(string title, PdfPage destinationPage, bool opened)
```

#### Parameters

`title` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The outline text.

`destinationPage` [PdfPage](./pdfsharp.pdf.pdfpage)<br>
The destination page.

`opened` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
Specifies whether the node is displayed expanded (opened) or collapsed.

#### Returns

[PdfOutline](./pdfsharp.pdf.pdfoutline)<br>

### **Add(String, PdfPage)**

Creates a PdfOutline and adds it into the outline collection.

```csharp
public PdfOutline Add(string title, PdfPage destinationPage)
```

#### Parameters

`title` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`destinationPage` [PdfPage](./pdfsharp.pdf.pdfpage)<br>

#### Returns

[PdfOutline](./pdfsharp.pdf.pdfoutline)<br>

### **IndexOf(PdfOutline)**

Gets the index of the specified item.

```csharp
public int IndexOf(PdfOutline item)
```

#### Parameters

`item` [PdfOutline](./pdfsharp.pdf.pdfoutline)<br>

#### Returns

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **Insert(Int32, PdfOutline)**

Inserts the item at the specified index.

```csharp
public void Insert(int index, PdfOutline outline)
```

#### Parameters

`index` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

`outline` [PdfOutline](./pdfsharp.pdf.pdfoutline)<br>

### **RemoveAt(Int32)**

Removes the outline item at the specified index.

```csharp
public void RemoveAt(int index)
```

#### Parameters

`index` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **GetEnumerator()**

Returns an enumerator that iterates through the outline collection.

```csharp
public IEnumerator<PdfOutline> GetEnumerator()
```

#### Returns

[IEnumerator&lt;PdfOutline&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerator-1)<br>

### **CountOpen()**

```csharp
internal int CountOpen()
```

#### Returns

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
