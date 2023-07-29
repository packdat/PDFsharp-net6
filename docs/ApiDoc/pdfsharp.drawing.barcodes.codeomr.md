# CodeOmr

Namespace: PdfSharp.Drawing.BarCodes

Represents an OMR code.

```csharp
public class CodeOmr : BarCode
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [CodeBase](./pdfsharp.drawing.barcodes.codebase) → [BarCode](./pdfsharp.drawing.barcodes.barcode) → [CodeOmr](./pdfsharp.drawing.barcodes.codeomr)

## Properties

### **SynchronizeCode**

Gets or sets a value indicating whether a synchronize mark is rendered.

```csharp
public bool SynchronizeCode { get; set; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **MakerDistance**

Gets or sets the distance of the markers.

```csharp
public double MakerDistance { get; set; }
```

#### Property Value

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **MakerThickness**

Gets or sets the thickness of the markers.

```csharp
public double MakerThickness { get; set; }
```

#### Property Value

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **WideNarrowRatio**

When overridden in a derived class gets or sets the wide narrow ratio.

```csharp
public double WideNarrowRatio { get; set; }
```

#### Property Value

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **TextLocation**

Gets or sets the location of the text next to the bar code.

```csharp
public TextLocation TextLocation { get; set; }
```

#### Property Value

[TextLocation](./pdfsharp.drawing.barcodes.textlocation)<br>

### **DataLength**

Gets or sets the length of the data that defines the bar code.

```csharp
public int DataLength { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **StartChar**

Gets or sets the optional start character.

```csharp
public char StartChar { get; set; }
```

#### Property Value

[Char](https://docs.microsoft.com/en-us/dotnet/api/system.char)<br>

### **EndChar**

Gets or sets the optional end character.

```csharp
public char EndChar { get; set; }
```

#### Property Value

[Char](https://docs.microsoft.com/en-us/dotnet/api/system.char)<br>

### **TurboBit**

Gets or sets a value indicating whether the turbo bit is to be drawn.
 (A turbo bit is something special to Kern (computer output processing) company (as far as I know))

```csharp
public bool TurboBit { get; set; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

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

### **CodeOmr(String, XSize, CodeDirection)**

Initializes a new OmrCode with the given data.

```csharp
public CodeOmr(string text, XSize size, CodeDirection direction)
```

#### Parameters

`text` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`size` [XSize](./pdfsharp.drawing.xsize)<br>

`direction` [CodeDirection](./pdfsharp.drawing.barcodes.codedirection)<br>

## Methods

### **Render(XGraphics, XBrush, XFont, XPoint)**

Renders the OMR code.

```csharp
protected internal void Render(XGraphics gfx, XBrush brush, XFont font, XPoint position)
```

#### Parameters

`gfx` [XGraphics](./pdfsharp.drawing.xgraphics)<br>

`brush` [XBrush](./pdfsharp.drawing.xbrush)<br>

`font` [XFont](./pdfsharp.drawing.xfont)<br>

`position` [XPoint](./pdfsharp.drawing.xpoint)<br>

### **CheckCode(String)**

Determines whether the specified string can be used as Text for the OMR code.

```csharp
protected void CheckCode(string text)
```

#### Parameters

`text` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
