# PdfObjectID

Namespace: PdfSharp.Pdf

Represents a PDF object identifier, a pair of object and generation number.

```csharp
public struct PdfObjectID
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ValueType](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype) → [PdfObjectID](./pdfsharp.pdf.pdfobjectid)<br>
Implements [IComparable](https://docs.microsoft.com/en-us/dotnet/api/system.icomparable)

## Properties

### **ObjectNumber**

Gets or sets the object number.

```csharp
public int ObjectNumber { get; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **GenerationNumber**

Gets or sets the generation number.

```csharp
public int GenerationNumber { get; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **IsEmpty**

Indicates whether this object is an empty object identifier.

```csharp
public bool IsEmpty { get; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **Empty**

Creates an empty object identifier.

```csharp
public static PdfObjectID Empty { get; }
```

#### Property Value

[PdfObjectID](./pdfsharp.pdf.pdfobjectid)<br>

## Constructors

### **PdfObjectID(Int32)**

Initializes a new instance of the [PdfObjectID](./pdfsharp.pdf.pdfobjectid) class.

```csharp
PdfObjectID(int objectNumber)
```

#### Parameters

`objectNumber` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The object number.

### **PdfObjectID(Int32, Int32)**

Initializes a new instance of the [PdfObjectID](./pdfsharp.pdf.pdfobjectid) class.

```csharp
PdfObjectID(int objectNumber, int generationNumber)
```

#### Parameters

`objectNumber` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The object number.

`generationNumber` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The generation number.

## Methods

### **Equals(Object)**

Indicates whether this instance and a specified object are equal.

```csharp
bool Equals(object obj)
```

#### Parameters

`obj` [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **GetHashCode()**

Returns the hash code for this instance.

```csharp
int GetHashCode()
```

#### Returns

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **ToString()**

Returns the object and generation numbers as a string.

```csharp
string ToString()
```

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **CompareTo(Object)**

Compares the current object id with another object.

```csharp
int CompareTo(object obj)
```

#### Parameters

`obj` [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)<br>

#### Returns

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
