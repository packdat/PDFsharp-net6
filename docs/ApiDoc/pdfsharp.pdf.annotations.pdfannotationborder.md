# PdfAnnotationBorder

Namespace: PdfSharp.Pdf.Annotations

Specifies the characteristics of an [PdfAnnotation](./pdfsharp.pdf.annotations.pdfannotation)'s border

```csharp
public class PdfAnnotationBorder
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [PdfAnnotationBorder](./pdfsharp.pdf.annotations.pdfannotationborder)

## Properties

### **Width**

The width of the border in points

```csharp
public int Width { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **HorizontalRadius**

Horizontal radius of the border

```csharp
public int HorizontalRadius { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **VerticalRadius**

Vertical radius of the border

```csharp
public int VerticalRadius { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **BorderStyle**

The border-style

```csharp
public PdfAnnotationBorderStyle BorderStyle { get; set; }
```

#### Property Value

[PdfAnnotationBorderStyle](./pdfsharp.pdf.annotations.enums.pdfannotationborderstyle)<br>

### **DashPattern**

A dash array defining a pattern of dashes and gaps that shall be used in drawing a dashed border

```csharp
public Int32[] DashPattern { get; set; }
```

#### Property Value

[Int32[]](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

## Constructors

### **PdfAnnotationBorder()**

```csharp
public PdfAnnotationBorder()
```
