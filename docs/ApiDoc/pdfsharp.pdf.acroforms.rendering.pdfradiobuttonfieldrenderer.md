# PdfRadioButtonFieldRenderer

Namespace: PdfSharp.Pdf.AcroForms.Rendering

Renders a [PdfRadioButtonField](./pdfsharp.pdf.acroforms.pdfradiobuttonfield)<br>

```csharp
public class PdfRadioButtonFieldRenderer
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [PdfRadioButtonFieldRenderer](./pdfsharp.pdf.acroforms.rendering.pdfradiobuttonfieldrenderer)

**Remarks:**

Inheritors should override the methods
 [PdfRadioButtonFieldRenderer.RenderCheckedState(PdfRadioButtonField, PdfWidgetAnnotation, XGraphics, XRect)](./pdfsharp.pdf.acroforms.rendering.pdfradiobuttonfieldrenderer#rendercheckedstatepdfradiobuttonfield-pdfwidgetannotation-xgraphics-xrect) and
 [PdfRadioButtonFieldRenderer.RenderUncheckedState(PdfRadioButtonField, PdfWidgetAnnotation, XGraphics, XRect)](./pdfsharp.pdf.acroforms.rendering.pdfradiobuttonfieldrenderer#renderuncheckedstatepdfradiobuttonfield-pdfwidgetannotation-xgraphics-xrect)

## Constructors

### **PdfRadioButtonFieldRenderer()**

```csharp
public PdfRadioButtonFieldRenderer()
```

## Methods

### **RenderCheckedState(PdfRadioButtonField, PdfWidgetAnnotation, XGraphics, XRect)**

Renders the ckecked state of the [PdfRadioButtonField](./pdfsharp.pdf.acroforms.pdfradiobuttonfield)

```csharp
public void RenderCheckedState(PdfRadioButtonField field, PdfWidgetAnnotation widget, XGraphics gfx, XRect rect)
```

#### Parameters

`field` [PdfRadioButtonField](./pdfsharp.pdf.acroforms.pdfradiobuttonfield)<br>
The field being rendered

`widget` [PdfWidgetAnnotation](./pdfsharp.pdf.annotations.pdfwidgetannotation)<br>
The [PdfWidgetAnnotation](./pdfsharp.pdf.annotations.pdfwidgetannotation) of the field that is being rendered

`gfx` [XGraphics](./pdfsharp.drawing.xgraphics)<br>
The [XGraphics](./pdfsharp.drawing.xgraphics) used to perform drawing operations

`rect` [XRect](./pdfsharp.drawing.xrect)<br>
The [XRect](./pdfsharp.drawing.xrect) spcifying the position and dimensions of the field

### **RenderUncheckedState(PdfRadioButtonField, PdfWidgetAnnotation, XGraphics, XRect)**

Renders the unckecked state of the [PdfRadioButtonField](./pdfsharp.pdf.acroforms.pdfradiobuttonfield)

```csharp
public void RenderUncheckedState(PdfRadioButtonField field, PdfWidgetAnnotation widget, XGraphics gfx, XRect rect)
```

#### Parameters

`field` [PdfRadioButtonField](./pdfsharp.pdf.acroforms.pdfradiobuttonfield)<br>
The field being rendered

`widget` [PdfWidgetAnnotation](./pdfsharp.pdf.annotations.pdfwidgetannotation)<br>
The [PdfWidgetAnnotation](./pdfsharp.pdf.annotations.pdfwidgetannotation) of the field that is being rendered

`gfx` [XGraphics](./pdfsharp.drawing.xgraphics)<br>
The [XGraphics](./pdfsharp.drawing.xgraphics) used to perform drawing operations

`rect` [XRect](./pdfsharp.drawing.xrect)<br>
The [XRect](./pdfsharp.drawing.xrect) spcifying the position and dimensions of the field
