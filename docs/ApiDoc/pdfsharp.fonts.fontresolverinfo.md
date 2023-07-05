# FontResolverInfo

Namespace: PdfSharp.Fonts

Describes the physical font that must be used to render a particular XFont.

```csharp
public class FontResolverInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [FontResolverInfo](./pdfsharp.fonts.fontresolverinfo)

## Properties

### **FaceName**

A name that uniquely identifies the font (not the family), e.g. the file name of the font. PDFsharp does not use this
 name internally, but passes it to the GetFont function of the IFontResolver interface to retrieve the font data.

```csharp
public string FaceName { get; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **MustSimulateBold**

Indicates whether bold must be simulated. Bold simulation is not implemented in PDFsharp. BUG really?

```csharp
public bool MustSimulateBold { get; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **MustSimulateItalic**

Indicates whether italic must be simulated.

```csharp
public bool MustSimulateItalic { get; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **StyleSimulations**

Gets the style simulation flags.

```csharp
public XStyleSimulations StyleSimulations { get; }
```

#### Property Value

[XStyleSimulations](./pdfsharp.drawing.xstylesimulations)<br>

## Constructors

### **FontResolverInfo(String)**

Initializes a new instance of the [FontResolverInfo](./pdfsharp.fonts.fontresolverinfo) struct.

```csharp
public FontResolverInfo(string faceName)
```

#### Parameters

`faceName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The name that uniquely identifies the fontface.

### **FontResolverInfo(String, Boolean, Boolean)**

Initializes a new instance of the [FontResolverInfo](./pdfsharp.fonts.fontresolverinfo) struct.

```csharp
public FontResolverInfo(string faceName, bool mustSimulateBold, bool mustSimulateItalic)
```

#### Parameters

`faceName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The name that uniquely identifies the fontface.

`mustSimulateBold` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
Set to `true` to simulate bold when rendered. Not implemented and must be false.

`mustSimulateItalic` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
Set to `true` to simulate italic when rendered.

### **FontResolverInfo(String, XStyleSimulations)**

Initializes a new instance of the [FontResolverInfo](./pdfsharp.fonts.fontresolverinfo) struct.

```csharp
public FontResolverInfo(string faceName, XStyleSimulations styleSimulations)
```

#### Parameters

`faceName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The name that uniquely identifies the fontface.

`styleSimulations` [XStyleSimulations](./pdfsharp.drawing.xstylesimulations)<br>
The style simulation flags.
