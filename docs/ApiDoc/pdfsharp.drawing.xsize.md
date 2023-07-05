# XSize

Namespace: PdfSharp.Drawing

Represents a pair of floating-point numbers, typically the width and height of a
 graphical object.

```csharp
public struct XSize
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ValueType](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype) → [XSize](./pdfsharp.drawing.xsize)<br>
Implements [IFormattable](https://docs.microsoft.com/en-us/dotnet/api/system.iformattable)

## Properties

### **Empty**

Returns an empty size, i.e. a size with a width or height less than 0.

```csharp
public static XSize Empty { get; }
```

#### Property Value

[XSize](./pdfsharp.drawing.xsize)<br>

### **IsEmpty**

Gets a value indicating whether this instance is empty.

```csharp
public bool IsEmpty { get; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **Width**

Gets or sets the width.

```csharp
public double Width { get; set; }
```

#### Property Value

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **Height**

Gets or sets the height.

```csharp
public double Height { get; set; }
```

#### Property Value

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

## Constructors

### **XSize(Double, Double)**

Initializes a new instance of the XSize class with the specified values.

```csharp
XSize(double width, double height)
```

#### Parameters

`width` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`height` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

## Methods

### **Equals(XSize, XSize)**

Indicates whether these two instances are equal.

```csharp
bool Equals(XSize size1, XSize size2)
```

#### Parameters

`size1` [XSize](./pdfsharp.drawing.xsize)<br>

`size2` [XSize](./pdfsharp.drawing.xsize)<br>

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

### **Equals(XSize)**

Indicates whether this instance and a specified size are equal.

```csharp
bool Equals(XSize value)
```

#### Parameters

`value` [XSize](./pdfsharp.drawing.xsize)<br>

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

Parses the size from a string.

```csharp
XSize Parse(string source)
```

#### Parameters

`source` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

#### Returns

[XSize](./pdfsharp.drawing.xsize)<br>

### **ToXPoint()**

Converts this XSize to an XPoint.

```csharp
XPoint ToXPoint()
```

#### Returns

[XPoint](./pdfsharp.drawing.xpoint)<br>

### **ToXVector()**

Converts this XSize to an XVector.

```csharp
XVector ToXVector()
```

#### Returns

[XVector](./pdfsharp.drawing.xvector)<br>

### **ToString()**

Converts this XSize to a human readable string.

```csharp
string ToString()
```

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **ToString(IFormatProvider)**

Converts this XSize to a human readable string.

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
