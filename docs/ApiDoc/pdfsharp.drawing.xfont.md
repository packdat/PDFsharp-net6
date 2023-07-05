# XFont

Namespace: PdfSharp.Drawing

Defines an object used to draw text.

```csharp
public sealed class XFont
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [XFont](./pdfsharp.drawing.xfont)

## Properties

### **FontFamily**

Gets the XFontFamily object associated with this XFont object.

```csharp
public XFontFamily FontFamily { get; }
```

#### Property Value

[XFontFamily](./pdfsharp.drawing.xfontfamily)<br>

### **Name**

WRONG: Gets the face name of this Font object.
 Indeed, it returns the font family name.

```csharp
public string Name { get; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **FromDocument**

Indicates, whether this font was created from an existing document.<br>
 Intended to avoid unnecessary adding of new Fonts to the document when filling existing AcroForms.

```csharp
public bool FromDocument { get; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **DocumentFontName**

Gets or sets the name this Font is referenced by in an existing document

```csharp
public string DocumentFontName { get; internal set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Size**

Gets the em-size of this font measured in the unit of this font object.

```csharp
public double Size { get; }
```

#### Property Value

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **Style**

Gets style information for this Font object.

```csharp
public XFontStyleEx Style { get; }
```

#### Property Value

[XFontStyleEx](./pdfsharp.drawing.xfontstyleex)<br>

### **Bold**

Indicates whether this XFont object is bold.

```csharp
public bool Bold { get; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **Italic**

Indicates whether this XFont object is italic.

```csharp
public bool Italic { get; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **Strikeout**

Indicates whether this XFont object is stroke out.

```csharp
public bool Strikeout { get; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **Underline**

Indicates whether this XFont object is underlined.

```csharp
public bool Underline { get; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **PdfOptions**

Gets the PDF options of the font.

```csharp
public XPdfFontOptions PdfOptions { get; }
```

#### Property Value

[XPdfFontOptions](./pdfsharp.drawing.xpdffontoptions)<br>

### **CellSpace**

Gets the cell space for the font. The CellSpace is the line spacing, the sum of CellAscent and CellDescent and optionally some extra space.

```csharp
public int CellSpace { get; internal set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **CellAscent**

Gets the cell ascent, the area above the base line that is used by the font.

```csharp
public int CellAscent { get; internal set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **CellDescent**

Gets the cell descent, the area below the base line that is used by the font.

```csharp
public int CellDescent { get; internal set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **Metrics**

Gets the font metrics.

```csharp
public XFontMetrics Metrics { get; }
```

#### Property Value

[XFontMetrics](./pdfsharp.drawing.xfontmetrics)<br>
The metrics.

### **Height**

Gets the line spacing of this font.

```csharp
public int Height { get; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

## Constructors

### **XFont(String, Double)**

Initializes a new instance of the [XFont](./pdfsharp.drawing.xfont) class.

```csharp
public XFont(string familyName, double emSize)
```

#### Parameters

`familyName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
Name of the font family.

`emSize` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The em size.

### **XFont(String, Double, XFontStyleEx)**

Initializes a new instance of the [XFont](./pdfsharp.drawing.xfont) class.

```csharp
public XFont(string familyName, double emSize, XFontStyleEx style)
```

#### Parameters

`familyName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
Name of the font family.

`emSize` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The em size.

`style` [XFontStyleEx](./pdfsharp.drawing.xfontstyleex)<br>
The font style.

### **XFont(String, Double, XFontStyleEx, XPdfFontOptions)**

Initializes a new instance of the [XFont](./pdfsharp.drawing.xfont) class.

```csharp
public XFont(string familyName, double emSize, XFontStyleEx style, XPdfFontOptions pdfOptions)
```

#### Parameters

`familyName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
Name of the font family.

`emSize` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The em size.

`style` [XFontStyleEx](./pdfsharp.drawing.xfontstyleex)<br>
The font style.

`pdfOptions` [XPdfFontOptions](./pdfsharp.drawing.xpdffontoptions)<br>
Additional PDF options.

### **XFont(String, Double, XFontStyle, XFontWeight, XFontStretch, XPdfFontOptions, Nullable&lt;XStyleSimulations&gt;)**

#### Caution

Not yet implemented.

---

Initializes a new instance of the [XFont](./pdfsharp.drawing.xfont) class.
 Not yet implemented.

```csharp
public XFont(string familyName, double emSize, XFontStyle style, XFontWeight weight, XFontStretch fontStretch, XPdfFontOptions pdfOptions, Nullable<XStyleSimulations> styleSimulations)
```

#### Parameters

`familyName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
Name of the family.

`emSize` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The em size.

`style` [XFontStyle](./pdfsharp.drawing.xfontstyle)<br>
The style.

`weight` [XFontWeight](./pdfsharp.drawing.xfontweight)<br>
The weight.

`fontStretch` [XFontStretch](./pdfsharp.drawing.xfontstretch)<br>
The font stretch.

`pdfOptions` [XPdfFontOptions](./pdfsharp.drawing.xpdffontoptions)<br>
The PDF options.

`styleSimulations` [Nullable&lt;XStyleSimulations&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>
The style simulations.

#### Exceptions

[NotImplementedException](https://docs.microsoft.com/en-us/dotnet/api/system.notimplementedexception)<br>
XFont

### **XFont(XTypeface, Double, XPdfFontOptions, Nullable&lt;XStyleSimulations&gt;)**

#### Caution

Not yet implemented.

---

Initializes a new instance of the [XFont](./pdfsharp.drawing.xfont) class.
 Not yet implemented.

```csharp
public XFont(XTypeface typeface, double emSize, XPdfFontOptions pdfOptions, Nullable<XStyleSimulations> styleSimulations)
```

#### Parameters

`typeface` [XTypeface](./pdfsharp.drawing.xtypeface)<br>
The typeface.

`emSize` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The em size.

`pdfOptions` [XPdfFontOptions](./pdfsharp.drawing.xpdffontoptions)<br>
The PDF options.

`styleSimulations` [Nullable&lt;XStyleSimulations&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>
The style simulations.

#### Exceptions

[NotImplementedException](https://docs.microsoft.com/en-us/dotnet/api/system.notimplementedexception)<br>
XFont

## Methods

### **GetHeight()**

Returns the line spacing, in pixels, of this font. The line spacing is the vertical distance
 between the base lines of two consecutive lines of text. Thus, the line spacing includes the
 blank space between lines along with the height of the character itself.

```csharp
public double GetHeight()
```

#### Returns

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **GetHeight(XGraphics)**

#### Caution

Use GetHeight() without parameter.

---

Returns the line spacing, in the current unit of a specified Graphics object, of this font.
 The line spacing is the vertical distance between the base lines of two consecutive lines of
 text. Thus, the line spacing includes the blank space between lines along with the height of

```csharp
public double GetHeight(XGraphics graphics)
```

#### Parameters

`graphics` [XGraphics](./pdfsharp.drawing.xgraphics)<br>

#### Returns

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **GetGlyphList()**

Gets the list of characters supported by this font

```csharp
public IList<char> GetGlyphList()
```

#### Returns

[IList&lt;Char&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1)<br>
The list of characters supported by this font
