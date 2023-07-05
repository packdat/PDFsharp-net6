# XTypeface

Namespace: PdfSharp.Drawing

Represents a combination of XFontFamily, XFontWeight, XFontStyleEx, and XFontStretch.

```csharp
public class XTypeface
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [XTypeface](./pdfsharp.drawing.xtypeface)

## Properties

### **Family**

Gets the font family from which the typeface was constructed.

```csharp
public XFontFamily Family { get; }
```

#### Property Value

[XFontFamily](./pdfsharp.drawing.xfontfamily)<br>

### **Style**

Gets the style of the Typeface.

```csharp
public XFontStyle Style { get; }
```

#### Property Value

[XFontStyle](./pdfsharp.drawing.xfontstyle)<br>

### **Weight**

Gets the relative weight of the typeface.

```csharp
public XFontWeight Weight { get; }
```

#### Property Value

[XFontWeight](./pdfsharp.drawing.xfontweight)<br>

### **Stretch**

Gets the stretch value for the Typeface.
 The stretch value determines whether a typeface is expanded or condensed when it is displayed.

```csharp
public XFontStretch Stretch { get; }
```

#### Property Value

[XFontStretch](./pdfsharp.drawing.xfontstretch)<br>

## Constructors

### **XTypeface(String)**

Initializes a new instance of the [XTypeface](./pdfsharp.drawing.xtypeface) class.

```csharp
public XTypeface(string typefaceName)
```

#### Parameters

`typefaceName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
Name of the typeface.

### **XTypeface(XFontFamily, XFontStyle, XFontWeight, XFontStretch)**

Initializes a new instance of the [XTypeface](./pdfsharp.drawing.xtypeface) class.

```csharp
public XTypeface(XFontFamily family, XFontStyle style, XFontWeight weight, XFontStretch stretch)
```

#### Parameters

`family` [XFontFamily](./pdfsharp.drawing.xfontfamily)<br>
The font family of the typeface.

`style` [XFontStyle](./pdfsharp.drawing.xfontstyle)<br>
The style of the typeface.

`weight` [XFontWeight](./pdfsharp.drawing.xfontweight)<br>
The relative weight of the typeface.

`stretch` [XFontStretch](./pdfsharp.drawing.xfontstretch)<br>
The degree to which the typeface is stretched.

## Methods

### **TryGetGlyphTypeface(XGlyphTypeface&)**

Tries the get GlyphTypeface that corresponds to the Typeface.

```csharp
public bool TryGetGlyphTypeface(XGlyphTypeface& glyphTypeface)
```

#### Parameters

`glyphTypeface` [XGlyphTypeface&](./pdfsharp.drawing.xglyphtypeface&)<br>
The glyph typeface that corresponds to this typeface,
 or null if the typeface was constructed from a composite font.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
