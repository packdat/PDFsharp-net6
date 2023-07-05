# PdfRectangle

Namespace: PdfSharp.Pdf

Represents a PDF rectangle value, that is internally an array with 4 real values.

```csharp
public sealed class PdfRectangle : PdfItem, System.ICloneable
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [PdfItem](./pdfsharp.pdf.pdfitem) → [PdfRectangle](./pdfsharp.pdf.pdfrectangle)<br>
Implements [ICloneable](https://docs.microsoft.com/en-us/dotnet/api/system.icloneable)

## Fields

### **Empty**

Represents an empty PdfRectangle.

```csharp
public static PdfRectangle Empty;
```

## Properties

### **IsEmpty**

Tests whether all coordinates are zero.

```csharp
public bool IsEmpty { get; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **X1**

Gets or sets the x-coordinate of the first corner of this PdfRectangle.

```csharp
public double X1 { get; }
```

#### Property Value

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **Y1**

Gets or sets the y-coordinate of the first corner of this PdfRectangle.

```csharp
public double Y1 { get; }
```

#### Property Value

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **X2**

Gets or sets the x-coordinate of the second corner of this PdfRectangle.

```csharp
public double X2 { get; }
```

#### Property Value

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **Y2**

Gets or sets the y-coordinate of the second corner of this PdfRectangle.

```csharp
public double Y2 { get; }
```

#### Property Value

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **Width**

Gets X2 - X1.

```csharp
public double Width { get; }
```

#### Property Value

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **Height**

Gets Y2 - Y1.

```csharp
public double Height { get; }
```

#### Property Value

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **Location**

Gets or sets the coordinates of the first point of this PdfRectangle.

```csharp
public XPoint Location { get; }
```

#### Property Value

[XPoint](./pdfsharp.drawing.xpoint)<br>

### **Size**

Gets or sets the size of this PdfRectangle.

```csharp
public XSize Size { get; }
```

#### Property Value

[XSize](./pdfsharp.drawing.xsize)<br>

## Constructors

### **PdfRectangle()**

Initializes a new instance of the PdfRectangle class.

```csharp
public PdfRectangle()
```

### **PdfRectangle(XPoint, XPoint)**

Initializes a new instance of the PdfRectangle class with two points specifying
 two diagonally opposite corners.

```csharp
public PdfRectangle(XPoint pt1, XPoint pt2)
```

#### Parameters

`pt1` [XPoint](./pdfsharp.drawing.xpoint)<br>

`pt2` [XPoint](./pdfsharp.drawing.xpoint)<br>

### **PdfRectangle(XPoint, XSize)**

Initializes a new instance of the PdfRectangle class with the specified location and size.

```csharp
public PdfRectangle(XPoint pt, XSize size)
```

#### Parameters

`pt` [XPoint](./pdfsharp.drawing.xpoint)<br>

`size` [XSize](./pdfsharp.drawing.xsize)<br>

### **PdfRectangle(XRect)**

Initializes a new instance of the PdfRectangle class with the specified XRect.

```csharp
public PdfRectangle(XRect rect)
```

#### Parameters

`rect` [XRect](./pdfsharp.drawing.xrect)<br>

## Methods

### **Clone()**

Clones this instance.

```csharp
public PdfRectangle Clone()
```

#### Returns

[PdfRectangle](./pdfsharp.pdf.pdfrectangle)<br>

### **Copy()**

Implements cloning this instance.

```csharp
protected object Copy()
```

#### Returns

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)<br>

### **Equals(Object)**

Tests whether the specified object is a PdfRectangle and has equal coordinates.

```csharp
public bool Equals(object obj)
```

#### Parameters

`obj` [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **GetHashCode()**

Serves as a hash function for a particular type.

```csharp
public int GetHashCode()
```

#### Returns

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **Contains(XPoint)**

Determines if the specified point is contained within this PdfRectangle.

```csharp
public bool Contains(XPoint pt)
```

#### Parameters

`pt` [XPoint](./pdfsharp.drawing.xpoint)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **Contains(Double, Double)**

Determines if the specified point is contained within this PdfRectangle.

```csharp
public bool Contains(double x, double y)
```

#### Parameters

`x` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`y` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **Contains(XRect)**

Determines if the rectangular region represented by rect is entirely contained within this PdfRectangle.

```csharp
public bool Contains(XRect rect)
```

#### Parameters

`rect` [XRect](./pdfsharp.drawing.xrect)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **Contains(PdfRectangle)**

Determines if the rectangular region represented by rect is entirely contained within this PdfRectangle.

```csharp
public bool Contains(PdfRectangle rect)
```

#### Parameters

`rect` [PdfRectangle](./pdfsharp.pdf.pdfrectangle)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **ToXRect()**

Returns the rectangle as an XRect object.

```csharp
public XRect ToXRect()
```

#### Returns

[XRect](./pdfsharp.drawing.xrect)<br>

### **ToString()**

Returns the rectangle as a string in the form «[x1 y1 x2 y2]».

```csharp
public string ToString()
```

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **WriteObject(PdfWriter)**

Writes the rectangle.

```csharp
internal void WriteObject(PdfWriter writer)
```

#### Parameters

`writer` [PdfWriter](./pdfsharp.pdf.io.pdfwriter)<br>
