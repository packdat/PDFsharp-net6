# CLexer

Namespace: PdfSharp.Pdf.Content

Lexical analyzer for PDF content files. Adobe specifies no grammar, but it seems that it
 is a simple post-fix notation.

```csharp
public class CLexer
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [CLexer](./pdfsharp.pdf.content.clexer)

## Properties

### **Symbol**

Gets or sets the current symbol.

```csharp
public CSymbol Symbol { get; set; }
```

#### Property Value

[CSymbol](./pdfsharp.pdf.content.csymbol)<br>

### **Token**

Gets the current token.

```csharp
public string Token { get; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **ContLength**

Gets the length of the content.

```csharp
public int ContLength { get; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **Position**

```csharp
public int Position { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

## Constructors

### **CLexer(Byte[])**

Initializes a new instance of the Lexer class.

```csharp
public CLexer(Byte[] content)
```

#### Parameters

`content` [Byte[]](https://docs.microsoft.com/en-us/dotnet/api/system.byte)<br>

### **CLexer(MemoryStream)**

Initializes a new instance of the Lexer class.

```csharp
public CLexer(MemoryStream content)
```

#### Parameters

`content` [MemoryStream](https://docs.microsoft.com/en-us/dotnet/api/system.io.memorystream)<br>

## Methods

### **ScanNextToken()**

Reads the next token and returns its type.

```csharp
public CSymbol ScanNextToken()
```

#### Returns

[CSymbol](./pdfsharp.pdf.content.csymbol)<br>

### **ScanComment()**

Scans a comment line. (Not yet used, comments are skipped by lexer.)

```csharp
public CSymbol ScanComment()
```

#### Returns

[CSymbol](./pdfsharp.pdf.content.csymbol)<br>

### **ScanInlineImage()**

Scans the bytes of an inline image.
 NYI: Just scans over it.

```csharp
public CSymbol ScanInlineImage()
```

#### Returns

[CSymbol](./pdfsharp.pdf.content.csymbol)<br>

### **ScanName()**

Scans a name.

```csharp
public CSymbol ScanName()
```

#### Returns

[CSymbol](./pdfsharp.pdf.content.csymbol)<br>

### **ScanDictionary()**

```csharp
protected CSymbol ScanDictionary()
```

#### Returns

[CSymbol](./pdfsharp.pdf.content.csymbol)<br>

### **ScanNumber()**

Scans an integer or real number.

```csharp
public CSymbol ScanNumber()
```

#### Returns

[CSymbol](./pdfsharp.pdf.content.csymbol)<br>

### **ScanOperator()**

Scans an operator.

```csharp
public CSymbol ScanOperator()
```

#### Returns

[CSymbol](./pdfsharp.pdf.content.csymbol)<br>

### **ScanLiteralString()**

```csharp
public CSymbol ScanLiteralString()
```

#### Returns

[CSymbol](./pdfsharp.pdf.content.csymbol)<br>

### **ScanHexadecimalString()**

```csharp
public CSymbol ScanHexadecimalString()
```

#### Returns

[CSymbol](./pdfsharp.pdf.content.csymbol)<br>

### **ScanNextChar()**

Move current position one character further in content stream.

```csharp
internal char ScanNextChar()
```

#### Returns

[Char](https://docs.microsoft.com/en-us/dotnet/api/system.char)<br>

### **AppendAndScanNextChar()**

Appends current character to the token and reads next one.

```csharp
internal char AppendAndScanNextChar()
```

#### Returns

[Char](https://docs.microsoft.com/en-us/dotnet/api/system.char)<br>

### **MoveToNonWhiteSpace()**

If the current character is not a white space, the function immediately returns it.
 Otherwise, the PDF cursor is moved forward to the first non-white space or EOF.
 White spaces are NUL, HT, LF, FF, CR, and SP.

```csharp
public char MoveToNonWhiteSpace()
```

#### Returns

[Char](https://docs.microsoft.com/en-us/dotnet/api/system.char)<br>

### **IsWhiteSpace(Char)**

Indicates whether the specified character is a content stream white-space character.

```csharp
internal static bool IsWhiteSpace(char ch)
```

#### Parameters

`ch` [Char](https://docs.microsoft.com/en-us/dotnet/api/system.char)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **IsOperatorChar(Char)**

Indicates whether the specified character is an content operator character.

```csharp
internal static bool IsOperatorChar(char ch)
```

#### Parameters

`ch` [Char](https://docs.microsoft.com/en-us/dotnet/api/system.char)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **IsDelimiter(Char)**

Indicates whether the specified character is a PDF delimiter character.

```csharp
internal static bool IsDelimiter(char ch)
```

#### Parameters

`ch` [Char](https://docs.microsoft.com/en-us/dotnet/api/system.char)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
