# XPdfFontOptions

Namespace: PdfSharp.Drawing

Specifies details about how the font is used in PDF creation.

```csharp
public class XPdfFontOptions
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [XPdfFontOptions](./pdfsharp.drawing.xpdffontoptions)

## Properties

### **FontEmbedding**

Gets a value indicating the font embedding.

```csharp
public PdfFontEmbedding FontEmbedding { get; }
```

#### Property Value

[PdfFontEmbedding](./pdfsharp.pdf.pdffontembedding)<br>

### **FontEncoding**

Gets a value indicating how the font is encoded.

```csharp
public PdfFontEncoding FontEncoding { get; }
```

#### Property Value

[PdfFontEncoding](./pdfsharp.pdf.pdffontencoding)<br>

### **WinAnsiDefault**

Gets the default options with WinAnsi encoding and always font embedding.

```csharp
public static XPdfFontOptions WinAnsiDefault { get; }
```

#### Property Value

[XPdfFontOptions](./pdfsharp.drawing.xpdffontoptions)<br>

### **UnicodeDefault**

Gets the default options with Unicode encoding and always font embedding.

```csharp
public static XPdfFontOptions UnicodeDefault { get; }
```

#### Property Value

[XPdfFontOptions](./pdfsharp.drawing.xpdffontoptions)<br>

## Constructors

### **XPdfFontOptions(PdfFontEncoding, PdfFontEmbedding)**

Initializes a new instance of the [XPdfFontOptions](./pdfsharp.drawing.xpdffontoptions) class.

```csharp
public XPdfFontOptions(PdfFontEncoding encoding, PdfFontEmbedding embedding)
```

#### Parameters

`encoding` [PdfFontEncoding](./pdfsharp.pdf.pdffontencoding)<br>

`embedding` [PdfFontEmbedding](./pdfsharp.pdf.pdffontembedding)<br>

### **XPdfFontOptions(PdfFontEncoding)**

Initializes a new instance of the [XPdfFontOptions](./pdfsharp.drawing.xpdffontoptions) class.

```csharp
public XPdfFontOptions(PdfFontEncoding encoding)
```

#### Parameters

`encoding` [PdfFontEncoding](./pdfsharp.pdf.pdffontencoding)<br>

### **XPdfFontOptions(PdfFontEmbedding)**

Initializes a new instance of the [XPdfFontOptions](./pdfsharp.drawing.xpdffontoptions) class.

```csharp
public XPdfFontOptions(PdfFontEmbedding embedding)
```

#### Parameters

`embedding` [PdfFontEmbedding](./pdfsharp.pdf.pdffontembedding)<br>
