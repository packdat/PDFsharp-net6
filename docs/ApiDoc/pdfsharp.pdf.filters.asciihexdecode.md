# AsciiHexDecode

Namespace: PdfSharp.Pdf.Filters

Implements the ASCIIHexDecode filter.

```csharp
public class AsciiHexDecode : Filter
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [Filter](./pdfsharp.pdf.filters.filter) → [AsciiHexDecode](./pdfsharp.pdf.filters.asciihexdecode)

## Constructors

### **AsciiHexDecode()**

```csharp
public AsciiHexDecode()
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
