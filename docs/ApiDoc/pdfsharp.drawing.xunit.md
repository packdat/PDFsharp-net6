# XUnit

Namespace: PdfSharp.Drawing

Represents a value and its unit of measure. The structure converts implicitly from and to
 double with a value measured in point.

```csharp
public struct XUnit
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ValueType](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype) → [XUnit](./pdfsharp.drawing.xunit)<br>
Implements [IFormattable](https://docs.microsoft.com/en-us/dotnet/api/system.iformattable)

## Fields

### **Zero**

Represents a unit with all values zero.

```csharp
public static XUnit Zero;
```

## Properties

### **Value**

Gets the raw value of the object without any conversion.
 To determine the XGraphicsUnit use property

```csharp
Type
```

.
 To get the value in point use the implicit conversion to double.

```csharp
public double Value { get; private set; }
```

#### Property Value

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **Type**

Gets the unit of measure.

```csharp
public XGraphicsUnit Type { get; private set; }
```

#### Property Value

[XGraphicsUnit](./pdfsharp.drawing.xgraphicsunit)<br>

### **Point**

Gets or sets the value in point.

```csharp
public double Point { get; set; }
```

#### Property Value

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **Inch**

Gets or sets the value in inch.

```csharp
public double Inch { get; set; }
```

#### Property Value

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **Millimeter**

Gets or sets the value in millimeter.

```csharp
public double Millimeter { get; set; }
```

#### Property Value

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **Centimeter**

Gets or sets the value in centimeter.

```csharp
public double Centimeter { get; set; }
```

#### Property Value

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **Presentation**

Gets or sets the value in presentation units (1/96 inch).

```csharp
public double Presentation { get; set; }
```

#### Property Value

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

## Constructors

### **XUnit(Double)**

Initializes a new instance of the XUnit class with type set to point.

```csharp
XUnit(double point)
```

#### Parameters

`point` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **XUnit(Double, XGraphicsUnit)**

Initializes a new instance of the XUnit class.

```csharp
XUnit(double value, XGraphicsUnit type)
```

#### Parameters

`value` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`type` [XGraphicsUnit](./pdfsharp.drawing.xgraphicsunit)<br>

## Methods

### **ToString(IFormatProvider)**

Returns the object as string using the format information.
 The unit of measure is appended to the end of the string.

```csharp
string ToString(IFormatProvider formatProvider)
```

#### Parameters

`formatProvider` [IFormatProvider](https://docs.microsoft.com/en-us/dotnet/api/system.iformatprovider)<br>

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **ToString()**

Returns the object as string. The unit of measure is appended to the end of the string.

```csharp
string ToString()
```

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **FromPoint(Double)**

Returns an XUnit object. Sets type to point.

```csharp
XUnit FromPoint(double value)
```

#### Parameters

`value` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

#### Returns

[XUnit](./pdfsharp.drawing.xunit)<br>

### **FromInch(Double)**

Returns an XUnit object. Sets type to inch.

```csharp
XUnit FromInch(double value)
```

#### Parameters

`value` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

#### Returns

[XUnit](./pdfsharp.drawing.xunit)<br>

### **FromMillimeter(Double)**

Returns an XUnit object. Sets type to millimeters.

```csharp
XUnit FromMillimeter(double value)
```

#### Parameters

`value` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

#### Returns

[XUnit](./pdfsharp.drawing.xunit)<br>

### **FromCentimeter(Double)**

Returns an XUnit object. Sets type to centimeters.

```csharp
XUnit FromCentimeter(double value)
```

#### Parameters

`value` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

#### Returns

[XUnit](./pdfsharp.drawing.xunit)<br>

### **FromPresentation(Double)**

Returns an XUnit object. Sets type to Presentation.

```csharp
XUnit FromPresentation(double value)
```

#### Parameters

`value` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

#### Returns

[XUnit](./pdfsharp.drawing.xunit)<br>

### **Equals(Object)**

Calls base class Equals.

```csharp
bool Equals(object obj)
```

#### Parameters

`obj` [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)<br>

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

This member is intended to be used by XmlDomainObjectReader only.

```csharp
XUnit Parse(string value)
```

#### Parameters

`value` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

#### Returns

[XUnit](./pdfsharp.drawing.xunit)<br>

### **ConvertType(XGraphicsUnit)**

Converts an existing object from one unit into another unit type.

```csharp
void ConvertType(XGraphicsUnit type)
```

#### Parameters

`type` [XGraphicsUnit](./pdfsharp.drawing.xgraphicsunit)<br>
