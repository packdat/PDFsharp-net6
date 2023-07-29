# PdfNameTreeNode

Namespace: PdfSharp.Pdf

Represents a name tree node.

```csharp
public sealed class PdfNameTreeNode : PdfDictionary, System.ICloneable, System.Collections.Generic.IEnumerable`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib, Version=6.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e],[PdfSharp.Pdf.PdfItem, PdfSharp, Version=0.1.3.0, Culture=neutral, PublicKeyToken=null]], System.Private.CoreLib, Version=6.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e]], System.Collections.IEnumerable
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [PdfItem](./pdfsharp.pdf.pdfitem) → [PdfObject](./pdfsharp.pdf.pdfobject) → [PdfDictionary](./pdfsharp.pdf.pdfdictionary) → [PdfNameTreeNode](./pdfsharp.pdf.pdfnametreenode)<br>
Implements [ICloneable](https://docs.microsoft.com/en-us/dotnet/api/system.icloneable), [IEnumerable&lt;KeyValuePair&lt;String, PdfItem&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1), [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.ienumerable)

## Properties

### **Parent**

Gets the parent of this node or null if this is the root-node

```csharp
public PdfNameTreeNode Parent { get; set; }
```

#### Property Value

[PdfNameTreeNode](./pdfsharp.pdf.pdfnametreenode)<br>

### **IsRoot**

Gets a value indicating whether this instance is a root node.

```csharp
public bool IsRoot { get; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **KidsCount**

Gets the number of Kids elements.

```csharp
public int KidsCount { get; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **NamesCount**

Gets the number of Names elements.

```csharp
public int NamesCount { get; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **NamesCountTotal**

Get the number of names in this node including all children

```csharp
public int NamesCountTotal { get; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **Kids**

```csharp
public IEnumerable<PdfNameTreeNode> Kids { get; }
```

#### Property Value

[IEnumerable&lt;PdfNameTreeNode&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)<br>

### **LeastKey**

Gets the least key.

```csharp
public string LeastKey { get; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **GreatestKey**

Gets the greatest key.

```csharp
public string GreatestKey { get; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

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

## Constructors

### **PdfNameTreeNode()**

Initializes a new instance of the [PdfNameTreeNode](./pdfsharp.pdf.pdfnametreenode) class.

```csharp
public PdfNameTreeNode()
```

### **PdfNameTreeNode(PdfDictionary)**

Initializes a new instance of the [PdfNameTreeNode](./pdfsharp.pdf.pdfnametreenode) class.

```csharp
public PdfNameTreeNode(PdfDictionary dict)
```

#### Parameters

`dict` [PdfDictionary](./pdfsharp.pdf.pdfdictionary)<br>

## Methods

### **GetNames(Boolean)**

Gets the list of names this node contains

```csharp
public IReadOnlyList<string> GetNames(bool includeKids)
```

#### Parameters

`includeKids` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
Specifies whether the names of the kids should also be returned

#### Returns

[IReadOnlyList&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1)<br>
The list of names this node contains

**Remarks:**

Note: When kids are included, the names are not guaranteed to be sorted

### **ContainsName(String, Boolean)**

Determines whether this node contains the specified

```csharp
public bool ContainsName(string name, bool includeKids)
```

#### Parameters

`name` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The name to search for

`includeKids` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
Specifies whether the kids should also be searched

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
true, if this node contains , false otherwise

### **GetValue(String, Boolean)**

Get the value of the item with the specified .<br>
 If the value represents a reference, the referenced value is returned.

```csharp
public PdfItem GetValue(string name, bool includeKids)
```

#### Parameters

`name` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The name whose value should be retrieved

`includeKids` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
Specifies whether the kids should also be searched

#### Returns

[PdfItem](./pdfsharp.pdf.pdfitem)<br>
The value for  when found, otwerwise null

### **AddKid(PdfNameTreeNode)**

Adds a child node to this node.

```csharp
public void AddKid(PdfNameTreeNode kidNode)
```

#### Parameters

`kidNode` [PdfNameTreeNode](./pdfsharp.pdf.pdfnametreenode)<br>

### **AddName(String, PdfItem)**

Adds a key/value pair to the Names array of this node.

```csharp
public void AddName(string key, PdfItem value)
```

#### Parameters

`key` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`value` [PdfItem](./pdfsharp.pdf.pdfitem)<br>

### **PrepareForSave()**

```csharp
internal void PrepareForSave()
```

### **WriteObject(PdfWriter)**

```csharp
internal void WriteObject(PdfWriter writer)
```

#### Parameters

`writer` [PdfWriter](./pdfsharp.pdf.io.pdfwriter)<br>
