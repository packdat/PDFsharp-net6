# XPoint

Namespace: PdfSharp.Drawing

Represents a pair of floating-point x- and y-coordinates that defines a point
 in a two-dimensional plane.

```csharp
public struct XPoint
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ValueType](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype) → [XPoint](./pdfsharp.drawing.xpoint)<br>
Implements [IFormattable](https://docs.microsoft.com/en-us/dotnet/api/system.iformattable)

## Properties

### **X**

Gets the x-coordinate of this XPoint.

```csharp
public double X { get; set; }
```

#### Property Value

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **Y**

Gets the x-coordinate of this XPoint.

```csharp
public double Y { get; set; }
```

#### Property Value

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

## Constructors

### **XPoint(Double, Double)**

Initializes a new instance of the XPoint class with the specified coordinates.

```csharp
XPoint(double x, double y)
```

#### Parameters

`x` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`y` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

## Methods

### **Equals(XPoint, XPoint)**

Indicates whether the specified points are equal.

```csharp
bool Equals(XPoint point1, XPoint point2)
```

#### Parameters

`point1` [XPoint](./pdfsharp.drawing.xpoint)<br>

`point2` [XPoint](./pdfsharp.drawing.xpoint)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **Equals(Object)**

Indicates whether this instance and a specified object are equal.

```csharp
bool Equals(object o)
```

#### Parameters

`o` [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **Equals(XPoint)**

Indicates whether this instance and a specified point are equal.

```csharp
bool Equals(XPoint value)
```

#### Parameters

`value` [XPoint](./pdfsharp.drawing.xpoint)<br>

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

Parses the point from a string.

```csharp
XPoint Parse(string source)
```

#### Parameters

`source` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

#### Returns

[XPoint](./pdfsharp.drawing.xpoint)<br>

### **ParsePoints(String)**

Parses an array of points from a string.

```csharp
XPoint[] ParsePoints(string value)
```

#### Parameters

`value` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

#### Returns

[XPoint[]](./pdfsharp.drawing.xpoint)<br>

### **ToString()**

Converts this XPoint to a human readable string.

```csharp
string ToString()
```

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **ToString(IFormatProvider)**

Converts this XPoint to a human readable string.

```csharp
string ToString(IFormatProvider provider)
```

#### Parameters

`provider` [IFormatProvider](https://docs.microsoft.com/en-us/dotnet/api/system.iformatprovider)<br>

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **ConvertToString(String, IFormatProvider)**

Implements ToString.

```csharp
string ConvertToString(string format, IFormatProvider provider)
```

#### Parameters

`format` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`provider` [IFormatProvider](https://docs.microsoft.com/en-us/dotnet/api/system.iformatprovider)<br>

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Offset(Double, Double)**

Offsets the x and y value of this point.

```csharp
void Offset(double offsetX, double offsetY)
```

#### Parameters

`offsetX` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`offsetY` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **Add(XPoint, XVector)**

Adds a point and a vector.

```csharp
XPoint Add(XPoint point, XVector vector)
```

#### Parameters

`point` [XPoint](./pdfsharp.drawing.xpoint)<br>

`vector` [XVector](./pdfsharp.drawing.xvector)<br>

#### Returns

[XPoint](./pdfsharp.drawing.xpoint)<br>

### **Subtract(XPoint, XVector)**

Subtracts a vector from a point.

```csharp
XPoint Subtract(XPoint point, XVector vector)
```

#### Parameters

`point` [XPoint](./pdfsharp.drawing.xpoint)<br>

`vector` [XVector](./pdfsharp.drawing.xvector)<br>

#### Returns

[XPoint](./pdfsharp.drawing.xpoint)<br>

### **Subtract(XPoint, XPoint)**

Subtracts a point from a point.

```csharp
XVector Subtract(XPoint point1, XPoint point2)
```

#### Parameters

`point1` [XPoint](./pdfsharp.drawing.xpoint)<br>

`point2` [XPoint](./pdfsharp.drawing.xpoint)<br>

#### Returns

[XVector](./pdfsharp.drawing.xvector)<br>

### **Multiply(XPoint, XMatrix)**

Multiplies a point with a matrix.

```csharp
XPoint Multiply(XPoint point, XMatrix matrix)
```

#### Parameters

`point` [XPoint](./pdfsharp.drawing.xpoint)<br>

`matrix` [XMatrix](./pdfsharp.drawing.xmatrix)<br>

#### Returns

[XPoint](./pdfsharp.drawing.xpoint)<br>
