# UAManager

Namespace: PdfSharp.UniversalAccessibility

This is just a scratch.

```csharp
public class UAManager
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [UAManager](./pdfsharp.universalaccessibility.uamanager)

## Properties

### **StructureTreeRoot**

Root of the structure tree.

```csharp
public PdfStructureTreeRoot StructureTreeRoot { get; set; }
```

#### Property Value

[PdfStructureTreeRoot](./pdfsharp.pdf.structure.pdfstructuretreeroot)<br>

### **StructureTreeElementDocument**

Structure element of the document.

```csharp
public PdfStructureElement StructureTreeElementDocument { get; set; }
```

#### Property Value

[PdfStructureElement](./pdfsharp.pdf.structure.pdfstructureelement)<br>

### **StructureBuilder**

Gets the structure builder.

```csharp
public StructureBuilder StructureBuilder { get; }
```

#### Property Value

[StructureBuilder](./pdfsharp.universalaccessibility.structurebuilder)<br>

### **Owner**

Gets the owning document for this UAManager.

```csharp
public PdfDocument Owner { get; }
```

#### Property Value

[PdfDocument](./pdfsharp.pdf.pdfdocument)<br>

### **CurrentPage**

Gets the current page.

```csharp
public PdfPage CurrentPage { get; private set; }
```

#### Property Value

[PdfPage](./pdfsharp.pdf.pdfpage)<br>

### **CurrentGraphics**

Gets the current XGraphics object.

```csharp
public XGraphics CurrentGraphics { get; private set; }
```

#### Property Value

[XGraphics](./pdfsharp.drawing.xgraphics)<br>

## Methods

### **ForDocument(PdfDocument)**

Gets the Universal Accessibility Manager for the document.

```csharp
public static UAManager ForDocument(PdfDocument document)
```

#### Parameters

`document` [PdfDocument](./pdfsharp.pdf.pdfdocument)<br>

#### Returns

[UAManager](./pdfsharp.universalaccessibility.uamanager)<br>

### **SetDocumentLanguage(String)**

Sets the language of the document.

```csharp
public void SetDocumentLanguage(string lang)
```

#### Parameters

`lang` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **BeginTextMode()**

Sets the text mode.

```csharp
public void BeginTextMode()
```

### **BeginGraphicMode()**

Sets the graphic mode.

```csharp
public void BeginGraphicMode()
```

### **IsInTextMode()**

Determine if renderer is in Text mode or Graphic mode.

```csharp
public bool IsInTextMode()
```

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
