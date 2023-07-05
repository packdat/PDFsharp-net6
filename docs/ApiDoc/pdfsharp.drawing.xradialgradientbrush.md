# XRadialGradientBrush

Namespace: PdfSharp.Drawing

Defines a Brush with a radial gradient.

```csharp
public sealed class XRadialGradientBrush : XGradientBrush
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [XBrush](./pdfsharp.drawing.xbrush) → [XGradientBrush](./pdfsharp.drawing.xgradientbrush) → [XRadialGradientBrush](./pdfsharp.drawing.xradialgradientbrush)

## Properties

### **Transform**

Gets or sets an XMatrix that defines a local geometric transform for this RadialGradientBrush.

```csharp
public XMatrix Transform { get; set; }
```

#### Property Value

[XMatrix](./pdfsharp.drawing.xmatrix)<br>

### **InnerRadius**

Gets or sets the inner radius.

```csharp
public double InnerRadius { get; set; }
```

#### Property Value

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **OuterRadius**

Gets or sets the outer radius.

```csharp
public double OuterRadius { get; set; }
```

#### Property Value

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **ExtendLeft**

Gets or sets a value indicating whether to extend the gradient beyond its bounds.

```csharp
public bool ExtendLeft { get; set; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **ExtendRight**

Gets or sets a value indicating whether to extend the gradient beyond its bounds.

```csharp
public bool ExtendRight { get; set; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

## Constructors

### **XRadialGradientBrush(XPoint, XPoint, Double, Double, XColor, XColor)**

Initializes a new instance of the [XRadialGradientBrush](./pdfsharp.drawing.xradialgradientbrush) class.

```csharp
public XRadialGradientBrush(XPoint point1, XPoint point2, double innerRadius, double outerRadius, XColor color1, XColor color2)
```

#### Parameters

`point1` [XPoint](./pdfsharp.drawing.xpoint)<br>

`point2` [XPoint](./pdfsharp.drawing.xpoint)<br>

`innerRadius` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`outerRadius` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`color1` [XColor](./pdfsharp.drawing.xcolor)<br>

`color2` [XColor](./pdfsharp.drawing.xcolor)<br>

## Methods

### **TranslateTransform(Double, Double)**

Translates the brush with the specified offset.

```csharp
public void TranslateTransform(double dx, double dy)
```

#### Parameters

`dx` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`dy` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **TranslateTransform(Double, Double, XMatrixOrder)**

Translates the brush with the specified offset.

```csharp
public void TranslateTransform(double dx, double dy, XMatrixOrder order)
```

#### Parameters

`dx` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`dy` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`order` [XMatrixOrder](./pdfsharp.drawing.xmatrixorder)<br>

### **ScaleTransform(Double, Double)**

Scales the brush with the specified scalars.

```csharp
public void ScaleTransform(double sx, double sy)
```

#### Parameters

`sx` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`sy` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **ScaleTransform(Double, Double, XMatrixOrder)**

Scales the brush with the specified scalars.

```csharp
public void ScaleTransform(double sx, double sy, XMatrixOrder order)
```

#### Parameters

`sx` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`sy` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`order` [XMatrixOrder](./pdfsharp.drawing.xmatrixorder)<br>

### **RotateTransform(Double)**

Rotates the brush with the specified angle.

```csharp
public void RotateTransform(double angle)
```

#### Parameters

`angle` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **RotateTransform(Double, XMatrixOrder)**

Rotates the brush with the specified angle.

```csharp
public void RotateTransform(double angle, XMatrixOrder order)
```

#### Parameters

`angle` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`order` [XMatrixOrder](./pdfsharp.drawing.xmatrixorder)<br>

### **MultiplyTransform(XMatrix)**

Multiply the brush transformation matrix with the specified matrix.

```csharp
public void MultiplyTransform(XMatrix matrix)
```

#### Parameters

`matrix` [XMatrix](./pdfsharp.drawing.xmatrix)<br>

### **MultiplyTransform(XMatrix, XMatrixOrder)**

Multiply the brush transformation matrix with the specified matrix.

```csharp
public void MultiplyTransform(XMatrix matrix, XMatrixOrder order)
```

#### Parameters

`matrix` [XMatrix](./pdfsharp.drawing.xmatrix)<br>

`order` [XMatrixOrder](./pdfsharp.drawing.xmatrixorder)<br>

### **ResetTransform()**

Resets the brush transformation matrix with identity matrix.

```csharp
public void ResetTransform()
```
