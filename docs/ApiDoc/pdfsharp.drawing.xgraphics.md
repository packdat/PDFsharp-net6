# XGraphics

Namespace: PdfSharp.Drawing

Represents a drawing surface for a fixed size page.

```csharp
public sealed class XGraphics : System.IDisposable
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [XGraphics](./pdfsharp.drawing.xgraphics)<br>
Implements [IDisposable](https://docs.microsoft.com/en-us/dotnet/api/system.idisposable)

## Properties

### **PageUnit**

Gets or sets the unit of measure used for page coordinates.
 CURRENTLY ONLY POINT IS IMPLEMENTED.

```csharp
public XGraphicsUnit PageUnit { get; }
```

#### Property Value

[XGraphicsUnit](./pdfsharp.drawing.xgraphicsunit)<br>

### **PageDirection**

Gets or sets the value indicating in which direction y-value grow.

```csharp
public XPageDirection PageDirection { get; set; }
```

#### Property Value

[XPageDirection](./pdfsharp.drawing.xpagedirection)<br>

### **PageOrigin**

Gets the current page origin. Setting the origin is not yet implemented.

```csharp
public XPoint PageOrigin { get; set; }
```

#### Property Value

[XPoint](./pdfsharp.drawing.xpoint)<br>

### **PageSize**

Gets the current size of the page.

```csharp
public XSize PageSize { get; }
```

#### Property Value

[XSize](./pdfsharp.drawing.xsize)<br>

### **GraphicsStateLevel**

Gets the current graphics state level. The default value is 0. Each call of Save or BeginContainer
 increased and each call of Restore or EndContainer decreased the value by 1.

```csharp
public int GraphicsStateLevel { get; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **SmoothingMode**

Gets or sets the smoothing mode.

```csharp
public XSmoothingMode SmoothingMode { get; set; }
```

#### Property Value

[XSmoothingMode](./pdfsharp.drawing.xsmoothingmode)<br>
The smoothing mode.

### **Transform**

Gets the current transformation matrix.
 The transformation matrix cannot be set. Instead use Save/Restore or BeginContainer/EndContainer to
 save the state before Transform is called and later restore to the previous transform.

```csharp
public XMatrix Transform { get; }
```

#### Property Value

[XMatrix](./pdfsharp.drawing.xmatrix)<br>

### **Internals**

Permits access to internal data.

```csharp
public XGraphicsInternals Internals { get; }
```

#### Property Value

[XGraphicsInternals](./pdfsharp.drawing.xgraphics.xgraphicsinternals)<br>

### **Transformer**

(Under construction. May change in future versions.)

```csharp
public SpaceTransformer Transformer { get; }
```

#### Property Value

[SpaceTransformer](./pdfsharp.drawing.xgraphics.spacetransformer)<br>

### **PdfPage**

Gets the PDF page that serves as drawing surface if PDF is rendered,
 or null if no such object exists.

```csharp
public PdfPage PdfPage { get; }
```

#### Property Value

[PdfPage](./pdfsharp.pdf.pdfpage)<br>

## Methods

### **DrawImage(XImage, Double, Double)**

Draws the specified image.

```csharp
public void DrawImage(XImage image, double x, double y)
```

#### Parameters

`image` [XImage](./pdfsharp.drawing.ximage)<br>

`x` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`y` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **DrawImage(XImage, XRect)**

Draws the specified image.

```csharp
public void DrawImage(XImage image, XRect rect)
```

#### Parameters

`image` [XImage](./pdfsharp.drawing.ximage)<br>

`rect` [XRect](./pdfsharp.drawing.xrect)<br>

### **DrawImage(XImage, Double, Double, Double, Double)**

Draws the specified image.

```csharp
public void DrawImage(XImage image, double x, double y, double width, double height)
```

#### Parameters

`image` [XImage](./pdfsharp.drawing.ximage)<br>

`x` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`y` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`width` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`height` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **DrawImage(XImage, XRect, XRect, XGraphicsUnit)**

Draws the specified image.

```csharp
public void DrawImage(XImage image, XRect destRect, XRect srcRect, XGraphicsUnit srcUnit)
```

#### Parameters

`image` [XImage](./pdfsharp.drawing.ximage)<br>

`destRect` [XRect](./pdfsharp.drawing.xrect)<br>

`srcRect` [XRect](./pdfsharp.drawing.xrect)<br>

`srcUnit` [XGraphicsUnit](./pdfsharp.drawing.xgraphicsunit)<br>

### **DrawBarCode(BarCode, XPoint)**

Draws the specified bar code.

```csharp
public void DrawBarCode(BarCode barcode, XPoint position)
```

#### Parameters

`barcode` [BarCode](./pdfsharp.drawing.barcodes.barcode)<br>

`position` [XPoint](./pdfsharp.drawing.xpoint)<br>

### **DrawBarCode(BarCode, XBrush, XPoint)**

Draws the specified bar code.

```csharp
public void DrawBarCode(BarCode barcode, XBrush brush, XPoint position)
```

#### Parameters

`barcode` [BarCode](./pdfsharp.drawing.barcodes.barcode)<br>

`brush` [XBrush](./pdfsharp.drawing.xbrush)<br>

`position` [XPoint](./pdfsharp.drawing.xpoint)<br>

### **DrawBarCode(BarCode, XBrush, XFont, XPoint)**

Draws the specified bar code.

```csharp
public void DrawBarCode(BarCode barcode, XBrush brush, XFont font, XPoint position)
```

#### Parameters

`barcode` [BarCode](./pdfsharp.drawing.barcodes.barcode)<br>

`brush` [XBrush](./pdfsharp.drawing.xbrush)<br>

`font` [XFont](./pdfsharp.drawing.xfont)<br>

`position` [XPoint](./pdfsharp.drawing.xpoint)<br>

### **DrawMatrixCode(MatrixCode, XPoint)**

Draws the specified data matrix code.

```csharp
public void DrawMatrixCode(MatrixCode matrixcode, XPoint position)
```

#### Parameters

`matrixcode` [MatrixCode](./pdfsharp.drawing.barcodes.matrixcode)<br>

`position` [XPoint](./pdfsharp.drawing.xpoint)<br>

### **DrawMatrixCode(MatrixCode, XBrush, XPoint)**

Draws the specified data matrix code.

```csharp
public void DrawMatrixCode(MatrixCode matrixcode, XBrush brush, XPoint position)
```

#### Parameters

`matrixcode` [MatrixCode](./pdfsharp.drawing.barcodes.matrixcode)<br>

`brush` [XBrush](./pdfsharp.drawing.xbrush)<br>

`position` [XPoint](./pdfsharp.drawing.xpoint)<br>

### **Save()**

Saves the current state of this XGraphics object and identifies the saved state with the
 returned XGraphicsState object.

```csharp
public XGraphicsState Save()
```

#### Returns

[XGraphicsState](./pdfsharp.drawing.xgraphicsstate)<br>

### **Restore(XGraphicsState)**

Restores the state of this XGraphics object to the state represented by the specified 
 XGraphicsState object.

```csharp
public void Restore(XGraphicsState state)
```

#### Parameters

`state` [XGraphicsState](./pdfsharp.drawing.xgraphicsstate)<br>

### **Restore()**

Restores the state of this XGraphics object to the state before the most recently call of Save.

```csharp
public void Restore()
```

### **BeginContainer()**

Saves a graphics container with the current state of this XGraphics and 
 opens and uses a new graphics container.

```csharp
public XGraphicsContainer BeginContainer()
```

#### Returns

[XGraphicsContainer](./pdfsharp.drawing.xgraphicscontainer)<br>

### **BeginContainer(XRect, XRect, XGraphicsUnit)**

Saves a graphics container with the current state of this XGraphics and 
 opens and uses a new graphics container.

```csharp
public XGraphicsContainer BeginContainer(XRect dstrect, XRect srcrect, XGraphicsUnit unit)
```

#### Parameters

`dstrect` [XRect](./pdfsharp.drawing.xrect)<br>

`srcrect` [XRect](./pdfsharp.drawing.xrect)<br>

`unit` [XGraphicsUnit](./pdfsharp.drawing.xgraphicsunit)<br>

#### Returns

[XGraphicsContainer](./pdfsharp.drawing.xgraphicscontainer)<br>

### **EndContainer(XGraphicsContainer)**

Closes the current graphics container and restores the state of this XGraphics 
 to the state saved by a call to the BeginContainer method.

```csharp
public void EndContainer(XGraphicsContainer container)
```

#### Parameters

`container` [XGraphicsContainer](./pdfsharp.drawing.xgraphicscontainer)<br>

### **TranslateTransform(Double, Double)**

Applies the specified translation operation to the transformation matrix of this object by 
 prepending it to the object's transformation matrix.

```csharp
public void TranslateTransform(double dx, double dy)
```

#### Parameters

`dx` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`dy` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **TranslateTransform(Double, Double, XMatrixOrder)**

Applies the specified translation operation to the transformation matrix of this object
 in the specified order.

```csharp
public void TranslateTransform(double dx, double dy, XMatrixOrder order)
```

#### Parameters

`dx` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`dy` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`order` [XMatrixOrder](./pdfsharp.drawing.xmatrixorder)<br>

### **ScaleTransform(Double, Double)**

Applies the specified scaling operation to the transformation matrix of this object by 
 prepending it to the object's transformation matrix.

```csharp
public void ScaleTransform(double scaleX, double scaleY)
```

#### Parameters

`scaleX` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`scaleY` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **ScaleTransform(Double, Double, XMatrixOrder)**

Applies the specified scaling operation to the transformation matrix of this object
 in the specified order.

```csharp
public void ScaleTransform(double scaleX, double scaleY, XMatrixOrder order)
```

#### Parameters

`scaleX` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`scaleY` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`order` [XMatrixOrder](./pdfsharp.drawing.xmatrixorder)<br>

### **ScaleTransform(Double)**

Applies the specified scaling operation to the transformation matrix of this object by 
 prepending it to the object's transformation matrix.

```csharp
public void ScaleTransform(double scaleXY)
```

#### Parameters

`scaleXY` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **ScaleTransform(Double, XMatrixOrder)**

Applies the specified scaling operation to the transformation matrix of this object
 in the specified order.

```csharp
public void ScaleTransform(double scaleXY, XMatrixOrder order)
```

#### Parameters

`scaleXY` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`order` [XMatrixOrder](./pdfsharp.drawing.xmatrixorder)<br>

### **ScaleAtTransform(Double, Double, Double, Double)**

Applies the specified scaling operation to the transformation matrix of this object by 
 prepending it to the object's transformation matrix.

```csharp
public void ScaleAtTransform(double scaleX, double scaleY, double centerX, double centerY)
```

#### Parameters

`scaleX` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`scaleY` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`centerX` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`centerY` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **ScaleAtTransform(Double, Double, XPoint)**

Applies the specified scaling operation to the transformation matrix of this object by 
 prepending it to the object's transformation matrix.

```csharp
public void ScaleAtTransform(double scaleX, double scaleY, XPoint center)
```

#### Parameters

`scaleX` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`scaleY` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`center` [XPoint](./pdfsharp.drawing.xpoint)<br>

### **RotateTransform(Double)**

Applies the specified rotation operation to the transformation matrix of this object by 
 prepending it to the object's transformation matrix.

```csharp
public void RotateTransform(double angle)
```

#### Parameters

`angle` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **RotateTransform(Double, XMatrixOrder)**

Applies the specified rotation operation to the transformation matrix of this object
 in the specified order. The angle unit of measure is degree.

```csharp
public void RotateTransform(double angle, XMatrixOrder order)
```

#### Parameters

`angle` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`order` [XMatrixOrder](./pdfsharp.drawing.xmatrixorder)<br>

### **RotateAtTransform(Double, XPoint)**

Applies the specified rotation operation to the transformation matrix of this object by 
 prepending it to the object's transformation matrix.

```csharp
public void RotateAtTransform(double angle, XPoint point)
```

#### Parameters

`angle` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`point` [XPoint](./pdfsharp.drawing.xpoint)<br>

### **RotateAtTransform(Double, XPoint, XMatrixOrder)**

Applies the specified rotation operation to the transformation matrix of this object by 
 prepending it to the object's transformation matrix.

```csharp
public void RotateAtTransform(double angle, XPoint point, XMatrixOrder order)
```

#### Parameters

`angle` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`point` [XPoint](./pdfsharp.drawing.xpoint)<br>

`order` [XMatrixOrder](./pdfsharp.drawing.xmatrixorder)<br>

### **ShearTransform(Double, Double)**

Applies the specified shearing operation to the transformation matrix of this object by 
 prepending it to the object's transformation matrix.
 ShearTransform is a synonym for SkewAtTransform.
 Parameter shearX specifies the horizontal skew which is measured in degrees counterclockwise from the y-axis.
 Parameter shearY specifies the vertical skew which is measured in degrees counterclockwise from the x-axis.

```csharp
public void ShearTransform(double shearX, double shearY)
```

#### Parameters

`shearX` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`shearY` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **ShearTransform(Double, Double, XMatrixOrder)**

Applies the specified shearing operation to the transformation matrix of this object
 in the specified order.
 ShearTransform is a synonym for SkewAtTransform.
 Parameter shearX specifies the horizontal skew which is measured in degrees counterclockwise from the y-axis.
 Parameter shearY specifies the vertical skew which is measured in degrees counterclockwise from the x-axis.

```csharp
public void ShearTransform(double shearX, double shearY, XMatrixOrder order)
```

#### Parameters

`shearX` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`shearY` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`order` [XMatrixOrder](./pdfsharp.drawing.xmatrixorder)<br>

### **SkewAtTransform(Double, Double, Double, Double)**

Applies the specified shearing operation to the transformation matrix of this object by 
 prepending it to the object's transformation matrix.
 ShearTransform is a synonym for SkewAtTransform.
 Parameter shearX specifies the horizontal skew which is measured in degrees counterclockwise from the y-axis.
 Parameter shearY specifies the vertical skew which is measured in degrees counterclockwise from the x-axis.

```csharp
public void SkewAtTransform(double shearX, double shearY, double centerX, double centerY)
```

#### Parameters

`shearX` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`shearY` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`centerX` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`centerY` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **SkewAtTransform(Double, Double, XPoint)**

Applies the specified shearing operation to the transformation matrix of this object by 
 prepending it to the object's transformation matrix.
 ShearTransform is a synonym for SkewAtTransform.
 Parameter shearX specifies the horizontal skew which is measured in degrees counterclockwise from the y-axis.
 Parameter shearY specifies the vertical skew which is measured in degrees counterclockwise from the x-axis.

```csharp
public void SkewAtTransform(double shearX, double shearY, XPoint center)
```

#### Parameters

`shearX` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`shearY` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`center` [XPoint](./pdfsharp.drawing.xpoint)<br>

### **MultiplyTransform(XMatrix)**

Multiplies the transformation matrix of this object and specified matrix.

```csharp
public void MultiplyTransform(XMatrix matrix)
```

#### Parameters

`matrix` [XMatrix](./pdfsharp.drawing.xmatrix)<br>

### **MultiplyTransform(XMatrix, XMatrixOrder)**

Multiplies the transformation matrix of this object and specified matrix in the specified order.

```csharp
public void MultiplyTransform(XMatrix matrix, XMatrixOrder order)
```

#### Parameters

`matrix` [XMatrix](./pdfsharp.drawing.xmatrix)<br>

`order` [XMatrixOrder](./pdfsharp.drawing.xmatrixorder)<br>

### **IntersectClip(XRect)**

Updates the clip region of this XGraphics to the intersection of the 
 current clip region and the specified rectangle.

```csharp
public void IntersectClip(XRect rect)
```

#### Parameters

`rect` [XRect](./pdfsharp.drawing.xrect)<br>

### **IntersectClip(XGraphicsPath)**

Updates the clip region of this XGraphics to the intersection of the 
 current clip region and the specified graphical path.

```csharp
public void IntersectClip(XGraphicsPath path)
```

#### Parameters

`path` [XGraphicsPath](./pdfsharp.drawing.xgraphicspath)<br>

### **WriteComment(String)**

Writes a comment to the output stream. Comments have no effect on the rendering of the output.
 They may be useful to mark a position in a content stream of a page in a PDF document.

```csharp
public void WriteComment(string comment)
```

#### Parameters

`comment` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **DisassociateImage()**

```csharp
internal void DisassociateImage()
```

### **AppendToContentStream(String)**

```csharp
internal void AppendToContentStream(string str)
```

#### Parameters

`str` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **CreateMeasureContext(XSize, XGraphicsUnit, XPageDirection)**

Creates the measure context. This is a graphics context created only for querying measures of text.
 Drawing on a measure context has no effect.

```csharp
public static XGraphics CreateMeasureContext(XSize size, XGraphicsUnit pageUnit, XPageDirection pageDirection)
```

#### Parameters

`size` [XSize](./pdfsharp.drawing.xsize)<br>

`pageUnit` [XGraphicsUnit](./pdfsharp.drawing.xgraphicsunit)<br>

`pageDirection` [XPageDirection](./pdfsharp.drawing.xpagedirection)<br>

#### Returns

[XGraphics](./pdfsharp.drawing.xgraphics)<br>

### **FromPdfPage(PdfPage)**

Creates a new instance of the XGraphics class from a PdfSharp.Pdf.PdfPage object.

```csharp
public static XGraphics FromPdfPage(PdfPage page)
```

#### Parameters

`page` [PdfPage](./pdfsharp.pdf.pdfpage)<br>

#### Returns

[XGraphics](./pdfsharp.drawing.xgraphics)<br>

### **FromPdfPage(PdfPage, XGraphicsUnit)**

Creates a new instance of the XGraphics class from a PdfSharp.Pdf.PdfPage object.

```csharp
public static XGraphics FromPdfPage(PdfPage page, XGraphicsUnit unit)
```

#### Parameters

`page` [PdfPage](./pdfsharp.pdf.pdfpage)<br>

`unit` [XGraphicsUnit](./pdfsharp.drawing.xgraphicsunit)<br>

#### Returns

[XGraphics](./pdfsharp.drawing.xgraphics)<br>

### **FromPdfPage(PdfPage, XPageDirection)**

Creates a new instance of the XGraphics class from a PdfSharp.Pdf.PdfPage object.

```csharp
public static XGraphics FromPdfPage(PdfPage page, XPageDirection pageDirection)
```

#### Parameters

`page` [PdfPage](./pdfsharp.pdf.pdfpage)<br>

`pageDirection` [XPageDirection](./pdfsharp.drawing.xpagedirection)<br>

#### Returns

[XGraphics](./pdfsharp.drawing.xgraphics)<br>

### **FromPdfPage(PdfPage, XGraphicsPdfPageOptions)**

Creates a new instance of the XGraphics class from a PdfSharp.Pdf.PdfPage object.

```csharp
public static XGraphics FromPdfPage(PdfPage page, XGraphicsPdfPageOptions options)
```

#### Parameters

`page` [PdfPage](./pdfsharp.pdf.pdfpage)<br>

`options` [XGraphicsPdfPageOptions](./pdfsharp.drawing.xgraphicspdfpageoptions)<br>

#### Returns

[XGraphics](./pdfsharp.drawing.xgraphics)<br>

### **FromPdfPage(PdfPage, XGraphicsPdfPageOptions, XPageDirection)**

Creates a new instance of the XGraphics class from a PdfSharp.Pdf.PdfPage object.

```csharp
public static XGraphics FromPdfPage(PdfPage page, XGraphicsPdfPageOptions options, XPageDirection pageDirection)
```

#### Parameters

`page` [PdfPage](./pdfsharp.pdf.pdfpage)<br>

`options` [XGraphicsPdfPageOptions](./pdfsharp.drawing.xgraphicspdfpageoptions)<br>

`pageDirection` [XPageDirection](./pdfsharp.drawing.xpagedirection)<br>

#### Returns

[XGraphics](./pdfsharp.drawing.xgraphics)<br>

### **FromPdfPage(PdfPage, XGraphicsPdfPageOptions, XGraphicsUnit)**

Creates a new instance of the XGraphics class from a PdfSharp.Pdf.PdfPage object.

```csharp
public static XGraphics FromPdfPage(PdfPage page, XGraphicsPdfPageOptions options, XGraphicsUnit unit)
```

#### Parameters

`page` [PdfPage](./pdfsharp.pdf.pdfpage)<br>

`options` [XGraphicsPdfPageOptions](./pdfsharp.drawing.xgraphicspdfpageoptions)<br>

`unit` [XGraphicsUnit](./pdfsharp.drawing.xgraphicsunit)<br>

#### Returns

[XGraphics](./pdfsharp.drawing.xgraphics)<br>

### **FromPdfPage(PdfPage, XGraphicsPdfPageOptions, XGraphicsUnit, XPageDirection)**

Creates a new instance of the XGraphics class from a PdfSharp.Pdf.PdfPage object.

```csharp
public static XGraphics FromPdfPage(PdfPage page, XGraphicsPdfPageOptions options, XGraphicsUnit unit, XPageDirection pageDirection)
```

#### Parameters

`page` [PdfPage](./pdfsharp.pdf.pdfpage)<br>

`options` [XGraphicsPdfPageOptions](./pdfsharp.drawing.xgraphicspdfpageoptions)<br>

`unit` [XGraphicsUnit](./pdfsharp.drawing.xgraphicsunit)<br>

`pageDirection` [XPageDirection](./pdfsharp.drawing.xpagedirection)<br>

#### Returns

[XGraphics](./pdfsharp.drawing.xgraphics)<br>

### **FromPdfForm(XPdfForm)**

Creates a new instance of the XGraphics class from a PdfSharp.Drawing.XPdfForm object.

```csharp
public static XGraphics FromPdfForm(XPdfForm form)
```

#### Parameters

`form` [XPdfForm](./pdfsharp.drawing.xpdfform)<br>

#### Returns

[XGraphics](./pdfsharp.drawing.xgraphics)<br>

### **FromForm(XForm)**

Creates a new instance of the XGraphics class from a PdfSharp.Drawing.XForm object.

```csharp
public static XGraphics FromForm(XForm form)
```

#### Parameters

`form` [XForm](./pdfsharp.drawing.xform)<br>

#### Returns

[XGraphics](./pdfsharp.drawing.xgraphics)<br>

### **FromImage(XImage)**

Creates a new instance of the XGraphics class from a PdfSharp.Drawing.XForm object.

```csharp
public static XGraphics FromImage(XImage image)
```

#### Parameters

`image` [XImage](./pdfsharp.drawing.ximage)<br>

#### Returns

[XGraphics](./pdfsharp.drawing.xgraphics)<br>

### **FromImage(XImage, XGraphicsUnit)**

Creates a new instance of the XGraphics class from a PdfSharp.Drawing.XImage object.

```csharp
public static XGraphics FromImage(XImage image, XGraphicsUnit unit)
```

#### Parameters

`image` [XImage](./pdfsharp.drawing.ximage)<br>

`unit` [XGraphicsUnit](./pdfsharp.drawing.xgraphicsunit)<br>

#### Returns

[XGraphics](./pdfsharp.drawing.xgraphics)<br>

### **Dispose()**

Releases all resources used by this object.

```csharp
public void Dispose()
```

### **DrawLine(XPen, XPoint, XPoint)**

Draws a line connecting two XPoint structures.

```csharp
public void DrawLine(XPen pen, XPoint pt1, XPoint pt2)
```

#### Parameters

`pen` [XPen](./pdfsharp.drawing.xpen)<br>

`pt1` [XPoint](./pdfsharp.drawing.xpoint)<br>

`pt2` [XPoint](./pdfsharp.drawing.xpoint)<br>

### **DrawLine(XPen, Double, Double, Double, Double)**

Draws a line connecting the two points specified by coordinate pairs.

```csharp
public void DrawLine(XPen pen, double x1, double y1, double x2, double y2)
```

#### Parameters

`pen` [XPen](./pdfsharp.drawing.xpen)<br>

`x1` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`y1` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`x2` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`y2` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **DrawLines(XPen, XPoint[])**

Draws a series of line segments that connect an array of points.

```csharp
public void DrawLines(XPen pen, XPoint[] points)
```

#### Parameters

`pen` [XPen](./pdfsharp.drawing.xpen)<br>

`points` [XPoint[]](./pdfsharp.drawing.xpoint)<br>

### **DrawLines(XPen, Double, Double, Double[])**

Draws a series of line segments that connect an array of x and y pairs.

```csharp
public void DrawLines(XPen pen, double x, double y, Double[] value)
```

#### Parameters

`pen` [XPen](./pdfsharp.drawing.xpen)<br>

`x` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`y` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`value` [Double[]](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **DrawBezier(XPen, XPoint, XPoint, XPoint, XPoint)**

Draws a Bézier spline defined by four points.

```csharp
public void DrawBezier(XPen pen, XPoint pt1, XPoint pt2, XPoint pt3, XPoint pt4)
```

#### Parameters

`pen` [XPen](./pdfsharp.drawing.xpen)<br>

`pt1` [XPoint](./pdfsharp.drawing.xpoint)<br>

`pt2` [XPoint](./pdfsharp.drawing.xpoint)<br>

`pt3` [XPoint](./pdfsharp.drawing.xpoint)<br>

`pt4` [XPoint](./pdfsharp.drawing.xpoint)<br>

### **DrawBezier(XPen, Double, Double, Double, Double, Double, Double, Double, Double)**

Draws a Bézier spline defined by four points.

```csharp
public void DrawBezier(XPen pen, double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
```

#### Parameters

`pen` [XPen](./pdfsharp.drawing.xpen)<br>

`x1` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`y1` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`x2` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`y2` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`x3` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`y3` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`x4` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`y4` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **DrawBeziers(XPen, XPoint[])**

Draws a series of Bézier splines from an array of points.

```csharp
public void DrawBeziers(XPen pen, XPoint[] points)
```

#### Parameters

`pen` [XPen](./pdfsharp.drawing.xpen)<br>

`points` [XPoint[]](./pdfsharp.drawing.xpoint)<br>

### **DrawCurve(XPen, XPoint[])**

Draws a cardinal spline through a specified array of points.

```csharp
public void DrawCurve(XPen pen, XPoint[] points)
```

#### Parameters

`pen` [XPen](./pdfsharp.drawing.xpen)<br>

`points` [XPoint[]](./pdfsharp.drawing.xpoint)<br>

### **DrawCurve(XPen, XPoint[], Int32, Int32, Double)**

Draws a cardinal spline through a specified array of point using a specified tension.
 The drawing begins offset from the beginning of the array.

```csharp
public void DrawCurve(XPen pen, XPoint[] points, int offset, int numberOfSegments, double tension)
```

#### Parameters

`pen` [XPen](./pdfsharp.drawing.xpen)<br>

`points` [XPoint[]](./pdfsharp.drawing.xpoint)<br>

`offset` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

`numberOfSegments` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

`tension` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **DrawCurve(XPen, XPoint[], Double)**

Draws a cardinal spline through a specified array of points using a specified tension.

```csharp
public void DrawCurve(XPen pen, XPoint[] points, double tension)
```

#### Parameters

`pen` [XPen](./pdfsharp.drawing.xpen)<br>

`points` [XPoint[]](./pdfsharp.drawing.xpoint)<br>

`tension` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **DrawArc(XPen, XRect, Double, Double)**

Draws an arc representing a portion of an ellipse.

```csharp
public void DrawArc(XPen pen, XRect rect, double startAngle, double sweepAngle)
```

#### Parameters

`pen` [XPen](./pdfsharp.drawing.xpen)<br>

`rect` [XRect](./pdfsharp.drawing.xrect)<br>

`startAngle` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`sweepAngle` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **DrawArc(XPen, Double, Double, Double, Double, Double, Double)**

Draws an arc representing a portion of an ellipse.

```csharp
public void DrawArc(XPen pen, double x, double y, double width, double height, double startAngle, double sweepAngle)
```

#### Parameters

`pen` [XPen](./pdfsharp.drawing.xpen)<br>

`x` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`y` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`width` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`height` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`startAngle` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`sweepAngle` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **DrawRectangle(XPen, XRect)**

Draws a rectangle.

```csharp
public void DrawRectangle(XPen pen, XRect rect)
```

#### Parameters

`pen` [XPen](./pdfsharp.drawing.xpen)<br>

`rect` [XRect](./pdfsharp.drawing.xrect)<br>

### **DrawRectangle(XPen, Double, Double, Double, Double)**

Draws a rectangle.

```csharp
public void DrawRectangle(XPen pen, double x, double y, double width, double height)
```

#### Parameters

`pen` [XPen](./pdfsharp.drawing.xpen)<br>

`x` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`y` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`width` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`height` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **DrawRectangle(XBrush, XRect)**

Draws a rectangle.

```csharp
public void DrawRectangle(XBrush brush, XRect rect)
```

#### Parameters

`brush` [XBrush](./pdfsharp.drawing.xbrush)<br>

`rect` [XRect](./pdfsharp.drawing.xrect)<br>

### **DrawRectangle(XBrush, Double, Double, Double, Double)**

Draws a rectangle.

```csharp
public void DrawRectangle(XBrush brush, double x, double y, double width, double height)
```

#### Parameters

`brush` [XBrush](./pdfsharp.drawing.xbrush)<br>

`x` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`y` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`width` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`height` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **DrawRectangle(XPen, XBrush, XRect)**

Draws a rectangle.

```csharp
public void DrawRectangle(XPen pen, XBrush brush, XRect rect)
```

#### Parameters

`pen` [XPen](./pdfsharp.drawing.xpen)<br>

`brush` [XBrush](./pdfsharp.drawing.xbrush)<br>

`rect` [XRect](./pdfsharp.drawing.xrect)<br>

### **DrawRectangle(XPen, XBrush, Double, Double, Double, Double)**

Draws a rectangle.

```csharp
public void DrawRectangle(XPen pen, XBrush brush, double x, double y, double width, double height)
```

#### Parameters

`pen` [XPen](./pdfsharp.drawing.xpen)<br>

`brush` [XBrush](./pdfsharp.drawing.xbrush)<br>

`x` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`y` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`width` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`height` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **DrawRectangles(XPen, XRect[])**

Draws a series of rectangles.

```csharp
public void DrawRectangles(XPen pen, XRect[] rectangles)
```

#### Parameters

`pen` [XPen](./pdfsharp.drawing.xpen)<br>

`rectangles` [XRect[]](./pdfsharp.drawing.xrect)<br>

### **DrawRectangles(XBrush, XRect[])**

Draws a series of rectangles.

```csharp
public void DrawRectangles(XBrush brush, XRect[] rectangles)
```

#### Parameters

`brush` [XBrush](./pdfsharp.drawing.xbrush)<br>

`rectangles` [XRect[]](./pdfsharp.drawing.xrect)<br>

### **DrawRectangles(XPen, XBrush, XRect[])**

Draws a series of rectangles.

```csharp
public void DrawRectangles(XPen pen, XBrush brush, XRect[] rectangles)
```

#### Parameters

`pen` [XPen](./pdfsharp.drawing.xpen)<br>

`brush` [XBrush](./pdfsharp.drawing.xbrush)<br>

`rectangles` [XRect[]](./pdfsharp.drawing.xrect)<br>

### **DrawRoundedRectangle(XPen, XRect, XSize)**

Draws a rectangle with rounded corners.

```csharp
public void DrawRoundedRectangle(XPen pen, XRect rect, XSize ellipseSize)
```

#### Parameters

`pen` [XPen](./pdfsharp.drawing.xpen)<br>

`rect` [XRect](./pdfsharp.drawing.xrect)<br>

`ellipseSize` [XSize](./pdfsharp.drawing.xsize)<br>

### **DrawRoundedRectangle(XPen, Double, Double, Double, Double, Double, Double)**

Draws a rectangle with rounded corners.

```csharp
public void DrawRoundedRectangle(XPen pen, double x, double y, double width, double height, double ellipseWidth, double ellipseHeight)
```

#### Parameters

`pen` [XPen](./pdfsharp.drawing.xpen)<br>

`x` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`y` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`width` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`height` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`ellipseWidth` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`ellipseHeight` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **DrawRoundedRectangle(XBrush, XRect, XSize)**

Draws a rectangle with rounded corners.

```csharp
public void DrawRoundedRectangle(XBrush brush, XRect rect, XSize ellipseSize)
```

#### Parameters

`brush` [XBrush](./pdfsharp.drawing.xbrush)<br>

`rect` [XRect](./pdfsharp.drawing.xrect)<br>

`ellipseSize` [XSize](./pdfsharp.drawing.xsize)<br>

### **DrawRoundedRectangle(XBrush, Double, Double, Double, Double, Double, Double)**

Draws a rectangle with rounded corners.

```csharp
public void DrawRoundedRectangle(XBrush brush, double x, double y, double width, double height, double ellipseWidth, double ellipseHeight)
```

#### Parameters

`brush` [XBrush](./pdfsharp.drawing.xbrush)<br>

`x` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`y` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`width` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`height` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`ellipseWidth` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`ellipseHeight` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **DrawRoundedRectangle(XPen, XBrush, XRect, XSize)**

Draws a rectangle with rounded corners.

```csharp
public void DrawRoundedRectangle(XPen pen, XBrush brush, XRect rect, XSize ellipseSize)
```

#### Parameters

`pen` [XPen](./pdfsharp.drawing.xpen)<br>

`brush` [XBrush](./pdfsharp.drawing.xbrush)<br>

`rect` [XRect](./pdfsharp.drawing.xrect)<br>

`ellipseSize` [XSize](./pdfsharp.drawing.xsize)<br>

### **DrawRoundedRectangle(XPen, XBrush, Double, Double, Double, Double, Double, Double)**

Draws a rectangle with rounded corners.

```csharp
public void DrawRoundedRectangle(XPen pen, XBrush brush, double x, double y, double width, double height, double ellipseWidth, double ellipseHeight)
```

#### Parameters

`pen` [XPen](./pdfsharp.drawing.xpen)<br>

`brush` [XBrush](./pdfsharp.drawing.xbrush)<br>

`x` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`y` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`width` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`height` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`ellipseWidth` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`ellipseHeight` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **DrawEllipse(XPen, XRect)**

Draws an ellipse defined by a bounding rectangle.

```csharp
public void DrawEllipse(XPen pen, XRect rect)
```

#### Parameters

`pen` [XPen](./pdfsharp.drawing.xpen)<br>

`rect` [XRect](./pdfsharp.drawing.xrect)<br>

### **DrawEllipse(XPen, Double, Double, Double, Double)**

Draws an ellipse defined by a bounding rectangle.

```csharp
public void DrawEllipse(XPen pen, double x, double y, double width, double height)
```

#### Parameters

`pen` [XPen](./pdfsharp.drawing.xpen)<br>

`x` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`y` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`width` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`height` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **DrawEllipse(XBrush, XRect)**

Draws an ellipse defined by a bounding rectangle.

```csharp
public void DrawEllipse(XBrush brush, XRect rect)
```

#### Parameters

`brush` [XBrush](./pdfsharp.drawing.xbrush)<br>

`rect` [XRect](./pdfsharp.drawing.xrect)<br>

### **DrawEllipse(XBrush, Double, Double, Double, Double)**

Draws an ellipse defined by a bounding rectangle.

```csharp
public void DrawEllipse(XBrush brush, double x, double y, double width, double height)
```

#### Parameters

`brush` [XBrush](./pdfsharp.drawing.xbrush)<br>

`x` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`y` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`width` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`height` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **DrawEllipse(XPen, XBrush, XRect)**

Draws an ellipse defined by a bounding rectangle.

```csharp
public void DrawEllipse(XPen pen, XBrush brush, XRect rect)
```

#### Parameters

`pen` [XPen](./pdfsharp.drawing.xpen)<br>

`brush` [XBrush](./pdfsharp.drawing.xbrush)<br>

`rect` [XRect](./pdfsharp.drawing.xrect)<br>

### **DrawEllipse(XPen, XBrush, Double, Double, Double, Double)**

Draws an ellipse defined by a bounding rectangle.

```csharp
public void DrawEllipse(XPen pen, XBrush brush, double x, double y, double width, double height)
```

#### Parameters

`pen` [XPen](./pdfsharp.drawing.xpen)<br>

`brush` [XBrush](./pdfsharp.drawing.xbrush)<br>

`x` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`y` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`width` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`height` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **DrawPolygon(XPen, XPoint[])**

Draws a polygon defined by an array of points.

```csharp
public void DrawPolygon(XPen pen, XPoint[] points)
```

#### Parameters

`pen` [XPen](./pdfsharp.drawing.xpen)<br>

`points` [XPoint[]](./pdfsharp.drawing.xpoint)<br>

### **DrawPolygon(XBrush, XPoint[], XFillMode)**

Draws a polygon defined by an array of points.

```csharp
public void DrawPolygon(XBrush brush, XPoint[] points, XFillMode fillMode)
```

#### Parameters

`brush` [XBrush](./pdfsharp.drawing.xbrush)<br>

`points` [XPoint[]](./pdfsharp.drawing.xpoint)<br>

`fillMode` [XFillMode](./pdfsharp.drawing.xfillmode)<br>

### **DrawPolygon(XPen, XBrush, XPoint[], XFillMode)**

Draws a polygon defined by an array of points.

```csharp
public void DrawPolygon(XPen pen, XBrush brush, XPoint[] points, XFillMode fillMode)
```

#### Parameters

`pen` [XPen](./pdfsharp.drawing.xpen)<br>

`brush` [XBrush](./pdfsharp.drawing.xbrush)<br>

`points` [XPoint[]](./pdfsharp.drawing.xpoint)<br>

`fillMode` [XFillMode](./pdfsharp.drawing.xfillmode)<br>

### **DrawPie(XPen, XRect, Double, Double)**

Draws a pie defined by an ellipse.

```csharp
public void DrawPie(XPen pen, XRect rect, double startAngle, double sweepAngle)
```

#### Parameters

`pen` [XPen](./pdfsharp.drawing.xpen)<br>

`rect` [XRect](./pdfsharp.drawing.xrect)<br>

`startAngle` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`sweepAngle` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **DrawPie(XPen, Double, Double, Double, Double, Double, Double)**

Draws a pie defined by an ellipse.

```csharp
public void DrawPie(XPen pen, double x, double y, double width, double height, double startAngle, double sweepAngle)
```

#### Parameters

`pen` [XPen](./pdfsharp.drawing.xpen)<br>

`x` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`y` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`width` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`height` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`startAngle` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`sweepAngle` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **DrawPie(XBrush, XRect, Double, Double)**

Draws a pie defined by an ellipse.

```csharp
public void DrawPie(XBrush brush, XRect rect, double startAngle, double sweepAngle)
```

#### Parameters

`brush` [XBrush](./pdfsharp.drawing.xbrush)<br>

`rect` [XRect](./pdfsharp.drawing.xrect)<br>

`startAngle` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`sweepAngle` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **DrawPie(XBrush, Double, Double, Double, Double, Double, Double)**

Draws a pie defined by an ellipse.

```csharp
public void DrawPie(XBrush brush, double x, double y, double width, double height, double startAngle, double sweepAngle)
```

#### Parameters

`brush` [XBrush](./pdfsharp.drawing.xbrush)<br>

`x` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`y` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`width` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`height` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`startAngle` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`sweepAngle` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **DrawPie(XPen, XBrush, XRect, Double, Double)**

Draws a pie defined by an ellipse.

```csharp
public void DrawPie(XPen pen, XBrush brush, XRect rect, double startAngle, double sweepAngle)
```

#### Parameters

`pen` [XPen](./pdfsharp.drawing.xpen)<br>

`brush` [XBrush](./pdfsharp.drawing.xbrush)<br>

`rect` [XRect](./pdfsharp.drawing.xrect)<br>

`startAngle` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`sweepAngle` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **DrawPie(XPen, XBrush, Double, Double, Double, Double, Double, Double)**

Draws a pie defined by an ellipse.

```csharp
public void DrawPie(XPen pen, XBrush brush, double x, double y, double width, double height, double startAngle, double sweepAngle)
```

#### Parameters

`pen` [XPen](./pdfsharp.drawing.xpen)<br>

`brush` [XBrush](./pdfsharp.drawing.xbrush)<br>

`x` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`y` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`width` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`height` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`startAngle` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`sweepAngle` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **DrawClosedCurve(XPen, XPoint[])**

Draws a closed cardinal spline defined by an array of points.

```csharp
public void DrawClosedCurve(XPen pen, XPoint[] points)
```

#### Parameters

`pen` [XPen](./pdfsharp.drawing.xpen)<br>

`points` [XPoint[]](./pdfsharp.drawing.xpoint)<br>

### **DrawClosedCurve(XPen, XPoint[], Double)**

Draws a closed cardinal spline defined by an array of points.

```csharp
public void DrawClosedCurve(XPen pen, XPoint[] points, double tension)
```

#### Parameters

`pen` [XPen](./pdfsharp.drawing.xpen)<br>

`points` [XPoint[]](./pdfsharp.drawing.xpoint)<br>

`tension` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **DrawClosedCurve(XBrush, XPoint[])**

Draws a closed cardinal spline defined by an array of points.

```csharp
public void DrawClosedCurve(XBrush brush, XPoint[] points)
```

#### Parameters

`brush` [XBrush](./pdfsharp.drawing.xbrush)<br>

`points` [XPoint[]](./pdfsharp.drawing.xpoint)<br>

### **DrawClosedCurve(XBrush, XPoint[], XFillMode)**

Draws a closed cardinal spline defined by an array of points.

```csharp
public void DrawClosedCurve(XBrush brush, XPoint[] points, XFillMode fillMode)
```

#### Parameters

`brush` [XBrush](./pdfsharp.drawing.xbrush)<br>

`points` [XPoint[]](./pdfsharp.drawing.xpoint)<br>

`fillMode` [XFillMode](./pdfsharp.drawing.xfillmode)<br>

### **DrawClosedCurve(XBrush, XPoint[], XFillMode, Double)**

Draws a closed cardinal spline defined by an array of points.

```csharp
public void DrawClosedCurve(XBrush brush, XPoint[] points, XFillMode fillMode, double tension)
```

#### Parameters

`brush` [XBrush](./pdfsharp.drawing.xbrush)<br>

`points` [XPoint[]](./pdfsharp.drawing.xpoint)<br>

`fillMode` [XFillMode](./pdfsharp.drawing.xfillmode)<br>

`tension` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **DrawClosedCurve(XPen, XBrush, XPoint[])**

Draws a closed cardinal spline defined by an array of points.

```csharp
public void DrawClosedCurve(XPen pen, XBrush brush, XPoint[] points)
```

#### Parameters

`pen` [XPen](./pdfsharp.drawing.xpen)<br>

`brush` [XBrush](./pdfsharp.drawing.xbrush)<br>

`points` [XPoint[]](./pdfsharp.drawing.xpoint)<br>

### **DrawClosedCurve(XPen, XBrush, XPoint[], XFillMode)**

Draws a closed cardinal spline defined by an array of points.

```csharp
public void DrawClosedCurve(XPen pen, XBrush brush, XPoint[] points, XFillMode fillMode)
```

#### Parameters

`pen` [XPen](./pdfsharp.drawing.xpen)<br>

`brush` [XBrush](./pdfsharp.drawing.xbrush)<br>

`points` [XPoint[]](./pdfsharp.drawing.xpoint)<br>

`fillMode` [XFillMode](./pdfsharp.drawing.xfillmode)<br>

### **DrawClosedCurve(XPen, XBrush, XPoint[], XFillMode, Double)**

Draws a closed cardinal spline defined by an array of points.

```csharp
public void DrawClosedCurve(XPen pen, XBrush brush, XPoint[] points, XFillMode fillMode, double tension)
```

#### Parameters

`pen` [XPen](./pdfsharp.drawing.xpen)<br>

`brush` [XBrush](./pdfsharp.drawing.xbrush)<br>

`points` [XPoint[]](./pdfsharp.drawing.xpoint)<br>

`fillMode` [XFillMode](./pdfsharp.drawing.xfillmode)<br>

`tension` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **DrawPath(XPen, XGraphicsPath)**

Draws a graphical path.

```csharp
public void DrawPath(XPen pen, XGraphicsPath path)
```

#### Parameters

`pen` [XPen](./pdfsharp.drawing.xpen)<br>

`path` [XGraphicsPath](./pdfsharp.drawing.xgraphicspath)<br>

### **DrawPath(XBrush, XGraphicsPath)**

Draws a graphical path.

```csharp
public void DrawPath(XBrush brush, XGraphicsPath path)
```

#### Parameters

`brush` [XBrush](./pdfsharp.drawing.xbrush)<br>

`path` [XGraphicsPath](./pdfsharp.drawing.xgraphicspath)<br>

### **DrawPath(XPen, XBrush, XGraphicsPath)**

Draws a graphical path.

```csharp
public void DrawPath(XPen pen, XBrush brush, XGraphicsPath path)
```

#### Parameters

`pen` [XPen](./pdfsharp.drawing.xpen)<br>

`brush` [XBrush](./pdfsharp.drawing.xbrush)<br>

`path` [XGraphicsPath](./pdfsharp.drawing.xgraphicspath)<br>

### **DrawString(String, XFont, XBrush, XPoint)**

Draws the specified text string.

```csharp
public void DrawString(string s, XFont font, XBrush brush, XPoint point)
```

#### Parameters

`s` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`font` [XFont](./pdfsharp.drawing.xfont)<br>

`brush` [XBrush](./pdfsharp.drawing.xbrush)<br>

`point` [XPoint](./pdfsharp.drawing.xpoint)<br>

### **DrawString(String, XFont, XBrush, XPoint, XStringFormat)**

Draws the specified text string.

```csharp
public void DrawString(string s, XFont font, XBrush brush, XPoint point, XStringFormat format)
```

#### Parameters

`s` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`font` [XFont](./pdfsharp.drawing.xfont)<br>

`brush` [XBrush](./pdfsharp.drawing.xbrush)<br>

`point` [XPoint](./pdfsharp.drawing.xpoint)<br>

`format` [XStringFormat](./pdfsharp.drawing.xstringformat)<br>

### **DrawString(String, XFont, XBrush, Double, Double)**

Draws the specified text string.

```csharp
public void DrawString(string s, XFont font, XBrush brush, double x, double y)
```

#### Parameters

`s` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`font` [XFont](./pdfsharp.drawing.xfont)<br>

`brush` [XBrush](./pdfsharp.drawing.xbrush)<br>

`x` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`y` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **DrawString(String, XFont, XBrush, Double, Double, XStringFormat)**

Draws the specified text string.

```csharp
public void DrawString(string s, XFont font, XBrush brush, double x, double y, XStringFormat format)
```

#### Parameters

`s` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`font` [XFont](./pdfsharp.drawing.xfont)<br>

`brush` [XBrush](./pdfsharp.drawing.xbrush)<br>

`x` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`y` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

`format` [XStringFormat](./pdfsharp.drawing.xstringformat)<br>

### **DrawString(String, XFont, XBrush, XRect)**

Draws the specified text string.

```csharp
public void DrawString(string s, XFont font, XBrush brush, XRect layoutRectangle)
```

#### Parameters

`s` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`font` [XFont](./pdfsharp.drawing.xfont)<br>

`brush` [XBrush](./pdfsharp.drawing.xbrush)<br>

`layoutRectangle` [XRect](./pdfsharp.drawing.xrect)<br>

### **DrawString(String, XFont, XBrush, XRect, XStringFormat)**

Draws the specified text string.

```csharp
public void DrawString(string text, XFont font, XBrush brush, XRect layoutRectangle, XStringFormat format)
```

#### Parameters

`text` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`font` [XFont](./pdfsharp.drawing.xfont)<br>

`brush` [XBrush](./pdfsharp.drawing.xbrush)<br>

`layoutRectangle` [XRect](./pdfsharp.drawing.xrect)<br>

`format` [XStringFormat](./pdfsharp.drawing.xstringformat)<br>

### **MeasureString(String, XFont, XStringFormat)**

Measures the specified string when drawn with the specified font.

```csharp
public XSize MeasureString(string text, XFont font, XStringFormat stringFormat)
```

#### Parameters

`text` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`font` [XFont](./pdfsharp.drawing.xfont)<br>

`stringFormat` [XStringFormat](./pdfsharp.drawing.xstringformat)<br>

#### Returns

[XSize](./pdfsharp.drawing.xsize)<br>

### **MeasureString(String, XFont)**

Measures the specified string when drawn with the specified font.

```csharp
public XSize MeasureString(string text, XFont font)
```

#### Parameters

`text` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`font` [XFont](./pdfsharp.drawing.xfont)<br>

#### Returns

[XSize](./pdfsharp.drawing.xsize)<br>

### **DrawImage(XImage, XPoint)**

Draws the specified image.

```csharp
public void DrawImage(XImage image, XPoint point)
```

#### Parameters

`image` [XImage](./pdfsharp.drawing.ximage)<br>

`point` [XPoint](./pdfsharp.drawing.xpoint)<br>
