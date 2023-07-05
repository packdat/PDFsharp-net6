# CodeBase

Namespace: PdfSharp.Drawing.BarCodes

Represents the base class of all codes.

```csharp
public abstract class CodeBase
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [CodeBase](./pdfsharp.drawing.barcodes.codebase)

## Properties

### **Size**

Gets or sets the size.

```csharp
public XSize Size { get; set; }
```

#### Property Value

[XSize](./pdfsharp.drawing.xsize)<br>

### **Text**

Gets or sets the text the bar code shall represent.

```csharp
public string Text { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Anchor**

Always MiddleCenter.

```csharp
public AnchorType Anchor { get; set; }
```

#### Property Value

[AnchorType](./pdfsharp.drawing.barcodes.anchortype)<br>

### **Direction**

Gets or sets the drawing direction.

```csharp
public CodeDirection Direction { get; set; }
```

#### Property Value

[CodeDirection](./pdfsharp.drawing.barcodes.codedirection)<br>

## Constructors

### **CodeBase(String, XSize, CodeDirection)**

Initializes a new instance of the [CodeBase](./pdfsharp.drawing.barcodes.codebase) class.

```csharp
public CodeBase(string text, XSize size, CodeDirection direction)
```

#### Parameters

`text` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`size` [XSize](./pdfsharp.drawing.xsize)<br>

`direction` [CodeDirection](./pdfsharp.drawing.barcodes.codedirection)<br>

## Methods

### **CheckCode(String)**

When implemented in a derived class, determines whether the specified string can be used as Text
 for this bar code type.

```csharp
protected abstract void CheckCode(string text)
```

#### Parameters

`text` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The code string to check.

### **CalcDistance(AnchorType, AnchorType, XSize)**

Calculates the distance between an old anchor point and a new anchor point.

```csharp
public static XVector CalcDistance(AnchorType oldType, AnchorType newType, XSize size)
```

#### Parameters

`oldType` [AnchorType](./pdfsharp.drawing.barcodes.anchortype)<br>

`newType` [AnchorType](./pdfsharp.drawing.barcodes.anchortype)<br>

`size` [XSize](./pdfsharp.drawing.xsize)<br>

#### Returns

[XVector](./pdfsharp.drawing.xvector)<br>
