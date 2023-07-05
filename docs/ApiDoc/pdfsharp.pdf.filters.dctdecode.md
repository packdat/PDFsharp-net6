# DctDecode

Namespace: PdfSharp.Pdf.Filters

Implements a dummy DCTDecode filter.
 Filter does nothing, but allows to read and write PDF files with
 DCT encoded streams.

```csharp
public class DctDecode : NoOpFiler
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [Filter](./pdfsharp.pdf.filters.filter) → [NoOpFiler](./pdfsharp.pdf.filters.noopfiler) → [DctDecode](./pdfsharp.pdf.filters.dctdecode)

## Constructors

### **DctDecode()**

```csharp
public DctDecode()
```

## Methods

### **Encode(Byte[])**

Returns a copy of the input data.

```csharp
public Byte[] Encode(Byte[] data)
```

#### Parameters

`data` [Byte[]](https://docs.microsoft.com/en-us/dotnet/api/system.byte)<br>

#### Returns

[Byte[]](https://docs.microsoft.com/en-us/dotnet/api/system.byte)<br>

### **Decode(Byte[], FilterParms)**

Returns a copy of the input data.

```csharp
public Byte[] Decode(Byte[] data, FilterParms parms)
```

#### Parameters

`data` [Byte[]](https://docs.microsoft.com/en-us/dotnet/api/system.byte)<br>

`parms` [FilterParms](./pdfsharp.pdf.filters.filterparms)<br>

#### Returns

[Byte[]](https://docs.microsoft.com/en-us/dotnet/api/system.byte)<br>
