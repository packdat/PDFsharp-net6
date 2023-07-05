# IFontResolver2

Namespace: PdfSharp.Fonts

Provides functionality that converts a requested typeface into a physical font.

```csharp
public interface IFontResolver2 : IFontResolverMarker
```

Implements [IFontResolverMarker](./pdfsharp.fonts.ifontresolvermarker)

## Methods

### **ResolveTypeface(String, XFontStyle, XFontWeight, XFontStretch)**

Converts specified information about a required typeface into a specific font.

```csharp
FontResolverInfo ResolveTypeface(string familyName, XFontStyle style, XFontWeight weight, XFontStretch stretch)
```

#### Parameters

`familyName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The font family of the typeface.

`style` [XFontStyle](./pdfsharp.drawing.xfontstyle)<br>
The style of the typeface.

`weight` [XFontWeight](./pdfsharp.drawing.xfontweight)<br>
The relative weight of the typeface.

`stretch` [XFontStretch](./pdfsharp.drawing.xfontstretch)<br>
The degree to which the typeface is stretched.

#### Returns

[FontResolverInfo](./pdfsharp.fonts.fontresolverinfo)<br>
Information about the physical font, or null if the request cannot be satisfied.

### **GetFont(String)**

Gets the bytes of a physical font with specified face name.

```csharp
ReadOnlyMemory<byte> GetFont(string faceName)
```

#### Parameters

`faceName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
A face name previously retrieved by ResolveTypeface.

#### Returns

[ReadOnlyMemory&lt;Byte&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.readonlymemory-1)<br>
