# XColor

Namespace: PdfSharp.Drawing

Represents an RGB, CMYK, or gray scale color.

```csharp
public struct XColor
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ValueType](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype) → [XColor](./pdfsharp.drawing.xcolor)

## Fields

### **Empty**

Represents the empty color.

```csharp
public static XColor Empty;
```

## Properties

### **ColorSpace**

Gets or sets the color space to be used for PDF generation.

```csharp
public XColorSpace ColorSpace { get; set; }
```

#### Property Value

[XColorSpace](./pdfsharp.drawing.xcolorspace)<br>

### **IsEmpty**

Indicates whether this XColor structure is uninitialized.

```csharp
public bool IsEmpty { get; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **IsKnownColor**

Gets a value indicating whether this color is a known color.

```csharp
public bool IsKnownColor { get; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **A**

Gets or sets the alpha value the specifies the transparency. 
 The value is in the range from 1 (opaque) to 0 (completely transparent).

```csharp
public double A { get; set; }
```

#### Property Value

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **R**

Gets or sets the red value.

```csharp
public byte R { get; set; }
```

#### Property Value

[Byte](https://docs.microsoft.com/en-us/dotnet/api/system.byte)<br>

### **G**

Gets or sets the green value.

```csharp
public byte G { get; set; }
```

#### Property Value

[Byte](https://docs.microsoft.com/en-us/dotnet/api/system.byte)<br>

### **B**

Gets or sets the blue value.

```csharp
public byte B { get; set; }
```

#### Property Value

[Byte](https://docs.microsoft.com/en-us/dotnet/api/system.byte)<br>

### **C**

Gets or sets the cyan value.

```csharp
public double C { get; set; }
```

#### Property Value

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **M**

Gets or sets the magenta value.

```csharp
public double M { get; set; }
```

#### Property Value

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **Y**

Gets or sets the yellow value.

```csharp
public double Y { get; set; }
```

#### Property Value

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **K**

Gets or sets the black (or key) value.

```csharp
public double K { get; set; }
```

#### Property Value

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **GS**

Gets or sets the gray scale value.

```csharp
public double GS { get; set; }
```

#### Property Value

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **RgbCmykG**

Special property for XmlSerializer only.

```csharp
public string RgbCmykG { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

## Methods

### **FromArgb(Int32)**

Creates an XColor structure from a 32-bit ARGB value.

```csharp
XColor FromArgb(int argb)
```

#### Parameters

`argb` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

#### Returns

[XColor](./pdfsharp.drawing.xcolor)<br>

### **FromArgb(UInt32)**

Creates an XColor structure from a 32-bit ARGB value.

```csharp
XColor FromArgb(uint argb)
```

#### Parameters

`argb` [UInt32](https://docs.microsoft.com/en-us/dotnet/api/system.uint32)<br>

#### Returns

[XColor](./pdfsharp.drawing.xcolor)<br>

### **FromArgb(Int32, Int32, Int32)**

Creates an XColor structure from the specified 8-bit color values (red, green, and blue).
 The alpha value is implicitly 255 (fully opaque).

```csharp
XColor FromArgb(int red, int green, int blue)
```

#### Parameters

`red` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

`green` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

`blue` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

#### Returns

[XColor](./pdfsharp.drawing.xcolor)<br>

### **FromArgb(Int32, Int32, Int32, Int32)**

Creates an XColor structure from the four ARGB component (alpha, red, green, and blue) values.

```csharp
XColor FromArgb(int alpha, int red, int green, int blue)
```

#### Parameters

`alpha` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

`red` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

`green` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

`blue` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

#### Returns

[XColor](./pdfsharp.drawing.xcolor)<br>

### **FromArgb(Int32, XColor)**

Creates an XColor structure from the specified alpha value and color.

```csharp
XColor FromArgb(int alpha, XColor color)
```

#### Parameters

`alpha` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

`color` [XColor](./pdfsharp.drawing.xcolor)<br>

#### Returns

[XColor](./pdfsharp.drawing.xcolor)<br>

### **FromCmyk(Double, Double, Double, Double)**

Creates an XColor structure from the specified CMYK values.

```csharp
XColor FromCmyk(double cyan, double magenta, double yellow, double black)
```

#### Parameters

`cyan` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`magenta` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`yellow` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`black` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

#### Returns

[XColor](./pdfsharp.drawing.xcolor)<br>

### **FromCmyk(Double, Double, Double, Double, Double)**

Creates an XColor structure from the specified CMYK values.

```csharp
XColor FromCmyk(double alpha, double cyan, double magenta, double yellow, double black)
```

#### Parameters

`alpha` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`cyan` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`magenta` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`yellow` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`black` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

#### Returns

[XColor](./pdfsharp.drawing.xcolor)<br>

### **FromGrayScale(Double)**

Creates an XColor structure from the specified gray value.

```csharp
XColor FromGrayScale(double grayScale)
```

#### Parameters

`grayScale` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

#### Returns

[XColor](./pdfsharp.drawing.xcolor)<br>

### **FromKnownColor(XKnownColor)**

Creates an XColor from the specified pre-defined color.

```csharp
XColor FromKnownColor(XKnownColor color)
```

#### Parameters

`color` [XKnownColor](./pdfsharp.drawing.xknowncolor)<br>

#### Returns

[XColor](./pdfsharp.drawing.xcolor)<br>

### **FromName(String)**

#### Caution

Not really implemented and not useful. See XColorResourceManager.

---

Creates an XColor from the specified name of a pre-defined color.

```csharp
XColor FromName(string name)
```

#### Parameters

`name` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

#### Returns

[XColor](./pdfsharp.drawing.xcolor)<br>

### **Equals(Object)**

Determines whether the specified object is a Color structure and is equivalent to this 
 Color structure.

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

### **GetHue()**

Gets the hue-saturation-brightness (HSB) hue value, in degrees, for this color.

```csharp
double GetHue()
```

#### Returns

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The hue, in degrees, of this color. The hue is measured in degrees, ranging from 0 through 360, in HSB color space.

### **GetSaturation()**

Gets the hue-saturation-brightness (HSB) saturation value for this color.

```csharp
double GetSaturation()
```

#### Returns

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The saturation of this color. The saturation ranges from 0 through 1, where 0 is grayscale and 1 is the most saturated.

### **GetBrightness()**

Gets the hue-saturation-brightness (HSB) brightness value for this color.

```csharp
double GetBrightness()
```

#### Returns

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The brightness of this color. The brightness ranges from 0 through 1, where 0 represents black and 1 represents white.
