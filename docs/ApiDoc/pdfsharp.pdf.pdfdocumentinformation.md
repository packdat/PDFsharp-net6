# PdfDocumentInformation

Namespace: PdfSharp.Pdf

Represents the PDF document information dictionary.

```csharp
public sealed class PdfDocumentInformation : PdfDictionary, System.ICloneable, System.Collections.Generic.IEnumerable`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib, Version=6.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e],[PdfSharp.Pdf.PdfItem, PdfSharp, Version=0.1.2.0, Culture=neutral, PublicKeyToken=null]], System.Private.CoreLib, Version=6.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e]], System.Collections.IEnumerable
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [PdfItem](./pdfsharp.pdf.pdfitem) → [PdfObject](./pdfsharp.pdf.pdfobject) → [PdfDictionary](./pdfsharp.pdf.pdfdictionary) → [PdfDocumentInformation](./pdfsharp.pdf.pdfdocumentinformation)<br>
Implements [ICloneable](https://docs.microsoft.com/en-us/dotnet/api/system.icloneable), [IEnumerable&lt;KeyValuePair&lt;String, PdfItem&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1), [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.ienumerable)

## Properties

### **Title**

Gets or sets the document's title.

```csharp
public string Title { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Author**

Gets or sets the name of the person who created the document.

```csharp
public string Author { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Subject**

Gets or sets the name of the subject of the document.

```csharp
public string Subject { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Keywords**

Gets or sets keywords associated with the document.

```csharp
public string Keywords { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Creator**

Gets or sets the name of the application (for example, MigraDoc) that created the document.

```csharp
public string Creator { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Producer**

Gets the producer application (for example, PDFsharp).

```csharp
public string Producer { get; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **CreationDate**

Gets or sets the creation date of the document.
 Breaking Change: If the date is not set in a PDF file DateTime.MinValue is returned.

```csharp
public DateTime CreationDate { get; set; }
```

#### Property Value

[DateTime](https://docs.microsoft.com/en-us/dotnet/api/system.datetime)<br>

### **ModificationDate**

Gets or sets the modification date of the document.
 Breaking Change: If the date is not set in a PDF file DateTime.MinValue is returned.

```csharp
public DateTime ModificationDate { get; set; }
```

#### Property Value

[DateTime](https://docs.microsoft.com/en-us/dotnet/api/system.datetime)<br>

### **Elements**

Gets the dictionary containing the elements of this dictionary.

```csharp
public DictionaryElements Elements { get; }
```

#### Property Value

[DictionaryElements](./pdfsharp.pdf.pdfdictionary.dictionaryelements)<br>

### **Stream**

Gets or sets the PDF stream belonging to this dictionary. Returns null if the dictionary has
 no stream. To create the stream, call the CreateStream function.

```csharp
public PdfStream Stream { get; set; }
```

#### Property Value

[PdfStream](./pdfsharp.pdf.pdfdictionary.pdfstream)<br>

### **Owner**

Gets the PdfDocument this object belongs to.

```csharp
public PdfDocument Owner { get; }
```

#### Property Value

[PdfDocument](./pdfsharp.pdf.pdfdocument)<br>

### **IsIndirect**

Indicates whether the object is an indirect object.

```csharp
public bool IsIndirect { get; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **Internals**

Gets the PdfInternals object of this document, that grants access to some internal structures
 which are not part of the public interface of PdfDocument.

```csharp
public PdfObjectInternals Internals { get; }
```

#### Property Value

[PdfObjectInternals](./pdfsharp.pdf.advanced.pdfobjectinternals)<br>

### **Reference**

Gets the indirect reference of this object. If the value is null, this object is a direct object.

```csharp
public PdfReference Reference { get; internal set; }
```

#### Property Value

[PdfReference](./pdfsharp.pdf.advanced.pdfreference)<br>

### **ReferenceNotNull**

Gets the indirect reference of this object. Throws if it is null.

```csharp
public PdfReference ReferenceNotNull { get; }
```

#### Property Value

[PdfReference](./pdfsharp.pdf.advanced.pdfreference)<br>

#### Exceptions

[InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/system.invalidoperationexception)<br>
The indirect reference must be not null here.

## Constructors

### **PdfDocumentInformation(PdfDocument)**

Initializes a new instance of the [PdfDocumentInformation](./pdfsharp.pdf.pdfdocumentinformation) class.

```csharp
public PdfDocumentInformation(PdfDocument document)
```

#### Parameters

`document` [PdfDocument](./pdfsharp.pdf.pdfdocument)<br>
