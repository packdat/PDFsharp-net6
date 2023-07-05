# XFontWeight

Namespace: PdfSharp.Drawing

Defines the density of a typeface, in terms of the lightness or heaviness of the strokes.

```csharp
public struct XFontWeight
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ValueType](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype) → [XFontWeight](./pdfsharp.drawing.xfontweight)<br>
Implements [IFormattable](https://docs.microsoft.com/en-us/dotnet/api/system.iformattable)

## Properties

### **Weight**

Gets the weight of the font, a value between 1 and 999.

```csharp
public int Weight { get; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

## Methods

### **Compare(XFontWeight, XFontWeight)**

Compares the specified font weights.

```csharp
int Compare(XFontWeight left, XFontWeight right)
```

#### Parameters

`left` [XFontWeight](./pdfsharp.drawing.xfontweight)<br>

`right` [XFontWeight](./pdfsharp.drawing.xfontweight)<br>

#### Returns

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **Equals(XFontWeight)**

Determines whether the specified [XFontWeight](./pdfsharp.drawing.xfontweight) is equal to the current [XFontWeight](./pdfsharp.drawing.xfontweight).

```csharp
bool Equals(XFontWeight obj)
```

#### Parameters

`obj` [XFontWeight](./pdfsharp.drawing.xfontweight)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **Equals(Object)**

Determines whether the specified [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) is equal to the current [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object).

```csharp
bool Equals(object obj)
```

#### Parameters

`obj` [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **GetHashCode()**

Serves as a hash function for this type.

```csharp
int GetHashCode()
```

#### Returns

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **ToString()**

Returns a [String](https://docs.microsoft.com/en-us/dotnet/api/system.string) that represents the current [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object).

```csharp
string ToString()
```

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **ConvertToString(String, IFormatProvider)**

```csharp
string ConvertToString(string format, IFormatProvider provider)
```

#### Parameters

`format` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`provider` [IFormatProvider](https://docs.microsoft.com/en-us/dotnet/api/system.iformatprovider)<br>

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **FromGdiFontStyle(XFontStyleEx)**

Simple hack to make it work...

```csharp
XFontWeight FromGdiFontStyle(XFontStyleEx style)
```

#### Parameters

`style` [XFontStyleEx](./pdfsharp.drawing.xfontstyleex)<br>

#### Returns

[XFontWeight](./pdfsharp.drawing.xfontweight)<br>
