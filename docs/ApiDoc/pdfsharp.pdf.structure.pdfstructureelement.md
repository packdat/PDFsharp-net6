# PdfStructureElement

Namespace: PdfSharp.Pdf.Structure

Represents the root of a structure tree.

```csharp
public sealed class PdfStructureElement : PdfSharp.Pdf.PdfDictionary, System.ICloneable, System.Collections.Generic.IEnumerable`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib, Version=6.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e],[PdfSharp.Pdf.PdfItem, PdfSharp, Version=0.1.3.0, Culture=neutral, PublicKeyToken=null]], System.Private.CoreLib, Version=6.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e]], System.Collections.IEnumerable
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [PdfItem](./pdfsharp.pdf.pdfitem) → [PdfObject](./pdfsharp.pdf.pdfobject) → [PdfDictionary](./pdfsharp.pdf.pdfdictionary) → [PdfStructureElement](./pdfsharp.pdf.structure.pdfstructureelement)<br>
Implements [ICloneable](https://docs.microsoft.com/en-us/dotnet/api/system.icloneable), [IEnumerable&lt;KeyValuePair&lt;String, PdfItem&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1), [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.ienumerable)

## Properties

### **LayoutAttributes**

Gets the PdfLayoutAttributes instance in "/A". If not existing, it creates one.

```csharp
public PdfLayoutAttributes LayoutAttributes { get; }
```

#### Property Value

[PdfLayoutAttributes](./pdfsharp.pdf.structure.pdflayoutattributes)<br>

### **TableAttributes**

Gets the PdfTableAttributes instance in "/A". If not existing, it creates one.

```csharp
public PdfTableAttributes TableAttributes { get; }
```

#### Property Value

[PdfTableAttributes](./pdfsharp.pdf.structure.pdftableattributes)<br>

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

### **PdfStructureElement()**

Initializes a new instance of the [PdfStructureElement](./pdfsharp.pdf.structure.pdfstructureelement) class.

```csharp
public PdfStructureElement()
```

### **PdfStructureElement(PdfDocument)**

Initializes a new instance of the [PdfStructureElement](./pdfsharp.pdf.structure.pdfstructureelement) class.

```csharp
public PdfStructureElement(PdfDocument document)
```

#### Parameters

`document` [PdfDocument](./pdfsharp.pdf.pdfdocument)<br>
The document that owns this object.

## Methods

### **PrepareForSave()**

```csharp
internal void PrepareForSave()
```

### **GetKids(DictionaryElements)**

Returns all PdfDictionaries saved in the "/K" key.

```csharp
internal static IEnumerable<PdfDictionary> GetKids(DictionaryElements elements)
```

#### Parameters

`elements` [DictionaryElements](./pdfsharp.pdf.pdfdictionary.dictionaryelements)<br>

#### Returns

[IEnumerable&lt;PdfDictionary&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)<br>
