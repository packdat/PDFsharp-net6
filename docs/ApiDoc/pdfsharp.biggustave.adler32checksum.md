# Adler32Checksum

Namespace: PdfSharp.BigGustave

Used to calculate the Adler-32 checksum used for ZLIB data in accordance with 
 RFC 1950: ZLIB Compressed Data Format Specification.

```csharp
public static class Adler32Checksum
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [Adler32Checksum](./pdfsharp.biggustave.adler32checksum)

## Methods

### **Calculate(IEnumerable&lt;Byte&gt;, Int32)**

Calculate the Adler-32 checksum for some data.

```csharp
public static int Calculate(IEnumerable<byte> data, int length)
```

#### Parameters

`data` [IEnumerable&lt;Byte&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)<br>

`length` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

#### Returns

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
