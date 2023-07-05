# PlatformFontResolver

Namespace: PdfSharp.Fonts

Default platform specific font resolving.

```csharp
public static class PlatformFontResolver
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [PlatformFontResolver](./pdfsharp.fonts.platformfontresolver)

## Methods

### **ResolveTypeface(String, Boolean, Boolean)**

Resolves the typeface by generating a font resolver info.

```csharp
public static FontResolverInfo ResolveTypeface(string familyName, bool isBold, bool isItalic)
```

#### Parameters

`familyName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
Name of the font family.

`isBold` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
Indicates whether a bold font is requested.

`isItalic` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
Indicates whether an italic font is requested.

#### Returns

[FontResolverInfo](./pdfsharp.fonts.fontresolverinfo)<br>

### **ResolveTypeface(String, FontResolvingOptions, String)**

Internal implementation.

```csharp
internal static FontResolverInfo ResolveTypeface(string familyName, FontResolvingOptions fontResolvingOptions, string typefaceKey)
```

#### Parameters

`familyName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`fontResolvingOptions` [FontResolvingOptions](./pdfsharp.fonts.internal.fontresolvingoptions)<br>

`typefaceKey` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

#### Returns

[FontResolverInfo](./pdfsharp.fonts.fontresolverinfo)<br>

### **CreateFontSource(String, FontResolvingOptions, XFontFamily&, XTypeface&, XGlyphTypeface&, String)**

Creates an XGlyphTypeface.

```csharp
internal static XFontSource CreateFontSource(string familyName, FontResolvingOptions fontResolvingOptions, XFontFamily& fontFamily, XTypeface& typeface, XGlyphTypeface& glyphTypeface, string typefaceKey)
```

#### Parameters

`familyName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`fontResolvingOptions` [FontResolvingOptions](./pdfsharp.fonts.internal.fontresolvingoptions)<br>

`fontFamily` [XFontFamily&](./pdfsharp.drawing.xfontfamily&)<br>

`typeface` [XTypeface&](./pdfsharp.drawing.xtypeface&)<br>

`glyphTypeface` [XGlyphTypeface&](./pdfsharp.drawing.xglyphtypeface&)<br>

`typefaceKey` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

#### Returns

[XFontSource](./pdfsharp.drawing.xfontsource)<br>
