# PdfWidgetAnnotation

Namespace: PdfSharp.Pdf.Annotations

Represents a text annotation.

```csharp
public sealed class PdfWidgetAnnotation : PdfAnnotation, System.ICloneable, System.Collections.Generic.IEnumerable`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib, Version=6.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e],[PdfSharp.Pdf.PdfItem, PdfSharp, Version=0.1.3.0, Culture=neutral, PublicKeyToken=null]], System.Private.CoreLib, Version=6.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e]], System.Collections.IEnumerable
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [PdfItem](./pdfsharp.pdf.pdfitem) → [PdfObject](./pdfsharp.pdf.pdfobject) → [PdfDictionary](./pdfsharp.pdf.pdfdictionary) → [PdfAnnotation](./pdfsharp.pdf.annotations.pdfannotation) → [PdfWidgetAnnotation](./pdfsharp.pdf.annotations.pdfwidgetannotation)<br>
Implements [ICloneable](https://docs.microsoft.com/en-us/dotnet/api/system.icloneable), [IEnumerable&lt;KeyValuePair&lt;String, PdfItem&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1), [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.ienumerable)

## Properties

### **BackColor**

Gets or sets the background color of the field.

```csharp
public XColor BackColor { get; set; }
```

#### Property Value

[XColor](./pdfsharp.drawing.xcolor)<br>

### **BorderColor**

Gets or sets the border color of the field.

```csharp
public XColor BorderColor { get; set; }
```

#### Property Value

[XColor](./pdfsharp.drawing.xcolor)<br>

### **Rotation**

Gets or sets the Rotation of this Widget in counter-clockwise direction.

```csharp
public int Rotation { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **CaptionPlacement**

Gets or sets the placement of the widget's caption relative to it's icon<br>
 Only applies to [PdfPushButtonField](./pdfsharp.pdf.acroforms.pdfpushbuttonfield)s

```csharp
public CaptionPosition CaptionPlacement { get; set; }
```

#### Property Value

[CaptionPosition](./pdfsharp.pdf.annotations.pdfwidgetannotation.captionposition)<br>

### **Highlighting**

Gets or sets the annotation’s highlighting mode, the visual effect to be used when
 the mouse button is pressed or held down inside its active area

```csharp
public HighlightingMode Highlighting { get; set; }
```

#### Property Value

[HighlightingMode](./pdfsharp.pdf.annotations.pdfwidgetannotation.highlightingmode)<br>

### **NormalCaption**

Gets or sets the normal Caption of this Annotation.<br>
 Only applies to [PdfButtonField](./pdfsharp.pdf.acroforms.pdfbuttonfield)s

```csharp
public string NormalCaption { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

**Remarks:**

see PdfReference 1.7, Chapter 12.5.6.19: Widget Annotations

### **RolloverCaption**

Gets or sets the rollover Caption of this Annotation which shall be displayed
 when the user rolls the cursor into its active area without pressing the mouse button.<br>
 Only applies to [PdfPushButtonField](./pdfsharp.pdf.acroforms.pdfpushbuttonfield)s

```csharp
public string RolloverCaption { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **DownCaption**

Gets or sets the down Caption of this Annotation which shall be displayed
 when the mouse button is pressed within its active area.<br>
 Only applies to [PdfPushButtonField](./pdfsharp.pdf.acroforms.pdfpushbuttonfield)s

```csharp
public string DownCaption { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **NormalIcon**

The widget annotation’s normal icon, which shall be displayed when it is not interacting with the user.
 Only applies to [PdfPushButtonField](./pdfsharp.pdf.acroforms.pdfpushbuttonfield)s

```csharp
public PdfFormXObject NormalIcon { get; set; }
```

#### Property Value

[PdfFormXObject](./pdfsharp.pdf.advanced.pdfformxobject)<br>

### **RolloverIcon**

The widget annotation’s rollover icon, which shall be displayed
 when the user rolls the cursor into its active area without pressing the mouse button.
 Only applies to [PdfPushButtonField](./pdfsharp.pdf.acroforms.pdfpushbuttonfield)s

```csharp
public PdfFormXObject RolloverIcon { get; set; }
```

#### Property Value

[PdfFormXObject](./pdfsharp.pdf.advanced.pdfformxobject)<br>

### **DownIcon**

The widget annotation’s alternate (down) icon, which shall be displayed
 when the mouse button is pressed within its active area.
 Only applies to [PdfPushButtonField](./pdfsharp.pdf.acroforms.pdfpushbuttonfield)s

```csharp
public PdfFormXObject DownIcon { get; set; }
```

#### Property Value

[PdfFormXObject](./pdfsharp.pdf.advanced.pdfformxobject)<br>

### **ParentField**

Get the parent-field of this Widget, if it is the child of a [PdfAcroField](./pdfsharp.pdf.acroforms.pdfacrofield).

```csharp
public PdfObject ParentField { get; internal set; }
```

#### Property Value

[PdfObject](./pdfsharp.pdf.pdfobject)<br>

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

### **PdfWidgetAnnotation(PdfDictionary)**

Initializes a new instance of the [PdfWidgetAnnotation](./pdfsharp.pdf.annotations.pdfwidgetannotation) with the specified dictionary.

```csharp
public PdfWidgetAnnotation(PdfDictionary dict)
```

#### Parameters

`dict` [PdfDictionary](./pdfsharp.pdf.pdfdictionary)<br>

## Methods

### **PrepareForSave()**

```csharp
internal void PrepareForSave()
```
