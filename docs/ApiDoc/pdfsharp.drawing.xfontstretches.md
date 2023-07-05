# XFontStretches

Namespace: PdfSharp.Drawing

Provides a set of static predefined  values.

```csharp
public static class XFontStretches
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [XFontStretches](./pdfsharp.drawing.xfontstretches)

## Properties

### **UltraCondensed**

Specifies an ultra-condensed .

```csharp
public static XFontStretch UltraCondensed { get; }
```

#### Property Value

[XFontStretch](./pdfsharp.drawing.xfontstretch)<br>

### **ExtraCondensed**

Specifies an extra-condensed .

```csharp
public static XFontStretch ExtraCondensed { get; }
```

#### Property Value

[XFontStretch](./pdfsharp.drawing.xfontstretch)<br>

### **Condensed**

Specifies a condensed .

```csharp
public static XFontStretch Condensed { get; }
```

#### Property Value

[XFontStretch](./pdfsharp.drawing.xfontstretch)<br>

### **SemiCondensed**

Specifies a semi-condensed .

```csharp
public static XFontStretch SemiCondensed { get; }
```

#### Property Value

[XFontStretch](./pdfsharp.drawing.xfontstretch)<br>

### **Normal**

Specifies a normal .

```csharp
public static XFontStretch Normal { get; }
```

#### Property Value

[XFontStretch](./pdfsharp.drawing.xfontstretch)<br>

### **Medium**

Specifies a medium .

```csharp
public static XFontStretch Medium { get; }
```

#### Property Value

[XFontStretch](./pdfsharp.drawing.xfontstretch)<br>

### **SemiExpanded**

Specifies a semi-expanded .

```csharp
public static XFontStretch SemiExpanded { get; }
```

#### Property Value

[XFontStretch](./pdfsharp.drawing.xfontstretch)<br>

### **Expanded**

Specifies an expanded .

```csharp
public static XFontStretch Expanded { get; }
```

#### Property Value

[XFontStretch](./pdfsharp.drawing.xfontstretch)<br>

### **ExtraExpanded**

Specifies an extra-expanded .

```csharp
public static XFontStretch ExtraExpanded { get; }
```

#### Property Value

[XFontStretch](./pdfsharp.drawing.xfontstretch)<br>

### **UltraExpanded**

Specifies an ultra-expanded .

```csharp
public static XFontStretch UltraExpanded { get; }
```

#### Property Value

[XFontStretch](./pdfsharp.drawing.xfontstretch)<br>

## Methods

### **XFontStretchStringToKnownStretch(String, IFormatProvider, XFontStretch&)**

```csharp
internal static bool XFontStretchStringToKnownStretch(string stretch, IFormatProvider provider, XFontStretch& xFontStretch)
```

#### Parameters

`stretch` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`provider` [IFormatProvider](https://docs.microsoft.com/en-us/dotnet/api/system.iformatprovider)<br>

`xFontStretch` [XFontStretch&](./pdfsharp.drawing.xfontstretch&)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **XFontStretchToString(XFontStretchValue, String&)**

```csharp
internal static bool XFontStretchToString(XFontStretchValue stretch, String& convertedValue)
```

#### Parameters

`stretch` [XFontStretchValue](./pdfsharp.drawing.xfontstretchvalue)<br>

`convertedValue` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
