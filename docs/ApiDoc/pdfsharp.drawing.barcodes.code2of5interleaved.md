# Code2of5Interleaved

Namespace: PdfSharp.Drawing.BarCodes

Implementation of the Code 2 of 5 bar code.

```csharp
public class Code2of5Interleaved : ThickThinBarCode
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [CodeBase](./pdfsharp.drawing.barcodes.codebase) → [BarCode](./pdfsharp.drawing.barcodes.barcode) → [ThickThinBarCode](./pdfsharp.drawing.barcodes.thickthinbarcode) → [Code2of5Interleaved](./pdfsharp.drawing.barcodes.code2of5interleaved)

## Properties

### **WideNarrowRatio**

Gets or sets the ratio between thick and thin lines. Must be between 2 and 3.
 Optimal and also default value is 2.6.

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

### **Code2of5Interleaved()**

Initializes a new instance of Interleaved2of5.

```csharp
public Code2of5Interleaved()
```

### **Code2of5Interleaved(String)**

Initializes a new instance of Interleaved2of5.

```csharp
public Code2of5Interleaved(string code)
```

#### Parameters

`code` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Code2of5Interleaved(String, XSize)**

Initializes a new instance of Interleaved2of5.

```csharp
public Code2of5Interleaved(string code, XSize size)
```

#### Parameters

`code` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`size` [XSize](./pdfsharp.drawing.xsize)<br>

### **Code2of5Interleaved(String, XSize, CodeDirection)**

Initializes a new instance of Interleaved2of5.

```csharp
public Code2of5Interleaved(string code, XSize size, CodeDirection direction)
```

#### Parameters

`code` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`size` [XSize](./pdfsharp.drawing.xsize)<br>

`direction` [CodeDirection](./pdfsharp.drawing.barcodes.codedirection)<br>

## Methods

### **Render(XGraphics, XBrush, XFont, XPoint)**

Renders the bar code.

```csharp
protected internal void Render(XGraphics gfx, XBrush brush, XFont font, XPoint position)
```

#### Parameters

`gfx` [XGraphics](./pdfsharp.drawing.xgraphics)<br>

`brush` [XBrush](./pdfsharp.drawing.xbrush)<br>

`font` [XFont](./pdfsharp.drawing.xfont)<br>

`position` [XPoint](./pdfsharp.drawing.xpoint)<br>

### **CalcThinBarWidth(BarCodeRenderInfo)**

Calculates the thick and thin line widths,
 taking into account the required rendering size.

```csharp
internal void CalcThinBarWidth(BarCodeRenderInfo info)
```

#### Parameters

`info` [BarCodeRenderInfo](./pdfsharp.drawing.barcodes.barcoderenderinfo)<br>

### **CheckCode(String)**

Checks the code to be convertible into an interleaved 2 of 5 bar code.

```csharp
protected void CheckCode(string text)
```

#### Parameters

`text` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The code to be checked.
