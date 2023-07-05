# PdfTextFieldRenderer

Namespace: PdfSharp.Pdf.AcroForms.Rendering

Renders a [PdfTextField](./pdfsharp.pdf.acroforms.pdftextfield)

```csharp
public class PdfTextFieldRenderer
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [PdfTextFieldRenderer](./pdfsharp.pdf.acroforms.rendering.pdftextfieldrenderer)

**Remarks:**

Inheritors should override the method [PdfTextFieldRenderer.Render(PdfTextField, PdfWidgetAnnotation, XGraphics, XRect)](./pdfsharp.pdf.acroforms.rendering.pdftextfieldrenderer#renderpdftextfield-pdfwidgetannotation-xgraphics-xrect)

## Constructors

### **PdfTextFieldRenderer()**

```csharp
public PdfTextFieldRenderer()
```

## Methods

### **Render(PdfTextField, PdfWidgetAnnotation, XGraphics, XRect)**

Renders the [PdfTextField](./pdfsharp.pdf.acroforms.pdftextfield)

```csharp
public void Render(PdfTextField field, PdfWidgetAnnotation widget, XGraphics gfx, XRect rect)
```

#### Parameters

`field` [PdfTextField](./pdfsharp.pdf.acroforms.pdftextfield)<br>
The field being rendered

`widget` [PdfWidgetAnnotation](./pdfsharp.pdf.annotations.pdfwidgetannotation)<br>
The [PdfWidgetAnnotation](./pdfsharp.pdf.annotations.pdfwidgetannotation) of the field that is being rendered

`gfx` [XGraphics](./pdfsharp.drawing.xgraphics)<br>
The [XGraphics](./pdfsharp.drawing.xgraphics) used to perform drawing operations

`rect` [XRect](./pdfsharp.drawing.xrect)<br>
The [XRect](./pdfsharp.drawing.xrect) spcifying the position and dimensions of the field
