# FlateDecode

Namespace: PdfSharp.Pdf.Filters

Implements the FlateDecode filter by wrapping SharpZipLib.

```csharp
public class FlateDecode : Filter
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [Filter](./pdfsharp.pdf.filters.filter) → [FlateDecode](./pdfsharp.pdf.filters.flatedecode)

## Constructors

### **FlateDecode()**

```csharp
public FlateDecode()
```

## Methods

### **Encode(Byte[])**

Encodes the specified data.

```csharp
public Byte[] Encode(Byte[] data)
```

#### Parameters

`data` [Byte[]](https://docs.microsoft.com/en-us/dotnet/api/system.byte)<br>

#### Returns

[Byte[]](https://docs.microsoft.com/en-us/dotnet/api/system.byte)<br>

### **Encode(Byte[], PdfFlateEncodeMode)**

Encodes the specified data.

```csharp
public Byte[] Encode(Byte[] data, PdfFlateEncodeMode mode)
```

#### Parameters

`data` [Byte[]](https://docs.microsoft.com/en-us/dotnet/api/system.byte)<br>

`mode` [PdfFlateEncodeMode](./pdfsharp.pdf.pdfflateencodemode)<br>

#### Returns

[Byte[]](https://docs.microsoft.com/en-us/dotnet/api/system.byte)<br>

### **Decode(Byte[], FilterParms)**

Decodes the specified data.

```csharp
public Byte[] Decode(Byte[] data, FilterParms parms)
```

#### Parameters

`data` [Byte[]](https://docs.microsoft.com/en-us/dotnet/api/system.byte)<br>

`parms` [FilterParms](./pdfsharp.pdf.filters.filterparms)<br>

#### Returns

[Byte[]](https://docs.microsoft.com/en-us/dotnet/api/system.byte)<br>
