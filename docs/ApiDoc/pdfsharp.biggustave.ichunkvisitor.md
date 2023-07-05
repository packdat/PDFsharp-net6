# IChunkVisitor

Namespace: PdfSharp.BigGustave

Enables execution of custom logic whenever a chunk is read.

```csharp
public interface IChunkVisitor
```

## Methods

### **Visit(Stream, ImageHeader, ChunkHeader, Byte[], Byte[])**

Called by the PNG reader after a chunk is read.

```csharp
void Visit(Stream stream, ImageHeader header, ChunkHeader chunkHeader, Byte[] data, Byte[] crc)
```

#### Parameters

`stream` [Stream](https://docs.microsoft.com/en-us/dotnet/api/system.io.stream)<br>

`header` [ImageHeader](./pdfsharp.biggustave.imageheader)<br>

`chunkHeader` [ChunkHeader](./pdfsharp.biggustave.chunkheader)<br>

`data` [Byte[]](https://docs.microsoft.com/en-us/dotnet/api/system.byte)<br>

`crc` [Byte[]](https://docs.microsoft.com/en-us/dotnet/api/system.byte)<br>
