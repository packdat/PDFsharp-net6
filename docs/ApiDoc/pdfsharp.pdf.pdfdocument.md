# PdfDocument

Namespace: PdfSharp.Pdf

Represents a PDF document.

```csharp
public sealed class PdfDocument : PdfObject, System.ICloneable, System.IDisposable
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [PdfItem](./pdfsharp.pdf.pdfitem) → [PdfObject](./pdfsharp.pdf.pdfobject) → [PdfDocument](./pdfsharp.pdf.pdfdocument)<br>
Implements [ICloneable](https://docs.microsoft.com/en-us/dotnet/api/system.icloneable), [IDisposable](https://docs.microsoft.com/en-us/dotnet/api/system.idisposable)

## Properties

### **Tag**

Gets or sets a user defined object that contains arbitrary information associated with this document.
 The tag is not used by PDFsharp.

```csharp
public object Tag { get; set; }
```

#### Property Value

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)<br>

### **Events**

Encapsulates the document's events.

```csharp
public DocumentEvents Events { get; }
```

#### Property Value

[DocumentEvents](./pdfsharp.events.documentevents)<br>

### **Options**

Gets the document options used for saving the document.

```csharp
public PdfDocumentOptions Options { get; }
```

#### Property Value

[PdfDocumentOptions](./pdfsharp.pdf.pdfdocumentoptions)<br>

### **Settings**

Gets PDF specific document settings.

```csharp
public PdfDocumentSettings Settings { get; }
```

#### Property Value

[PdfDocumentSettings](./pdfsharp.pdf.pdfdocumentsettings)<br>

### **Version**

Gets or sets the PDF version number. Return value 14 e.g. means PDF 1.4 / Acrobat 5 etc.

```csharp
public int Version { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **PageCount**

Gets the number of pages in the document.

```csharp
public int PageCount { get; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **FileSize**

Gets the file size of the document.

```csharp
public long FileSize { get; }
```

#### Property Value

[Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>

### **FullPath**

Gets the full qualified file name if the document was read form a file, or an empty string otherwise.

```csharp
public string FullPath { get; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Guid**

Gets a Guid that uniquely identifies this instance of PdfDocument.

```csharp
public Guid Guid { get; }
```

#### Property Value

[Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)<br>

### **IsImported**

Returns a value indicating whether the document was newly created or opened from an existing document.
 Returns true if the document was opened with the PdfReader.Open function, false otherwise.

```csharp
public bool IsImported { get; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **IsReadOnly**

Returns a value indicating whether the document is read only or can be modified.

```csharp
public bool IsReadOnly { get; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **Info**

Gets information about the document.

```csharp
public PdfDocumentInformation Info { get; }
```

#### Property Value

[PdfDocumentInformation](./pdfsharp.pdf.pdfdocumentinformation)<br>

### **CustomValues**

This function is intended to be undocumented.

```csharp
public PdfCustomValues CustomValues { get; set; }
```

#### Property Value

[PdfCustomValues](./pdfsharp.pdf.pdfcustomvalues)<br>

### **Pages**

Get the pages dictionary.

```csharp
public PdfPages Pages { get; }
```

#### Property Value

[PdfPages](./pdfsharp.pdf.pdfpages)<br>

### **PageLayout**

Gets or sets a value specifying the page layout to be used when the document is opened.

```csharp
public PdfPageLayout PageLayout { get; set; }
```

#### Property Value

[PdfPageLayout](./pdfsharp.pdf.pdfpagelayout)<br>

### **PageMode**

Gets or sets a value specifying how the document should be displayed when opened.

```csharp
public PdfPageMode PageMode { get; set; }
```

#### Property Value

[PdfPageMode](./pdfsharp.pdf.pdfpagemode)<br>

### **ViewerPreferences**

Gets the viewer preferences of this document.

```csharp
public PdfViewerPreferences ViewerPreferences { get; }
```

#### Property Value

[PdfViewerPreferences](./pdfsharp.pdf.pdfviewerpreferences)<br>

### **Outlines**

Gets the root of the outline (or bookmark) tree.

```csharp
public PdfOutlineCollection Outlines { get; }
```

#### Property Value

[PdfOutlineCollection](./pdfsharp.pdf.pdfoutlinecollection)<br>

### **AcroForm**

Get the AcroForm dictionary.

```csharp
public PdfAcroForm AcroForm { get; }
```

#### Property Value

[PdfAcroForm](./pdfsharp.pdf.acroforms.pdfacroform)<br>

### **Language**

Gets or sets the default language of the document.

```csharp
public string Language { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **SecuritySettings**

Gets the security settings of this document.

```csharp
public PdfSecuritySettings SecuritySettings { get; }
```

#### Property Value

[PdfSecuritySettings](./pdfsharp.pdf.security.pdfsecuritysettings)<br>

### **Internals**

Gets the PdfInternals object of this document, that grants access to some internal structures
 which are not part of the public interface of PdfDocument.

```csharp
public PdfInternals Internals { get; }
```

#### Property Value

[PdfInternals](./pdfsharp.pdf.advanced.pdfinternals)<br>

### **SecurityHandler**

Gets the standard security handler and creates it, if not existing.

```csharp
public PdfStandardSecurityHandler SecurityHandler { get; }
```

#### Property Value

[PdfStandardSecurityHandler](./pdfsharp.pdf.security.pdfstandardsecurityhandler)<br>

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

### **PdfDocument()**

Creates a new PDF document in memory.
 To open an existing PDF file, use the PdfReader class.

```csharp
public PdfDocument()
```

### **PdfDocument(String)**

Creates a new PDF document with the specified file name. The file is immediately created and kept
 locked until the document is closed. At that time the document is saved automatically.
 Do not call Save() for documents created with this constructor, just call Close().
 To open an existing PDF file and import it, use the PdfReader class.

```csharp
public PdfDocument(string filename)
```

#### Parameters

`filename` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **PdfDocument(Stream)**

Creates a new PDF document using the specified stream.
 The stream won't be used until the document is closed. At that time the document is saved automatically.
 Do not call Save() for documents created with this constructor, just call Close().
 To open an existing PDF file, use the PdfReader class.

```csharp
public PdfDocument(Stream outputStream)
```

#### Parameters

`outputStream` [Stream](https://docs.microsoft.com/en-us/dotnet/api/system.io.stream)<br>

## Methods

### **Dispose()**

Disposes all references to this document stored in other documents. This function should be called
 for documents you finished importing pages from. Calling Dispose is technically not necessary but
 useful for earlier reclaiming memory of documents you do not need anymore.

```csharp
public void Dispose()
```

### **Close()**

Closes this instance.

```csharp
public void Close()
```

### **Save(String)**

Saves the document to the specified path. If a file already exists, it will be overwritten.

```csharp
public void Save(string path)
```

#### Parameters

`path` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Save(Stream, Boolean)**

Saves the document to the specified stream.

```csharp
public void Save(Stream stream, bool closeStream)
```

#### Parameters

`stream` [Stream](https://docs.microsoft.com/en-us/dotnet/api/system.io.stream)<br>

`closeStream` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **Save(Stream)**

Saves the document to the specified stream.
 The stream is not closed by this function.
 (Older versions of PDFsharp closes the stream. That was not very useful.)

```csharp
public void Save(Stream stream)
```

#### Parameters

`stream` [Stream](https://docs.microsoft.com/en-us/dotnet/api/system.io.stream)<br>

### **PrepareForSave()**

Dispatches PrepareForSave to the objects that need it.

```csharp
internal void PrepareForSave()
```

### **CanSave(String&)**

Determines whether the document can be saved.

```csharp
public bool CanSave(String& message)
```

#### Parameters

`message` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **HasVersion(String)**

```csharp
internal bool HasVersion(string version)
```

#### Parameters

`version` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **SetRequiredVersion(Int32)**

Adjusts the version if the current version is lower than the required version.

```csharp
public bool SetRequiredVersion(int requiredVersion)
```

#### Parameters

`requiredVersion` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The minimum version number to set version to.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
True, if Version was modified.

### **DocumentNotImported()**

```csharp
internal Exception DocumentNotImported()
```

#### Returns

[Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception)<br>

### **ImportAcroForm(PdfAcroForm, Action&lt;PdfAcroField, PdfAcroField&gt;)**

Imports the fields from the specified [PdfAcroForm](./pdfsharp.pdf.acroforms.pdfacroform) into the current document.<br>
 If the current document does not contain an AcroForm, a new one is created automatically.<br>
 This method should be called after importing pages into the current document.

```csharp
public void ImportAcroForm(PdfAcroForm remoteForm, Action<PdfAcroField, PdfAcroField> fieldHandler)
```

#### Parameters

`remoteForm` [PdfAcroForm](./pdfsharp.pdf.acroforms.pdfacroform)<br>
The [PdfDocument.AcroForm](./pdfsharp.pdf.pdfdocument#acroform) to import

`fieldHandler` [Action&lt;PdfAcroField, PdfAcroField&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.action-2)<br>
A method that allows modifying a field after it was imported.<br>
 It receives the original (remote) field and the imported (local) field as parameters.

**Remarks:**

While importing, the new fields may be renamed, if a field with the same name is already present.<br>
 The new field receives a number-suffix in this case, starting at 2.<br>
 i.e. if the new field has the name myField and there is already a field myField present,
 the new field is renamed to myField2.<br>
 If more fields with the same name are imported, the number-suffix will increase automatically.<br>
 This is useful when merging multiple versions of the same document. (e.g.with different field-values)

### **GetOrCreateAcroForm()**

Gets the existing [PdfAcroForm](./pdfsharp.pdf.acroforms.pdfacroform) or creates a new one, if there is no [PdfAcroForm](./pdfsharp.pdf.acroforms.pdfacroform) in the current document

```csharp
public PdfAcroForm GetOrCreateAcroForm()
```

#### Returns

[PdfAcroForm](./pdfsharp.pdf.acroforms.pdfacroform)<br>
The [PdfAcroForm](./pdfsharp.pdf.acroforms.pdfacroform) associated with this document

### **AddPage()**

Creates a new page and adds it to this document.
 Depending on the IsMetric property of the current region the page size is set to 
 A4 or Letter respectively. If this size is not appropriate it should be changed before
 any drawing operations are performed on the page.

```csharp
public PdfPage AddPage()
```

#### Returns

[PdfPage](./pdfsharp.pdf.pdfpage)<br>

### **AddPage(PdfPage)**

Adds the specified page to this document. If the page is from an external document,
 it is imported to this document. In this case the returned page is not the same
 object as the specified one.

```csharp
public PdfPage AddPage(PdfPage page)
```

#### Parameters

`page` [PdfPage](./pdfsharp.pdf.pdfpage)<br>

#### Returns

[PdfPage](./pdfsharp.pdf.pdfpage)<br>

### **InsertPage(Int32)**

Creates a new page and inserts it in this document at the specified position.

```csharp
public PdfPage InsertPage(int index)
```

#### Parameters

`index` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

#### Returns

[PdfPage](./pdfsharp.pdf.pdfpage)<br>

### **InsertPage(Int32, PdfPage)**

Inserts the specified page in this document. If the page is from an external document,
 it is imported to this document. In this case the returned page is not the same
 object as the specified one.

```csharp
public PdfPage InsertPage(int index, PdfPage page)
```

#### Parameters

`index` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

`page` [PdfPage](./pdfsharp.pdf.pdfpage)<br>

#### Returns

[PdfPage](./pdfsharp.pdf.pdfpage)<br>

### **AddNamedDestination(String, Int32, PdfNamedDestinationParameters)**

Adds a named destination to the document.

```csharp
public void AddNamedDestination(string destinationName, int destinationPage, PdfNamedDestinationParameters parameters)
```

#### Parameters

`destinationName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The Named Destination's name.

`destinationPage` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The page to navigate to.

`parameters` [PdfNamedDestinationParameters](./pdfsharp.pdf.advanced.pdfnameddestinationparameters)<br>
The PdfNamedDestinationParameters defining the named destination's parameters.

### **AddEmbeddedFile(String, String)**

Adds an embedded file to the document.

```csharp
public void AddEmbeddedFile(string name, string path)
```

#### Parameters

`name` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The name used to refer and to entitle the embedded file.

`path` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The path of the file to embed.

### **AddEmbeddedFile(String, Stream)**

Adds an embedded file to the document.

```csharp
public void AddEmbeddedFile(string name, Stream stream)
```

#### Parameters

`name` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The name used to refer and to entitle the embedded file.

`stream` [Stream](https://docs.microsoft.com/en-us/dotnet/api/system.io.stream)<br>
The stream containing the file to embed.

### **FlattenAcroForm()**

Flattens the AcroField's widget annotations of this document.<br>
 Other annotations are unaffected.

```csharp
public void FlattenAcroForm()
```

### **OnExternalDocumentFinalized(DocumentHandle)**

Occurs when the specified document is not used anymore for importing content.

```csharp
internal void OnExternalDocumentFinalized(DocumentHandle handle)
```

#### Parameters

`handle` [DocumentHandle](./pdfsharp.pdf.pdfdocument.documenthandle)<br>
