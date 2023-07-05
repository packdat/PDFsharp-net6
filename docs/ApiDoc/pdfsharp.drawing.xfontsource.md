# XFontSource

Namespace: PdfSharp.Drawing

The bytes of a font file.

```csharp
public class XFontSource
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [XFontSource](./pdfsharp.drawing.xfontsource)

## Properties

### **FontName**

Gets the name of the font's name table.

```csharp
public string FontName { get; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Bytes**

Gets the bytes of the font.

```csharp
public Byte[] Bytes { get; }
```

#### Property Value

[Byte[]](https://docs.microsoft.com/en-us/dotnet/api/system.byte)<br>

## Methods

### **GetOrCreateFrom(Byte[])**

Gets an existing font source or creates a new one.
 A new font source is cached in font factory.

```csharp
public static XFontSource GetOrCreateFrom(Byte[] bytes)
```

#### Parameters

`bytes` [Byte[]](https://docs.microsoft.com/en-us/dotnet/api/system.byte)<br>

#### Returns

[XFontSource](./pdfsharp.drawing.xfontsource)<br>

### **GetOrCreateFromGlyphTypeface(String, XGlyphTypeface)**

```csharp
internal static XFontSource GetOrCreateFromGlyphTypeface(string typefaceKey, XGlyphTypeface glyphTypeface)
```

#### Parameters

`typefaceKey` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`glyphTypeface` [XGlyphTypeface](./pdfsharp.drawing.xglyphtypeface)<br>

#### Returns

[XFontSource](./pdfsharp.drawing.xfontsource)<br>

### **CreateCompiledFont(Byte[])**

Creates a font source from a byte array.

```csharp
public static XFontSource CreateCompiledFont(Byte[] bytes)
```

#### Parameters

`bytes` [Byte[]](https://docs.microsoft.com/en-us/dotnet/api/system.byte)<br>

#### Returns

[XFontSource](./pdfsharp.drawing.xfontsource)<br>

### **GetHashCode()**

Returns a hash code for this instance.

```csharp
public int GetHashCode()
```

#### Returns

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **Equals(Object)**

Determines whether the specified object is equal to the current object.

```csharp
public bool Equals(object obj)
```

#### Parameters

`obj` [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)<br>
The object to compare with the current object.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
if the specified object is equal to the current object; otherwise, .
