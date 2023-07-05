# DocumentFontResolver

Namespace: PdfSharp.Fonts

Resolves the 14 standard-fonts and/or fonts in existing documents.<br>

```csharp
public class DocumentFontResolver : IFontResolver, IFontResolverMarker
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [DocumentFontResolver](./pdfsharp.fonts.documentfontresolver)<br>
Implements [IFontResolver](./pdfsharp.fonts.ifontresolver), [IFontResolverMarker](./pdfsharp.fonts.ifontresolvermarker)

## Constructors

### **DocumentFontResolver(PdfDocument)**

Creates a new instance of the [DocumentFontResolver](./pdfsharp.fonts.documentfontresolver)

```csharp
public DocumentFontResolver(PdfDocument document)
```

#### Parameters

`document` [PdfDocument](./pdfsharp.pdf.pdfdocument)<br>

## Methods

### **GetFont(String)**

Gets the data for the specified font.

```csharp
public Byte[] GetFont(string faceName)
```

#### Parameters

`faceName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
Name of the font

#### Returns

[Byte[]](https://docs.microsoft.com/en-us/dotnet/api/system.byte)<br>
Font data or null, if no font with the specified name could be found

### **ResolveTypeface(String, Boolean, Boolean)**

Get a [FontResolverInfo](./pdfsharp.fonts.fontresolverinfo) for the specified font

```csharp
public FontResolverInfo ResolveTypeface(string familyName, bool isBold, bool isItalic)
```

#### Parameters

`familyName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
Name of the font

`isBold` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

`isItalic` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

#### Returns

[FontResolverInfo](./pdfsharp.fonts.fontresolverinfo)<br>
A [FontResolverInfo](./pdfsharp.fonts.fontresolverinfo) or null, if no font with the specified name could be found
