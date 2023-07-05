# PdfObjectInternals

Namespace: PdfSharp.Pdf.Advanced

Provides access to the internal PDF object data structures.
 This class prevents the public interfaces from pollution with too many internal functions.

```csharp
public class PdfObjectInternals
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [PdfObjectInternals](./pdfsharp.pdf.advanced.pdfobjectinternals)

## Properties

### **ObjectID**

Gets the object identifier. Returns PdfObjectID.Empty for direct objects.

```csharp
public PdfObjectID ObjectID { get; }
```

#### Property Value

[PdfObjectID](./pdfsharp.pdf.pdfobjectid)<br>

### **ObjectNumber**

Gets the object number.

```csharp
public int ObjectNumber { get; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **GenerationNumber**

Gets the generation number.

```csharp
public int GenerationNumber { get; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **TypeID**

Gets the name of the current type.
 Not a very useful property, but can be used for data binding.

```csharp
public string TypeID { get; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
