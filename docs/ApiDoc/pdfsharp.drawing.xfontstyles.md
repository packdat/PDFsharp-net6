# XFontStyles

Namespace: PdfSharp.Drawing

Provides a set of static predefined font style /&gt; values.

```csharp
public static class XFontStyles
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [XFontStyles](./pdfsharp.drawing.xfontstyles)

## Properties

### **Normal**

Specifies a normal font style. /&gt;

```csharp
public static XFontStyle Normal { get; }
```

#### Property Value

[XFontStyle](./pdfsharp.drawing.xfontstyle)<br>

### **Oblique**

Specifies an oblique font style.

```csharp
public static XFontStyle Oblique { get; }
```

#### Property Value

[XFontStyle](./pdfsharp.drawing.xfontstyle)<br>

### **Italic**

Specifies an italic font style. /&gt;

```csharp
public static XFontStyle Italic { get; }
```

#### Property Value

[XFontStyle](./pdfsharp.drawing.xfontstyle)<br>

## Methods

### **XFontStyleStringToKnownStyle(String, IFormatProvider, XFontStyle&)**

```csharp
internal static bool XFontStyleStringToKnownStyle(string style, IFormatProvider provider, XFontStyle& xFontStyle)
```

#### Parameters

`style` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`provider` [IFormatProvider](https://docs.microsoft.com/en-us/dotnet/api/system.iformatprovider)<br>

`xFontStyle` [XFontStyle&](./pdfsharp.drawing.xfontstyle&)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
