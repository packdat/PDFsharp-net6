# XSolidBrush

Namespace: PdfSharp.Drawing

Defines a single-color object used to fill shapes and draw text.

```csharp
public sealed class XSolidBrush : XBrush
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [XBrush](./pdfsharp.drawing.xbrush) → [XSolidBrush](./pdfsharp.drawing.xsolidbrush)

## Properties

### **Color**

Gets or sets the color of this brush.

```csharp
public XColor Color { get; set; }
```

#### Property Value

[XColor](./pdfsharp.drawing.xcolor)<br>

### **Overprint**

Gets or sets a value indicating whether the brush enables overprint when used in a PDF document.
 Experimental, takes effect only on CMYK color mode.

```csharp
public bool Overprint { get; set; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

## Constructors

### **XSolidBrush()**

Initializes a new instance of the [XSolidBrush](./pdfsharp.drawing.xsolidbrush) class.

```csharp
public XSolidBrush()
```

### **XSolidBrush(XColor)**

Initializes a new instance of the [XSolidBrush](./pdfsharp.drawing.xsolidbrush) class.

```csharp
public XSolidBrush(XColor color)
```

#### Parameters

`color` [XColor](./pdfsharp.drawing.xcolor)<br>

### **XSolidBrush(XSolidBrush)**

Initializes a new instance of the [XSolidBrush](./pdfsharp.drawing.xsolidbrush) class.

```csharp
public XSolidBrush(XSolidBrush brush)
```

#### Parameters

`brush` [XSolidBrush](./pdfsharp.drawing.xsolidbrush)<br>
