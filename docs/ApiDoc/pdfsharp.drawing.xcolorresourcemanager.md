# XColorResourceManager

Namespace: PdfSharp.Drawing

Manages the localization of the color class.

```csharp
public class XColorResourceManager
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [XColorResourceManager](./pdfsharp.drawing.xcolorresourcemanager)

## Constructors

### **XColorResourceManager()**

Initializes a new instance of the [XColorResourceManager](./pdfsharp.drawing.xcolorresourcemanager) class.

```csharp
public XColorResourceManager()
```

### **XColorResourceManager(CultureInfo)**

Initializes a new instance of the [XColorResourceManager](./pdfsharp.drawing.xcolorresourcemanager) class.

```csharp
public XColorResourceManager(CultureInfo cultureInfo)
```

#### Parameters

`cultureInfo` [CultureInfo](https://docs.microsoft.com/en-us/dotnet/api/system.globalization.cultureinfo)<br>
The culture info.

## Methods

### **GetKnownColor(UInt32)**

Gets a known color from an ARGB value. Throws an ArgumentException if the value is not a known color.

```csharp
public static XKnownColor GetKnownColor(uint argb)
```

#### Parameters

`argb` [UInt32](https://docs.microsoft.com/en-us/dotnet/api/system.uint32)<br>

#### Returns

[XKnownColor](./pdfsharp.drawing.xknowncolor)<br>

### **GetKnownColors(Boolean)**

Gets all known colors.

```csharp
public static XKnownColor[] GetKnownColors(bool includeTransparent)
```

#### Parameters

`includeTransparent` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
Indicates whether to include the color Transparent.

#### Returns

[XKnownColor[]](./pdfsharp.drawing.xknowncolor)<br>

### **ToColorName(XKnownColor)**

Converts a known color to a localized color name.

```csharp
public string ToColorName(XKnownColor knownColor)
```

#### Parameters

`knownColor` [XKnownColor](./pdfsharp.drawing.xknowncolor)<br>

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **ToColorName(XColor)**

Converts a color to a localized color name or an ARGB value.

```csharp
public string ToColorName(XColor color)
```

#### Parameters

`color` [XColor](./pdfsharp.drawing.xcolor)<br>

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
