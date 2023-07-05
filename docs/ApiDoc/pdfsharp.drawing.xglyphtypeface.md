# XGlyphTypeface

Namespace: PdfSharp.Drawing

Specifies a physical font face that corresponds to a font file on the disk or in memory.

```csharp
public sealed class XGlyphTypeface
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [XGlyphTypeface](./pdfsharp.drawing.xglyphtypeface)

## Properties

### **FontFamily**

Gets the font family of this glyph typeface.

```csharp
public XFontFamily FontFamily { get; }
```

#### Property Value

[XFontFamily](./pdfsharp.drawing.xfontfamily)<br>

### **FontSource**

Gets the font source of this glyph typeface.

```csharp
public XFontSource FontSource { get; }
```

#### Property Value

[XFontSource](./pdfsharp.drawing.xfontsource)<br>

### **FamilyName**

Gets the English family name of the font, for example "Arial".

```csharp
public string FamilyName { get; private set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **StyleName**

Gets the English subfamily name of the font,
 for example "Bold".

```csharp
public string StyleName { get; private set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **DisplayName**

Gets the English display name of the font,
 for example "Arial italic".

```csharp
public string DisplayName { get; private set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **IsBold**

Gets a value indicating whether the font weight is bold.

```csharp
public bool IsBold { get; private set; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **IsItalic**

Gets a value indicating whether the font style is italic.

```csharp
public bool IsItalic { get; private set; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **StyleSimulations**

Gets a value indicating whether the style bold, italic, or both styles must be simulated.

```csharp
public XStyleSimulations StyleSimulations { get; }
```

#### Property Value

[XStyleSimulations](./pdfsharp.drawing.xstylesimulations)<br>

## Methods

### **GetOrCreateFrom(String, FontResolvingOptions)**

```csharp
internal static XGlyphTypeface GetOrCreateFrom(string familyName, FontResolvingOptions fontResolvingOptions)
```

#### Parameters

`familyName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`fontResolvingOptions` [FontResolvingOptions](./pdfsharp.fonts.internal.fontresolvingoptions)<br>

#### Returns

[XGlyphTypeface](./pdfsharp.drawing.xglyphtypeface)<br>

### **GetBaseName()**

```csharp
internal string GetBaseName()
```

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **ComputeKey(String, FontResolvingOptions)**

Computes the bijective key for a typeface.

```csharp
internal static string ComputeKey(string familyName, FontResolvingOptions fontResolvingOptions)
```

#### Parameters

`familyName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`fontResolvingOptions` [FontResolvingOptions](./pdfsharp.fonts.internal.fontresolvingoptions)<br>

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **ComputeKey(String, Boolean, Boolean)**

Computes the bijective key for a typeface.

```csharp
internal static string ComputeKey(string familyName, bool isBold, bool isItalic)
```

#### Parameters

`familyName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`isBold` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

`isItalic` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
