# PdfResources

Namespace: PdfSharp.Pdf.Advanced

Represents a PDF resource object.

```csharp
public sealed class PdfResources : PdfSharp.Pdf.PdfDictionary, System.ICloneable, System.Collections.Generic.IEnumerable`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib, Version=6.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e],[PdfSharp.Pdf.PdfItem, PdfSharp, Version=0.1.3.0, Culture=neutral, PublicKeyToken=null]], System.Private.CoreLib, Version=6.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e]], System.Collections.IEnumerable
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [PdfItem](./pdfsharp.pdf.pdfitem) → [PdfObject](./pdfsharp.pdf.pdfobject) → [PdfDictionary](./pdfsharp.pdf.pdfdictionary) → [PdfResources](./pdfsharp.pdf.advanced.pdfresources)<br>
Implements [ICloneable](https://docs.microsoft.com/en-us/dotnet/api/system.icloneable), [IEnumerable&lt;KeyValuePair&lt;String, PdfItem&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1), [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.ienumerable)

## Properties

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

### **PdfResources(PdfDocument)**

Initializes a new instance of the [PdfResources](./pdfsharp.pdf.advanced.pdfresources) class.

```csharp
public PdfResources(PdfDocument document)
```

#### Parameters

`document` [PdfDocument](./pdfsharp.pdf.pdfdocument)<br>
The document.

## Methods

### **AddFont(PdfFont)**

Adds the specified font to this resource dictionary and returns its local resource name.

```csharp
public string AddFont(PdfFont font)
```

#### Parameters

`font` [PdfFont](./pdfsharp.pdf.advanced.pdffont)<br>

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **AddImage(PdfImage)**

Adds the specified image to this resource dictionary
 and returns its local resource name.

```csharp
public string AddImage(PdfImage image)
```

#### Parameters

`image` [PdfImage](./pdfsharp.pdf.advanced.pdfimage)<br>

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **AddForm(PdfFormXObject)**

Adds the specified form object to this resource dictionary
 and returns its local resource name.

```csharp
public string AddForm(PdfFormXObject form)
```

#### Parameters

`form` [PdfFormXObject](./pdfsharp.pdf.advanced.pdfformxobject)<br>

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **AddExtGState(PdfExtGState)**

Adds the specified graphics state to this resource dictionary
 and returns its local resource name.

```csharp
public string AddExtGState(PdfExtGState extGState)
```

#### Parameters

`extGState` [PdfExtGState](./pdfsharp.pdf.advanced.pdfextgstate)<br>

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **AddPattern(PdfShadingPattern)**

Adds the specified pattern to this resource dictionary
 and returns its local resource name.

```csharp
public string AddPattern(PdfShadingPattern pattern)
```

#### Parameters

`pattern` [PdfShadingPattern](./pdfsharp.pdf.advanced.pdfshadingpattern)<br>

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **AddPattern(PdfTilingPattern)**

Adds the specified pattern to this resource dictionary
 and returns its local resource name.

```csharp
public string AddPattern(PdfTilingPattern pattern)
```

#### Parameters

`pattern` [PdfTilingPattern](./pdfsharp.pdf.advanced.pdftilingpattern)<br>

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **AddShading(PdfShading)**

Adds the specified shading to this resource dictionary
 and returns its local resource name.

```csharp
public string AddShading(PdfShading shading)
```

#### Parameters

`shading` [PdfShading](./pdfsharp.pdf.advanced.pdfshading)<br>

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **ExistsResourceName(String)**

Check whether a resource name is already used in the context of this resource dictionary.
 PDF4NET uses GUIDs as resource names, but I think this weapon is to heavy.

```csharp
internal bool ExistsResourceName(string name)
```

#### Parameters

`name` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
