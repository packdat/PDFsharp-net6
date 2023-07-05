# PdfEmbeddedGoToAction

Namespace: PdfSharp.Pdf.Actions

Represents a PDF Embedded Goto action.

```csharp
public sealed class PdfEmbeddedGoToAction : PdfAction, System.ICloneable, System.Collections.Generic.IEnumerable`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib, Version=6.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e],[PdfSharp.Pdf.PdfItem, PdfSharp, Version=0.1.2.0, Culture=neutral, PublicKeyToken=null]], System.Private.CoreLib, Version=6.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e]], System.Collections.IEnumerable
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [PdfItem](./pdfsharp.pdf.pdfitem) → [PdfObject](./pdfsharp.pdf.pdfobject) → [PdfDictionary](./pdfsharp.pdf.pdfdictionary) → [PdfAction](./pdfsharp.pdf.actions.pdfaction) → [PdfEmbeddedGoToAction](./pdfsharp.pdf.actions.pdfembeddedgotoaction)<br>
Implements [ICloneable](https://docs.microsoft.com/en-us/dotnet/api/system.icloneable), [IEnumerable&lt;KeyValuePair&lt;String, PdfItem&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1), [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.ienumerable)

## Fields

### **Separator**

Separator for splitting destination path segments ans destination name.

```csharp
public static char Separator;
```

### **ParentString**

Path segment string used to move to the parent document.

```csharp
public static string ParentString;
```

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

### **PdfEmbeddedGoToAction()**

Initializes a new instance of the [PdfEmbeddedGoToAction](./pdfsharp.pdf.actions.pdfembeddedgotoaction) class.

```csharp
public PdfEmbeddedGoToAction()
```

### **PdfEmbeddedGoToAction(PdfDocument)**

Initializes a new instance of the [PdfEmbeddedGoToAction](./pdfsharp.pdf.actions.pdfembeddedgotoaction) class.

```csharp
public PdfEmbeddedGoToAction(PdfDocument document)
```

#### Parameters

`document` [PdfDocument](./pdfsharp.pdf.pdfdocument)<br>
The document that owns this object.

## Methods

### **CreatePdfEmbeddedGoToAction(String, Nullable&lt;Boolean&gt;)**

Creates a link to an embedded document.

```csharp
public static PdfEmbeddedGoToAction CreatePdfEmbeddedGoToAction(string destinationPath, Nullable<bool> newWindow)
```

#### Parameters

`destinationPath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The path to the named destination through the embedded documents.
 The path is separated by '\' and the last segment is the name of the named destination.
 The other segments describe the route from the current (root or embedded) document to the embedded document holding the destination.
 ".." references to the parent, other strings refer to a child with this name in the EmbeddedFiles name dictionary.

`newWindow` [Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>
True, if the destination document shall be opened in a new window.
 If not set, the viewer application should behave in accordance with the current user preference.

#### Returns

[PdfEmbeddedGoToAction](./pdfsharp.pdf.actions.pdfembeddedgotoaction)<br>

### **CreatePdfEmbeddedGoToAction(String, String, Nullable&lt;Boolean&gt;)**

Creates a link to an embedded document in another document.

```csharp
public static PdfEmbeddedGoToAction CreatePdfEmbeddedGoToAction(string documentPath, string destinationPath, Nullable<bool> newWindow)
```

#### Parameters

`documentPath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The path to the target document.

`destinationPath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The path to the named destination through the embedded documents in the target document.
 The path is separated by '\' and the last segment is the name of the named destination.
 The other segments describe the route from the root document to the embedded document.
 Each segment name refers to a child with this name in the EmbeddedFiles name dictionary.

`newWindow` [Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>
True, if the destination document shall be opened in a new window.
 If not set, the viewer application should behave in accordance with the current user preference.

#### Returns

[PdfEmbeddedGoToAction](./pdfsharp.pdf.actions.pdfembeddedgotoaction)<br>

### **WriteObject(PdfWriter)**

```csharp
internal void WriteObject(PdfWriter writer)
```

#### Parameters

`writer` [PdfWriter](./pdfsharp.pdf.io.pdfwriter)<br>
