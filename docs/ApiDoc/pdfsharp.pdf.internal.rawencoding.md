# RawEncoding

Namespace: PdfSharp.Pdf.Internal

An encoder for raw strings. The raw encoding is simply the identity relation between
 characters and bytes. PDFsharp internally works with raw encoded strings instead of
 byte arrays because strings are much more handy than byte arrays.

```csharp
public sealed class RawEncoding : System.Text.Encoding, System.ICloneable
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [Encoding](https://docs.microsoft.com/en-us/dotnet/api/system.text.encoding) → [RawEncoding](./pdfsharp.pdf.internal.rawencoding)<br>
Implements [ICloneable](https://docs.microsoft.com/en-us/dotnet/api/system.icloneable)

**Remarks:**

Raw encoded strings represent an array of bytes. Therefore a character greater than
 255 is not valid in a raw encoded string.

## Properties

### **Preamble**

```csharp
public ReadOnlySpan<byte> Preamble { get; }
```

#### Property Value

[ReadOnlySpan&lt;Byte&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.readonlyspan-1)<br>

### **BodyName**

```csharp
public string BodyName { get; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **EncodingName**

```csharp
public string EncodingName { get; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **HeaderName**

```csharp
public string HeaderName { get; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **WebName**

```csharp
public string WebName { get; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **WindowsCodePage**

```csharp
public int WindowsCodePage { get; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **IsBrowserDisplay**

```csharp
public bool IsBrowserDisplay { get; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **IsBrowserSave**

```csharp
public bool IsBrowserSave { get; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **IsMailNewsDisplay**

```csharp
public bool IsMailNewsDisplay { get; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **IsMailNewsSave**

```csharp
public bool IsMailNewsSave { get; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **IsSingleByte**

```csharp
public bool IsSingleByte { get; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **EncoderFallback**

```csharp
public EncoderFallback EncoderFallback { get; set; }
```

#### Property Value

[EncoderFallback](https://docs.microsoft.com/en-us/dotnet/api/system.text.encoderfallback)<br>

### **DecoderFallback**

```csharp
public DecoderFallback DecoderFallback { get; set; }
```

#### Property Value

[DecoderFallback](https://docs.microsoft.com/en-us/dotnet/api/system.text.decoderfallback)<br>

### **IsReadOnly**

```csharp
public bool IsReadOnly { get;  set; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **CodePage**

```csharp
public int CodePage { get; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

## Constructors

### **RawEncoding()**

Initializes a new instance of the [RawEncoding](./pdfsharp.pdf.internal.rawencoding) class.

```csharp
public RawEncoding()
```

## Methods

### **GetByteCount(Char[], Int32, Int32)**

When overridden in a derived class, calculates the number of bytes produced by encoding a set of characters from the specified character array.

```csharp
public int GetByteCount(Char[] chars, int index, int count)
```

#### Parameters

`chars` [Char[]](https://docs.microsoft.com/en-us/dotnet/api/system.char)<br>
The character array containing the set of characters to encode.

`index` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The index of the first character to encode.

`count` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The number of characters to encode.

#### Returns

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The number of bytes produced by encoding the specified characters.

### **GetBytes(Char[], Int32, Int32, Byte[], Int32)**

When overridden in a derived class, encodes a set of characters from the specified character array into the specified byte array.

```csharp
public int GetBytes(Char[] chars, int charIndex, int charCount, Byte[] bytes, int byteIndex)
```

#### Parameters

`chars` [Char[]](https://docs.microsoft.com/en-us/dotnet/api/system.char)<br>
The character array containing the set of characters to encode.

`charIndex` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The index of the first character to encode.

`charCount` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The number of characters to encode.

`bytes` [Byte[]](https://docs.microsoft.com/en-us/dotnet/api/system.byte)<br>
The byte array to contain the resulting sequence of bytes.

`byteIndex` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The index at which to start writing the resulting sequence of bytes.

#### Returns

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The actual number of bytes written into .

### **GetCharCount(Byte[], Int32, Int32)**

When overridden in a derived class, calculates the number of characters produced by decoding a sequence of bytes from the specified byte array.

```csharp
public int GetCharCount(Byte[] bytes, int index, int count)
```

#### Parameters

`bytes` [Byte[]](https://docs.microsoft.com/en-us/dotnet/api/system.byte)<br>
The byte array containing the sequence of bytes to decode.

`index` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The index of the first byte to decode.

`count` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The number of bytes to decode.

#### Returns

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The number of characters produced by decoding the specified sequence of bytes.

### **GetChars(Byte[], Int32, Int32, Char[], Int32)**

When overridden in a derived class, decodes a sequence of bytes from the specified byte array into the specified character array.

```csharp
public int GetChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex)
```

#### Parameters

`bytes` [Byte[]](https://docs.microsoft.com/en-us/dotnet/api/system.byte)<br>
The byte array containing the sequence of bytes to decode.

`byteIndex` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The index of the first byte to decode.

`byteCount` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The number of bytes to decode.

`chars` [Char[]](https://docs.microsoft.com/en-us/dotnet/api/system.char)<br>
The character array to contain the resulting set of characters.

`charIndex` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The index at which to start writing the resulting set of characters.

#### Returns

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The actual number of characters written into .

### **GetMaxByteCount(Int32)**

When overridden in a derived class, calculates the maximum number of bytes produced by encoding the specified number of characters.

```csharp
public int GetMaxByteCount(int charCount)
```

#### Parameters

`charCount` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The number of characters to encode.

#### Returns

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The maximum number of bytes produced by encoding the specified number of characters.

### **GetMaxCharCount(Int32)**

When overridden in a derived class, calculates the maximum number of characters produced by decoding the specified number of bytes.

```csharp
public int GetMaxCharCount(int byteCount)
```

#### Parameters

`byteCount` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The number of bytes to decode.

#### Returns

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The maximum number of characters produced by decoding the specified number of bytes.
