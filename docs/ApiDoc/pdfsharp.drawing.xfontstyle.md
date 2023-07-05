# XFontStyle

Namespace: PdfSharp.Drawing

Defines a structure that represents the style of a font face as normal, italic, or oblique.

```csharp
public struct XFontStyle
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ValueType](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype) → [XFontStyle](./pdfsharp.drawing.xfontstyle)<br>
Implements [IFormattable](https://docs.microsoft.com/en-us/dotnet/api/system.iformattable)

## Methods

### **Equals(XFontStyle)**

Compares a  with the current  instance for equality.

```csharp
bool Equals(XFontStyle obj)
```

#### Parameters

`obj` [XFontStyle](./pdfsharp.drawing.xfontstyle)<br>
An instance of  to compare for equality.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
to show the two instances are equal; otherwise, .

### **Equals(Object)**

Compares an [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) with the current  instance for equality.

```csharp
bool Equals(object obj)
```

#### Parameters

`obj` [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)<br>
An [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) value that represents the  to compare for equality.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
to show the two instances are equal; otherwise, .

### **GetHashCode()**

Retrieves the hash code for this object.

```csharp
int GetHashCode()
```

#### Returns

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
A 32-bit hash code, which is a signed integer.

### **ToString()**

Creates a [String](https://docs.microsoft.com/en-us/dotnet/api/system.string) that represents the current  object and is based on the [CultureInfo.CurrentCulture](https://docs.microsoft.com/en-us/dotnet/api/system.globalization.cultureinfo.currentculture) property information.

```csharp
string ToString()
```

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
A [String](https://docs.microsoft.com/en-us/dotnet/api/system.string) that represents the value of the  object, such as "Normal", "Italic", or "Oblique".

### **GetStyleForInternalConstruction()**

```csharp
int GetStyleForInternalConstruction()
```

#### Returns

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **FromGdiFontStyle(XFontStyleEx)**

Simple hack to make it work...
 Returns Normal or Italic - bold, underline and such get lost here.

```csharp
XFontStyle FromGdiFontStyle(XFontStyleEx style)
```

#### Parameters

`style` [XFontStyleEx](./pdfsharp.drawing.xfontstyleex)<br>

#### Returns

[XFontStyle](./pdfsharp.drawing.xfontstyle)<br>
