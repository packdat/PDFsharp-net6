# PdfLinkAnnotation

Namespace: PdfSharp.Pdf.Annotations

Represents a link annotation.

```csharp
public sealed class PdfLinkAnnotation : PdfAnnotation, System.ICloneable, System.Collections.Generic.IEnumerable`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib, Version=6.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e],[PdfSharp.Pdf.PdfItem, PdfSharp, Version=0.1.2.0, Culture=neutral, PublicKeyToken=null]], System.Private.CoreLib, Version=6.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e]], System.Collections.IEnumerable
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [PdfItem](./pdfsharp.pdf.pdfitem) → [PdfObject](./pdfsharp.pdf.pdfobject) → [PdfDictionary](./pdfsharp.pdf.pdfdictionary) → [PdfAnnotation](./pdfsharp.pdf.annotations.pdfannotation) → [PdfLinkAnnotation](./pdfsharp.pdf.annotations.pdflinkannotation)<br>
Implements [ICloneable](https://docs.microsoft.com/en-us/dotnet/api/system.icloneable), [IEnumerable&lt;KeyValuePair&lt;String, PdfItem&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1), [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.ienumerable)

## Properties

### **Border**

Gets or sets the border-properties of this Annotation

```csharp
public PdfAnnotationBorder Border { get; set; }
```

#### Property Value

[PdfAnnotationBorder](./pdfsharp.pdf.annotations.pdfannotationborder)<br>

### **Flags**

Gets or sets the annotation flags of this instance.

```csharp
public PdfAnnotationFlags Flags { get; set; }
```

#### Property Value

[PdfAnnotationFlags](./pdfsharp.pdf.annotations.pdfannotationflags)<br>

### **Parent**

Gets or sets the PdfAnnotations object that this annotation belongs to.

```csharp
public PdfAnnotations Parent { get; set; }
```

#### Property Value

[PdfAnnotations](./pdfsharp.pdf.annotations.pdfannotations)<br>

### **Rectangle**

Gets or sets the annotation rectangle, defining the location of the annotation
 on the page in default user space units.

```csharp
public PdfRectangle Rectangle { get; set; }
```

#### Property Value

[PdfRectangle](./pdfsharp.pdf.pdfrectangle)<br>

### **Page**

Gets or sets the page for this Annotation

```csharp
public PdfPage Page { get; set; }
```

#### Property Value

[PdfPage](./pdfsharp.pdf.pdfpage)<br>

### **Title**

Gets or sets the text label to be displayed in the title bar of the annotation’s
 pop-up window when open and active. By convention, this entry identifies
 the user who added the annotation.

```csharp
public string Title { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Subject**

Gets or sets text representing a short description of the subject being
 addressed by the annotation.

```csharp
public string Subject { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Contents**

Gets or sets the text to be displayed for the annotation or, if this type of
 annotation does not display text, an alternate description of the annotation’s
 contents in human-readable form.

```csharp
public string Contents { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Color**

Gets or sets the color representing the components of the annotation. If the color
 has an alpha value other than 1, it is ignored. Use property Opacity to get or set the
 opacity of an annotation.

```csharp
public XColor Color { get; set; }
```

#### Property Value

[XColor](./pdfsharp.drawing.xcolor)<br>

### **Opacity**

Gets or sets the constant opacity value to be used in painting the annotation.
 This value applies to all visible elements of the annotation in its closed state
 (including its background and border) but not to the popup window that appears when
 the annotation is opened.

```csharp
public double Opacity { get; set; }
```

#### Property Value

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

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

### **PdfLinkAnnotation()**

Initializes a new instance of the [PdfLinkAnnotation](./pdfsharp.pdf.annotations.pdflinkannotation) class.

```csharp
public PdfLinkAnnotation()
```

### **PdfLinkAnnotation(PdfDocument)**

Initializes a new instance of the [PdfLinkAnnotation](./pdfsharp.pdf.annotations.pdflinkannotation) class.

```csharp
public PdfLinkAnnotation(PdfDocument document)
```

#### Parameters

`document` [PdfDocument](./pdfsharp.pdf.pdfdocument)<br>

## Methods

### **CreateDocumentLink(PdfRectangle, Int32)**

Creates a link within the current document.

```csharp
public static PdfLinkAnnotation CreateDocumentLink(PdfRectangle rect, int destinationPage)
```

#### Parameters

`rect` [PdfRectangle](./pdfsharp.pdf.pdfrectangle)<br>
The link area in default page coordinates.

`destinationPage` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The one-based destination page number.

#### Returns

[PdfLinkAnnotation](./pdfsharp.pdf.annotations.pdflinkannotation)<br>

### **CreateDocumentLink(PdfRectangle, String)**

Creates a link within the current document using a named destination.

```csharp
public static PdfLinkAnnotation CreateDocumentLink(PdfRectangle rect, string destinationName)
```

#### Parameters

`rect` [PdfRectangle](./pdfsharp.pdf.pdfrectangle)<br>
The link area in default page coordinates.

`destinationName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The named destination's name.

#### Returns

[PdfLinkAnnotation](./pdfsharp.pdf.annotations.pdflinkannotation)<br>

### **CreateDocumentLink(PdfRectangle, String, String, Nullable&lt;Boolean&gt;)**

Creates a link to an external PDF document using a named destination.

```csharp
public static PdfLinkAnnotation CreateDocumentLink(PdfRectangle rect, string documentPath, string destinationName, Nullable<bool> newWindow)
```

#### Parameters

`rect` [PdfRectangle](./pdfsharp.pdf.pdfrectangle)<br>
The link area in default page coordinates.

`documentPath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The path to the target document.

`destinationName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The named destination's name in the target document.

`newWindow` [Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>
True, if the destination document shall be opened in a new window.
 If not set, the viewer application should behave in accordance with the current user preference.

#### Returns

[PdfLinkAnnotation](./pdfsharp.pdf.annotations.pdflinkannotation)<br>

### **CreateEmbeddedDocumentLink(PdfRectangle, String, Nullable&lt;Boolean&gt;)**

Creates a link to an embedded document.

```csharp
public static PdfLinkAnnotation CreateEmbeddedDocumentLink(PdfRectangle rect, string destinationPath, Nullable<bool> newWindow)
```

#### Parameters

`rect` [PdfRectangle](./pdfsharp.pdf.pdfrectangle)<br>
The link area in default page coordinates.

`destinationPath` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The path to the named destination through the embedded documents.
 The path is separated by '\' and the last segment is the name of the named destination.
 The other segments describe the route from the current (root or embedded) document to the embedded document holding the destination.
 ".." references to the parent, other strings refer to a child with this name in the EmbeddedFiles name dictionary.

`newWindow` [Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>
True, if the destination document shall be opened in a new window.
 If not set, the viewer application should behave in accordance with the current user preference.

#### Returns

[PdfLinkAnnotation](./pdfsharp.pdf.annotations.pdflinkannotation)<br>

### **CreateEmbeddedDocumentLink(PdfRectangle, String, String, Nullable&lt;Boolean&gt;)**

Creates a link to an embedded document in another document.

```csharp
public static PdfLinkAnnotation CreateEmbeddedDocumentLink(PdfRectangle rect, string documentPath, string destinationPath, Nullable<bool> newWindow)
```

#### Parameters

`rect` [PdfRectangle](./pdfsharp.pdf.pdfrectangle)<br>
The link area in default page coordinates.

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

[PdfLinkAnnotation](./pdfsharp.pdf.annotations.pdflinkannotation)<br>

### **CreateWebLink(PdfRectangle, String)**

Creates a link to the web.

```csharp
public static PdfLinkAnnotation CreateWebLink(PdfRectangle rect, string url)
```

#### Parameters

`rect` [PdfRectangle](./pdfsharp.pdf.pdfrectangle)<br>

`url` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

#### Returns

[PdfLinkAnnotation](./pdfsharp.pdf.annotations.pdflinkannotation)<br>

### **CreateFileLink(PdfRectangle, String)**

Creates a link to a file.

```csharp
public static PdfLinkAnnotation CreateFileLink(PdfRectangle rect, string fileName)
```

#### Parameters

`rect` [PdfRectangle](./pdfsharp.pdf.pdfrectangle)<br>

`fileName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

#### Returns

[PdfLinkAnnotation](./pdfsharp.pdf.annotations.pdflinkannotation)<br>

### **WriteObject(PdfWriter)**

```csharp
internal void WriteObject(PdfWriter writer)
```

#### Parameters

`writer` [PdfWriter](./pdfsharp.pdf.io.pdfwriter)<br>
