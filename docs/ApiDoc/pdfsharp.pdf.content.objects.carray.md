# CArray

Namespace: PdfSharp.Pdf.Content.Objects

Represents an array of objects in a PDF content stream.

```csharp
public class CArray : CSequence, System.ICloneable, System.Collections.Generic.IList`1[[PdfSharp.Pdf.Content.Objects.CObject, PdfSharp, Version=0.1.3.0, Culture=neutral, PublicKeyToken=null]], System.Collections.Generic.ICollection`1[[PdfSharp.Pdf.Content.Objects.CObject, PdfSharp, Version=0.1.3.0, Culture=neutral, PublicKeyToken=null]], System.Collections.Generic.IEnumerable`1[[PdfSharp.Pdf.Content.Objects.CObject, PdfSharp, Version=0.1.3.0, Culture=neutral, PublicKeyToken=null]], System.Collections.IEnumerable
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [CObject](./pdfsharp.pdf.content.objects.cobject) → [CSequence](./pdfsharp.pdf.content.objects.csequence) → [CArray](./pdfsharp.pdf.content.objects.carray)<br>
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

### **CArray()**

```csharp
public CArray()
```

## Methods

### **Clone()**

Creates a new object that is a copy of the current instance.

```csharp
public CArray Clone()
```

#### Returns

[CArray](./pdfsharp.pdf.content.objects.carray)<br>

### **Copy()**

Implements the copy mechanism of this class.

```csharp
protected CObject Copy()
```

#### Returns

[CObject](./pdfsharp.pdf.content.objects.cobject)<br>

### **ToString()**

Returns a string that represents the current value.

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
