# PdfUInteger

Namespace: PdfSharp.Pdf

Represents a direct unsigned integer value.

```csharp
public sealed class PdfUInteger : PdfNumber, System.ICloneable, System.IConvertible
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [PdfItem](./pdfsharp.pdf.pdfitem) → [PdfNumber](./pdfsharp.pdf.pdfnumber) → [PdfUInteger](./pdfsharp.pdf.pdfuinteger)<br>
Implements [ICloneable](https://docs.microsoft.com/en-us/dotnet/api/system.icloneable), [IConvertible](https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible)

## Properties

### **Value**

Gets the value as integer.

```csharp
public uint Value { get; }
```

#### Property Value

[UInt32](https://docs.microsoft.com/en-us/dotnet/api/system.uint32)<br>

## Constructors

### **PdfUInteger()**

Initializes a new instance of the [PdfUInteger](./pdfsharp.pdf.pdfuinteger) class.

```csharp
public PdfUInteger()
```

### **PdfUInteger(UInt32)**

Initializes a new instance of the [PdfUInteger](./pdfsharp.pdf.pdfuinteger) class.

```csharp
public PdfUInteger(uint value)
```

#### Parameters

`value` [UInt32](https://docs.microsoft.com/en-us/dotnet/api/system.uint32)<br>

## Methods

### **ToString()**

Returns the unsigned integer as string.

```csharp
public string ToString()
```

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **WriteObject(PdfWriter)**

Writes the integer as string.

```csharp
internal void WriteObject(PdfWriter writer)
```

#### Parameters

`writer` [PdfWriter](./pdfsharp.pdf.io.pdfwriter)<br>

### **ToUInt64(IFormatProvider)**

Converts the value of this instance to an equivalent 64-bit unsigned integer.

```csharp
public ulong ToUInt64(IFormatProvider provider)
```

#### Parameters

`provider` [IFormatProvider](https://docs.microsoft.com/en-us/dotnet/api/system.iformatprovider)<br>

#### Returns

[UInt64](https://docs.microsoft.com/en-us/dotnet/api/system.uint64)<br>

### **ToSByte(IFormatProvider)**

Converts the value of this instance to an equivalent 8-bit signed integer.

```csharp
public sbyte ToSByte(IFormatProvider provider)
```

#### Parameters

`provider` [IFormatProvider](https://docs.microsoft.com/en-us/dotnet/api/system.iformatprovider)<br>

#### Returns

[SByte](https://docs.microsoft.com/en-us/dotnet/api/system.sbyte)<br>

### **ToDouble(IFormatProvider)**

Converts the value of this instance to an equivalent double-precision floating-point number.

```csharp
public double ToDouble(IFormatProvider provider)
```

#### Parameters

`provider` [IFormatProvider](https://docs.microsoft.com/en-us/dotnet/api/system.iformatprovider)<br>

#### Returns

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **ToDateTime(IFormatProvider)**

Returns an undefined DateTime structure.

```csharp
public DateTime ToDateTime(IFormatProvider provider)
```

#### Parameters

`provider` [IFormatProvider](https://docs.microsoft.com/en-us/dotnet/api/system.iformatprovider)<br>

#### Returns

[DateTime](https://docs.microsoft.com/en-us/dotnet/api/system.datetime)<br>

### **ToSingle(IFormatProvider)**

Converts the value of this instance to an equivalent single-precision floating-point number.

```csharp
public float ToSingle(IFormatProvider provider)
```

#### Parameters

`provider` [IFormatProvider](https://docs.microsoft.com/en-us/dotnet/api/system.iformatprovider)<br>

#### Returns

[Single](https://docs.microsoft.com/en-us/dotnet/api/system.single)<br>

### **ToBoolean(IFormatProvider)**

Converts the value of this instance to an equivalent Boolean value.

```csharp
public bool ToBoolean(IFormatProvider provider)
```

#### Parameters

`provider` [IFormatProvider](https://docs.microsoft.com/en-us/dotnet/api/system.iformatprovider)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **ToInt32(IFormatProvider)**

Converts the value of this instance to an equivalent 32-bit signed integer.

```csharp
public int ToInt32(IFormatProvider provider)
```

#### Parameters

`provider` [IFormatProvider](https://docs.microsoft.com/en-us/dotnet/api/system.iformatprovider)<br>

#### Returns

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **ToUInt16(IFormatProvider)**

Converts the value of this instance to an equivalent 16-bit unsigned integer.

```csharp
public ushort ToUInt16(IFormatProvider provider)
```

#### Parameters

`provider` [IFormatProvider](https://docs.microsoft.com/en-us/dotnet/api/system.iformatprovider)<br>

#### Returns

[UInt16](https://docs.microsoft.com/en-us/dotnet/api/system.uint16)<br>

### **ToInt16(IFormatProvider)**

Converts the value of this instance to an equivalent 16-bit signed integer.

```csharp
public short ToInt16(IFormatProvider provider)
```

#### Parameters

`provider` [IFormatProvider](https://docs.microsoft.com/en-us/dotnet/api/system.iformatprovider)<br>

#### Returns

[Int16](https://docs.microsoft.com/en-us/dotnet/api/system.int16)<br>

### **ToByte(IFormatProvider)**

Converts the value of this instance to an equivalent 8-bit unsigned integer.

```csharp
public byte ToByte(IFormatProvider provider)
```

#### Parameters

`provider` [IFormatProvider](https://docs.microsoft.com/en-us/dotnet/api/system.iformatprovider)<br>

#### Returns

[Byte](https://docs.microsoft.com/en-us/dotnet/api/system.byte)<br>

### **ToChar(IFormatProvider)**

Converts the value of this instance to an equivalent Unicode character.

```csharp
public char ToChar(IFormatProvider provider)
```

#### Parameters

`provider` [IFormatProvider](https://docs.microsoft.com/en-us/dotnet/api/system.iformatprovider)<br>

#### Returns

[Char](https://docs.microsoft.com/en-us/dotnet/api/system.char)<br>

### **ToInt64(IFormatProvider)**

Converts the value of this instance to an equivalent 64-bit signed integer.

```csharp
public long ToInt64(IFormatProvider provider)
```

#### Parameters

`provider` [IFormatProvider](https://docs.microsoft.com/en-us/dotnet/api/system.iformatprovider)<br>

#### Returns

[Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>

### **GetTypeCode()**

Returns type code for 32-bit integers.

```csharp
public TypeCode GetTypeCode()
```

#### Returns

[TypeCode](https://docs.microsoft.com/en-us/dotnet/api/system.typecode)<br>

### **ToDecimal(IFormatProvider)**

Converts the value of this instance to an equivalent [Decimal](https://docs.microsoft.com/en-us/dotnet/api/system.decimal) number.

```csharp
public decimal ToDecimal(IFormatProvider provider)
```

#### Parameters

`provider` [IFormatProvider](https://docs.microsoft.com/en-us/dotnet/api/system.iformatprovider)<br>

#### Returns

[Decimal](https://docs.microsoft.com/en-us/dotnet/api/system.decimal)<br>

### **ToType(Type, IFormatProvider)**

Returns null.

```csharp
public object ToType(Type conversionType, IFormatProvider provider)
```

#### Parameters

`conversionType` [Type](https://docs.microsoft.com/en-us/dotnet/api/system.type)<br>

`provider` [IFormatProvider](https://docs.microsoft.com/en-us/dotnet/api/system.iformatprovider)<br>

#### Returns

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)<br>

### **ToUInt32(IFormatProvider)**

Converts the value of this instance to an equivalent 32-bit unsigned integer.

```csharp
public uint ToUInt32(IFormatProvider provider)
```

#### Parameters

`provider` [IFormatProvider](https://docs.microsoft.com/en-us/dotnet/api/system.iformatprovider)<br>

#### Returns

[UInt32](https://docs.microsoft.com/en-us/dotnet/api/system.uint32)<br>
