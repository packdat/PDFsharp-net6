# ChunkHeader

Namespace: PdfSharp.BigGustave

The header for a data chunk in a PNG file.

```csharp
public struct ChunkHeader
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ValueType](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype) → [ChunkHeader](./pdfsharp.biggustave.chunkheader)

## Properties

### **Position**

The position/start of the chunk header within the stream.

```csharp
public long Position { get; }
```

#### Property Value

[Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>

### **Length**

The length of the chunk in bytes.

```csharp
public int Length { get; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **Name**

The name of the chunk, uppercase first letter means the chunk is critical (vs. ancillary).

```csharp
public string Name { get; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **IsCritical**

Whether the chunk is critical (must be read by all readers) or ancillary (may be ignored).

```csharp
public bool IsCritical { get; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **IsPublic**

A public chunk is one that is defined in the International Standard or is registered in the list of public chunk types maintained by the Registration Authority. 
 Applications can also define private (unregistered) chunk types for their own purposes.

```csharp
public bool IsPublic { get; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **IsSafeToCopy**

Whether the (if unrecognized) chunk is safe to copy.

```csharp
public bool IsSafeToCopy { get; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

## Constructors

### **ChunkHeader(Int64, Int32, String)**

Create a new [ChunkHeader](./pdfsharp.biggustave.chunkheader).

```csharp
ChunkHeader(long position, int length, string name)
```

#### Parameters

`position` [Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)<br>

`length` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

`name` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

## Methods

### **ToString()**

```csharp
string ToString()
```

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
