# Pixel

Namespace: PdfSharp.BigGustave

A pixel in a [Png](./pdfsharp.biggustave.png) image.

```csharp
public struct Pixel
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ValueType](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype) → [Pixel](./pdfsharp.biggustave.pixel)

## Properties

### **R**

The red value for the pixel.

```csharp
public byte R { get; }
```

#### Property Value

[Byte](https://docs.microsoft.com/en-us/dotnet/api/system.byte)<br>

### **G**

The green value for the pixel.

```csharp
public byte G { get; }
```

#### Property Value

[Byte](https://docs.microsoft.com/en-us/dotnet/api/system.byte)<br>

### **B**

The blue value for the pixel.

```csharp
public byte B { get; }
```

#### Property Value

[Byte](https://docs.microsoft.com/en-us/dotnet/api/system.byte)<br>

### **A**

The alpha transparency value for the pixel.

```csharp
public byte A { get; }
```

#### Property Value

[Byte](https://docs.microsoft.com/en-us/dotnet/api/system.byte)<br>

### **IsGrayscale**

Whether the pixel is grayscale (if [Pixel.R](./pdfsharp.biggustave.pixel#r), [Pixel.G](./pdfsharp.biggustave.pixel#g) and [Pixel.B](./pdfsharp.biggustave.pixel#b) will all have the same value).

```csharp
public bool IsGrayscale { get; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

## Constructors

### **Pixel(Byte, Byte, Byte, Byte, Boolean)**

Create a new [Pixel](./pdfsharp.biggustave.pixel).

```csharp
Pixel(byte r, byte g, byte b, byte a, bool isGrayscale)
```

#### Parameters

`r` [Byte](https://docs.microsoft.com/en-us/dotnet/api/system.byte)<br>
The red value for the pixel.

`g` [Byte](https://docs.microsoft.com/en-us/dotnet/api/system.byte)<br>
The green value for the pixel.

`b` [Byte](https://docs.microsoft.com/en-us/dotnet/api/system.byte)<br>
The blue value for the pixel.

`a` [Byte](https://docs.microsoft.com/en-us/dotnet/api/system.byte)<br>
The alpha transparency value for the pixel.

`isGrayscale` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
Whether the pixel is grayscale.

### **Pixel(Byte, Byte, Byte)**

Create a new [Pixel](./pdfsharp.biggustave.pixel) which has [Pixel.IsGrayscale](./pdfsharp.biggustave.pixel#isgrayscale) false and is fully opaque.

```csharp
Pixel(byte r, byte g, byte b)
```

#### Parameters

`r` [Byte](https://docs.microsoft.com/en-us/dotnet/api/system.byte)<br>
The red value for the pixel.

`g` [Byte](https://docs.microsoft.com/en-us/dotnet/api/system.byte)<br>
The green value for the pixel.

`b` [Byte](https://docs.microsoft.com/en-us/dotnet/api/system.byte)<br>
The blue value for the pixel.

### **Pixel(Byte)**

Create a new grayscale [Pixel](./pdfsharp.biggustave.pixel).

```csharp
Pixel(byte grayscale)
```

#### Parameters

`grayscale` [Byte](https://docs.microsoft.com/en-us/dotnet/api/system.byte)<br>
The grayscale value.

## Methods

### **Equals(Object)**

```csharp
bool Equals(object obj)
```

#### Parameters

`obj` [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **Equals(Pixel)**

Whether the pixel values are equal.

```csharp
bool Equals(Pixel other)
```

#### Parameters

`other` [Pixel](./pdfsharp.biggustave.pixel)<br>
The other pixel.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
if all pixel values are equal otherwise .

### **GetHashCode()**

```csharp
int GetHashCode()
```

#### Returns

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **ToString()**

```csharp
string ToString()
```

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
