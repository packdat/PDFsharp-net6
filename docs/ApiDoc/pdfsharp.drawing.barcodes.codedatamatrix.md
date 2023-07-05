# CodeDataMatrix

Namespace: PdfSharp.Drawing.BarCodes

Defines the DataMatrix 2D barcode. THIS IS AN EMPIRA INTERNAL IMPLEMENTATION. THE CODE IN
 THE OPEN SOURCE VERSION IS A FAKE.

```csharp
public class CodeDataMatrix : MatrixCode
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [CodeBase](./pdfsharp.drawing.barcodes.codebase) → [MatrixCode](./pdfsharp.drawing.barcodes.matrixcode) → [CodeDataMatrix](./pdfsharp.drawing.barcodes.codedatamatrix)

## Properties

### **QuietZone**

Gets or sets the size of the Matrix' Quiet Zone.

```csharp
public int QuietZone { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

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

### **CodeDataMatrix()**

Initializes a new instance of CodeDataMatrix.

```csharp
public CodeDataMatrix()
```

### **CodeDataMatrix(String, Int32)**

Initializes a new instance of CodeDataMatrix.

```csharp
public CodeDataMatrix(string code, int length)
```

#### Parameters

`code` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`length` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **CodeDataMatrix(String, Int32, XSize)**

Initializes a new instance of CodeDataMatrix.

```csharp
public CodeDataMatrix(string code, int length, XSize size)
```

#### Parameters

`code` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`length` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

`size` [XSize](./pdfsharp.drawing.xsize)<br>

### **CodeDataMatrix(String, DataMatrixEncoding, Int32, XSize)**

Initializes a new instance of CodeDataMatrix.

```csharp
public CodeDataMatrix(string code, DataMatrixEncoding dmEncoding, int length, XSize size)
```

#### Parameters

`code` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`dmEncoding` [DataMatrixEncoding](./pdfsharp.drawing.barcodes.datamatrixencoding)<br>

`length` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

`size` [XSize](./pdfsharp.drawing.xsize)<br>

### **CodeDataMatrix(String, Int32, Int32)**

Initializes a new instance of CodeDataMatrix.

```csharp
public CodeDataMatrix(string code, int rows, int columns)
```

#### Parameters

`code` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`rows` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

`columns` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **CodeDataMatrix(String, Int32, Int32, XSize)**

Initializes a new instance of CodeDataMatrix.

```csharp
public CodeDataMatrix(string code, int rows, int columns, XSize size)
```

#### Parameters

`code` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`rows` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

`columns` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

`size` [XSize](./pdfsharp.drawing.xsize)<br>

### **CodeDataMatrix(String, DataMatrixEncoding, Int32, Int32, XSize)**

Initializes a new instance of CodeDataMatrix.

```csharp
public CodeDataMatrix(string code, DataMatrixEncoding dmEncoding, int rows, int columns, XSize size)
```

#### Parameters

`code` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`dmEncoding` [DataMatrixEncoding](./pdfsharp.drawing.barcodes.datamatrixencoding)<br>

`rows` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

`columns` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

`size` [XSize](./pdfsharp.drawing.xsize)<br>

### **CodeDataMatrix(String, Int32, Int32, Int32)**

Initializes a new instance of CodeDataMatrix.

```csharp
public CodeDataMatrix(string code, int rows, int columns, int quietZone)
```

#### Parameters

`code` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`rows` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

`columns` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

`quietZone` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **CodeDataMatrix(String, String, Int32, Int32, Int32, XSize)**

Initializes a new instance of CodeDataMatrix.

```csharp
public CodeDataMatrix(string code, string encoding, int rows, int columns, int quietZone, XSize size)
```

#### Parameters

`code` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`encoding` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`rows` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

`columns` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

`quietZone` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

`size` [XSize](./pdfsharp.drawing.xsize)<br>

## Methods

### **SetEncoding(DataMatrixEncoding)**

Sets the encoding of the DataMatrix.

```csharp
public void SetEncoding(DataMatrixEncoding dmEncoding)
```

#### Parameters

`dmEncoding` [DataMatrixEncoding](./pdfsharp.drawing.barcodes.datamatrixencoding)<br>

### **Render(XGraphics, XBrush, XPoint)**

Renders the matrix code.

```csharp
protected internal void Render(XGraphics gfx, XBrush brush, XPoint position)
```

#### Parameters

`gfx` [XGraphics](./pdfsharp.drawing.xgraphics)<br>

`brush` [XBrush](./pdfsharp.drawing.xbrush)<br>

`position` [XPoint](./pdfsharp.drawing.xpoint)<br>

### **CheckCode(String)**

Determines whether the specified string can be used as data in the DataMatrix.

```csharp
protected void CheckCode(string text)
```

#### Parameters

`text` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The code to be checked.
