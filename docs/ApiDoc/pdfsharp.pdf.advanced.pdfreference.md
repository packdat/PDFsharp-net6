# PdfReference

Namespace: PdfSharp.Pdf.Advanced

Represents an indirect reference to a PdfObject.

```csharp
public sealed class PdfReference : PdfSharp.Pdf.PdfItem, System.ICloneable
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [PdfItem](./pdfsharp.pdf.pdfitem) → [PdfReference](./pdfsharp.pdf.advanced.pdfreference)<br>
Implements [ICloneable](https://docs.microsoft.com/en-us/dotnet/api/system.icloneable)

## Properties

### **ObjectID**

Gets or sets the object identifier.

```csharp
public PdfObjectID ObjectID { get; set; }
```

#### Property Value

[PdfObjectID](./pdfsharp.pdf.pdfobjectid)<br>

### **ObjectNumber**

Gets the object number of the object identifier.

```csharp
public int ObjectNumber { get; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **GenerationNumber**

Gets the generation number of the object identifier.

```csharp
public int GenerationNumber { get; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **Position**

Gets or sets the file position of the related PdfObject.

```csharp
public int Position { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **Value**

Gets or sets the referenced PdfObject.

```csharp
public PdfObject Value { get; set; }
```

#### Property Value

[PdfObject](./pdfsharp.pdf.pdfobject)<br>

### **Document**

Gets or sets the document this object belongs to.

```csharp
public PdfDocument Document { get; set; }
```

#### Property Value

[PdfDocument](./pdfsharp.pdf.pdfdocument)<br>

## Constructors

### **PdfReference(PdfObject)**

Initializes a new PdfReference instance for the specified indirect object.

```csharp
public PdfReference(PdfObject pdfObject)
```

#### Parameters

`pdfObject` [PdfObject](./pdfsharp.pdf.pdfobject)<br>

### **PdfReference(PdfObjectID, Int32)**

Initializes a new PdfReference instance from the specified object identifier and file position.

```csharp
public PdfReference(PdfObjectID objectID, int position)
```

#### Parameters

`objectID` [PdfObjectID](./pdfsharp.pdf.pdfobjectid)<br>

`position` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

## Methods

### **WriteXRefEntry(PdfWriter)**

Writes the object in PDF iref table format.

```csharp
internal void WriteXRefEntry(PdfWriter writer)
```

#### Parameters

`writer` [PdfWriter](./pdfsharp.pdf.io.pdfwriter)<br>

### **WriteObject(PdfWriter)**

Writes an indirect reference.

```csharp
internal void WriteObject(PdfWriter writer)
```

#### Parameters

`writer` [PdfWriter](./pdfsharp.pdf.io.pdfwriter)<br>

### **SetObject(PdfObject)**

Hack for dead objects.

```csharp
internal void SetObject(PdfObject value)
```

#### Parameters

`value` [PdfObject](./pdfsharp.pdf.pdfobject)<br>

### **ToString()**

Gets a string representing the object identifier.

```csharp
public string ToString()
```

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Dereference(Object&)**

Dereferences the specified item. If the item is a PdfReference, the item is set
 to the referenced value. Otherwise no action is taken.

```csharp
public static void Dereference(Object& item)
```

#### Parameters

`item` [Object&](https://docs.microsoft.com/en-us/dotnet/api/system.object&)<br>

### **Dereference(PdfItem&)**

Dereferences the specified item. If the item is a PdfReference, the item is set
 to the referenced value. Otherwise no action is taken.

```csharp
public static void Dereference(PdfItem& item)
```

#### Parameters

`item` [PdfItem&](./pdfsharp.pdf.pdfitem&)<br>
