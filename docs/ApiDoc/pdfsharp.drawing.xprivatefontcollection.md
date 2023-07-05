# XPrivateFontCollection

Namespace: PdfSharp.Drawing

Makes fonts that are not installed on the system available within the current application domain.<br>

```csharp
public sealed class XPrivateFontCollection
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [XPrivateFontCollection](./pdfsharp.drawing.xprivatefontcollection)

## Methods

### **AddFont(String)**

#### Caution

Use the GDI build of PDFsharp and use Add(Stream stream)

---

Adds the specified font data to the global PrivateFontCollection.
 Family name and style are automatically retrieved from the font.

```csharp
public static void AddFont(string filename)
```

#### Parameters

`filename` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **AddFont(Stream, String)**

#### Caution

Use the GDI build of PDFsharp and use Add(Stream stream)

---

Adds the specified font data to the global PrivateFontCollection.
 Family name and style are automatically retrieved from the font.

```csharp
public static void AddFont(Stream stream, string facename)
```

#### Parameters

`stream` [Stream](https://docs.microsoft.com/en-us/dotnet/api/system.io.stream)<br>

`facename` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **TryCreateTypeface(String, XFontStyleEx, XFontFamily&)**

```csharp
internal static XTypeface TryCreateTypeface(string name, XFontStyleEx style, XFontFamily& fontFamily)
```

#### Parameters

`name` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`style` [XFontStyleEx](./pdfsharp.drawing.xfontstyleex)<br>

`fontFamily` [XFontFamily&](./pdfsharp.drawing.xfontfamily&)<br>

#### Returns

[XTypeface](./pdfsharp.drawing.xtypeface)<br>
