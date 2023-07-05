# Palette

Namespace: PdfSharp.BigGustave

The Palette class.

```csharp
public class Palette
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [Palette](./pdfsharp.biggustave.palette)

## Properties

### **HasAlphaValues**

True if palette has alpha values.

```csharp
public bool HasAlphaValues { get; private set; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **Data**

The palette data.

```csharp
public Byte[] Data { get; }
```

#### Property Value

[Byte[]](https://docs.microsoft.com/en-us/dotnet/api/system.byte)<br>

## Constructors

### **Palette(Byte[])**

Creates a palette object. Input palette data length from PLTE chunk must be a multiple of 3.

```csharp
public Palette(Byte[] data)
```

#### Parameters

`data` [Byte[]](https://docs.microsoft.com/en-us/dotnet/api/system.byte)<br>

## Methods

### **SetAlphaValues(Byte[])**

Adds transparency values from tRNS chunk.

```csharp
public void SetAlphaValues(Byte[] bytes)
```

#### Parameters

`bytes` [Byte[]](https://docs.microsoft.com/en-us/dotnet/api/system.byte)<br>

### **GetPixel(Int32)**

Gets the palette entry for a specific index.

```csharp
public Pixel GetPixel(int index)
```

#### Parameters

`index` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

#### Returns

[Pixel](./pdfsharp.biggustave.pixel)<br>
