# IFontResolver

Namespace: PdfSharp.Fonts

Provides functionality that converts a requested typeface into a physical font.

```csharp
public interface IFontResolver : IFontResolverMarker
```

Implements [IFontResolverMarker](./pdfsharp.fonts.ifontresolvermarker)

## Methods

### **ResolveTypeface(String, Boolean, Boolean)**

Converts specified information about a required typeface into a specific font.

```csharp
FontResolverInfo ResolveTypeface(string familyName, bool isBold, bool isItalic)
```

#### Parameters

`familyName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
Name of the font family.

`isBold` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
Set to `true` when a bold fontface is required.

`isItalic` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
Set to `true` when an italic fontface is required.

#### Returns

[FontResolverInfo](./pdfsharp.fonts.fontresolverinfo)<br>
Information about the physical font, or null if the request cannot be satisfied.

### **GetFont(String)**

Gets the bytes of a physical font with specified face name.

```csharp
Byte[] GetFont(string faceName)
```

#### Parameters

`faceName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
A face name previously retrieved by ResolveTypeface.

#### Returns

[Byte[]](https://docs.microsoft.com/en-us/dotnet/api/system.byte)<br>
