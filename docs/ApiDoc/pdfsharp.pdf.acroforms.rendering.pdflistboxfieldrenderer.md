# PdfListBoxFieldRenderer

Namespace: PdfSharp.Pdf.AcroForms.Rendering

Renders a [PdfListBoxField](./pdfsharp.pdf.acroforms.pdflistboxfield)<br>

```csharp
public class PdfListBoxFieldRenderer
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [PdfListBoxFieldRenderer](./pdfsharp.pdf.acroforms.rendering.pdflistboxfieldrenderer)

**Remarks:**

Inheritors should override the method [PdfListBoxFieldRenderer.Render(PdfListBoxField, PdfWidgetAnnotation, XGraphics, XRect)](./pdfsharp.pdf.acroforms.rendering.pdflistboxfieldrenderer#renderpdflistboxfield-pdfwidgetannotation-xgraphics-xrect)

## Constructors

### **PdfListBoxFieldRenderer()**

```csharp
public PdfListBoxFieldRenderer()
```

## Methods

### **Render(PdfListBoxField, PdfWidgetAnnotation, XGraphics, XRect)**

Renders the [PdfListBoxField](./pdfsharp.pdf.acroforms.pdflistboxfield)

```csharp
public void Render(PdfListBoxField field, PdfWidgetAnnotation widget, XGraphics gfx, XRect rect)
```

#### Parameters

`field` [PdfListBoxField](./pdfsharp.pdf.acroforms.pdflistboxfield)<br>
The field being rendered

`widget` [PdfWidgetAnnotation](./pdfsharp.pdf.annotations.pdfwidgetannotation)<br>
The [PdfWidgetAnnotation](./pdfsharp.pdf.annotations.pdfwidgetannotation) of the field that is being rendered

`gfx` [XGraphics](./pdfsharp.drawing.xgraphics)<br>
The [XGraphics](./pdfsharp.drawing.xgraphics) used to perform drawing operations

`rect` [XRect](./pdfsharp.drawing.xrect)<br>
The [XRect](./pdfsharp.drawing.xrect) spcifying the position and dimensions of the field
