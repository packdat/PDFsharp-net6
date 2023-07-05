# PdfCheckBoxFieldRenderer

Namespace: PdfSharp.Pdf.AcroForms.Rendering

Renders a [PdfCheckBoxField](./pdfsharp.pdf.acroforms.pdfcheckboxfield)<br>

```csharp
public class PdfCheckBoxFieldRenderer
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [PdfCheckBoxFieldRenderer](./pdfsharp.pdf.acroforms.rendering.pdfcheckboxfieldrenderer)

**Remarks:**

Inheritors should override the methods [PdfCheckBoxFieldRenderer.RenderCheckedState(PdfCheckBoxField, PdfWidgetAnnotation, XGraphics, XRect)](./pdfsharp.pdf.acroforms.rendering.pdfcheckboxfieldrenderer#rendercheckedstatepdfcheckboxfield-pdfwidgetannotation-xgraphics-xrect)
 and [PdfCheckBoxFieldRenderer.RenderUncheckedState(PdfCheckBoxField, PdfWidgetAnnotation, XGraphics, XRect)](./pdfsharp.pdf.acroforms.rendering.pdfcheckboxfieldrenderer#renderuncheckedstatepdfcheckboxfield-pdfwidgetannotation-xgraphics-xrect)

## Constructors

### **PdfCheckBoxFieldRenderer()**

```csharp
public PdfCheckBoxFieldRenderer()
```

## Methods

### **RenderCheckedState(PdfCheckBoxField, PdfWidgetAnnotation, XGraphics, XRect)**

Renders the ckecked state of the [PdfCheckBoxField](./pdfsharp.pdf.acroforms.pdfcheckboxfield)

```csharp
public void RenderCheckedState(PdfCheckBoxField field, PdfWidgetAnnotation widget, XGraphics gfx, XRect rect)
```

#### Parameters

`field` [PdfCheckBoxField](./pdfsharp.pdf.acroforms.pdfcheckboxfield)<br>
The field being rendered

`widget` [PdfWidgetAnnotation](./pdfsharp.pdf.annotations.pdfwidgetannotation)<br>
The [PdfWidgetAnnotation](./pdfsharp.pdf.annotations.pdfwidgetannotation) of the field that is being rendered

`gfx` [XGraphics](./pdfsharp.drawing.xgraphics)<br>
The [XGraphics](./pdfsharp.drawing.xgraphics) used to perform drawing operations

`rect` [XRect](./pdfsharp.drawing.xrect)<br>
The [XRect](./pdfsharp.drawing.xrect) spcifying the position and dimensions of the field

### **RenderUncheckedState(PdfCheckBoxField, PdfWidgetAnnotation, XGraphics, XRect)**

Renders the unckecked state of the [PdfCheckBoxField](./pdfsharp.pdf.acroforms.pdfcheckboxfield)

```csharp
public void RenderUncheckedState(PdfCheckBoxField field, PdfWidgetAnnotation widget, XGraphics gfx, XRect rect)
```

#### Parameters

`field` [PdfCheckBoxField](./pdfsharp.pdf.acroforms.pdfcheckboxfield)<br>
The field being rendered

`widget` [PdfWidgetAnnotation](./pdfsharp.pdf.annotations.pdfwidgetannotation)<br>
The [PdfWidgetAnnotation](./pdfsharp.pdf.annotations.pdfwidgetannotation) of the field that is being rendered

`gfx` [XGraphics](./pdfsharp.drawing.xgraphics)<br>
The [XGraphics](./pdfsharp.drawing.xgraphics) used to perform drawing operations

`rect` [XRect](./pdfsharp.drawing.xrect)<br>
The [XRect](./pdfsharp.drawing.xrect) spcifying the position and dimensions of the field
