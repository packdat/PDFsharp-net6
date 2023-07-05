# Filter

Namespace: PdfSharp.Pdf.Filters

Base class for all stream filters

```csharp
public abstract class Filter
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [Filter](./pdfsharp.pdf.filters.filter)

## Methods

### **Encode(Byte[])**

When implemented in a derived class encodes the specified data.

```csharp
public abstract Byte[] Encode(Byte[] data)
```

#### Parameters

`data` [Byte[]](https://docs.microsoft.com/en-us/dotnet/api/system.byte)<br>

#### Returns

[Byte[]](https://docs.microsoft.com/en-us/dotnet/api/system.byte)<br>

### **Encode(String)**

Encodes a raw string.

```csharp
public Byte[] Encode(string rawString)
```

#### Parameters

`rawString` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

#### Returns

[Byte[]](https://docs.microsoft.com/en-us/dotnet/api/system.byte)<br>

### **Decode(Byte[], FilterParms)**

When implemented in a derived class decodes the specified data.

```csharp
public abstract Byte[] Decode(Byte[] data, FilterParms parms)
```

#### Parameters

`data` [Byte[]](https://docs.microsoft.com/en-us/dotnet/api/system.byte)<br>

`parms` [FilterParms](./pdfsharp.pdf.filters.filterparms)<br>

#### Returns

[Byte[]](https://docs.microsoft.com/en-us/dotnet/api/system.byte)<br>

### **Decode(Byte[], PdfDictionary)**

Decodes the specified data.

```csharp
public Byte[] Decode(Byte[] data, PdfDictionary decodeParms)
```

#### Parameters

`data` [Byte[]](https://docs.microsoft.com/en-us/dotnet/api/system.byte)<br>

`decodeParms` [PdfDictionary](./pdfsharp.pdf.pdfdictionary)<br>

#### Returns

[Byte[]](https://docs.microsoft.com/en-us/dotnet/api/system.byte)<br>

### **DecodeToString(Byte[], FilterParms)**

Decodes to a raw string.

```csharp
public string DecodeToString(Byte[] data, FilterParms parms)
```

#### Parameters

`data` [Byte[]](https://docs.microsoft.com/en-us/dotnet/api/system.byte)<br>

`parms` [FilterParms](./pdfsharp.pdf.filters.filterparms)<br>

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **DecodeToString(Byte[])**

Decodes to a raw string.

```csharp
public string DecodeToString(Byte[] data)
```

#### Parameters

`data` [Byte[]](https://docs.microsoft.com/en-us/dotnet/api/system.byte)<br>

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **RemoveWhiteSpace(Byte[])**

Removes all white spaces from the data. The function assumes that the bytes are characters.

```csharp
protected Byte[] RemoveWhiteSpace(Byte[] data)
```

#### Parameters

`data` [Byte[]](https://docs.microsoft.com/en-us/dotnet/api/system.byte)<br>

#### Returns

[Byte[]](https://docs.microsoft.com/en-us/dotnet/api/system.byte)<br>
