# XRect

Namespace: PdfSharp.Drawing

Stores a set of four floating-point numbers that represent the location and size of a rectangle.

```csharp
public struct XRect
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ValueType](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype) → [XRect](./pdfsharp.drawing.xrect)<br>
Implements [IFormattable](https://docs.microsoft.com/en-us/dotnet/api/system.iformattable)

## Properties

### **Empty**

Gets the empty rectangle.

```csharp
public static XRect Empty { get; }
```

#### Property Value

[XRect](./pdfsharp.drawing.xrect)<br>

### **IsEmpty**

Gets a value indicating whether this instance is empty.

```csharp
public bool IsEmpty { get; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **Location**

Gets or sets the location of the rectangle.

```csharp
public XPoint Location { get; set; }
```

#### Property Value

[XPoint](./pdfsharp.drawing.xpoint)<br>

### **Size**

Gets or sets the size of the rectangle.

```csharp
public XSize Size { get; set; }
```

#### Property Value

[XSize](./pdfsharp.drawing.xsize)<br>

### **X**

Gets or sets the X value of the rectangle.

```csharp
public double X { get; set; }
```

#### Property Value

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **Y**

Gets or sets the Y value of the rectangle.

```csharp
public double Y { get; set; }
```

#### Property Value

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **Width**

Gets or sets the width of the rectangle.

```csharp
public double Width { get; set; }
```

#### Property Value

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **Height**

Gets or sets the height of the rectangle.

```csharp
public double Height { get; set; }
```

#### Property Value

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **Left**

Gets the x-axis value of the left side of the rectangle.

```csharp
public double Left { get; }
```

#### Property Value

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **Top**

Gets the y-axis value of the top side of the rectangle.

```csharp
public double Top { get; }
```

#### Property Value

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **Right**

Gets the x-axis value of the right side of the rectangle.

```csharp
public double Right { get; }
```

#### Property Value

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **Bottom**

Gets the y-axis value of the bottom side of the rectangle.

```csharp
public double Bottom { get; }
```

#### Property Value

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **TopLeft**

Gets the position of the top-left corner of the rectangle.

```csharp
public XPoint TopLeft { get; }
```

#### Property Value

[XPoint](./pdfsharp.drawing.xpoint)<br>

### **TopRight**

Gets the position of the top-right corner of the rectangle.

```csharp
public XPoint TopRight { get; }
```

#### Property Value

[XPoint](./pdfsharp.drawing.xpoint)<br>

### **BottomLeft**

Gets the position of the bottom-left corner of the rectangle.

```csharp
public XPoint BottomLeft { get; }
```

#### Property Value

[XPoint](./pdfsharp.drawing.xpoint)<br>

### **BottomRight**

Gets the position of the bottom-right corner of the rectangle.

```csharp
public XPoint BottomRight { get; }
```

#### Property Value

[XPoint](./pdfsharp.drawing.xpoint)<br>

### **Center**

Gets the center of the rectangle.

```csharp
public XPoint Center { get; }
```

#### Property Value

[XPoint](./pdfsharp.drawing.xpoint)<br>

## Constructors

### **XRect(Double, Double, Double, Double)**

Initializes a new instance of the XRect class.

```csharp
XRect(double x, double y, double width, double height)
```

#### Parameters

`x` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`y` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`width` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`height` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **XRect(XPoint, XPoint)**

Initializes a new instance of the XRect class.

```csharp
XRect(XPoint point1, XPoint point2)
```

#### Parameters

`point1` [XPoint](./pdfsharp.drawing.xpoint)<br>

`point2` [XPoint](./pdfsharp.drawing.xpoint)<br>

### **XRect(XPoint, XVector)**

Initializes a new instance of the XRect class.

```csharp
XRect(XPoint point, XVector vector)
```

#### Parameters

`point` [XPoint](./pdfsharp.drawing.xpoint)<br>

`vector` [XVector](./pdfsharp.drawing.xvector)<br>

### **XRect(XPoint, XSize)**

Initializes a new instance of the XRect class.

```csharp
XRect(XPoint location, XSize size)
```

#### Parameters

`location` [XPoint](./pdfsharp.drawing.xpoint)<br>

`size` [XSize](./pdfsharp.drawing.xsize)<br>

### **XRect(XSize)**

Initializes a new instance of the XRect class.

```csharp
XRect(XSize size)
```

#### Parameters

`size` [XSize](./pdfsharp.drawing.xsize)<br>

## Methods

### **FromLTRB(Double, Double, Double, Double)**

Creates a rectangle from four straight lines.

```csharp
XRect FromLTRB(double left, double top, double right, double bottom)
```

#### Parameters

`left` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`top` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`right` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`bottom` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

#### Returns

[XRect](./pdfsharp.drawing.xrect)<br>

### **Equals(XRect, XRect)**

Determines whether the two rectangles are equal.

```csharp
bool Equals(XRect rect1, XRect rect2)
```

#### Parameters

`rect1` [XRect](./pdfsharp.drawing.xrect)<br>

`rect2` [XRect](./pdfsharp.drawing.xrect)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **Equals(Object)**

Determines whether this instance and the specified object are equal.

```csharp
bool Equals(object o)
```

#### Parameters

`o` [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **Equals(XRect)**

Determines whether this instance and the specified rect are equal.

```csharp
bool Equals(XRect value)
```

#### Parameters

`value` [XRect](./pdfsharp.drawing.xrect)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **GetHashCode()**

Returns the hash code for this instance.

```csharp
int GetHashCode()
```

#### Returns

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **Parse(String)**

Parses the rectangle from a string.

```csharp
XRect Parse(string source)
```

#### Parameters

`source` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

#### Returns

[XRect](./pdfsharp.drawing.xrect)<br>

### **ToString()**

Converts this XRect to a human readable string.

```csharp
string ToString()
```

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **ToString(IFormatProvider)**

Converts this XRect to a human readable string.

```csharp
string ToString(IFormatProvider provider)
```

#### Parameters

`provider` [IFormatProvider](https://docs.microsoft.com/en-us/dotnet/api/system.iformatprovider)<br>

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

### **Contains(XPoint)**

Indicates whether the rectangle contains the specified point.

```csharp
bool Contains(XPoint point)
```

#### Parameters

`point` [XPoint](./pdfsharp.drawing.xpoint)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **Contains(Double, Double)**

Indicates whether the rectangle contains the specified point.

```csharp
bool Contains(double x, double y)
```

#### Parameters

`x` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`y` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **Contains(XRect)**

Indicates whether the rectangle contains the specified rectangle.

```csharp
bool Contains(XRect rect)
```

#### Parameters

`rect` [XRect](./pdfsharp.drawing.xrect)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **IntersectsWith(XRect)**

Indicates whether the specified rectangle intersects with the current rectangle.

```csharp
bool IntersectsWith(XRect rect)
```

#### Parameters

`rect` [XRect](./pdfsharp.drawing.xrect)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **Intersect(XRect)**

Sets current rectangle to the intersection of the current rectangle and the specified rectangle.

```csharp
void Intersect(XRect rect)
```

#### Parameters

`rect` [XRect](./pdfsharp.drawing.xrect)<br>

### **Intersect(XRect, XRect)**

Returns the intersection of two rectangles.

```csharp
XRect Intersect(XRect rect1, XRect rect2)
```

#### Parameters

`rect1` [XRect](./pdfsharp.drawing.xrect)<br>

`rect2` [XRect](./pdfsharp.drawing.xrect)<br>

#### Returns

[XRect](./pdfsharp.drawing.xrect)<br>

### **Union(XRect)**

Sets current rectangle to the union of the current rectangle and the specified rectangle.

```csharp
void Union(XRect rect)
```

#### Parameters

`rect` [XRect](./pdfsharp.drawing.xrect)<br>

### **Union(XRect, XRect)**

Returns the union of two rectangles.

```csharp
XRect Union(XRect rect1, XRect rect2)
```

#### Parameters

`rect1` [XRect](./pdfsharp.drawing.xrect)<br>

`rect2` [XRect](./pdfsharp.drawing.xrect)<br>

#### Returns

[XRect](./pdfsharp.drawing.xrect)<br>

### **Union(XPoint)**

Sets current rectangle to the union of the current rectangle and the specified point.

```csharp
void Union(XPoint point)
```

#### Parameters

`point` [XPoint](./pdfsharp.drawing.xpoint)<br>

### **Union(XRect, XPoint)**

Returns the union of a rectangle and a point.

```csharp
XRect Union(XRect rect, XPoint point)
```

#### Parameters

`rect` [XRect](./pdfsharp.drawing.xrect)<br>

`point` [XPoint](./pdfsharp.drawing.xpoint)<br>

#### Returns

[XRect](./pdfsharp.drawing.xrect)<br>

### **Offset(XVector)**

Moves a rectangle by the specified amount.

```csharp
void Offset(XVector offsetVector)
```

#### Parameters

`offsetVector` [XVector](./pdfsharp.drawing.xvector)<br>

### **Offset(Double, Double)**

Moves a rectangle by the specified amount.

```csharp
void Offset(double offsetX, double offsetY)
```

#### Parameters

`offsetX` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`offsetY` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **Offset(XRect, XVector)**

Returns a rectangle that is offset from the specified rectangle by using the specified vector.

```csharp
XRect Offset(XRect rect, XVector offsetVector)
```

#### Parameters

`rect` [XRect](./pdfsharp.drawing.xrect)<br>

`offsetVector` [XVector](./pdfsharp.drawing.xvector)<br>

#### Returns

[XRect](./pdfsharp.drawing.xrect)<br>

### **Offset(XRect, Double, Double)**

Returns a rectangle that is offset from the specified rectangle by using specified horizontal and vertical amounts.

```csharp
XRect Offset(XRect rect, double offsetX, double offsetY)
```

#### Parameters

`rect` [XRect](./pdfsharp.drawing.xrect)<br>

`offsetX` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`offsetY` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

#### Returns

[XRect](./pdfsharp.drawing.xrect)<br>

### **Inflate(XSize)**

Expands the rectangle by using the specified Size, in all directions.

```csharp
void Inflate(XSize size)
```

#### Parameters

`size` [XSize](./pdfsharp.drawing.xsize)<br>

### **Inflate(Double, Double)**

Expands or shrinks the rectangle by using the specified width and height amounts, in all directions.

```csharp
void Inflate(double width, double height)
```

#### Parameters

`width` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`height` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **Inflate(XRect, XSize)**

Returns the rectangle that results from expanding the specified rectangle by the specified Size, in all directions.

```csharp
XRect Inflate(XRect rect, XSize size)
```

#### Parameters

`rect` [XRect](./pdfsharp.drawing.xrect)<br>

`size` [XSize](./pdfsharp.drawing.xsize)<br>

#### Returns

[XRect](./pdfsharp.drawing.xrect)<br>

### **Inflate(XRect, Double, Double)**

Creates a rectangle that results from expanding or shrinking the specified rectangle by the specified width and height amounts, in all directions.

```csharp
XRect Inflate(XRect rect, double width, double height)
```

#### Parameters

`rect` [XRect](./pdfsharp.drawing.xrect)<br>

`width` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`height` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

#### Returns

[XRect](./pdfsharp.drawing.xrect)<br>

### **Transform(XRect, XMatrix)**

Returns the rectangle that results from applying the specified matrix to the specified rectangle.

```csharp
XRect Transform(XRect rect, XMatrix matrix)
```

#### Parameters

`rect` [XRect](./pdfsharp.drawing.xrect)<br>

`matrix` [XMatrix](./pdfsharp.drawing.xmatrix)<br>

#### Returns

[XRect](./pdfsharp.drawing.xrect)<br>

### **Transform(XMatrix)**

Transforms the rectangle by applying the specified matrix.

```csharp
void Transform(XMatrix matrix)
```

#### Parameters

`matrix` [XMatrix](./pdfsharp.drawing.xmatrix)<br>

### **Scale(Double, Double)**

Multiplies the size of the current rectangle by the specified x and y values.

```csharp
void Scale(double scaleX, double scaleY)
```

#### Parameters

`scaleX` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`scaleY` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
