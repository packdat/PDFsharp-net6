# Filtering

Namespace: PdfSharp.Pdf.Filters

Applies standard filters to streams.

```csharp
public static class Filtering
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [Filtering](./pdfsharp.pdf.filters.filtering)

## Properties

### **AsciiHexDecode**

Gets the filter singleton.

```csharp
public static AsciiHexDecode AsciiHexDecode { get; }
```

#### Property Value

[AsciiHexDecode](./pdfsharp.pdf.filters.asciihexdecode)<br>

### **Ascii85Decode**

Gets the filter singleton.

```csharp
public static Ascii85Decode Ascii85Decode { get; }
```

#### Property Value

[Ascii85Decode](./pdfsharp.pdf.filters.ascii85decode)<br>

### **LzwDecode**

Gets the filter singleton.

```csharp
public static LzwDecode LzwDecode { get; }
```

#### Property Value

[LzwDecode](./pdfsharp.pdf.filters.lzwdecode)<br>

### **FlateDecode**

Gets the filter singleton.

```csharp
public static FlateDecode FlateDecode { get; }
```

#### Property Value

[FlateDecode](./pdfsharp.pdf.filters.flatedecode)<br>

### **DctDecode**

Gets the filter singleton.

```csharp
public static DctDecode DctDecode { get; }
```

#### Property Value

[DctDecode](./pdfsharp.pdf.filters.dctdecode)<br>

## Methods

### **GetFilter(String)**

Gets the filter specified by the case sensitive name.

```csharp
public static Filter GetFilter(string filterName)
```

#### Parameters

`filterName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

#### Returns

[Filter](./pdfsharp.pdf.filters.filter)<br>

### **Encode(Byte[], String)**

Encodes the data with the specified filter.

```csharp
public static Byte[] Encode(Byte[] data, string filterName)
```

#### Parameters

`data` [Byte[]](https://docs.microsoft.com/en-us/dotnet/api/system.byte)<br>

`filterName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

#### Returns

[Byte[]](https://docs.microsoft.com/en-us/dotnet/api/system.byte)<br>

### **Encode(String, String)**

Encodes a raw string with the specified filter.

```csharp
public static Byte[] Encode(string rawString, string filterName)
```

#### Parameters

`rawString` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`filterName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

#### Returns

[Byte[]](https://docs.microsoft.com/en-us/dotnet/api/system.byte)<br>

### **Decode(Byte[], String, FilterParms)**

Decodes the data with the specified filter.

```csharp
public static Byte[] Decode(Byte[] data, string filterName, FilterParms parms)
```

#### Parameters

`data` [Byte[]](https://docs.microsoft.com/en-us/dotnet/api/system.byte)<br>

`filterName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`parms` [FilterParms](./pdfsharp.pdf.filters.filterparms)<br>

#### Returns

[Byte[]](https://docs.microsoft.com/en-us/dotnet/api/system.byte)<br>

### **Decode(Byte[], String)**

Decodes the data with the specified filter.

```csharp
public static Byte[] Decode(Byte[] data, string filterName)
```

#### Parameters

`data` [Byte[]](https://docs.microsoft.com/en-us/dotnet/api/system.byte)<br>

`filterName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

#### Returns

[Byte[]](https://docs.microsoft.com/en-us/dotnet/api/system.byte)<br>

### **Decode(Byte[], PdfItem, PdfItem)**

Decodes the data with the specified filter.

```csharp
public static Byte[] Decode(Byte[] data, PdfItem filterItem, PdfItem decodeParms)
```

#### Parameters

`data` [Byte[]](https://docs.microsoft.com/en-us/dotnet/api/system.byte)<br>

`filterItem` [PdfItem](./pdfsharp.pdf.pdfitem)<br>

`decodeParms` [PdfItem](./pdfsharp.pdf.pdfitem)<br>

#### Returns

[Byte[]](https://docs.microsoft.com/en-us/dotnet/api/system.byte)<br>

### **DecodeToString(Byte[], String, FilterParms)**

Decodes to a raw string with the specified filter.

```csharp
public static string DecodeToString(Byte[] data, string filterName, FilterParms parms)
```

#### Parameters

`data` [Byte[]](https://docs.microsoft.com/en-us/dotnet/api/system.byte)<br>

`filterName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`parms` [FilterParms](./pdfsharp.pdf.filters.filterparms)<br>

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **DecodeToString(Byte[], String)**

Decodes to a raw string with the specified filter.

```csharp
public static string DecodeToString(Byte[] data, string filterName)
```

#### Parameters

`data` [Byte[]](https://docs.microsoft.com/en-us/dotnet/api/system.byte)<br>

`filterName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
