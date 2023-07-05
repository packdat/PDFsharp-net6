# GlobalFontSettings

Namespace: PdfSharp.Fonts

Provides functionality to specify information about the handling of fonts in the current application domain.

```csharp
public static class GlobalFontSettings
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [GlobalFontSettings](./pdfsharp.fonts.globalfontsettings)

## Fields

### **DefaultFontName**

The name of the default font.

```csharp
public static string DefaultFontName;
```

## Properties

### **FontResolver**

Gets or sets the global font resolver for the current application domain.
 This static function must be called only once and before any font operation was executed by PDFsharp.
 If this is not easily to obtain, e.g. because your code is running on a web server, you must provide the
 same instance of your font resolver in every subsequent setting of this property.
 In a web application set the font resolver in Global.asax.

```csharp
public static IFontResolver FontResolver { get; set; }
```

#### Property Value

[IFontResolver](./pdfsharp.fonts.ifontresolver)<br>

### **DefaultFontEncoding**

Gets or sets the default font encoding used for XFont objects where encoding is not explicitly specified.
 If it is not set, the default value is PdfFontEncoding.Unicode.
 If you are sure your document contains only Windows-1252 characters (see https://en.wikipedia.org/wiki/Windows-1252) 
 set default encoding to PdfFontEncoding.Windows1252.
 Must be set only once per app domain.

```csharp
public static PdfFontEncoding DefaultFontEncoding { get; set; }
```

#### Property Value

[PdfFontEncoding](./pdfsharp.pdf.pdffontencoding)<br>

## Methods

### **AddFontResolver(IFontResolverMarker)**

#### Caution

Not yet implemented.

---

Adds a font resolver. NYI

```csharp
public static void AddFontResolver(IFontResolverMarker fontResolver)
```

#### Parameters

`fontResolver` [IFontResolverMarker](./pdfsharp.fonts.ifontresolvermarker)<br>
The font resolver.

### **ResetFontResolvers()**

Resets the font resolvers and clears all internal cache.
 Intended to be used in unit tests only.

```csharp
public static void ResetFontResolvers()
```
