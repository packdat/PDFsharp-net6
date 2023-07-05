# ImageHeader

Namespace: PdfSharp.BigGustave

The high level information about the image.

```csharp
public struct ImageHeader
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ValueType](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype) → [ImageHeader](./pdfsharp.biggustave.imageheader)

## Properties

### **Width**

The width of the image in pixels.

```csharp
public int Width { get; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **Height**

The height of the image in pixels.

```csharp
public int Height { get; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **BitDepth**

The bit depth of the image.

```csharp
public byte BitDepth { get; }
```

#### Property Value

[Byte](https://docs.microsoft.com/en-us/dotnet/api/system.byte)<br>

### **ColorType**

The color type of the image.

```csharp
public ColorType ColorType { get; }
```

#### Property Value

[ColorType](./pdfsharp.biggustave.colortype)<br>

### **CompressionMethod**

The compression method used for the image.

```csharp
public CompressionMethod CompressionMethod { get; }
```

#### Property Value

[CompressionMethod](./pdfsharp.biggustave.compressionmethod)<br>

### **FilterMethod**

The filter method used for the image.

```csharp
public FilterMethod FilterMethod { get; }
```

#### Property Value

[FilterMethod](./pdfsharp.biggustave.filtermethod)<br>

### **InterlaceMethod**

The interlace method used by the image..

```csharp
public InterlaceMethod InterlaceMethod { get; }
```

#### Property Value

[InterlaceMethod](./pdfsharp.biggustave.interlacemethod)<br>

## Constructors

### **ImageHeader(Int32, Int32, Byte, ColorType, CompressionMethod, FilterMethod, InterlaceMethod)**

Create a new [ImageHeader](./pdfsharp.biggustave.imageheader).

```csharp
ImageHeader(int width, int height, byte bitDepth, ColorType colorType, CompressionMethod compressionMethod, FilterMethod filterMethod, InterlaceMethod interlaceMethod)
```

#### Parameters

`width` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

`height` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

`bitDepth` [Byte](https://docs.microsoft.com/en-us/dotnet/api/system.byte)<br>

`colorType` [ColorType](./pdfsharp.biggustave.colortype)<br>

`compressionMethod` [CompressionMethod](./pdfsharp.biggustave.compressionmethod)<br>

`filterMethod` [FilterMethod](./pdfsharp.biggustave.filtermethod)<br>

`interlaceMethod` [InterlaceMethod](./pdfsharp.biggustave.interlacemethod)<br>

## Methods

### **ToString()**

```csharp
string ToString()
```

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
