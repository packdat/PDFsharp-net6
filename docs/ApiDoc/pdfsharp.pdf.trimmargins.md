# TrimMargins

Namespace: PdfSharp.Pdf

Represents trim margins added to the page.

```csharp
public sealed class TrimMargins
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [TrimMargins](./pdfsharp.pdf.trimmargins)

## Properties

### **All**

Sets all four crop margins simultaneously.

```csharp
public XUnit All { set; }
```

#### Property Value

[XUnit](./pdfsharp.drawing.xunit)<br>

### **Left**

Gets or sets the left crop margin.

```csharp
public XUnit Left { get; set; }
```

#### Property Value

[XUnit](./pdfsharp.drawing.xunit)<br>

### **Right**

Gets or sets the right crop margin.

```csharp
public XUnit Right { get; set; }
```

#### Property Value

[XUnit](./pdfsharp.drawing.xunit)<br>

### **Top**

Gets or sets the top crop margin.

```csharp
public XUnit Top { get; set; }
```

#### Property Value

[XUnit](./pdfsharp.drawing.xunit)<br>

### **Bottom**

Gets or sets the bottom crop margin.

```csharp
public XUnit Bottom { get; set; }
```

#### Property Value

[XUnit](./pdfsharp.drawing.xunit)<br>

### **AreSet**

Gets a value indicating whether this instance has at least one margin with a value other than zero.

```csharp
public bool AreSet { get; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

## Constructors

### **TrimMargins()**

```csharp
public TrimMargins()
```
