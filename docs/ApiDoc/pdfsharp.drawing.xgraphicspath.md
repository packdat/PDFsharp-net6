# XGraphicsPath

Namespace: PdfSharp.Drawing

Represents a series of connected lines and curves.

```csharp
public sealed class XGraphicsPath
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [XGraphicsPath](./pdfsharp.drawing.xgraphicspath)

## Properties

### **FillMode**

Gets or sets an XFillMode that determines how the interiors of shapes are filled.

```csharp
public XFillMode FillMode { get; set; }
```

#### Property Value

[XFillMode](./pdfsharp.drawing.xfillmode)<br>

### **Internals**

Grants access to internal objects of this class.

```csharp
public XGraphicsPathInternals Internals { get; }
```

#### Property Value

[XGraphicsPathInternals](./pdfsharp.drawing.xgraphicspathinternals)<br>

## Constructors

### **XGraphicsPath()**

Initializes a new instance of the [XGraphicsPath](./pdfsharp.drawing.xgraphicspath) class.

```csharp
public XGraphicsPath()
```

## Methods

### **Clone()**

Clones this instance.

```csharp
public XGraphicsPath Clone()
```

#### Returns

[XGraphicsPath](./pdfsharp.drawing.xgraphicspath)<br>

### **AddLine(XPoint, XPoint)**

Adds a line segment to current figure.

```csharp
public void AddLine(XPoint pt1, XPoint pt2)
```

#### Parameters

`pt1` [XPoint](./pdfsharp.drawing.xpoint)<br>

`pt2` [XPoint](./pdfsharp.drawing.xpoint)<br>

### **AddLine(Double, Double, Double, Double)**

Adds a line segment to current figure.

```csharp
public void AddLine(double x1, double y1, double x2, double y2)
```

#### Parameters

`x1` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`y1` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`x2` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`y2` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **AddLines(XPoint[])**

Adds a series of connected line segments to current figure.

```csharp
public void AddLines(XPoint[] points)
```

#### Parameters

`points` [XPoint[]](./pdfsharp.drawing.xpoint)<br>

### **AddBezier(XPoint, XPoint, XPoint, XPoint)**

Adds a cubic Bézier curve to the current figure.

```csharp
public void AddBezier(XPoint pt1, XPoint pt2, XPoint pt3, XPoint pt4)
```

#### Parameters

`pt1` [XPoint](./pdfsharp.drawing.xpoint)<br>

`pt2` [XPoint](./pdfsharp.drawing.xpoint)<br>

`pt3` [XPoint](./pdfsharp.drawing.xpoint)<br>

`pt4` [XPoint](./pdfsharp.drawing.xpoint)<br>

### **AddBezier(Double, Double, Double, Double, Double, Double, Double, Double)**

Adds a cubic Bézier curve to the current figure.

```csharp
public void AddBezier(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
```

#### Parameters

`x1` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`y1` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`x2` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`y2` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`x3` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`y3` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`x4` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`y4` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **AddBeziers(XPoint[])**

Adds a sequence of connected cubic Bézier curves to the current figure.

```csharp
public void AddBeziers(XPoint[] points)
```

#### Parameters

`points` [XPoint[]](./pdfsharp.drawing.xpoint)<br>

### **AddCurve(XPoint[])**

Adds a spline curve to the current figure.

```csharp
public void AddCurve(XPoint[] points)
```

#### Parameters

`points` [XPoint[]](./pdfsharp.drawing.xpoint)<br>

### **AddCurve(XPoint[], Double)**

Adds a spline curve to the current figure.

```csharp
public void AddCurve(XPoint[] points, double tension)
```

#### Parameters

`points` [XPoint[]](./pdfsharp.drawing.xpoint)<br>

`tension` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **AddCurve(XPoint[], Int32, Int32, Double)**

Adds a spline curve to the current figure.

```csharp
public void AddCurve(XPoint[] points, int offset, int numberOfSegments, double tension)
```

#### Parameters

`points` [XPoint[]](./pdfsharp.drawing.xpoint)<br>

`offset` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

`numberOfSegments` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

`tension` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **AddArc(XRect, Double, Double)**

Adds an elliptical arc to the current figure.

```csharp
public void AddArc(XRect rect, double startAngle, double sweepAngle)
```

#### Parameters

`rect` [XRect](./pdfsharp.drawing.xrect)<br>

`startAngle` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`sweepAngle` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **AddArc(Double, Double, Double, Double, Double, Double)**

Adds an elliptical arc to the current figure.

```csharp
public void AddArc(double x, double y, double width, double height, double startAngle, double sweepAngle)
```

#### Parameters

`x` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`y` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`width` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`height` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`startAngle` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`sweepAngle` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **AddArc(XPoint, XPoint, XSize, Double, Boolean, XSweepDirection)**

Adds an elliptical arc to the current figure. The arc is specified WPF like.

```csharp
public void AddArc(XPoint point1, XPoint point2, XSize size, double rotationAngle, bool isLargeArg, XSweepDirection sweepDirection)
```

#### Parameters

`point1` [XPoint](./pdfsharp.drawing.xpoint)<br>

`point2` [XPoint](./pdfsharp.drawing.xpoint)<br>

`size` [XSize](./pdfsharp.drawing.xsize)<br>

`rotationAngle` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`isLargeArg` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

`sweepDirection` [XSweepDirection](./pdfsharp.drawing.xsweepdirection)<br>

### **AddRectangle(XRect)**

Adds a rectangle to this path.

```csharp
public void AddRectangle(XRect rect)
```

#### Parameters

`rect` [XRect](./pdfsharp.drawing.xrect)<br>

### **AddRectangle(Double, Double, Double, Double)**

Adds a rectangle to this path.

```csharp
public void AddRectangle(double x, double y, double width, double height)
```

#### Parameters

`x` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`y` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`width` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`height` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **AddRectangles(XRect[])**

Adds a series of rectangles to this path.

```csharp
public void AddRectangles(XRect[] rects)
```

#### Parameters

`rects` [XRect[]](./pdfsharp.drawing.xrect)<br>

### **AddRoundedRectangle(Double, Double, Double, Double, Double, Double)**

Adds a rectangle with rounded corners to this path.

```csharp
public void AddRoundedRectangle(double x, double y, double width, double height, double ellipseWidth, double ellipseHeight)
```

#### Parameters

`x` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`y` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`width` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`height` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`ellipseWidth` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`ellipseHeight` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **AddEllipse(XRect)**

Adds an ellipse to the current path.

```csharp
public void AddEllipse(XRect rect)
```

#### Parameters

`rect` [XRect](./pdfsharp.drawing.xrect)<br>

### **AddEllipse(Double, Double, Double, Double)**

Adds an ellipse to the current path.

```csharp
public void AddEllipse(double x, double y, double width, double height)
```

#### Parameters

`x` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`y` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`width` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`height` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **AddPolygon(XPoint[])**

Adds a polygon to this path.

```csharp
public void AddPolygon(XPoint[] points)
```

#### Parameters

`points` [XPoint[]](./pdfsharp.drawing.xpoint)<br>

### **AddPie(XRect, Double, Double)**

Adds the outline of a pie shape to this path.

```csharp
public void AddPie(XRect rect, double startAngle, double sweepAngle)
```

#### Parameters

`rect` [XRect](./pdfsharp.drawing.xrect)<br>

`startAngle` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`sweepAngle` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **AddPie(Double, Double, Double, Double, Double, Double)**

Adds the outline of a pie shape to this path.

```csharp
public void AddPie(double x, double y, double width, double height, double startAngle, double sweepAngle)
```

#### Parameters

`x` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`y` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`width` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`height` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`startAngle` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`sweepAngle` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **AddClosedCurve(XPoint[])**

Adds a closed curve to this path.

```csharp
public void AddClosedCurve(XPoint[] points)
```

#### Parameters

`points` [XPoint[]](./pdfsharp.drawing.xpoint)<br>

### **AddClosedCurve(XPoint[], Double)**

Adds a closed curve to this path.

```csharp
public void AddClosedCurve(XPoint[] points, double tension)
```

#### Parameters

`points` [XPoint[]](./pdfsharp.drawing.xpoint)<br>

`tension` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **AddPath(XGraphicsPath, Boolean)**

Adds the specified path to this path.

```csharp
public void AddPath(XGraphicsPath path, bool connect)
```

#### Parameters

`path` [XGraphicsPath](./pdfsharp.drawing.xgraphicspath)<br>

`connect` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **AddString(String, XFontFamily, XFontStyleEx, Double, XPoint, XStringFormat)**

Adds a text string to this path.

```csharp
public void AddString(string s, XFontFamily family, XFontStyleEx style, double emSize, XPoint origin, XStringFormat format)
```

#### Parameters

`s` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`family` [XFontFamily](./pdfsharp.drawing.xfontfamily)<br>

`style` [XFontStyleEx](./pdfsharp.drawing.xfontstyleex)<br>

`emSize` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`origin` [XPoint](./pdfsharp.drawing.xpoint)<br>

`format` [XStringFormat](./pdfsharp.drawing.xstringformat)<br>

### **AddString(String, XFontFamily, XFontStyleEx, Double, XRect, XStringFormat)**

Adds a text string to this path.

```csharp
public void AddString(string s, XFontFamily family, XFontStyleEx style, double emSize, XRect layoutRect, XStringFormat format)
```

#### Parameters

`s` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`family` [XFontFamily](./pdfsharp.drawing.xfontfamily)<br>

`style` [XFontStyleEx](./pdfsharp.drawing.xfontstyleex)<br>

`emSize` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`layoutRect` [XRect](./pdfsharp.drawing.xrect)<br>

`format` [XStringFormat](./pdfsharp.drawing.xstringformat)<br>

### **CloseFigure()**

Closes the current figure and starts a new figure.

```csharp
public void CloseFigure()
```

### **StartFigure()**

Starts a new figure without closing the current figure.

```csharp
public void StartFigure()
```

### **Flatten()**

Converts each curve in this XGraphicsPath into a sequence of connected line segments.

```csharp
public void Flatten()
```

### **Flatten(XMatrix)**

Converts each curve in this XGraphicsPath into a sequence of connected line segments.

```csharp
public void Flatten(XMatrix matrix)
```

#### Parameters

`matrix` [XMatrix](./pdfsharp.drawing.xmatrix)<br>

### **Flatten(XMatrix, Double)**

Converts each curve in this XGraphicsPath into a sequence of connected line segments.

```csharp
public void Flatten(XMatrix matrix, double flatness)
```

#### Parameters

`matrix` [XMatrix](./pdfsharp.drawing.xmatrix)<br>

`flatness` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **Widen(XPen)**

Replaces this path with curves that enclose the area that is filled when this path is drawn 
 by the specified pen.

```csharp
public void Widen(XPen pen)
```

#### Parameters

`pen` [XPen](./pdfsharp.drawing.xpen)<br>

### **Widen(XPen, XMatrix)**

Replaces this path with curves that enclose the area that is filled when this path is drawn 
 by the specified pen.

```csharp
public void Widen(XPen pen, XMatrix matrix)
```

#### Parameters

`pen` [XPen](./pdfsharp.drawing.xpen)<br>

`matrix` [XMatrix](./pdfsharp.drawing.xmatrix)<br>

### **Widen(XPen, XMatrix, Double)**

Replaces this path with curves that enclose the area that is filled when this path is drawn 
 by the specified pen.

```csharp
public void Widen(XPen pen, XMatrix matrix, double flatness)
```

#### Parameters

`pen` [XPen](./pdfsharp.drawing.xpen)<br>

`matrix` [XMatrix](./pdfsharp.drawing.xmatrix)<br>

`flatness` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
