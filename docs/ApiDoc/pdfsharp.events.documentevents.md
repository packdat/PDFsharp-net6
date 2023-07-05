# DocumentEvents

Namespace: PdfSharp.Events

A class encapsulating all events of a PdfDocument.

```csharp
public class DocumentEvents
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [DocumentEvents](./pdfsharp.events.documentevents)

## Constructors

### **DocumentEvents()**

```csharp
public DocumentEvents()
```

## Methods

### **OnPageAdded(Object, PageEventArgs)**

An event raised if a page was added.

```csharp
public void OnPageAdded(object sender, PageEventArgs args)
```

#### Parameters

`sender` [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)<br>
The sender of the event.

`args` [PageEventArgs](./pdfsharp.events.pageeventargs)<br>
The PageEventArgs of the event.

### **OnPageRemoved(Object, PageEventArgs)**

An event raised if a page was removes.

```csharp
public void OnPageRemoved(object sender, PageEventArgs args)
```

#### Parameters

`sender` [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)<br>
The sender of the event.

`args` [PageEventArgs](./pdfsharp.events.pageeventargs)<br>
The PageEventArgs of the event.

### **OnPageGraphicsCreated(Object, PageGraphicsEventArgs)**

An event raised if the XGraphics object of a page is created.

```csharp
public void OnPageGraphicsCreated(object sender, PageGraphicsEventArgs args)
```

#### Parameters

`sender` [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)<br>
The sender of the event.

`args` [PageGraphicsEventArgs](./pdfsharp.events.pagegraphicseventargs)<br>
The PageGraphicsEventArgs of the event.

### **OnPageGraphicsAction(Object, PageGraphicsEventArgs)**

An event raised if something is drawn on a page's XGraphics object.

```csharp
public void OnPageGraphicsAction(object sender, PageGraphicsEventArgs args)
```

#### Parameters

`sender` [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)<br>
The sender of the event.

`args` [PageGraphicsEventArgs](./pdfsharp.events.pagegraphicseventargs)<br>
The PageGraphicsEventArgs of the event.

## Events

### **PageAdded**

EventHandler for OnPageAdded.

```csharp
public event PageAddedOrRemovedEventHandler PageAdded;
```

### **PageRemoved**

EventHandler for OnPageRemoved.

```csharp
public event PageAddedOrRemovedEventHandler PageRemoved;
```

### **PageGraphicsCreated**

EventHandler for OnPageGraphicsCreated.

```csharp
public event PageGraphicsEventHandler PageGraphicsCreated;
```

### **PageGraphicsAction**

EventHandler for OnPageGraphicsAction.

```csharp
public event PageGraphicsEventHandler PageGraphicsAction;
```
