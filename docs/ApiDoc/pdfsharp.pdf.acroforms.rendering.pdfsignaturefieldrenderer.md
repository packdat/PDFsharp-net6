# PdfSignatureFieldRenderer

Namespace: PdfSharp.Pdf.AcroForms.Rendering

Renders a [PdfSignatureField](./pdfsharp.pdf.acroforms.pdfsignaturefield)<br>
 The current implementation does not render anything.<br>

```csharp
public class PdfSignatureFieldRenderer
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [PdfSignatureFieldRenderer](./pdfsharp.pdf.acroforms.rendering.pdfsignaturefieldrenderer)

**Remarks:**

Inheritors should override the method [PdfSignatureFieldRenderer.Render(PdfSignatureField, PdfWidgetAnnotation, XGraphics, XRect)](./pdfsharp.pdf.acroforms.rendering.pdfsignaturefieldrenderer#renderpdfsignaturefield-pdfwidgetannotation-xgraphics-xrect)

## Constructors

### **PdfSignatureFieldRenderer()**

```csharp
public PdfSignatureFieldRenderer()
```

## Methods

### **Render(PdfSignatureField, PdfWidgetAnnotation, XGraphics, XRect)**

Renders the [PdfSignatureField](./pdfsharp.pdf.acroforms.pdfsignaturefield)

```csharp
public void Render(PdfSignatureField field, PdfWidgetAnnotation widget, XGraphics gfx, XRect rect)
```

#### Parameters

`field` [PdfSignatureField](./pdfsharp.pdf.acroforms.pdfsignaturefield)<br>
The field being rendered

`widget` [PdfWidgetAnnotation](./pdfsharp.pdf.annotations.pdfwidgetannotation)<br>
The [PdfWidgetAnnotation](./pdfsharp.pdf.annotations.pdfwidgetannotation) of the field that is being rendered

`gfx` [XGraphics](./pdfsharp.drawing.xgraphics)<br>
The [XGraphics](./pdfsharp.drawing.xgraphics) used to perform drawing operations

`rect` [XRect](./pdfsharp.drawing.xrect)<br>
The [XRect](./pdfsharp.drawing.xrect) spcifying the position and dimensions of the field
