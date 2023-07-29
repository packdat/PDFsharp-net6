# StructureBuilder

Namespace: PdfSharp.UniversalAccessibility

Helper class that adds structure to PDF documents.

```csharp
public class StructureBuilder
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [StructureBuilder](./pdfsharp.universalaccessibility.structurebuilder)

## Properties

### **CurrentStructureElement**

Gets the current structure element.

```csharp
public PdfStructureElement CurrentStructureElement { get; }
```

#### Property Value

[PdfStructureElement](./pdfsharp.pdf.structure.pdfstructureelement)<br>

## Methods

### **BeginElement(PdfGroupingElementTag)**

Starts a grouping element.

```csharp
public void BeginElement(PdfGroupingElementTag tag)
```

#### Parameters

`tag` [PdfGroupingElementTag](./pdfsharp.universalaccessibility.pdfgroupingelementtag)<br>
The structure type to be created.

### **BeginGroupingElement(String)**

Starts a grouping element.

```csharp
public void BeginGroupingElement(string tag)
```

#### Parameters

`tag` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **BeginElement(PdfBlockLevelElementTag)**

Starts a block-level element.

```csharp
public void BeginElement(PdfBlockLevelElementTag tag)
```

#### Parameters

`tag` [PdfBlockLevelElementTag](./pdfsharp.universalaccessibility.pdfblocklevelelementtag)<br>
The structure type to be created.

### **BeginBlockLevelElement(String)**

Starts a block-level element.

```csharp
public void BeginBlockLevelElement(string tag)
```

#### Parameters

`tag` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **BeginElement(PdfInlineLevelElementTag)**

Starts an inline-level element.

```csharp
public void BeginElement(PdfInlineLevelElementTag tag)
```

#### Parameters

`tag` [PdfInlineLevelElementTag](./pdfsharp.universalaccessibility.pdfinlinelevelelementtag)<br>
The structure type to be created.

### **BeginInlineLevelElement(String)**

Starts an inline-level element.

```csharp
public void BeginInlineLevelElement(string tag)
```

#### Parameters

`tag` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **BeginElement(PdfIllustrationElementTag, String, XRect)**

Starts an illustration element.

```csharp
public void BeginElement(PdfIllustrationElementTag tag, string altText, XRect boundingBox)
```

#### Parameters

`tag` [PdfIllustrationElementTag](./pdfsharp.universalaccessibility.pdfillustrationelementtag)<br>
The structure type to be created.

`altText` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The alternative text for this illustration.

`boundingBox` [XRect](./pdfsharp.drawing.xrect)<br>
The element's bounding box.

### **BeginIllustrationElement(String, String, XRect)**

Starts an illustration element.

```csharp
public void BeginIllustrationElement(string tag, string altText, XRect boundingRect)
```

#### Parameters

`tag` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`altText` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

`boundingRect` [XRect](./pdfsharp.drawing.xrect)<br>

### **BeginArtifact()**

Starts an artifact.

```csharp
public void BeginArtifact()
```

### **BeginElement(PdfLinkAnnotation, String)**

Starts a link element.

```csharp
public void BeginElement(PdfLinkAnnotation linkAnnotation, string altText)
```

#### Parameters

`linkAnnotation` [PdfLinkAnnotation](./pdfsharp.pdf.annotations.pdflinkannotation)<br>
The PdfLinkAnnotation this link is using.

`altText` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The alternative text for this link.

### **End()**

Ends the current element.

```csharp
public void End()
```

### **SetAltText(String)**

Sets the content of the "/Alt" (alternative text) key. Used e. g. for illustrations.

```csharp
public void SetAltText(string altText)
```

#### Parameters

`altText` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The alternative text.

### **SetExpandedText(String)**

Sets the content of the "/E" (expanded text) key. Used for abbreviations.

```csharp
public void SetExpandedText(string expandedText)
```

#### Parameters

`expandedText` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The expanded text representation of the abbreviation.

### **SetLanguage(String)**

Sets the content of the "/Lang" (language) key. The chosen language is used for all children of the current structure element until a child has a new language defined.

```csharp
public void SetLanguage(string language)
```

#### Parameters

`language` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The language of the structure element and its children.

### **SetRowSpan(Int32)**

Sets the rowspan of a table cell.

```csharp
public void SetRowSpan(int rowSpan)
```

#### Parameters

`rowSpan` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The number of spanning cells.

### **SetColSpan(Int32)**

Sets the colspan of a table cell.

```csharp
public void SetColSpan(int colSpan)
```

#### Parameters

`colSpan` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The number of spanning cells.

### **BeginMarkedContentInternal(StructureElementItem)**

Starts the marked content. Used for every marked content with an MCID.

```csharp
internal void BeginMarkedContentInternal(StructureElementItem steItem)
```

#### Parameters

`steItem` [StructureElementItem](./pdfsharp.universalaccessibility.structureelementitem)<br>
The StructureElementItem to create a marked content for.

### **EndMarkedContentsWithId()**

Ends all open marked contents that have a marked content with id.

```csharp
public void EndMarkedContentsWithId()
```

### **OnAddPage()**

Called when AddPage was issued.

```csharp
internal void OnAddPage()
```

### **OnDrawString()**

Called when DrawString was issued.

```csharp
internal void OnDrawString()
```

### **OnDraw()**

Called when e.g. DrawEllipse was issued.

```csharp
internal void OnDraw()
```
