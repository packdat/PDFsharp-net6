# PdfRendererExtensions

Namespace: PdfSharp.UniversalAccessibility

Helper class containing methods that are called on XGraphics object's XGraphicsPdfRenderer.

```csharp
public static class PdfRendererExtensions
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [PdfRendererExtensions](./pdfsharp.universalaccessibility.pdfrendererextensions)

## Methods

### **BeginTextMode(XGraphics)**

Activate Text mode for Universal Accessibility.

```csharp
public static void BeginTextMode(XGraphics gfx)
```

#### Parameters

`gfx` [XGraphics](./pdfsharp.drawing.xgraphics)<br>

### **BeginGraphicMode(XGraphics)**

Activate Graphic mode for Universal Accessibility.

```csharp
public static void BeginGraphicMode(XGraphics gfx)
```

#### Parameters

`gfx` [XGraphics](./pdfsharp.drawing.xgraphics)<br>

### **IsInTextMode(XGraphics)**

Determine if renderer is in Text mode or Graphic mode.

```csharp
public static bool IsInTextMode(XGraphics gfx)
```

#### Parameters

`gfx` [XGraphics](./pdfsharp.drawing.xgraphics)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
