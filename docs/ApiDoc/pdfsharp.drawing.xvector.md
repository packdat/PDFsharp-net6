# XVector

Namespace: PdfSharp.Drawing

Represents a two-dimensional vector specified by x- and y-coordinates.
 It is a displacement in 2-D space.

```csharp
public struct XVector
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ValueType](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype) → [XVector](./pdfsharp.drawing.xvector)<br>
Implements [IFormattable](https://docs.microsoft.com/en-us/dotnet/api/system.iformattable)

## Properties

### **X**

Gets or sets the X component of this vector.

```csharp
public double X { get; set; }
```

#### Property Value

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **Y**

Gets or sets the Y component of this vector.

```csharp
public double Y { get; set; }
```

#### Property Value

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **Length**

Gets the length of this vector.

```csharp
public double Length { get; }
```

#### Property Value

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **LengthSquared**

Gets the square of the length of this vector.

```csharp
public double LengthSquared { get; }
```

#### Property Value

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

## Constructors

### **XVector(Double, Double)**

Initializes a new instance of the [XVector](./pdfsharp.drawing.xvector) struct.

```csharp
XVector(double x, double y)
```

#### Parameters

`x` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The X-offset of the new Vector.

`y` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The Y-offset of the new Vector.

## Methods

### **Equals(XVector, XVector)**

Compares two vectors for equality.

```csharp
bool Equals(XVector vector1, XVector vector2)
```

#### Parameters

`vector1` [XVector](./pdfsharp.drawing.xvector)<br>
The first vector to compare.

`vector2` [XVector](./pdfsharp.drawing.xvector)<br>
The second vector to compare.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **Equals(Object)**

Determines whether the specified Object is a Vector structure and,
 if it is, whether it has the same X and Y values as this vector.

```csharp
bool Equals(object o)
```

#### Parameters

`o` [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)<br>
The vector to compare.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **Equals(XVector)**

Compares two vectors for equality.

```csharp
bool Equals(XVector value)
```

#### Parameters

`value` [XVector](./pdfsharp.drawing.xvector)<br>
The vector to compare with this vector.

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

Converts a string representation of a vector into the equivalent Vector structure.

```csharp
XVector Parse(string source)
```

#### Parameters

`source` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The string representation of the vector.

#### Returns

[XVector](./pdfsharp.drawing.xvector)<br>

### **ToString()**

Returns the string representation of this Vector structure.

```csharp
string ToString()
```

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **ToString(IFormatProvider)**

Returns the string representation of this Vector structure with the specified formatting information.

```csharp
string ToString(IFormatProvider provider)
```

#### Parameters

`provider` [IFormatProvider](https://docs.microsoft.com/en-us/dotnet/api/system.iformatprovider)<br>
The culture-specific formatting information.

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

### **Normalize()**

Normalizes this vector.

```csharp
void Normalize()
```

### **CrossProduct(XVector, XVector)**

Calculates the cross product of two vectors.

```csharp
double CrossProduct(XVector vector1, XVector vector2)
```

#### Parameters

`vector1` [XVector](./pdfsharp.drawing.xvector)<br>
The first vector to evaluate.

`vector2` [XVector](./pdfsharp.drawing.xvector)<br>
The second vector to evaluate.

#### Returns

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **AngleBetween(XVector, XVector)**

Retrieves the angle, expressed in degrees, between the two specified vectors.

```csharp
double AngleBetween(XVector vector1, XVector vector2)
```

#### Parameters

`vector1` [XVector](./pdfsharp.drawing.xvector)<br>
The first vector to evaluate.

`vector2` [XVector](./pdfsharp.drawing.xvector)<br>
The second vector to evaluate.

#### Returns

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **Negate()**

Negates this vector. The vector has the same magnitude as before, but its direction is now opposite.

```csharp
void Negate()
```

### **Add(XVector, XVector)**

Adds two vectors and returns the result as a Vector structure.

```csharp
XVector Add(XVector vector1, XVector vector2)
```

#### Parameters

`vector1` [XVector](./pdfsharp.drawing.xvector)<br>
The first vector to add.

`vector2` [XVector](./pdfsharp.drawing.xvector)<br>
The second vector to add.

#### Returns

[XVector](./pdfsharp.drawing.xvector)<br>

### **Subtract(XVector, XVector)**

Subtracts the specified vector from another specified vector.

```csharp
XVector Subtract(XVector vector1, XVector vector2)
```

#### Parameters

`vector1` [XVector](./pdfsharp.drawing.xvector)<br>
The vector from which vector2 is subtracted.

`vector2` [XVector](./pdfsharp.drawing.xvector)<br>
The vector to subtract from vector1.

#### Returns

[XVector](./pdfsharp.drawing.xvector)<br>

### **Add(XVector, XPoint)**

Translates a point by the specified vector and returns the resulting point.

```csharp
XPoint Add(XVector vector, XPoint point)
```

#### Parameters

`vector` [XVector](./pdfsharp.drawing.xvector)<br>
The vector used to translate point.

`point` [XPoint](./pdfsharp.drawing.xpoint)<br>
The point to translate.

#### Returns

[XPoint](./pdfsharp.drawing.xpoint)<br>

### **Multiply(XVector, Double)**

Multiplies the specified vector by the specified scalar and returns the resulting vector.

```csharp
XVector Multiply(XVector vector, double scalar)
```

#### Parameters

`vector` [XVector](./pdfsharp.drawing.xvector)<br>
The vector to multiply.

`scalar` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The scalar to multiply.

#### Returns

[XVector](./pdfsharp.drawing.xvector)<br>

### **Multiply(Double, XVector)**

Multiplies the specified scalar by the specified vector and returns the resulting Vector.

```csharp
XVector Multiply(double scalar, XVector vector)
```

#### Parameters

`scalar` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The scalar to multiply.

`vector` [XVector](./pdfsharp.drawing.xvector)<br>
The vector to multiply.

#### Returns

[XVector](./pdfsharp.drawing.xvector)<br>

### **Divide(XVector, Double)**

Divides the specified vector by the specified scalar and returns the result as a Vector.

```csharp
XVector Divide(XVector vector, double scalar)
```

#### Parameters

`vector` [XVector](./pdfsharp.drawing.xvector)<br>
The vector structure to divide.

`scalar` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The amount by which vector is divided.

#### Returns

[XVector](./pdfsharp.drawing.xvector)<br>

### **Multiply(XVector, XMatrix)**

Transforms the coordinate space of the specified vector using the specified Matrix.

```csharp
XVector Multiply(XVector vector, XMatrix matrix)
```

#### Parameters

`vector` [XVector](./pdfsharp.drawing.xvector)<br>
The vector to transform.

`matrix` [XMatrix](./pdfsharp.drawing.xmatrix)<br>
The transformation to apply to vector.

#### Returns

[XVector](./pdfsharp.drawing.xvector)<br>

### **Multiply(XVector, XVector)**

Calculates the dot product of the two specified vectors and returns the result as a Double.

```csharp
double Multiply(XVector vector1, XVector vector2)
```

#### Parameters

`vector1` [XVector](./pdfsharp.drawing.xvector)<br>
The first vector to multiply.

`vector2` [XVector](./pdfsharp.drawing.xvector)<br>
The second vector structure to multiply.

#### Returns

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **Determinant(XVector, XVector)**

Calculates the determinant of two vectors.

```csharp
double Determinant(XVector vector1, XVector vector2)
```

#### Parameters

`vector1` [XVector](./pdfsharp.drawing.xvector)<br>
The first vector to evaluate.

`vector2` [XVector](./pdfsharp.drawing.xvector)<br>
The second vector to evaluate.

#### Returns

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
