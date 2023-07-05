# PdfOutline

Namespace: PdfSharp.Pdf

Represents an outline item in the outlines tree. An 'outline' is also known as a 'bookmark'.

```csharp
public sealed class PdfOutline : PdfDictionary, System.ICloneable, System.Collections.Generic.IEnumerable`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib, Version=6.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e],[PdfSharp.Pdf.PdfItem, PdfSharp, Version=0.1.2.0, Culture=neutral, PublicKeyToken=null]], System.Private.CoreLib, Version=6.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e]], System.Collections.IEnumerable
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [PdfItem](./pdfsharp.pdf.pdfitem) → [PdfObject](./pdfsharp.pdf.pdfobject) → [PdfDictionary](./pdfsharp.pdf.pdfdictionary) → [PdfOutline](./pdfsharp.pdf.pdfoutline)<br>
Implements [ICloneable](https://docs.microsoft.com/en-us/dotnet/api/system.icloneable), [IEnumerable&lt;KeyValuePair&lt;String, PdfItem&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1), [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.ienumerable)

## Properties

### **Parent**

Gets the parent of this outline item. The root item has no parent and returns null.

```csharp
public PdfOutline Parent { get; internal set; }
```

#### Property Value

[PdfOutline](./pdfsharp.pdf.pdfoutline)<br>

### **Title**

Gets or sets the title.

```csharp
public string Title { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **DestinationPage**

Gets or sets the destination page.

```csharp
public PdfPage DestinationPage { get; set; }
```

#### Property Value

[PdfPage](./pdfsharp.pdf.pdfpage)<br>

### **Left**

Gets or sets the left position of the page positioned at the left side of the window.
 Applies only if PageDestinationType is Xyz, FitV, FitR, or FitBV.

```csharp
public Nullable<double> Left { get; set; }
```

#### Property Value

[Nullable&lt;Double&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Top**

Gets or sets the top position of the page positioned at the top side of the window.
 Applies only if PageDestinationType is Xyz, FitH, FitR, ob FitBH.

```csharp
public Nullable<double> Top { get; set; }
```

#### Property Value

[Nullable&lt;Double&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Right**

Gets or sets the right position of the page positioned at the right side of the window.
 Applies only if PageDestinationType is FitR.

```csharp
public double Right { get; set; }
```

#### Property Value

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **Bottom**

Gets or sets the bottom position of the page positioned at the bottom side of the window.
 Applies only if PageDestinationType is FitR.

```csharp
public double Bottom { get; set; }
```

#### Property Value

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **Zoom**

Gets or sets the zoom faction of the page.
 Applies only if PageDestinationType is Xyz.

```csharp
public Nullable<double> Zoom { get; set; }
```

#### Property Value

[Nullable&lt;Double&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Opened**

Gets or sets whether the outline item is opened (or expanded).

```csharp
public bool Opened { get; set; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **Style**

Gets or sets the style of the outline text.

```csharp
public PdfOutlineStyle Style { get; set; }
```

#### Property Value

[PdfOutlineStyle](./pdfsharp.pdf.pdfoutlinestyle)<br>

### **PageDestinationType**

Gets or sets the type of the page destination.

```csharp
public PdfPageDestinationType PageDestinationType { get; set; }
```

#### Property Value

[PdfPageDestinationType](./pdfsharp.pdf.pdfpagedestinationtype)<br>

### **TextColor**

Gets or sets the color of the text.

```csharp
public XColor TextColor { get; set; }
```

#### Property Value

[XColor](./pdfsharp.drawing.xcolor)<br>
The color of the text.

### **HasChildren**

Gets a value indicating whether this outline object has child items.

```csharp
public bool HasChildren { get; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **Outlines**

Gets the outline collection of this node.

```csharp
public PdfOutlineCollection Outlines { get; }
```

#### Property Value

[PdfOutlineCollection](./pdfsharp.pdf.pdfoutlinecollection)<br>

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

### **PdfOutline()**

Initializes a new instance of the [PdfOutline](./pdfsharp.pdf.pdfoutline) class.

```csharp
public PdfOutline()
```

### **PdfOutline(PdfDictionary)**

Initializes a new instance from an existing dictionary. Used for object type transformation.

```csharp
public PdfOutline(PdfDictionary dict)
```

#### Parameters

`dict` [PdfDictionary](./pdfsharp.pdf.pdfdictionary)<br>

### **PdfOutline(String, PdfPage, Boolean, PdfOutlineStyle, XColor)**

Initializes a new instance of the [PdfOutline](./pdfsharp.pdf.pdfoutline) class.

```csharp
public PdfOutline(string title, PdfPage destinationPage, bool opened, PdfOutlineStyle style, XColor textColor)
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

### **PdfOutline(String, PdfPage, Boolean, PdfOutlineStyle)**

Initializes a new instance of the [PdfOutline](./pdfsharp.pdf.pdfoutline) class.

```csharp
public PdfOutline(string title, PdfPage destinationPage, bool opened, PdfOutlineStyle style)
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

### **PdfOutline(String, PdfPage, Boolean)**

Initializes a new instance of the [PdfOutline](./pdfsharp.pdf.pdfoutline) class.

```csharp
public PdfOutline(string title, PdfPage destinationPage, bool opened)
```

#### Parameters

`title` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The outline text.

`destinationPage` [PdfPage](./pdfsharp.pdf.pdfpage)<br>
The destination page.

`opened` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
Specifies whether the node is displayed expanded (opened) or collapsed.

### **PdfOutline(String, PdfPage)**

Initializes a new instance of the [PdfOutline](./pdfsharp.pdf.pdfoutline) class.

```csharp
public PdfOutline(string title, PdfPage destinationPage)
```

#### Parameters

`title` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The outline text.

`destinationPage` [PdfPage](./pdfsharp.pdf.pdfpage)<br>
The destination page.

## Methods

### **CountOpen()**

Counts the open outline items. Not yet used.

```csharp
internal int CountOpen()
```

#### Returns

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **PrepareForSave()**

Creates key/values pairs according to the object structure.

```csharp
internal void PrepareForSave()
```

### **WriteObject(PdfWriter)**

```csharp
internal void WriteObject(PdfWriter writer)
```

#### Parameters

`writer` [PdfWriter](./pdfsharp.pdf.io.pdfwriter)<br>
