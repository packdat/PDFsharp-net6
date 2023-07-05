# PdfNamedDestinationParameters

Namespace: PdfSharp.Pdf.Advanced

Creates the named destination parameters.

```csharp
public class PdfNamedDestinationParameters
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [PdfNamedDestinationParameters](./pdfsharp.pdf.advanced.pdfnameddestinationparameters)

## Methods

### **CreateUnchangedPosition()**

Creates a PdfNamedDestinationParameters object for a named destination.
 Moving to this destination will only move to the destination page, without changing the left, top and zoom values for the displayed area.

```csharp
public static PdfNamedDestinationParameters CreateUnchangedPosition()
```

#### Returns

[PdfNamedDestinationParameters](./pdfsharp.pdf.advanced.pdfnameddestinationparameters)<br>

### **CreateVerticalPosition(Nullable&lt;Double&gt;, Nullable&lt;Double&gt;)**

Creates a PdfNamedDestinationParameters object for a named destination.
 Moving to this destination will move to the desired top value and the optional zoom value on the destination page. The left value for the displayed area and null values are retained unchanged.

```csharp
public static PdfNamedDestinationParameters CreateVerticalPosition(Nullable<double> top, Nullable<double> zoom)
```

#### Parameters

`top` [Nullable&lt;Double&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>
The top value of the displayed area in PDF world space units.

`zoom` [Nullable&lt;Double&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>
Optional: The zoom value for the displayed area. 1 = 100%, 2 = 200% etc.

#### Returns

[PdfNamedDestinationParameters](./pdfsharp.pdf.advanced.pdfnameddestinationparameters)<br>

### **CreatePosition(Nullable&lt;Double&gt;, Nullable&lt;Double&gt;, Nullable&lt;Double&gt;)**

Creates a PdfNamedDestinationParameters object for a named destination.
 Moving to this destination will move to the desired left and top value and the optional zoom value on the destination page. Null values are retained unchanged.

```csharp
public static PdfNamedDestinationParameters CreatePosition(Nullable<double> left, Nullable<double> top, Nullable<double> zoom)
```

#### Parameters

`left` [Nullable&lt;Double&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>
The left value of the displayed area in PDF world space units.

`top` [Nullable&lt;Double&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>
The top value of the displayed area in PDF world space units.

`zoom` [Nullable&lt;Double&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>
Optional: The zoom value for the displayed area. 1 = 100%, 2 = 200% etc.

#### Returns

[PdfNamedDestinationParameters](./pdfsharp.pdf.advanced.pdfnameddestinationparameters)<br>

### **CreatePosition(XPoint, Nullable&lt;Double&gt;)**

Creates a PdfNamedDestinationParameters object for a named destination.
 Moving to this destination will move to the desired left and top value and the optional zoom value on the destination page. Null values are retained unchanged.

```csharp
public static PdfNamedDestinationParameters CreatePosition(XPoint position, Nullable<double> zoom)
```

#### Parameters

`position` [XPoint](./pdfsharp.drawing.xpoint)<br>
An XPoint defining the left and top value of the displayed area in PDF world space units.

`zoom` [Nullable&lt;Double&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>
Optional: The zoom value for the displayed area. 1 = 100%, 2 = 200% etc.

#### Returns

[PdfNamedDestinationParameters](./pdfsharp.pdf.advanced.pdfnameddestinationparameters)<br>

### **CreateFit()**

Creates a PdfNamedDestinationParameters object for a named destination.
 Moving to this destination will move to the destination page, displaying the whole page.

```csharp
public static PdfNamedDestinationParameters CreateFit()
```

#### Returns

[PdfNamedDestinationParameters](./pdfsharp.pdf.advanced.pdfnameddestinationparameters)<br>

### **CreateFitHorizontally(Nullable&lt;Double&gt;)**

Creates a PdfNamedDestinationParameters object for a named destination.
 Moving to this destination will move to the desired top value on the destination page.
 The page width is fitted to the window. Null values are retained unchanged.

```csharp
public static PdfNamedDestinationParameters CreateFitHorizontally(Nullable<double> top)
```

#### Parameters

`top` [Nullable&lt;Double&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>
The top value of the displayed area in PDF world space units.

#### Returns

[PdfNamedDestinationParameters](./pdfsharp.pdf.advanced.pdfnameddestinationparameters)<br>

### **CreateFitVertically(Nullable&lt;Double&gt;)**

Creates a PdfNamedDestinationParameters object for a named destination.
 Moving to this destination will move to the desired left value on the destination page.
 The page height is fitted to the window. Null values are retained unchanged.

```csharp
public static PdfNamedDestinationParameters CreateFitVertically(Nullable<double> left)
```

#### Parameters

`left` [Nullable&lt;Double&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>
The left value of the displayed area in PDF world space units.

#### Returns

[PdfNamedDestinationParameters](./pdfsharp.pdf.advanced.pdfnameddestinationparameters)<br>

### **CreateFitRectangle(Double, Double, Double, Double)**

Creates a PdfNamedDestinationParameters object for a named destination.
 Moving to this destination will move to the destination page. The given rectangle is fitted to the window.

```csharp
public static PdfNamedDestinationParameters CreateFitRectangle(double left, double top, double right, double bottom)
```

#### Parameters

`left` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The left value of the rectangle to display in PDF world space units.

`top` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The top value of the rectangle to display in PDF world space units.

`right` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The right value of the rectangle to display in PDF world space units.

`bottom` [Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>
The bottom value of the rectangle to display in PDF world space units.

#### Returns

[PdfNamedDestinationParameters](./pdfsharp.pdf.advanced.pdfnameddestinationparameters)<br>

### **CreateFitRectangle(XRect)**

Creates a PdfNamedDestinationParameters object for a named destination.
 Moving to this destination will move to the destination page. The given rectangle is fitted to the window.

```csharp
public static PdfNamedDestinationParameters CreateFitRectangle(XRect rect)
```

#### Parameters

`rect` [XRect](./pdfsharp.drawing.xrect)<br>
The XRect representing the rectangle to display in PDF world space units.

#### Returns

[PdfNamedDestinationParameters](./pdfsharp.pdf.advanced.pdfnameddestinationparameters)<br>

### **CreateFitRectangle(XPoint, XPoint)**

Creates a PdfNamedDestinationParameters object for a named destination.
 Moving to this destination will move to the destination page. The given rectangle is fitted to the window.

```csharp
public static PdfNamedDestinationParameters CreateFitRectangle(XPoint point1, XPoint point2)
```

#### Parameters

`point1` [XPoint](./pdfsharp.drawing.xpoint)<br>
The first XPoint representing the rectangle to display in PDF world space units.

`point2` [XPoint](./pdfsharp.drawing.xpoint)<br>
The second XPoint representing the rectangle to display in PDF world space units.

#### Returns

[PdfNamedDestinationParameters](./pdfsharp.pdf.advanced.pdfnameddestinationparameters)<br>

### **CreateFitBoundingBox()**

Creates a PdfNamedDestinationParameters object for a named destination.
 Moving to this destination will move to the destination page. The page's bounding box is fitted to the window.

```csharp
public static PdfNamedDestinationParameters CreateFitBoundingBox()
```

#### Returns

[PdfNamedDestinationParameters](./pdfsharp.pdf.advanced.pdfnameddestinationparameters)<br>

### **CreateFitBoundingBoxHorizontally(Nullable&lt;Double&gt;)**

Creates a PdfNamedDestinationParameters object for a named destination.
 Moving to this destination will move to the desired top value on the destination page.
 The page's bounding box width is fitted to the window. Null values are retained unchanged.

```csharp
public static PdfNamedDestinationParameters CreateFitBoundingBoxHorizontally(Nullable<double> top)
```

#### Parameters

`top` [Nullable&lt;Double&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>
The top value of the displayed area in PDF world space units.

#### Returns

[PdfNamedDestinationParameters](./pdfsharp.pdf.advanced.pdfnameddestinationparameters)<br>

### **CreateFitBoundingBoxVertically(Nullable&lt;Double&gt;)**

Creates a PdfNamedDestinationParameters object for a named destination.
 Moving to this destination will move to the desired left value on the destination page.
 The page's bounding box height is fitted to the window. Null values are retained unchanged.

```csharp
public static PdfNamedDestinationParameters CreateFitBoundingBoxVertically(Nullable<double> left)
```

#### Parameters

`left` [Nullable&lt;Double&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>
The left value of the displayed area in PDF world space units.

#### Returns

[PdfNamedDestinationParameters](./pdfsharp.pdf.advanced.pdfnameddestinationparameters)<br>

### **ToString()**

Returns the parameters string for the named destination.

```csharp
public string ToString()
```

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
