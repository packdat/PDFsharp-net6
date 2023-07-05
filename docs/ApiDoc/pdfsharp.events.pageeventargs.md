# PageEventArgs

Namespace: PdfSharp.Events

EventArgs for changes in the PdfPages of a document.

```csharp
public class PageEventArgs : PdfSharpEventArgs
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [EventArgs](https://docs.microsoft.com/en-us/dotnet/api/system.eventargs) → [PdfSharpEventArgs](./pdfsharp.events.pdfsharpeventargs) → [PageEventArgs](./pdfsharp.events.pageeventargs)

## Properties

### **Page**

Gets or sets the affected page.

```csharp
public PdfPage Page { get; set; }
```

#### Property Value

[PdfPage](./pdfsharp.pdf.pdfpage)<br>

### **PageIndex**

Gets or sets the page index of the affected page.

```csharp
public int PageIndex { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **EventType**

The event type of PageEvent.

```csharp
public PageEventType EventType { get; internal set; }
```

#### Property Value

[PageEventType](./pdfsharp.events.pageeventtype)<br>

### **Source**

The source of the event.

```csharp
public PdfObject Source { get; set; }
```

#### Property Value

[PdfObject](./pdfsharp.pdf.pdfobject)<br>

## Constructors

### **PageEventArgs()**

```csharp
public PageEventArgs()
```
