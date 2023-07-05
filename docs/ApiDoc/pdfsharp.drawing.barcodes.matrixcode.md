# MatrixCode

Namespace: PdfSharp.Drawing.BarCodes

Represents the base class of all 2D codes.

```csharp
public abstract class MatrixCode : CodeBase
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [CodeBase](./pdfsharp.drawing.barcodes.codebase) → [MatrixCode](./pdfsharp.drawing.barcodes.matrixcode)

## Properties

### **Encoding**

Gets or sets the encoding.

```csharp
public string Encoding { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Columns**

Gets or sets the number of columns.

```csharp
public int Columns { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **Rows**

Gets or sets the number of rows.

```csharp
public int Rows { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **Text**

Gets or sets the text.

```csharp
public string Text { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Size**

Gets or sets the size.

```csharp
public XSize Size { get; set; }
```

#### Property Value

[XSize](./pdfsharp.drawing.xsize)<br>

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

### **MatrixCode(String, String, Int32, Int32, XSize)**

Initializes a new instance of the [MatrixCode](./pdfsharp.drawing.barcodes.matrixcode) class.

```csharp
public MatrixCode(string text, string encoding, int rows, int columns, XSize size)
```

#### Parameters

`text` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`encoding` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`rows` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

`columns` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

`size` [XSize](./pdfsharp.drawing.xsize)<br>

## Methods

### **Render(XGraphics, XBrush, XPoint)**

When implemented in a derived class renders the 2D code.

```csharp
protected internal abstract void Render(XGraphics gfx, XBrush brush, XPoint center)
```

#### Parameters

`gfx` [XGraphics](./pdfsharp.drawing.xgraphics)<br>

`brush` [XBrush](./pdfsharp.drawing.xbrush)<br>

`center` [XPoint](./pdfsharp.drawing.xpoint)<br>

### **CheckCode(String)**

Determines whether the specified string can be used as Text for this matrix code type.

```csharp
protected void CheckCode(string text)
```

#### Parameters

`text` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
