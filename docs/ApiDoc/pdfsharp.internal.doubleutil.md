# DoubleUtil

Namespace: PdfSharp.Internal

Some floating-point utilities. Partially taken from WPF.

```csharp
public static class DoubleUtil
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [DoubleUtil](./pdfsharp.internal.doubleutil)

## Methods

### **AreClose(Double, Double)**

Indicates whether the values are so close that they can be considered as equal.

```csharp
public static bool AreClose(double value1, double value2)
```

#### Parameters

`value1` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`value2` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **AreRoughlyEqual(Double, Double, Int32)**

Indicates whether the values are so close that they can be considered as equal.

```csharp
public static bool AreRoughlyEqual(double value1, double value2, int decimalPlace)
```

#### Parameters

`value1` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`value2` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`decimalPlace` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **AreClose(XPoint, XPoint)**

Indicates whether the values are so close that they can be considered as equal.

```csharp
public static bool AreClose(XPoint point1, XPoint point2)
```

#### Parameters

`point1` [XPoint](./pdfsharp.drawing.xpoint)<br>

`point2` [XPoint](./pdfsharp.drawing.xpoint)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **AreClose(XRect, XRect)**

Indicates whether the values are so close that they can be considered as equal.

```csharp
public static bool AreClose(XRect rect1, XRect rect2)
```

#### Parameters

`rect1` [XRect](./pdfsharp.drawing.xrect)<br>

`rect2` [XRect](./pdfsharp.drawing.xrect)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **AreClose(XSize, XSize)**

Indicates whether the values are so close that they can be considered as equal.

```csharp
public static bool AreClose(XSize size1, XSize size2)
```

#### Parameters

`size1` [XSize](./pdfsharp.drawing.xsize)<br>

`size2` [XSize](./pdfsharp.drawing.xsize)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **AreClose(XVector, XVector)**

Indicates whether the values are so close that they can be considered as equal.

```csharp
public static bool AreClose(XVector vector1, XVector vector2)
```

#### Parameters

`vector1` [XVector](./pdfsharp.drawing.xvector)<br>

`vector2` [XVector](./pdfsharp.drawing.xvector)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **GreaterThan(Double, Double)**

Indicates whether value1 is greater than value2 and the values are not close to each other.

```csharp
public static bool GreaterThan(double value1, double value2)
```

#### Parameters

`value1` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`value2` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **GreaterThanOrClose(Double, Double)**

Indicates whether value1 is greater than value2 or the values are close to each other.

```csharp
public static bool GreaterThanOrClose(double value1, double value2)
```

#### Parameters

`value1` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`value2` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **LessThan(Double, Double)**

Indicates whether value1 is less than value2 and the values are not close to each other.

```csharp
public static bool LessThan(double value1, double value2)
```

#### Parameters

`value1` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`value2` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **LessThanOrClose(Double, Double)**

Indicates whether value1 is less than value2 or the values are close to each other.

```csharp
public static bool LessThanOrClose(double value1, double value2)
```

#### Parameters

`value1` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`value2` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **IsBetweenZeroAndOne(Double)**

Indicates whether the value is between 0 and 1 or close to 0 or 1.

```csharp
public static bool IsBetweenZeroAndOne(double value)
```

#### Parameters

`value` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **IsNaN(Double)**

Indicates whether the value is not a number.

```csharp
public static bool IsNaN(double value)
```

#### Parameters

`value` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **RectHasNaN(XRect)**

Indicates whether at least one of the four rectangle values is not a number.

```csharp
public static bool RectHasNaN(XRect r)
```

#### Parameters

`r` [XRect](./pdfsharp.drawing.xrect)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **IsOne(Double)**

Indicates whether the value is 1 or close to 1.

```csharp
public static bool IsOne(double value)
```

#### Parameters

`value` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **IsZero(Double)**

Indicates whether the value is 0 or close to 0.

```csharp
public static bool IsZero(double value)
```

#### Parameters

`value` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **DoubleToInt(Double)**

Converts a double to integer.

```csharp
public static int DoubleToInt(double value)
```

#### Parameters

`value` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

#### Returns

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
