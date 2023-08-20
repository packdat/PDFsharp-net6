# PdfCatalog

Namespace: PdfSharp.Pdf.Advanced

Represents the catalog dictionary.

```csharp
public sealed class PdfCatalog : PdfSharp.Pdf.PdfDictionary, System.ICloneable, System.Collections.Generic.IEnumerable`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib, Version=6.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e],[PdfSharp.Pdf.PdfItem, PdfSharp, Version=0.1.3.0, Culture=neutral, PublicKeyToken=null]], System.Private.CoreLib, Version=6.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e]], System.Collections.IEnumerable
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [PdfItem](./pdfsharp.pdf.pdfitem) → [PdfObject](./pdfsharp.pdf.pdfobject) → [PdfDictionary](./pdfsharp.pdf.pdfdictionary) → [PdfCatalog](./pdfsharp.pdf.advanced.pdfcatalog)<br>
Implements [ICloneable](https://docs.microsoft.com/en-us/dotnet/api/system.icloneable), [IEnumerable&lt;KeyValuePair&lt;String, PdfItem&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1), [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.ienumerable)

## Properties

### **Version**

Get or sets the version of the PDF specification to which the document conforms.

```csharp
public string Version { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Pages**

Gets the pages collection of this document.

```csharp
public PdfPages Pages { get; }
```

#### Property Value

[PdfPages](./pdfsharp.pdf.pdfpages)<br>

### **Names**

Gets the name dictionary of this document.

```csharp
public PdfNameDictionary Names { get; }
```

#### Property Value

[PdfNameDictionary](./pdfsharp.pdf.advanced.pdfnamedictionary)<br>

### **Destinations**

Gets the named destinations defined in the Catalog

```csharp
public PdfNamedDestinations Destinations { get; }
```

#### Property Value

[PdfNamedDestinations](./pdfsharp.pdf.advanced.pdfnameddestinations)<br>

### **AcroForm**

Gets the AcroForm dictionary of this document.

```csharp
public PdfAcroForm AcroForm { get; internal set; }
```

#### Property Value

[PdfAcroForm](./pdfsharp.pdf.acroforms.pdfacroform)<br>

### **Language**

Gets or sets the language identifier specifying the natural language for all text in the document.
 Sample values are 'en-US' for 'English United States' or 'de-DE' for 'Deutsch Deutschland' (i.e. 'German Germany').

```csharp
public string Language { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

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

### **PdfCatalog(PdfDocument)**

Initializes a new instance of the [PdfCatalog](./pdfsharp.pdf.advanced.pdfcatalog) class.

```csharp
public PdfCatalog(PdfDocument document)
```

#### Parameters

`document` [PdfDocument](./pdfsharp.pdf.pdfdocument)<br>

## Methods

### **PrepareForSave()**

Dispatches PrepareForSave to the objects that need it.

```csharp
internal void PrepareForSave()
```

### **WriteObject(PdfWriter)**

```csharp
internal void WriteObject(PdfWriter writer)
```

#### Parameters

`writer` [PdfWriter](./pdfsharp.pdf.io.pdfwriter)<br>
