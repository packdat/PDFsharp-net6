# Crc32

Namespace: PdfSharp.BigGustave

32-bit Cyclic Redundancy Code used by the PNG for checking the data is intact.

```csharp
public static class Crc32
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [Crc32](./pdfsharp.biggustave.crc32)

## Methods

### **Calculate(Byte[])**

Calculate the CRC32 for data.

```csharp
public static uint Calculate(Byte[] data)
```

#### Parameters

`data` [Byte[]](https://docs.microsoft.com/en-us/dotnet/api/system.byte)<br>

#### Returns

[UInt32](https://docs.microsoft.com/en-us/dotnet/api/system.uint32)<br>

### **Calculate(List&lt;Byte&gt;)**

Calculate the CRC32 for data.

```csharp
public static uint Calculate(List<byte> data)
```

#### Parameters

`data` [List&lt;Byte&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)<br>

#### Returns

[UInt32](https://docs.microsoft.com/en-us/dotnet/api/system.uint32)<br>

### **Calculate(Byte[], Byte[])**

Calculate the combined CRC32 for data.

```csharp
public static uint Calculate(Byte[] data, Byte[] data2)
```

#### Parameters

`data` [Byte[]](https://docs.microsoft.com/en-us/dotnet/api/system.byte)<br>

`data2` [Byte[]](https://docs.microsoft.com/en-us/dotnet/api/system.byte)<br>

#### Returns

[UInt32](https://docs.microsoft.com/en-us/dotnet/api/system.uint32)<br>
