# ContentReaderException

Namespace: PdfSharp.Pdf.Content

Exception thrown by ContentReader.

```csharp
public class ContentReaderException : PdfSharp.PdfSharpException, System.Runtime.Serialization.ISerializable
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception) → [PdfSharpException](./pdfsharp.pdfsharpexception) → [ContentReaderException](./pdfsharp.pdf.content.contentreaderexception)<br>
Implements [ISerializable](https://docs.microsoft.com/en-us/dotnet/api/system.runtime.serialization.iserializable)

## Properties

### **TargetSite**

```csharp
public MethodBase TargetSite { get; }
```

#### Property Value

[MethodBase](https://docs.microsoft.com/en-us/dotnet/api/system.reflection.methodbase)<br>

### **Message**

```csharp
public string Message { get; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Data**

```csharp
public IDictionary Data { get; }
```

#### Property Value

[IDictionary](https://docs.microsoft.com/en-us/dotnet/api/system.collections.idictionary)<br>

### **InnerException**

```csharp
public Exception InnerException { get; }
```

#### Property Value

[Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception)<br>

### **HelpLink**

```csharp
public string HelpLink { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Source**

```csharp
public string Source { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **HResult**

```csharp
public int HResult { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **StackTrace**

```csharp
public string StackTrace { get; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

## Constructors

### **ContentReaderException()**

Initializes a new instance of the [ContentReaderException](./pdfsharp.pdf.content.contentreaderexception) class.

```csharp
public ContentReaderException()
```

### **ContentReaderException(String)**

Initializes a new instance of the [ContentReaderException](./pdfsharp.pdf.content.contentreaderexception) class.

```csharp
public ContentReaderException(string message)
```

#### Parameters

`message` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The message.

### **ContentReaderException(String, Exception)**

Initializes a new instance of the [ContentReaderException](./pdfsharp.pdf.content.contentreaderexception) class.

```csharp
public ContentReaderException(string message, Exception innerException)
```

#### Parameters

`message` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The message.

`innerException` [Exception](https://docs.microsoft.com/en-us/dotnet/api/system.exception)<br>
The inner exception.
