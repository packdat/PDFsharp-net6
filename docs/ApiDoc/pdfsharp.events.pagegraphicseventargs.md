# PageGraphicsEventArgs

Namespace: PdfSharp.Events

EventArgs for actions on a page's XGraphics object.

```csharp
public class PageGraphicsEventArgs : PdfSharpEventArgs
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [EventArgs](https://docs.microsoft.com/en-us/dotnet/api/system.eventargs) → [PdfSharpEventArgs](./pdfsharp.events.pdfsharpeventargs) → [PageGraphicsEventArgs](./pdfsharp.events.pagegraphicseventargs)

## Properties

### **Page**

Gets the page xxxxx.

```csharp
public PdfPage Page { get; internal set; }
```

#### Property Value

[PdfPage](./pdfsharp.pdf.pdfpage)<br>

### **Graphics**

Gets the created XGraphics object.

```csharp
public XGraphics Graphics { get; internal set; }
```

#### Property Value

[XGraphics](./pdfsharp.drawing.xgraphics)<br>

### **ActionType**

The action type of PageGraphicsEvent.

```csharp
public PageGraphicsActionType ActionType { get; internal set; }
```

#### Property Value

[PageGraphicsActionType](./pdfsharp.events.pagegraphicsactiontype)<br>

### **Source**

The source of the event.

```csharp
public PdfObject Source { get; set; }
```

#### Property Value

[PdfObject](./pdfsharp.pdf.pdfobject)<br>

## Constructors

### **PageGraphicsEventArgs()**

```csharp
public PageGraphicsEventArgs()
```
