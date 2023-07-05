# PdfInternals

Namespace: PdfSharp.Pdf.Advanced

Provides access to the internal document data structures.
 This class prevents the public interfaces from pollution with too many internal functions.

```csharp
public class PdfInternals
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [PdfInternals](./pdfsharp.pdf.advanced.pdfinternals)

## Fields

### **CustomValueKey**

The name of the custom value key.

```csharp
public string CustomValueKey;
```

## Properties

### **FirstDocumentID**

Gets or sets the first document identifier.

```csharp
public string FirstDocumentID { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **FirstDocumentGuid**

Gets the first document identifier as GUID.

```csharp
public Guid FirstDocumentGuid { get; }
```

#### Property Value

[Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)<br>

### **SecondDocumentID**

Gets or sets the second document identifier.

```csharp
public string SecondDocumentID { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **SecondDocumentGuid**

Gets the first document identifier as GUID.

```csharp
public Guid SecondDocumentGuid { get; }
```

#### Property Value

[Guid](https://docs.microsoft.com/en-us/dotnet/api/system.guid)<br>

### **Catalog**

Gets the catalog dictionary.

```csharp
public PdfCatalog Catalog { get; }
```

#### Property Value

[PdfCatalog](./pdfsharp.pdf.advanced.pdfcatalog)<br>

### **ExtGStateTable**

Gets the ExtGStateTable object.

```csharp
public PdfExtGStateTable ExtGStateTable { get; }
```

#### Property Value

[PdfExtGStateTable](./pdfsharp.pdf.advanced.pdfextgstatetable)<br>

### **UAManager**

This property is not documented by intention.

```csharp
public object UAManager { get; }
```

#### Property Value

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)<br>

### **AllObjects**

#### Caution

Use GetAllObjects.

---

Gets all indirect objects ordered by their object identifier.

```csharp
public PdfObject[] AllObjects { get; }
```

#### Property Value

[PdfObject[]](./pdfsharp.pdf.pdfobject)<br>

## Methods

### **GetObject(PdfObjectID)**

Returns the object with the specified Identifier, or null if no such object exists.

```csharp
public PdfObject GetObject(PdfObjectID objectID)
```

#### Parameters

`objectID` [PdfObjectID](./pdfsharp.pdf.pdfobjectid)<br>

#### Returns

[PdfObject](./pdfsharp.pdf.pdfobject)<br>

### **MapExternalObject(PdfObject)**

Maps the specified external object to the substitute object in this document.
 Returns null if no such object exists.

```csharp
public PdfObject MapExternalObject(PdfObject externalObject)
```

#### Parameters

`externalObject` [PdfObject](./pdfsharp.pdf.pdfobject)<br>

#### Returns

[PdfObject](./pdfsharp.pdf.pdfobject)<br>

### **GetReference(PdfObject)**

Returns the PdfReference of the specified object, or null if the object is not in the
 document's object table.

```csharp
public static PdfReference GetReference(PdfObject obj)
```

#### Parameters

`obj` [PdfObject](./pdfsharp.pdf.pdfobject)<br>

#### Returns

[PdfReference](./pdfsharp.pdf.advanced.pdfreference)<br>

### **GetObjectID(PdfObject)**

Gets the object identifier of the specified object.

```csharp
public static PdfObjectID GetObjectID(PdfObject obj)
```

#### Parameters

`obj` [PdfObject](./pdfsharp.pdf.pdfobject)<br>

#### Returns

[PdfObjectID](./pdfsharp.pdf.pdfobjectid)<br>

### **GetObjectNumber(PdfObject)**

Gets the object number of the specified object.

```csharp
public static int GetObjectNumber(PdfObject obj)
```

#### Parameters

`obj` [PdfObject](./pdfsharp.pdf.pdfobject)<br>

#### Returns

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **GenerationNumber(PdfObject)**

Gets the generation number of the specified object.

```csharp
public static int GenerationNumber(PdfObject obj)
```

#### Parameters

`obj` [PdfObject](./pdfsharp.pdf.pdfobject)<br>

#### Returns

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **GetAllObjects()**

Gets all indirect objects ordered by their object identifier.

```csharp
public PdfObject[] GetAllObjects()
```

#### Returns

[PdfObject[]](./pdfsharp.pdf.pdfobject)<br>

### **CreateIndirectObject&lt;T&gt;()**

Creates the indirect object of the specified type, adds it to the document,
 and returns the object.

```csharp
public T CreateIndirectObject<T>()
```

#### Type Parameters

`T`<br>

#### Returns

T<br>

### **AddObject(PdfObject)**

Adds an object to the PDF document. This operation and only this operation makes the object 
 an indirect object owned by this document.

```csharp
public void AddObject(PdfObject obj)
```

#### Parameters

`obj` [PdfObject](./pdfsharp.pdf.pdfobject)<br>

### **RemoveObject(PdfObject)**

Removes an object from the PDF document.

```csharp
public void RemoveObject(PdfObject obj)
```

#### Parameters

`obj` [PdfObject](./pdfsharp.pdf.pdfobject)<br>

### **GetClosure(PdfObject)**

Returns an array containing the specified object as first element follows by its transitive
 closure. The closure of an object are all objects that can be reached by indirect references. 
 The transitive closure is the result of applying the calculation of the closure to a closure
 as long as no new objects came along. This is e.g. useful for getting all objects belonging 
 to the resources of a page.

```csharp
public PdfObject[] GetClosure(PdfObject obj)
```

#### Parameters

`obj` [PdfObject](./pdfsharp.pdf.pdfobject)<br>

#### Returns

[PdfObject[]](./pdfsharp.pdf.pdfobject)<br>

### **GetClosure(PdfObject, Int32)**

Returns an array containing the specified object as first element follows by its transitive
 closure limited by the specified number of iterations.

```csharp
public PdfObject[] GetClosure(PdfObject obj, int depth)
```

#### Parameters

`obj` [PdfObject](./pdfsharp.pdf.pdfobject)<br>

`depth` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

#### Returns

[PdfObject[]](./pdfsharp.pdf.pdfobject)<br>

### **WriteObject(Stream, PdfItem)**

Writes a PdfItem into the specified stream.

```csharp
public void WriteObject(Stream stream, PdfItem item)
```

#### Parameters

`stream` [Stream](https://docs.microsoft.com/en-us/dotnet/api/system.io.stream)<br>

`item` [PdfItem](./pdfsharp.pdf.pdfitem)<br>
