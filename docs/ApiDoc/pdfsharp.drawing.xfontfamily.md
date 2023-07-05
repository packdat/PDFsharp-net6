# XFontFamily

Namespace: PdfSharp.Drawing

Defines a group of typefaces having a similar basic design and certain variations in styles.

```csharp
public sealed class XFontFamily
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [XFontFamily](./pdfsharp.drawing.xfontfamily)

## Properties

### **Name**

Gets the name of the font family.

```csharp
public string Name { get; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Families**

#### Caution

Use platform API directly.

---

Returns an array that contains all the FontFamily objects associated with the current graphics context.

```csharp
public static XFontFamily[] Families { get; }
```

#### Property Value

[XFontFamily[]](./pdfsharp.drawing.xfontfamily)<br>

## Constructors

### **XFontFamily(String)**

Initializes a new instance of the [XFontFamily](./pdfsharp.drawing.xfontfamily) class.

```csharp
public XFontFamily(string familyName)
```

#### Parameters

`familyName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The family name of a font.

## Methods

### **CreateFromName_not_used(String, Boolean)**

```csharp
internal static XFontFamily CreateFromName_not_used(string name, bool createPlatformFamily)
```

#### Parameters

`name` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`createPlatformFamily` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

#### Returns

[XFontFamily](./pdfsharp.drawing.xfontfamily)<br>

### **GetOrCreateFontFamily(String)**

An XGlyphTypeface for a font source that comes from a custom font resolver
 creates a solitary font family exclusively for it.

```csharp
internal static XFontFamily GetOrCreateFontFamily(string name)
```

#### Parameters

`name` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

#### Returns

[XFontFamily](./pdfsharp.drawing.xfontfamily)<br>

### **GetCellAscent(XFontStyleEx)**

Returns the cell ascent, in design units, of the XFontFamily object of the specified style.

```csharp
public int GetCellAscent(XFontStyleEx style)
```

#### Parameters

`style` [XFontStyleEx](./pdfsharp.drawing.xfontstyleex)<br>

#### Returns

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **GetCellDescent(XFontStyleEx)**

Returns the cell descent, in design units, of the XFontFamily object of the specified style.

```csharp
public int GetCellDescent(XFontStyleEx style)
```

#### Parameters

`style` [XFontStyleEx](./pdfsharp.drawing.xfontstyleex)<br>

#### Returns

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **GetEmHeight(XFontStyleEx)**

Gets the height, in font design units, of the em square for the specified style.

```csharp
public int GetEmHeight(XFontStyleEx style)
```

#### Parameters

`style` [XFontStyleEx](./pdfsharp.drawing.xfontstyleex)<br>

#### Returns

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **GetLineSpacing(XFontStyleEx)**

Returns the line spacing, in design units, of the FontFamily object of the specified style.
 The line spacing is the vertical distance between the base lines of two consecutive lines of text.

```csharp
public int GetLineSpacing(XFontStyleEx style)
```

#### Parameters

`style` [XFontStyleEx](./pdfsharp.drawing.xfontstyleex)<br>

#### Returns

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **IsStyleAvailable(XFontStyleEx)**

Indicates whether the specified FontStyle enumeration is available.

```csharp
public bool IsStyleAvailable(XFontStyleEx style)
```

#### Parameters

`style` [XFontStyleEx](./pdfsharp.drawing.xfontstyleex)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **GetFamilies(XGraphics)**

#### Caution

Use platform API directly.

---

Returns an array that contains all the FontFamily objects available for the specified 
 graphics context.

```csharp
public static XFontFamily[] GetFamilies(XGraphics graphics)
```

#### Parameters

`graphics` [XGraphics](./pdfsharp.drawing.xgraphics)<br>

#### Returns

[XFontFamily[]](./pdfsharp.drawing.xfontfamily)<br>
