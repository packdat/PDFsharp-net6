# PdfObject

Namespace: PdfSharp.Pdf

Base class of all composite PDF objects.

```csharp
public abstract class PdfObject : PdfItem, System.ICloneable
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [PdfItem](./pdfsharp.pdf.pdfitem) → [PdfObject](./pdfsharp.pdf.pdfobject)<br>
Implements [ICloneable](https://docs.microsoft.com/en-us/dotnet/api/system.icloneable)

## Properties

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

## Methods

### **Clone()**

Creates a copy of this object. The clone does not belong to a document, i.e. its owner and its iref are null.

```csharp
public PdfObject Clone()
```

#### Returns

[PdfObject](./pdfsharp.pdf.pdfobject)<br>

### **Copy()**

Implements the copy mechanism. Must be overridden in derived classes.

```csharp
protected object Copy()
```

#### Returns

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)<br>

### **SetObjectID(Int32, Int32)**

Sets the object and generation number.
 Setting the object identifier makes this object an indirect object, i.e. the object gets
 a PdfReference entry in the PdfReferenceTable.

```csharp
internal void SetObjectID(int objectNumber, int generationNumber)
```

#### Parameters

`objectNumber` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

`generationNumber` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **PrepareForSave()**

When overridden in a derived class, prepares the object to get saved.

```csharp
internal void PrepareForSave()
```

### **WriteObject(PdfWriter)**

Saves the stream position. 2nd Edition.

```csharp
internal void WriteObject(PdfWriter writer)
```

#### Parameters

`writer` [PdfWriter](./pdfsharp.pdf.io.pdfwriter)<br>

### **DeepCopyClosure(PdfDocument, PdfObject)**

```csharp
internal static PdfObject DeepCopyClosure(PdfDocument owner, PdfObject externalObject)
```

#### Parameters

`owner` [PdfDocument](./pdfsharp.pdf.pdfdocument)<br>
The document that owns the cloned objects.

`externalObject` [PdfObject](./pdfsharp.pdf.pdfobject)<br>
The root object to be cloned.

#### Returns

[PdfObject](./pdfsharp.pdf.pdfobject)<br>
The clone of the root object

### **ImportClosure(PdfImportedObjectTable, PdfDocument, PdfObject)**

```csharp
internal static PdfObject ImportClosure(PdfImportedObjectTable importedObjectTable, PdfDocument owner, PdfObject externalObject)
```

#### Parameters

`importedObjectTable` [PdfImportedObjectTable](./pdfsharp.pdf.advanced.pdfimportedobjecttable)<br>
The imported object table of the owner for the external document.

`owner` [PdfDocument](./pdfsharp.pdf.pdfdocument)<br>
The document that owns the cloned objects.

`externalObject` [PdfObject](./pdfsharp.pdf.pdfobject)<br>
The root object to be cloned.

#### Returns

[PdfObject](./pdfsharp.pdf.pdfobject)<br>
The clone of the root object
