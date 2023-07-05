# PdfAcroFieldRenderer

Namespace: PdfSharp.Pdf.AcroForms.Rendering

Contains the renderers for [PdfAcroField](./pdfsharp.pdf.acroforms.pdfacrofield)s<br>
 Individual renderers may be overriden by their respective implementations

```csharp
public class PdfAcroFieldRenderer
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [PdfAcroFieldRenderer](./pdfsharp.pdf.acroforms.rendering.pdfacrofieldrenderer)

## Properties

### **CheckBoxFieldRenderer**

Gets or set the renderer for [PdfCheckBoxField](./pdfsharp.pdf.acroforms.pdfcheckboxfield)s
 <br>Trying to set this to null will throw an Exception

```csharp
public PdfCheckBoxFieldRenderer CheckBoxFieldRenderer { get; set; }
```

#### Property Value

[PdfCheckBoxFieldRenderer](./pdfsharp.pdf.acroforms.rendering.pdfcheckboxfieldrenderer)<br>

### **ComboBoxFieldRenderer**

Gets or set the renderer for [PdfComboBoxField](./pdfsharp.pdf.acroforms.pdfcomboboxfield)s
 <br>Trying to set this to null will throw an Exception

```csharp
public PdfComboBoxFieldRenderer ComboBoxFieldRenderer { get; set; }
```

#### Property Value

[PdfComboBoxFieldRenderer](./pdfsharp.pdf.acroforms.rendering.pdfcomboboxfieldrenderer)<br>

### **ListBoxFieldRenderer**

Gets or set the renderer for [PdfListBoxField](./pdfsharp.pdf.acroforms.pdflistboxfield)s
 <br>Trying to set this to null will throw an Exception

```csharp
public PdfListBoxFieldRenderer ListBoxFieldRenderer { get; set; }
```

#### Property Value

[PdfListBoxFieldRenderer](./pdfsharp.pdf.acroforms.rendering.pdflistboxfieldrenderer)<br>

### **PushButtonFieldRenderer**

Gets or set the renderer for [PdfPushButtonField](./pdfsharp.pdf.acroforms.pdfpushbuttonfield)s
 <br>Trying to set this to null will throw an Exception

```csharp
public PdfPushButtonFieldRenderer PushButtonFieldRenderer { get; set; }
```

#### Property Value

[PdfPushButtonFieldRenderer](./pdfsharp.pdf.acroforms.rendering.pdfpushbuttonfieldrenderer)<br>

### **RadioButtonFieldRenderer**

Gets or set the renderer for [PdfRadioButtonField](./pdfsharp.pdf.acroforms.pdfradiobuttonfield)s
 <br>Trying to set this to null will throw an Exception

```csharp
public PdfRadioButtonFieldRenderer RadioButtonFieldRenderer { get; set; }
```

#### Property Value

[PdfRadioButtonFieldRenderer](./pdfsharp.pdf.acroforms.rendering.pdfradiobuttonfieldrenderer)<br>

### **SignatureFieldRenderer**

Gets or set the renderer for [PdfSignatureField](./pdfsharp.pdf.acroforms.pdfsignaturefield)s
 <br>Trying to set this to null will throw an Exception

```csharp
public PdfSignatureFieldRenderer SignatureFieldRenderer { get; set; }
```

#### Property Value

[PdfSignatureFieldRenderer](./pdfsharp.pdf.acroforms.rendering.pdfsignaturefieldrenderer)<br>

### **TextFieldRenderer**

Gets or set the renderer for [PdfTextField](./pdfsharp.pdf.acroforms.pdftextfield)s
 <br>Trying to set this to null will throw an Exception

```csharp
public PdfTextFieldRenderer TextFieldRenderer { get; set; }
```

#### Property Value

[PdfTextFieldRenderer](./pdfsharp.pdf.acroforms.rendering.pdftextfieldrenderer)<br>

## Constructors

### **PdfAcroFieldRenderer()**

```csharp
public PdfAcroFieldRenderer()
```
