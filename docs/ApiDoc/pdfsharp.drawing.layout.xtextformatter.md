# XTextFormatter

Namespace: PdfSharp.Drawing.Layout

Represents a very simple text formatter.
 If this class does not satisfy your needs on formatting paragraphs, I recommend taking a look
 at MigraDoc Foundation. Alternatively, you should copy this class in your own source code and modify it.

```csharp
public class XTextFormatter
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [XTextFormatter](./pdfsharp.drawing.layout.xtextformatter)

## Properties

### **Text**

Gets or sets the text.

```csharp
public string Text { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The text.

### **Font**

Gets or sets the font.

```csharp
public XFont Font { get; set; }
```

#### Property Value

[XFont](./pdfsharp.drawing.xfont)<br>

### **LayoutRectangle**

Gets or sets the bounding box of the layout.

```csharp
public XRect LayoutRectangle { get; set; }
```

#### Property Value

[XRect](./pdfsharp.drawing.xrect)<br>

### **Alignment**

Gets or sets the alignment of the text.

```csharp
public XParagraphAlignment Alignment { get; set; }
```

#### Property Value

[XParagraphAlignment](./pdfsharp.drawing.layout.xparagraphalignment)<br>

## Constructors

### **XTextFormatter(XGraphics)**

Initializes a new instance of the [XTextFormatter](./pdfsharp.drawing.layout.xtextformatter) class.

```csharp
public XTextFormatter(XGraphics gfx)
```

#### Parameters

`gfx` [XGraphics](./pdfsharp.drawing.xgraphics)<br>

## Methods

### **DrawString(String, XFont, XBrush, XRect)**

Draws the text.

```csharp
public void DrawString(string text, XFont font, XBrush brush, XRect layoutRectangle)
```

#### Parameters

`text` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The text to be drawn.

`font` [XFont](./pdfsharp.drawing.xfont)<br>
The font.

`brush` [XBrush](./pdfsharp.drawing.xbrush)<br>
The text brush.

`layoutRectangle` [XRect](./pdfsharp.drawing.xrect)<br>
The layout rectangle.

### **DrawString(String, XFont, XBrush, XRect, XStringFormat)**

Draws the text.

```csharp
public void DrawString(string text, XFont font, XBrush brush, XRect layoutRectangle, XStringFormat format)
```

#### Parameters

`text` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The text to be drawn.

`font` [XFont](./pdfsharp.drawing.xfont)<br>
The font.

`brush` [XBrush](./pdfsharp.drawing.xbrush)<br>
The text brush.

`layoutRectangle` [XRect](./pdfsharp.drawing.xrect)<br>
The layout rectangle.

`format` [XStringFormat](./pdfsharp.drawing.xstringformat)<br>
The format. Must be `XStringFormat.TopLeft`
