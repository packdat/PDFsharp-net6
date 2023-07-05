# PdfReader

Namespace: PdfSharp.Pdf.IO

Represents the functionality for reading PDF documents.

```csharp
public static class PdfReader
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [PdfReader](./pdfsharp.pdf.io.pdfreader)

## Methods

### **TestPdfFile(String)**

Determines whether the file specified by its path is a PDF file by inspecting the first eight
 bytes of the data. If the file header has the form «%PDF-x.y» the function returns the version
 number as integer (e.g. 14 for PDF 1.4). If the file header is invalid or inaccessible
 for any reason, 0 is returned. The function never throws an exception.

```csharp
public static int TestPdfFile(string path)
```

#### Parameters

`path` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

#### Returns

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **TestPdfFile(Stream)**

Determines whether the specified stream is a PDF file by inspecting the first eight
 bytes of the data. If the data begins with «%PDF-x.y» the function returns the version
 number as integer (e.g. 14 for PDF 1.4). If the data is invalid or inaccessible
 for any reason, 0 is returned. The function never throws an exception.
 This method expects the stream position to point to the start of the file data to be checked.

```csharp
public static int TestPdfFile(Stream stream)
```

#### Parameters

`stream` [Stream](https://docs.microsoft.com/en-us/dotnet/api/system.io.stream)<br>

#### Returns

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **TestPdfFile(Byte[])**

Determines whether the specified data is a PDF file by inspecting the first eight
 bytes of the data. If the data begins with «%PDF-x.y» the function returns the version
 number as integer (e.g. 14 for PDF 1.4). If the data is invalid or inaccessible
 for any reason, 0 is returned. The function never throws an exception.

```csharp
public static int TestPdfFile(Byte[] data)
```

#### Parameters

`data` [Byte[]](https://docs.microsoft.com/en-us/dotnet/api/system.byte)<br>

#### Returns

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **GetPdfFileVersion(Byte[])**

Implements scanning the PDF file version.

```csharp
internal static int GetPdfFileVersion(Byte[] bytes)
```

#### Parameters

`bytes` [Byte[]](https://docs.microsoft.com/en-us/dotnet/api/system.byte)<br>

#### Returns

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **Open(String, PdfDocumentOpenMode)**

Opens an existing PDF document.

```csharp
public static PdfDocument Open(string path, PdfDocumentOpenMode openMode)
```

#### Parameters

`path` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`openMode` [PdfDocumentOpenMode](./pdfsharp.pdf.io.pdfdocumentopenmode)<br>

#### Returns

[PdfDocument](./pdfsharp.pdf.pdfdocument)<br>

### **Open(String, PdfDocumentOpenMode, PdfPasswordProvider)**

Opens an existing PDF document.

```csharp
public static PdfDocument Open(string path, PdfDocumentOpenMode openMode, PdfPasswordProvider provider)
```

#### Parameters

`path` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`openMode` [PdfDocumentOpenMode](./pdfsharp.pdf.io.pdfdocumentopenmode)<br>

`provider` [PdfPasswordProvider](./pdfsharp.pdf.io.pdfpasswordprovider)<br>

#### Returns

[PdfDocument](./pdfsharp.pdf.pdfdocument)<br>

### **Open(String, String, PdfDocumentOpenMode)**

Opens an existing PDF document.

```csharp
public static PdfDocument Open(string path, string password, PdfDocumentOpenMode openMode)
```

#### Parameters

`path` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`password` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`openMode` [PdfDocumentOpenMode](./pdfsharp.pdf.io.pdfdocumentopenmode)<br>

#### Returns

[PdfDocument](./pdfsharp.pdf.pdfdocument)<br>

### **Open(String, String, PdfDocumentOpenMode, PdfPasswordProvider)**

Opens an existing PDF document.

```csharp
public static PdfDocument Open(string path, string password, PdfDocumentOpenMode openMode, PdfPasswordProvider provider)
```

#### Parameters

`path` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`password` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`openMode` [PdfDocumentOpenMode](./pdfsharp.pdf.io.pdfdocumentopenmode)<br>

`provider` [PdfPasswordProvider](./pdfsharp.pdf.io.pdfpasswordprovider)<br>

#### Returns

[PdfDocument](./pdfsharp.pdf.pdfdocument)<br>

### **Open(String)**

Opens an existing PDF document.

```csharp
public static PdfDocument Open(string path)
```

#### Parameters

`path` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

#### Returns

[PdfDocument](./pdfsharp.pdf.pdfdocument)<br>

### **Open(String, String)**

Opens an existing PDF document.

```csharp
public static PdfDocument Open(string path, string password)
```

#### Parameters

`path` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`password` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

#### Returns

[PdfDocument](./pdfsharp.pdf.pdfdocument)<br>

### **Open(Stream, PdfDocumentOpenMode)**

Opens an existing PDF document.

```csharp
public static PdfDocument Open(Stream stream, PdfDocumentOpenMode openMode)
```

#### Parameters

`stream` [Stream](https://docs.microsoft.com/en-us/dotnet/api/system.io.stream)<br>

`openMode` [PdfDocumentOpenMode](./pdfsharp.pdf.io.pdfdocumentopenmode)<br>

#### Returns

[PdfDocument](./pdfsharp.pdf.pdfdocument)<br>

### **Open(Stream, PdfDocumentOpenMode, PdfPasswordProvider)**

Opens an existing PDF document.

```csharp
public static PdfDocument Open(Stream stream, PdfDocumentOpenMode openMode, PdfPasswordProvider passwordProvider)
```

#### Parameters

`stream` [Stream](https://docs.microsoft.com/en-us/dotnet/api/system.io.stream)<br>

`openMode` [PdfDocumentOpenMode](./pdfsharp.pdf.io.pdfdocumentopenmode)<br>

`passwordProvider` [PdfPasswordProvider](./pdfsharp.pdf.io.pdfpasswordprovider)<br>

#### Returns

[PdfDocument](./pdfsharp.pdf.pdfdocument)<br>

### **Open(Stream, String, PdfDocumentOpenMode)**

Opens an existing PDF document.

```csharp
public static PdfDocument Open(Stream stream, string password, PdfDocumentOpenMode openMode)
```

#### Parameters

`stream` [Stream](https://docs.microsoft.com/en-us/dotnet/api/system.io.stream)<br>

`password` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`openMode` [PdfDocumentOpenMode](./pdfsharp.pdf.io.pdfdocumentopenmode)<br>

#### Returns

[PdfDocument](./pdfsharp.pdf.pdfdocument)<br>

### **Open(Stream, String, PdfDocumentOpenMode, PdfPasswordProvider)**

Opens an existing PDF document.

```csharp
public static PdfDocument Open(Stream stream, string password, PdfDocumentOpenMode openMode, PdfPasswordProvider passwordProvider)
```

#### Parameters

`stream` [Stream](https://docs.microsoft.com/en-us/dotnet/api/system.io.stream)<br>

`password` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`openMode` [PdfDocumentOpenMode](./pdfsharp.pdf.io.pdfdocumentopenmode)<br>

`passwordProvider` [PdfPasswordProvider](./pdfsharp.pdf.io.pdfpasswordprovider)<br>

#### Returns

[PdfDocument](./pdfsharp.pdf.pdfdocument)<br>

### **Open(Stream)**

Opens an existing PDF document.

```csharp
public static PdfDocument Open(Stream stream)
```

#### Parameters

`stream` [Stream](https://docs.microsoft.com/en-us/dotnet/api/system.io.stream)<br>

#### Returns

[PdfDocument](./pdfsharp.pdf.pdfdocument)<br>
