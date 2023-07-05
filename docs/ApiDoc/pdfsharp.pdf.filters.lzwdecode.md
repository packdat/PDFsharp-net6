# LzwDecode

Namespace: PdfSharp.Pdf.Filters

Implements the LzwDecode filter.

```csharp
public class LzwDecode : Filter
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [Filter](./pdfsharp.pdf.filters.filter) → [LzwDecode](./pdfsharp.pdf.filters.lzwdecode)

## Constructors

### **LzwDecode()**

```csharp
public LzwDecode()
```

## Methods

### **Encode(Byte[])**

Throws a NotImplementedException because the obsolete LZW encoding is not supported by PDFsharp.

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
