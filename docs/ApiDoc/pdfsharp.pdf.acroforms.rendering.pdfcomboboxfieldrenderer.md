# PdfComboBoxFieldRenderer

Namespace: PdfSharp.Pdf.AcroForms.Rendering

Renders a [PdfComboBoxField](./pdfsharp.pdf.acroforms.pdfcomboboxfield)<br>

```csharp
public class PdfComboBoxFieldRenderer
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [PdfComboBoxFieldRenderer](./pdfsharp.pdf.acroforms.rendering.pdfcomboboxfieldrenderer)

**Remarks:**

Inheritors should override the method [PdfComboBoxFieldRenderer.Render(PdfComboBoxField, PdfWidgetAnnotation, XGraphics, XRect)](./pdfsharp.pdf.acroforms.rendering.pdfcomboboxfieldrenderer#renderpdfcomboboxfield-pdfwidgetannotation-xgraphics-xrect)

## Constructors

### **PdfComboBoxFieldRenderer()**

```csharp
public PdfComboBoxFieldRenderer()
```

## Methods

### **Render(PdfComboBoxField, PdfWidgetAnnotation, XGraphics, XRect)**

Renders the [PdfComboBoxField](./pdfsharp.pdf.acroforms.pdfcomboboxfield)

```csharp
public void Render(PdfComboBoxField field, PdfWidgetAnnotation widget, XGraphics gfx, XRect rect)
```

#### Parameters

`field` [PdfComboBoxField](./pdfsharp.pdf.acroforms.pdfcomboboxfield)<br>
The field being rendered

`widget` [PdfWidgetAnnotation](./pdfsharp.pdf.annotations.pdfwidgetannotation)<br>
The [PdfWidgetAnnotation](./pdfsharp.pdf.annotations.pdfwidgetannotation) of the field that is being rendered

`gfx` [XGraphics](./pdfsharp.drawing.xgraphics)<br>
The [XGraphics](./pdfsharp.drawing.xgraphics) used to perform drawing operations

`rect` [XRect](./pdfsharp.drawing.xrect)<br>
The [XRect](./pdfsharp.drawing.xrect) spcifying the position and dimensions of the field
