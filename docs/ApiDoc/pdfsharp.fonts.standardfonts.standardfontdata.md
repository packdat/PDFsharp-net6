# StandardFontData

Namespace: PdfSharp.Fonts.StandardFonts

Provides the data for the 14 Standard-Fonts defined in the PDF-specification.<br>
 Pdf spec. 1.7, Chapter 9.6.2.2: Standard Type 1 Fonts (Standard 14 Fonts)<br>
 Mainly intended for existing documents which use one or more of the standard-fonts without embedding them.<br>
 Used in conjunction with the [DocumentFontResolver](./pdfsharp.fonts.documentfontresolver)

```csharp
public static class StandardFontData
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [StandardFontData](./pdfsharp.fonts.standardfonts.standardfontdata)

## Properties

### **FontNames**

Get the names of the supported standard-fonts

```csharp
public static IEnumerable<string> FontNames { get; }
```

#### Property Value

[IEnumerable&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)<br>

## Methods

### **GetFontData(String)**

Gets the data for the specified font

```csharp
public static Byte[] GetFontData(string fontName)
```

#### Parameters

`fontName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
Name of the font

#### Returns

[Byte[]](https://docs.microsoft.com/en-us/dotnet/api/system.byte)<br>
Font-data or null if a font with the specified name could not be found

### **IsStandardFont(String)**

Indicates, whether the specified  is one of the 14 Standard-Fonts

```csharp
public static bool IsStandardFont(string fontName)
```

#### Parameters

`fontName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
Font-name to check

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
true, if  is one of the 14 Standard-Fonts, otherwise false
