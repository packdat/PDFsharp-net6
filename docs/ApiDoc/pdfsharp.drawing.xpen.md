# XPen

Namespace: PdfSharp.Drawing

Defines an object used to draw lines and curves.

```csharp
public sealed class XPen
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [XPen](./pdfsharp.drawing.xpen)

## Properties

### **Color**

Gets or sets the color.

```csharp
public XColor Color { get; set; }
```

#### Property Value

[XColor](./pdfsharp.drawing.xcolor)<br>

### **Width**

Gets or sets the width.

```csharp
public double Width { get; set; }
```

#### Property Value

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **LineJoin**

Gets or sets the line join.

```csharp
public XLineJoin LineJoin { get; set; }
```

#### Property Value

[XLineJoin](./pdfsharp.drawing.xlinejoin)<br>

### **LineCap**

Gets or sets the line cap.

```csharp
public XLineCap LineCap { get; set; }
```

#### Property Value

[XLineCap](./pdfsharp.drawing.xlinecap)<br>

### **MiterLimit**

Gets or sets the miter limit.

```csharp
public double MiterLimit { get; set; }
```

#### Property Value

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **DashStyle**

Gets or sets the dash style.

```csharp
public XDashStyle DashStyle { get; set; }
```

#### Property Value

[XDashStyle](./pdfsharp.drawing.xdashstyle)<br>

### **DashOffset**

Gets or sets the dash offset.

```csharp
public double DashOffset { get; set; }
```

#### Property Value

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **DashPattern**

Gets or sets the dash pattern.

```csharp
public Double[] DashPattern { get; set; }
```

#### Property Value

[Double[]](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **Overprint**

Gets or sets a value indicating whether the pen enables overprint when used in a PDF document.
 Experimental, takes effect only on CMYK color mode.

```csharp
public bool Overprint { get; set; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

## Constructors

### **XPen(XColor)**

Initializes a new instance of the [XPen](./pdfsharp.drawing.xpen) class.

```csharp
public XPen(XColor color)
```

#### Parameters

`color` [XColor](./pdfsharp.drawing.xcolor)<br>

### **XPen(XColor, Double)**

Initializes a new instance of the [XPen](./pdfsharp.drawing.xpen) class.

```csharp
public XPen(XColor color, double width)
```

#### Parameters

`color` [XColor](./pdfsharp.drawing.xcolor)<br>

`width` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **XPen(XPen)**

Initializes a new instance of the [XPen](./pdfsharp.drawing.xpen) class.

```csharp
public XPen(XPen pen)
```

#### Parameters

`pen` [XPen](./pdfsharp.drawing.xpen)<br>

## Methods

### **Clone()**

Clones this instance.

```csharp
public XPen Clone()
```

#### Returns

[XPen](./pdfsharp.drawing.xpen)<br>
