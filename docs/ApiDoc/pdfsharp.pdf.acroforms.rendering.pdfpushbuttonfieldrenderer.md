# PdfPushButtonFieldRenderer

Namespace: PdfSharp.Pdf.AcroForms.Rendering

Renders a [PdfPushButtonField](./pdfsharp.pdf.acroforms.pdfpushbuttonfield)<br>
 The current implementation does not render the Rollover- and Down- states 
 so the button will always appear in Normal state.<br>

```csharp
public class PdfPushButtonFieldRenderer
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [PdfPushButtonFieldRenderer](./pdfsharp.pdf.acroforms.rendering.pdfpushbuttonfieldrenderer)

**Remarks:**

Inheritors should override the methods [PdfPushButtonFieldRenderer.RenderNormalState(PdfPushButtonField, PdfWidgetAnnotation, XGraphics, XRect)](./pdfsharp.pdf.acroforms.rendering.pdfpushbuttonfieldrenderer#rendernormalstatepdfpushbuttonfield-pdfwidgetannotation-xgraphics-xrect), 
 [PdfPushButtonFieldRenderer.RenderRolloverState(PdfPushButtonField, PdfWidgetAnnotation, XGraphics, XRect)](./pdfsharp.pdf.acroforms.rendering.pdfpushbuttonfieldrenderer#renderrolloverstatepdfpushbuttonfield-pdfwidgetannotation-xgraphics-xrect) and 
 [PdfPushButtonFieldRenderer.RenderDownState(PdfPushButtonField, PdfWidgetAnnotation, XGraphics, XRect)](./pdfsharp.pdf.acroforms.rendering.pdfpushbuttonfieldrenderer#renderdownstatepdfpushbuttonfield-pdfwidgetannotation-xgraphics-xrect)<br><br>
 It is allowed to throw a [NotImplementedException](https://docs.microsoft.com/en-us/dotnet/api/system.notimplementedexception) in the methods
 [PdfPushButtonFieldRenderer.RenderRolloverState(PdfPushButtonField, PdfWidgetAnnotation, XGraphics, XRect)](./pdfsharp.pdf.acroforms.rendering.pdfpushbuttonfieldrenderer#renderrolloverstatepdfpushbuttonfield-pdfwidgetannotation-xgraphics-xrect) and 
 [PdfPushButtonFieldRenderer.RenderDownState(PdfPushButtonField, PdfWidgetAnnotation, XGraphics, XRect)](./pdfsharp.pdf.acroforms.rendering.pdfpushbuttonfieldrenderer#renderdownstatepdfpushbuttonfield-pdfwidgetannotation-xgraphics-xrect),
 only the implementation of [PdfPushButtonFieldRenderer.RenderNormalState(PdfPushButtonField, PdfWidgetAnnotation, XGraphics, XRect)](./pdfsharp.pdf.acroforms.rendering.pdfpushbuttonfieldrenderer#rendernormalstatepdfpushbuttonfield-pdfwidgetannotation-xgraphics-xrect) 
 is mandatory.

## Constructors

### **PdfPushButtonFieldRenderer()**

```csharp
public PdfPushButtonFieldRenderer()
```

## Methods

### **RenderNormalState(PdfPushButtonField, PdfWidgetAnnotation, XGraphics, XRect)**

Renders the normal state of the [PdfPushButtonField](./pdfsharp.pdf.acroforms.pdfpushbuttonfield)

```csharp
public void RenderNormalState(PdfPushButtonField field, PdfWidgetAnnotation widget, XGraphics gfx, XRect rect)
```

#### Parameters

`field` [PdfPushButtonField](./pdfsharp.pdf.acroforms.pdfpushbuttonfield)<br>
The field being rendered

`widget` [PdfWidgetAnnotation](./pdfsharp.pdf.annotations.pdfwidgetannotation)<br>
The [PdfWidgetAnnotation](./pdfsharp.pdf.annotations.pdfwidgetannotation) of the field that is being rendered

`gfx` [XGraphics](./pdfsharp.drawing.xgraphics)<br>
The [XGraphics](./pdfsharp.drawing.xgraphics) used to perform drawing operations

`rect` [XRect](./pdfsharp.drawing.xrect)<br>
The [XRect](./pdfsharp.drawing.xrect) spcifying the position and dimensions of the field

### **RenderRolloverState(PdfPushButtonField, PdfWidgetAnnotation, XGraphics, XRect)**

Renders the rollover state of the [PdfPushButtonField](./pdfsharp.pdf.acroforms.pdfpushbuttonfield)

```csharp
public void RenderRolloverState(PdfPushButtonField field, PdfWidgetAnnotation widget, XGraphics gfx, XRect rect)
```

#### Parameters

`field` [PdfPushButtonField](./pdfsharp.pdf.acroforms.pdfpushbuttonfield)<br>
The field being rendered

`widget` [PdfWidgetAnnotation](./pdfsharp.pdf.annotations.pdfwidgetannotation)<br>
The [PdfWidgetAnnotation](./pdfsharp.pdf.annotations.pdfwidgetannotation) of the field that is being rendered

`gfx` [XGraphics](./pdfsharp.drawing.xgraphics)<br>
The [XGraphics](./pdfsharp.drawing.xgraphics) used to perform drawing operations

`rect` [XRect](./pdfsharp.drawing.xrect)<br>
The [XRect](./pdfsharp.drawing.xrect) spcifying the position and dimensions of the field

### **RenderDownState(PdfPushButtonField, PdfWidgetAnnotation, XGraphics, XRect)**

Renders the down state of the [PdfPushButtonField](./pdfsharp.pdf.acroforms.pdfpushbuttonfield)

```csharp
public void RenderDownState(PdfPushButtonField field, PdfWidgetAnnotation widget, XGraphics gfx, XRect rect)
```

#### Parameters

`field` [PdfPushButtonField](./pdfsharp.pdf.acroforms.pdfpushbuttonfield)<br>
The field being rendered

`widget` [PdfWidgetAnnotation](./pdfsharp.pdf.annotations.pdfwidgetannotation)<br>
The [PdfWidgetAnnotation](./pdfsharp.pdf.annotations.pdfwidgetannotation) of the field that is being rendered

`gfx` [XGraphics](./pdfsharp.drawing.xgraphics)<br>
The [XGraphics](./pdfsharp.drawing.xgraphics) used to perform drawing operations

`rect` [XRect](./pdfsharp.drawing.xrect)<br>
The [XRect](./pdfsharp.drawing.xrect) spcifying the position and dimensions of the field
