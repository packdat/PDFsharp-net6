# PngOpenerSettings

Namespace: PdfSharp.BigGustave

Settings to use when opening a PNG using [Png.Open(Stream, IChunkVisitor)](./pdfsharp.biggustave.png#openstream-ichunkvisitor)

```csharp
public class PngOpenerSettings
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [PngOpenerSettings](./pdfsharp.biggustave.pngopenersettings)

## Properties

### **ChunkVisitor**

The code to execute whenever a chunk is read. Can be .

```csharp
public IChunkVisitor ChunkVisitor { get; set; }
```

#### Property Value

[IChunkVisitor](./pdfsharp.biggustave.ichunkvisitor)<br>

### **DisallowTrailingData**

Whether to throw if the image contains data after the image end marker.
  by default.

```csharp
public bool DisallowTrailingData { get; set; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

## Constructors

### **PngOpenerSettings()**

```csharp
public PngOpenerSettings()
```
