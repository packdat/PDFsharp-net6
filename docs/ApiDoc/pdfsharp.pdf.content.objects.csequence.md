# CSequence

Namespace: PdfSharp.Pdf.Content.Objects

Represents a sequence of objects in a PDF content stream.

```csharp
public class CSequence : CObject, System.ICloneable, System.Collections.Generic.IList`1[[PdfSharp.Pdf.Content.Objects.CObject, PdfSharp, Version=0.1.3.0, Culture=neutral, PublicKeyToken=null]], System.Collections.Generic.ICollection`1[[PdfSharp.Pdf.Content.Objects.CObject, PdfSharp, Version=0.1.3.0, Culture=neutral, PublicKeyToken=null]], System.Collections.Generic.IEnumerable`1[[PdfSharp.Pdf.Content.Objects.CObject, PdfSharp, Version=0.1.3.0, Culture=neutral, PublicKeyToken=null]], System.Collections.IEnumerable
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [CObject](./pdfsharp.pdf.content.objects.cobject) → [CSequence](./pdfsharp.pdf.content.objects.csequence)<br>
Implements [ICloneable](https://docs.microsoft.com/en-us/dotnet/api/system.icloneable), [IList&lt;CObject&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1), [ICollection&lt;CObject&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1), [IEnumerable&lt;CObject&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1), [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.ienumerable)

## Properties

### **Item**

```csharp
public CObject Item { get; set; }
```

#### Property Value

[CObject](./pdfsharp.pdf.content.objects.cobject)<br>

### **Count**

Gets the number of elements contained in the sequence.

```csharp
public int Count { get; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

## Constructors

### **CSequence()**

```csharp
public CSequence()
```

## Methods

### **Clone()**

Creates a new object that is a copy of the current instance.

```csharp
public CSequence Clone()
```

#### Returns

[CSequence](./pdfsharp.pdf.content.objects.csequence)<br>

### **Copy()**

Implements the copy mechanism of this class.

```csharp
protected CObject Copy()
```

#### Returns

[CObject](./pdfsharp.pdf.content.objects.cobject)<br>

### **Add(CSequence)**

Adds the specified sequence.

```csharp
public void Add(CSequence sequence)
```

#### Parameters

`sequence` [CSequence](./pdfsharp.pdf.content.objects.csequence)<br>
The sequence.

### **Add(CObject)**

Adds the specified value add the end of the sequence.

```csharp
public void Add(CObject value)
```

#### Parameters

`value` [CObject](./pdfsharp.pdf.content.objects.cobject)<br>

### **Clear()**

Removes all elements from the sequence.

```csharp
public void Clear()
```

### **Contains(CObject)**

Determines whether the specified value is in the sequence.

```csharp
public bool Contains(CObject value)
```

#### Parameters

`value` [CObject](./pdfsharp.pdf.content.objects.cobject)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **IndexOf(CObject)**

Returns the index of the specified value in the sequence or -1, if no such value is in the sequence.

```csharp
public int IndexOf(CObject value)
```

#### Parameters

`value` [CObject](./pdfsharp.pdf.content.objects.cobject)<br>

#### Returns

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **Insert(Int32, CObject)**

Inserts the specified value in the sequence.

```csharp
public void Insert(int index, CObject value)
```

#### Parameters

`index` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

`value` [CObject](./pdfsharp.pdf.content.objects.cobject)<br>

### **Remove(CObject)**

Removes the specified value from the sequence.

```csharp
public bool Remove(CObject value)
```

#### Parameters

`value` [CObject](./pdfsharp.pdf.content.objects.cobject)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **RemoveAt(Int32)**

Removes the value at the specified index from the sequence.

```csharp
public void RemoveAt(int index)
```

#### Parameters

`index` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **CopyTo(CObject[], Int32)**

Copies the elements of the sequence to the specified array.

```csharp
public void CopyTo(CObject[] array, int index)
```

#### Parameters

`array` [CObject[]](./pdfsharp.pdf.content.objects.cobject)<br>

`index` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **GetEnumerator()**

Returns an enumerator that iterates through the sequence.

```csharp
public IEnumerator<CObject> GetEnumerator()
```

#### Returns

[IEnumerator&lt;CObject&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerator-1)<br>

### **ToContent()**

Converts the sequence to a PDF content stream.

```csharp
public Byte[] ToContent()
```

#### Returns

[Byte[]](https://docs.microsoft.com/en-us/dotnet/api/system.byte)<br>

### **ToString()**

Returns a string containing all elements of the sequence.

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
