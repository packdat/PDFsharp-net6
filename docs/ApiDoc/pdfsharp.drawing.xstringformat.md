# XStringFormat

Namespace: PdfSharp.Drawing

Represents the text layout information.

```csharp
public class XStringFormat
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [XStringFormat](./pdfsharp.drawing.xstringformat)

## Properties

### **Alignment**

Gets or sets horizontal text alignment information.

```csharp
public XStringAlignment Alignment { get; set; }
```

#### Property Value

[XStringAlignment](./pdfsharp.drawing.xstringalignment)<br>

### **LineAlignment**

Gets or sets the line alignment.

```csharp
public XLineAlignment LineAlignment { get; set; }
```

#### Property Value

[XLineAlignment](./pdfsharp.drawing.xlinealignment)<br>

### **Default**

#### Caution

Use XStringFormats.Default. (Note plural in class name.)

---

Gets a new XStringFormat object that aligns the text left on the base line.

```csharp
public static XStringFormat Default { get; }
```

#### Property Value

[XStringFormat](./pdfsharp.drawing.xstringformat)<br>

### **TopLeft**

#### Caution

Use XStringFormats.Default. (Note plural in class name.)

---

Gets a new XStringFormat object that aligns the text top left of the layout rectangle.

```csharp
public static XStringFormat TopLeft { get; }
```

#### Property Value

[XStringFormat](./pdfsharp.drawing.xstringformat)<br>

### **Center**

#### Caution

Use XStringFormats.Center. (Note plural in class name.)

---

Gets a new XStringFormat object that centers the text in the middle of the layout rectangle.

```csharp
public static XStringFormat Center { get; }
```

#### Property Value

[XStringFormat](./pdfsharp.drawing.xstringformat)<br>

### **TopCenter**

#### Caution

Use XStringFormats.TopCenter. (Note plural in class name.)

---

Gets a new XStringFormat object that centers the text at the top of the layout rectangle.

```csharp
public static XStringFormat TopCenter { get; }
```

#### Property Value

[XStringFormat](./pdfsharp.drawing.xstringformat)<br>

### **BottomCenter**

#### Caution

Use XStringFormats.BottomCenter. (Note plural in class name.)

---

Gets a new XStringFormat object that centers the text at the bottom of the layout rectangle.

```csharp
public static XStringFormat BottomCenter { get; }
```

#### Property Value

[XStringFormat](./pdfsharp.drawing.xstringformat)<br>

## Constructors

### **XStringFormat()**

Initializes a new instance of the [XStringFormat](./pdfsharp.drawing.xstringformat) class.

```csharp
public XStringFormat()
```
