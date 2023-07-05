# XMatrix

Namespace: PdfSharp.Drawing

Represents a 3-by-3 matrix that represents an affine 2D transformation.

```csharp
public struct XMatrix
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ValueType](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype) → [XMatrix](./pdfsharp.drawing.xmatrix)<br>
Implements [IFormattable](https://docs.microsoft.com/en-us/dotnet/api/system.iformattable)

## Properties

### **Identity**

Gets the identity matrix.

```csharp
public static XMatrix Identity { get; }
```

#### Property Value

[XMatrix](./pdfsharp.drawing.xmatrix)<br>

### **IsIdentity**

Gets a value indicating whether this matrix instance is the identity matrix.

```csharp
public bool IsIdentity { get; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **Determinant**

Gets the determinant of this matrix.

```csharp
public double Determinant { get; }
```

#### Property Value

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **HasInverse**

Gets a value that indicates whether this matrix is invertible.

```csharp
public bool HasInverse { get; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **M11**

Gets or sets the value of the first row and first column of this matrix.

```csharp
public double M11 { get; set; }
```

#### Property Value

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **M12**

Gets or sets the value of the first row and second column of this matrix.

```csharp
public double M12 { get; set; }
```

#### Property Value

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **M21**

Gets or sets the value of the second row and first column of this matrix.

```csharp
public double M21 { get; set; }
```

#### Property Value

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **M22**

Gets or sets the value of the second row and second column of this matrix.

```csharp
public double M22 { get; set; }
```

#### Property Value

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **OffsetX**

Gets or sets the value of the third row and first column of this matrix.

```csharp
public double OffsetX { get; set; }
```

#### Property Value

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **OffsetY**

Gets or sets the value of the third row and second column of this matrix.

```csharp
public double OffsetY { get; set; }
```

#### Property Value

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

## Constructors

### **XMatrix(Double, Double, Double, Double, Double, Double)**

Initializes a new instance of the XMatrix struct.

```csharp
XMatrix(double m11, double m12, double m21, double m22, double offsetX, double offsetY)
```

#### Parameters

`m11` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`m12` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`m21` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`m22` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`offsetX` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`offsetY` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

## Methods

### **CreateScaling(Double, Double)**

```csharp
XMatrix CreateScaling(double scaleX, double scaleY)
```

#### Parameters

`scaleX` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`scaleY` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

#### Returns

[XMatrix](./pdfsharp.drawing.xmatrix)<br>

### **CreateScaling(Double, Double, Double, Double)**

```csharp
XMatrix CreateScaling(double scaleX, double scaleY, double centerX, double centerY)
```

#### Parameters

`scaleX` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`scaleY` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`centerX` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`centerY` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

#### Returns

[XMatrix](./pdfsharp.drawing.xmatrix)<br>

### **CreateSkewRadians(Double, Double, Double, Double)**

```csharp
XMatrix CreateSkewRadians(double skewX, double skewY, double centerX, double centerY)
```

#### Parameters

`skewX` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`skewY` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`centerX` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`centerY` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

#### Returns

[XMatrix](./pdfsharp.drawing.xmatrix)<br>

### **CreateSkewRadians(Double, Double)**

```csharp
XMatrix CreateSkewRadians(double skewX, double skewY)
```

#### Parameters

`skewX` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`skewY` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

#### Returns

[XMatrix](./pdfsharp.drawing.xmatrix)<br>

### **SetIdentity()**

Sets this matrix into an identity matrix.

```csharp
void SetIdentity()
```

### **GetElements()**

Gets an array of double values that represents the elements of this matrix.

```csharp
Double[] GetElements()
```

#### Returns

[Double[]](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **Multiply(XMatrix, XMatrix)**

Multiplies two matrices.

```csharp
XMatrix Multiply(XMatrix trans1, XMatrix trans2)
```

#### Parameters

`trans1` [XMatrix](./pdfsharp.drawing.xmatrix)<br>

`trans2` [XMatrix](./pdfsharp.drawing.xmatrix)<br>

#### Returns

[XMatrix](./pdfsharp.drawing.xmatrix)<br>

### **Append(XMatrix)**

Appends the specified matrix to this matrix.

```csharp
void Append(XMatrix matrix)
```

#### Parameters

`matrix` [XMatrix](./pdfsharp.drawing.xmatrix)<br>

### **Prepend(XMatrix)**

Prepends the specified matrix to this matrix.

```csharp
void Prepend(XMatrix matrix)
```

#### Parameters

`matrix` [XMatrix](./pdfsharp.drawing.xmatrix)<br>

### **Multiply(XMatrix)**

#### Caution

Use Append.

---

Appends the specified matrix to this matrix.

```csharp
void Multiply(XMatrix matrix)
```

#### Parameters

`matrix` [XMatrix](./pdfsharp.drawing.xmatrix)<br>

### **MultiplyPrepend(XMatrix)**

#### Caution

Use Prepend.

---

Prepends the specified matrix to this matrix.

```csharp
void MultiplyPrepend(XMatrix matrix)
```

#### Parameters

`matrix` [XMatrix](./pdfsharp.drawing.xmatrix)<br>

### **Multiply(XMatrix, XMatrixOrder)**

Multiplies this matrix with the specified matrix.

```csharp
void Multiply(XMatrix matrix, XMatrixOrder order)
```

#### Parameters

`matrix` [XMatrix](./pdfsharp.drawing.xmatrix)<br>

`order` [XMatrixOrder](./pdfsharp.drawing.xmatrixorder)<br>

### **Translate(Double, Double)**

#### Caution

Use TranslateAppend or TranslatePrepend explicitly, because in GDI+ and WPF the defaults are contrary.

---

Appends a translation of the specified offsets to this matrix.

```csharp
void Translate(double offsetX, double offsetY)
```

#### Parameters

`offsetX` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`offsetY` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **TranslateAppend(Double, Double)**

Appends a translation of the specified offsets to this matrix.

```csharp
void TranslateAppend(double offsetX, double offsetY)
```

#### Parameters

`offsetX` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`offsetY` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **TranslatePrepend(Double, Double)**

Prepends a translation of the specified offsets to this matrix.

```csharp
void TranslatePrepend(double offsetX, double offsetY)
```

#### Parameters

`offsetX` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`offsetY` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **Translate(Double, Double, XMatrixOrder)**

Translates the matrix with the specified offsets.

```csharp
void Translate(double offsetX, double offsetY, XMatrixOrder order)
```

#### Parameters

`offsetX` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`offsetY` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`order` [XMatrixOrder](./pdfsharp.drawing.xmatrixorder)<br>

### **Scale(Double, Double)**

#### Caution

Use ScaleAppend or ScalePrepend explicitly, because in GDI+ and WPF the defaults are contrary.

---

Appends the specified scale vector to this matrix.

```csharp
void Scale(double scaleX, double scaleY)
```

#### Parameters

`scaleX` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`scaleY` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **ScaleAppend(Double, Double)**

Appends the specified scale vector to this matrix.

```csharp
void ScaleAppend(double scaleX, double scaleY)
```

#### Parameters

`scaleX` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`scaleY` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **ScalePrepend(Double, Double)**

Prepends the specified scale vector to this matrix.

```csharp
void ScalePrepend(double scaleX, double scaleY)
```

#### Parameters

`scaleX` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`scaleY` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **Scale(Double, Double, XMatrixOrder)**

Scales the matrix with the specified scalars.

```csharp
void Scale(double scaleX, double scaleY, XMatrixOrder order)
```

#### Parameters

`scaleX` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`scaleY` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`order` [XMatrixOrder](./pdfsharp.drawing.xmatrixorder)<br>

### **Scale(Double)**

#### Caution

Use ScaleAppend or ScalePrepend explicitly, because in GDI+ and WPF the defaults are contrary.

---

Scales the matrix with the specified scalar.

```csharp
void Scale(double scaleXY)
```

#### Parameters

`scaleXY` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **ScaleAppend(Double)**

Appends the specified scale vector to this matrix.

```csharp
void ScaleAppend(double scaleXY)
```

#### Parameters

`scaleXY` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **ScalePrepend(Double)**

Prepends the specified scale vector to this matrix.

```csharp
void ScalePrepend(double scaleXY)
```

#### Parameters

`scaleXY` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **Scale(Double, XMatrixOrder)**

Scales the matrix with the specified scalar.

```csharp
void Scale(double scaleXY, XMatrixOrder order)
```

#### Parameters

`scaleXY` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`order` [XMatrixOrder](./pdfsharp.drawing.xmatrixorder)<br>

### **ScaleAt(Double, Double, Double, Double)**

#### Caution

Use ScaleAtAppend or ScaleAtPrepend explicitly, because in GDI+ and WPF the defaults are contrary.

---

Function is obsolete.

```csharp
void ScaleAt(double scaleX, double scaleY, double centerX, double centerY)
```

#### Parameters

`scaleX` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`scaleY` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`centerX` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`centerY` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **ScaleAtAppend(Double, Double, Double, Double)**

Appends the specified scale about the specified point of this matrix.

```csharp
void ScaleAtAppend(double scaleX, double scaleY, double centerX, double centerY)
```

#### Parameters

`scaleX` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`scaleY` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`centerX` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`centerY` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **ScaleAtPrepend(Double, Double, Double, Double)**

Prepends the specified scale about the specified point of this matrix.

```csharp
void ScaleAtPrepend(double scaleX, double scaleY, double centerX, double centerY)
```

#### Parameters

`scaleX` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`scaleY` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`centerX` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`centerY` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **Rotate(Double)**

#### Caution

Use RotateAppend or RotatePrepend explicitly, because in GDI+ and WPF the defaults are contrary.

---

Function is obsolete.

```csharp
void Rotate(double angle)
```

#### Parameters

`angle` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **RotateAppend(Double)**

Appends a rotation of the specified angle to this matrix.

```csharp
void RotateAppend(double angle)
```

#### Parameters

`angle` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **RotatePrepend(Double)**

Prepends a rotation of the specified angle to this matrix.

```csharp
void RotatePrepend(double angle)
```

#### Parameters

`angle` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **Rotate(Double, XMatrixOrder)**

Rotates the matrix with the specified angle.

```csharp
void Rotate(double angle, XMatrixOrder order)
```

#### Parameters

`angle` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`order` [XMatrixOrder](./pdfsharp.drawing.xmatrixorder)<br>

### **RotateAt(Double, Double, Double)**

#### Caution

Use RotateAtAppend or RotateAtPrepend explicitly, because in GDI+ and WPF the defaults are contrary.

---

Function is obsolete.

```csharp
void RotateAt(double angle, double centerX, double centerY)
```

#### Parameters

`angle` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`centerX` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`centerY` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **RotateAtAppend(Double, Double, Double)**

Appends a rotation of the specified angle at the specified point to this matrix.

```csharp
void RotateAtAppend(double angle, double centerX, double centerY)
```

#### Parameters

`angle` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`centerX` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`centerY` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **RotateAtPrepend(Double, Double, Double)**

Prepends a rotation of the specified angle at the specified point to this matrix.

```csharp
void RotateAtPrepend(double angle, double centerX, double centerY)
```

#### Parameters

`angle` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`centerX` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`centerY` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **RotateAt(Double, XPoint)**

#### Caution

Use RotateAtAppend or RotateAtPrepend explicitly, because in GDI+ and WPF the defaults are contrary.

---

Rotates the matrix with the specified angle at the specified point.

```csharp
void RotateAt(double angle, XPoint point)
```

#### Parameters

`angle` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`point` [XPoint](./pdfsharp.drawing.xpoint)<br>

### **RotateAtAppend(Double, XPoint)**

Appends a rotation of the specified angle at the specified point to this matrix.

```csharp
void RotateAtAppend(double angle, XPoint point)
```

#### Parameters

`angle` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`point` [XPoint](./pdfsharp.drawing.xpoint)<br>

### **RotateAtPrepend(Double, XPoint)**

Prepends a rotation of the specified angle at the specified point to this matrix.

```csharp
void RotateAtPrepend(double angle, XPoint point)
```

#### Parameters

`angle` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`point` [XPoint](./pdfsharp.drawing.xpoint)<br>

### **RotateAt(Double, XPoint, XMatrixOrder)**

Rotates the matrix with the specified angle at the specified point.

```csharp
void RotateAt(double angle, XPoint point, XMatrixOrder order)
```

#### Parameters

`angle` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`point` [XPoint](./pdfsharp.drawing.xpoint)<br>

`order` [XMatrixOrder](./pdfsharp.drawing.xmatrixorder)<br>

### **Shear(Double, Double)**

#### Caution

Use ShearAppend or ShearPrepend explicitly, because in GDI+ and WPF the defaults are contrary.

---

Function is obsolete.

```csharp
void Shear(double shearX, double shearY)
```

#### Parameters

`shearX` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`shearY` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **ShearAppend(Double, Double)**

Appends a skew of the specified degrees in the x and y dimensions to this matrix.

```csharp
void ShearAppend(double shearX, double shearY)
```

#### Parameters

`shearX` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`shearY` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **ShearPrepend(Double, Double)**

Prepends a skew of the specified degrees in the x and y dimensions to this matrix.

```csharp
void ShearPrepend(double shearX, double shearY)
```

#### Parameters

`shearX` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`shearY` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **Shear(Double, Double, XMatrixOrder)**

Shears the matrix with the specified scalars.

```csharp
void Shear(double shearX, double shearY, XMatrixOrder order)
```

#### Parameters

`shearX` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`shearY` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`order` [XMatrixOrder](./pdfsharp.drawing.xmatrixorder)<br>

### **Skew(Double, Double)**

#### Caution

Use SkewAppend or SkewPrepend explicitly, because in GDI+ and WPF the defaults are contrary.

---

Function is obsolete.

```csharp
void Skew(double skewX, double skewY)
```

#### Parameters

`skewX` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`skewY` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **SkewAppend(Double, Double)**

Appends a skew of the specified degrees in the x and y dimensions to this matrix.

```csharp
void SkewAppend(double skewX, double skewY)
```

#### Parameters

`skewX` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`skewY` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **SkewPrepend(Double, Double)**

Prepends a skew of the specified degrees in the x and y dimensions to this matrix.

```csharp
void SkewPrepend(double skewX, double skewY)
```

#### Parameters

`skewX` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`skewY` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **Transform(XPoint)**

Transforms the specified point by this matrix and returns the result.

```csharp
XPoint Transform(XPoint point)
```

#### Parameters

`point` [XPoint](./pdfsharp.drawing.xpoint)<br>

#### Returns

[XPoint](./pdfsharp.drawing.xpoint)<br>

### **Transform(XPoint[])**

Transforms the specified points by this matrix.

```csharp
void Transform(XPoint[] points)
```

#### Parameters

`points` [XPoint[]](./pdfsharp.drawing.xpoint)<br>

### **TransformPoints(XPoint[])**

Multiplies all points of the specified array with this matrix.

```csharp
void TransformPoints(XPoint[] points)
```

#### Parameters

`points` [XPoint[]](./pdfsharp.drawing.xpoint)<br>

### **Transform(XVector)**

Transforms the specified vector by this Matrix and returns the result.

```csharp
XVector Transform(XVector vector)
```

#### Parameters

`vector` [XVector](./pdfsharp.drawing.xvector)<br>

#### Returns

[XVector](./pdfsharp.drawing.xvector)<br>

### **Transform(XVector[])**

Transforms the specified vectors by this matrix.

```csharp
void Transform(XVector[] vectors)
```

#### Parameters

`vectors` [XVector[]](./pdfsharp.drawing.xvector)<br>

### **Invert()**

Inverts the matrix.

```csharp
void Invert()
```

### **Equals(XMatrix, XMatrix)**

Determines whether the two matrices are equal.

```csharp
bool Equals(XMatrix matrix1, XMatrix matrix2)
```

#### Parameters

`matrix1` [XMatrix](./pdfsharp.drawing.xmatrix)<br>

`matrix2` [XMatrix](./pdfsharp.drawing.xmatrix)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **Equals(Object)**

Determines whether this matrix is equal to the specified object.

```csharp
bool Equals(object o)
```

#### Parameters

`o` [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **Equals(XMatrix)**

Determines whether this matrix is equal to the specified matrix.

```csharp
bool Equals(XMatrix value)
```

#### Parameters

`value` [XMatrix](./pdfsharp.drawing.xmatrix)<br>

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

Parses a matrix from a string.

```csharp
XMatrix Parse(string source)
```

#### Parameters

`source` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

#### Returns

[XMatrix](./pdfsharp.drawing.xmatrix)<br>

### **ToString()**

Converts this XMatrix to a human readable string.

```csharp
string ToString()
```

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **ToString(IFormatProvider)**

Converts this XMatrix to a human readable string.

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

### **MultiplyVector(Double&, Double&)**

```csharp
void MultiplyVector(Double& x, Double& y)
```

#### Parameters

`x` [Double&](https://docs.microsoft.com/en-us/dotnet/api/system.double&)<br>

`y` [Double&](https://docs.microsoft.com/en-us/dotnet/api/system.double&)<br>

### **MultiplyPoint(Double&, Double&)**

```csharp
void MultiplyPoint(Double& x, Double& y)
```

#### Parameters

`x` [Double&](https://docs.microsoft.com/en-us/dotnet/api/system.double&)<br>

`y` [Double&](https://docs.microsoft.com/en-us/dotnet/api/system.double&)<br>

### **CreateTranslation(Double, Double)**

```csharp
XMatrix CreateTranslation(double offsetX, double offsetY)
```

#### Parameters

`offsetX` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`offsetY` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

#### Returns

[XMatrix](./pdfsharp.drawing.xmatrix)<br>

### **CreateRotationRadians(Double)**

```csharp
XMatrix CreateRotationRadians(double angle)
```

#### Parameters

`angle` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

#### Returns

[XMatrix](./pdfsharp.drawing.xmatrix)<br>

### **CreateRotationRadians(Double, Double, Double)**

```csharp
XMatrix CreateRotationRadians(double angle, double centerX, double centerY)
```

#### Parameters

`angle` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`centerX` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`centerY` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

#### Returns

[XMatrix](./pdfsharp.drawing.xmatrix)<br>
