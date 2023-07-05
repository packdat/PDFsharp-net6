# FontsDevHelper

Namespace: PdfSharp.Internal

Internal stuff for development of PDFsharp.

```csharp
public static class FontsDevHelper
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [FontsDevHelper](./pdfsharp.internal.fontsdevhelper)

## Methods

### **CreateSpecialFont(String, Double, XFontStyleEx, XPdfFontOptions, XStyleSimulations)**

Creates font and enforces bold/italic simulation.

```csharp
public static XFont CreateSpecialFont(string familyName, double emSize, XFontStyleEx style, XPdfFontOptions pdfOptions, XStyleSimulations styleSimulations)
```

#### Parameters

`familyName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`emSize` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`style` [XFontStyleEx](./pdfsharp.drawing.xfontstyleex)<br>

`pdfOptions` [XPdfFontOptions](./pdfsharp.drawing.xpdffontoptions)<br>

`styleSimulations` [XStyleSimulations](./pdfsharp.drawing.xstylesimulations)<br>

#### Returns

[XFont](./pdfsharp.drawing.xfont)<br>

### **GetFontCachesState()**

Dumps the font caches to a string.

```csharp
public static string GetFontCachesState()
```

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
