# Ascii85Decode

Namespace: PdfSharp.Pdf.Filters

Implements the ASCII85Decode filter.

```csharp
public class Ascii85Decode : Filter
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [Filter](./pdfsharp.pdf.filters.filter) → [Ascii85Decode](./pdfsharp.pdf.filters.ascii85decode)

## Constructors

### **Ascii85Decode()**

```csharp
public Ascii85Decode()
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
