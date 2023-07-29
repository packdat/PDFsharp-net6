# PdfAnnotation

Namespace: PdfSharp.Pdf.Annotations

Represents the base class of all annotations.

```csharp
public abstract class PdfAnnotation : PdfSharp.Pdf.PdfDictionary, System.ICloneable, System.Collections.Generic.IEnumerable`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib, Version=6.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e],[PdfSharp.Pdf.PdfItem, PdfSharp, Version=0.1.3.0, Culture=neutral, PublicKeyToken=null]], System.Private.CoreLib, Version=6.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e]], System.Collections.IEnumerable
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [PdfItem](./pdfsharp.pdf.pdfitem) → [PdfObject](./pdfsharp.pdf.pdfobject) → [PdfDictionary](./pdfsharp.pdf.pdfdictionary) → [PdfAnnotation](./pdfsharp.pdf.annotations.pdfannotation)<br>
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

## Methods

### **Delete()**

#### Caution

Use 'Parent.Remove(this)'

---

Removes an annotation from the document
 [PdfAnnotations.Remove(PdfAnnotation)](./pdfsharp.pdf.annotations.pdfannotations#removepdfannotation)

```csharp
public void Delete()
```

### **PlaceOnPage(PdfPage, PdfRectangle)**

Convenience-method that serves 2 purposes:<br>
 1: It allows setting the [PdfAnnotation.Page](./pdfsharp.pdf.annotations.pdfannotation#page) and the [PdfAnnotation.Rectangle](./pdfsharp.pdf.annotations.pdfannotation#rectangle) with one call<br>
 2: It eases placing the annotation on the page by using the top-left of the page as the origin<br>
 (as opposed to the bottom-left, which would be the case when using [PdfAnnotation.Rectangle](./pdfsharp.pdf.annotations.pdfannotation#rectangle) directly)

```csharp
public void PlaceOnPage(PdfPage page, PdfRectangle rectangle)
```

#### Parameters

`page` [PdfPage](./pdfsharp.pdf.pdfpage)<br>
The [PdfPage](./pdfsharp.pdf.pdfpage) the annotation should be placed on

`rectangle` [PdfRectangle](./pdfsharp.pdf.pdfrectangle)<br>
The rectangle of the Annotation. The position should be relative to the top-left of the page

### **DetermineBorder()**

Determines the border-characteristics of this annotation<br>
 PdfReference 1.7, Chapter 12.5.2 and 12.5.4

```csharp
protected void DetermineBorder()
```
