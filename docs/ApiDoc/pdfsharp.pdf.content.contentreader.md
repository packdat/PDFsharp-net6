# ContentReader

Namespace: PdfSharp.Pdf.Content

Represents the functionality for reading PDF content streams.

```csharp
public static class ContentReader
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ContentReader](./pdfsharp.pdf.content.contentreader)

## Methods

### **ReadContent(PdfPage)**

Reads the content stream(s) of the specified page.

```csharp
public static CSequence ReadContent(PdfPage page)
```

#### Parameters

`page` [PdfPage](./pdfsharp.pdf.pdfpage)<br>
The page.

#### Returns

[CSequence](./pdfsharp.pdf.content.objects.csequence)<br>

### **ReadContent(Byte[])**

Reads the specified content.

```csharp
public static CSequence ReadContent(Byte[] content)
```

#### Parameters

`content` [Byte[]](https://docs.microsoft.com/en-us/dotnet/api/system.byte)<br>
The content.

#### Returns

[CSequence](./pdfsharp.pdf.content.objects.csequence)<br>

### **ReadContent(MemoryStream)**

Reads the specified content.

```csharp
public static CSequence ReadContent(MemoryStream content)
```

#### Parameters

`content` [MemoryStream](https://docs.microsoft.com/en-us/dotnet/api/system.io.memorystream)<br>
The content.

#### Returns

[CSequence](./pdfsharp.pdf.content.objects.csequence)<br>
