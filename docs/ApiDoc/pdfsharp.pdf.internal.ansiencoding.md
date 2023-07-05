# AnsiEncoding

Namespace: PdfSharp.Pdf.Internal

An encoder for PDF AnsiEncoding.

```csharp
public sealed class AnsiEncoding : System.Text.Encoding, System.ICloneable
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [Encoding](https://docs.microsoft.com/en-us/dotnet/api/system.text.encoding) → [AnsiEncoding](./pdfsharp.pdf.internal.ansiencoding)<br>
Implements [ICloneable](https://docs.microsoft.com/en-us/dotnet/api/system.icloneable)

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

### **AnsiEncoding()**

```csharp
public AnsiEncoding()
```

## Methods

### **GetByteCount(Char[], Int32, Int32)**

Gets the byte count.

```csharp
public int GetByteCount(Char[] chars, int index, int count)
```

#### Parameters

`chars` [Char[]](https://docs.microsoft.com/en-us/dotnet/api/system.char)<br>

`index` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

`count` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

#### Returns

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **GetBytes(Char[], Int32, Int32, Byte[], Int32)**

Gets the bytes.

```csharp
public int GetBytes(Char[] chars, int charIndex, int charCount, Byte[] bytes, int byteIndex)
```

#### Parameters

`chars` [Char[]](https://docs.microsoft.com/en-us/dotnet/api/system.char)<br>

`charIndex` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

`charCount` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

`bytes` [Byte[]](https://docs.microsoft.com/en-us/dotnet/api/system.byte)<br>

`byteIndex` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

#### Returns

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **GetCharCount(Byte[], Int32, Int32)**

Gets the character count.

```csharp
public int GetCharCount(Byte[] bytes, int index, int count)
```

#### Parameters

`bytes` [Byte[]](https://docs.microsoft.com/en-us/dotnet/api/system.byte)<br>

`index` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

`count` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

#### Returns

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **GetChars(Byte[], Int32, Int32, Char[], Int32)**

Gets the chars.

```csharp
public int GetChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex)
```

#### Parameters

`bytes` [Byte[]](https://docs.microsoft.com/en-us/dotnet/api/system.byte)<br>

`byteIndex` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

`byteCount` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

`chars` [Char[]](https://docs.microsoft.com/en-us/dotnet/api/system.char)<br>

`charIndex` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

#### Returns

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

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

### **IsAnsi1252Char(Char)**

Indicates whether the specified Unicode character is available in the ANSI code page 1252.

```csharp
public static bool IsAnsi1252Char(char ch)
```

#### Parameters

`ch` [Char](https://docs.microsoft.com/en-us/dotnet/api/system.char)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **UnicodeToAnsi(Char)**

Maps Unicode to ANSI code page 1252.

```csharp
public static char UnicodeToAnsi(char ch)
```

#### Parameters

`ch` [Char](https://docs.microsoft.com/en-us/dotnet/api/system.char)<br>

#### Returns

[Char](https://docs.microsoft.com/en-us/dotnet/api/system.char)<br>
