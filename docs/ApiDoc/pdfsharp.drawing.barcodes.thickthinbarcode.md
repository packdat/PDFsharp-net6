# ThickThinBarCode

Namespace: PdfSharp.Drawing.BarCodes

Internal base class for several bar code types.

```csharp
public abstract class ThickThinBarCode : BarCode
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [CodeBase](./pdfsharp.drawing.barcodes.codebase) → [BarCode](./pdfsharp.drawing.barcodes.barcode) → [ThickThinBarCode](./pdfsharp.drawing.barcodes.thickthinbarcode)

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

### **ThickThinBarCode(String, XSize, CodeDirection)**

Initializes a new instance of the [ThickThinBarCode](./pdfsharp.drawing.barcodes.thickthinbarcode) class.

```csharp
public ThickThinBarCode(string code, XSize size, CodeDirection direction)
```

#### Parameters

`code` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`size` [XSize](./pdfsharp.drawing.xsize)<br>

`direction` [CodeDirection](./pdfsharp.drawing.barcodes.codedirection)<br>

## Methods

### **InitRendering(BarCodeRenderInfo)**

```csharp
internal void InitRendering(BarCodeRenderInfo info)
```

#### Parameters

`info` [BarCodeRenderInfo](./pdfsharp.drawing.barcodes.barcoderenderinfo)<br>

### **RenderBar(BarCodeRenderInfo, Boolean)**

Renders a thick or thin line for the bar code.

```csharp
internal void RenderBar(BarCodeRenderInfo info, bool isThick)
```

#### Parameters

`info` [BarCodeRenderInfo](./pdfsharp.drawing.barcodes.barcoderenderinfo)<br>

`isThick` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
Determines whether a thick or a thin line is about to be rendered.

### **RenderGap(BarCodeRenderInfo, Boolean)**

Renders a thick or thin gap for the bar code.

```csharp
internal void RenderGap(BarCodeRenderInfo info, bool isThick)
```

#### Parameters

`info` [BarCodeRenderInfo](./pdfsharp.drawing.barcodes.barcoderenderinfo)<br>

`isThick` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
Determines whether a thick or a thin gap is about to be rendered.

### **RenderTurboBit(BarCodeRenderInfo, Boolean)**

Renders a thick bar before or behind the code.

```csharp
internal void RenderTurboBit(BarCodeRenderInfo info, bool startBit)
```

#### Parameters

`info` [BarCodeRenderInfo](./pdfsharp.drawing.barcodes.barcoderenderinfo)<br>

`startBit` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **RenderText(BarCodeRenderInfo)**

```csharp
internal void RenderText(BarCodeRenderInfo info)
```

#### Parameters

`info` [BarCodeRenderInfo](./pdfsharp.drawing.barcodes.barcoderenderinfo)<br>

### **GetBarWidth(BarCodeRenderInfo, Boolean)**

Gets the width of a thick or a thin line (or gap). CalcLineWidth must have been called before.

```csharp
internal double GetBarWidth(BarCodeRenderInfo info, bool isThick)
```

#### Parameters

`info` [BarCodeRenderInfo](./pdfsharp.drawing.barcodes.barcoderenderinfo)<br>

`isThick` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
Determines whether a thick line's width shall be returned.

#### Returns

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **CalcThinBarWidth(BarCodeRenderInfo)**

```csharp
internal abstract void CalcThinBarWidth(BarCodeRenderInfo info)
```

#### Parameters

`info` [BarCodeRenderInfo](./pdfsharp.drawing.barcodes.barcoderenderinfo)<br>
