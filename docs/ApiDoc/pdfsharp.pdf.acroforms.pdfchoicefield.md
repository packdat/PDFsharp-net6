# PdfChoiceField

Namespace: PdfSharp.Pdf.AcroForms

Represents the base class for all choice field dictionaries.

```csharp
public abstract class PdfChoiceField : PdfAcroField, System.ICloneable, System.Collections.Generic.IEnumerable`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib, Version=6.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e],[PdfSharp.Pdf.PdfItem, PdfSharp, Version=0.1.2.0, Culture=neutral, PublicKeyToken=null]], System.Private.CoreLib, Version=6.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e]], System.Collections.IEnumerable
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [PdfItem](./pdfsharp.pdf.pdfitem) → [PdfObject](./pdfsharp.pdf.pdfobject) → [PdfDictionary](./pdfsharp.pdf.pdfdictionary) → [PdfAcroField](./pdfsharp.pdf.acroforms.pdfacrofield) → [PdfChoiceField](./pdfsharp.pdf.acroforms.pdfchoicefield)<br>
Implements [ICloneable](https://docs.microsoft.com/en-us/dotnet/api/system.icloneable), [IEnumerable&lt;KeyValuePair&lt;String, PdfItem&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1), [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.ienumerable)

## Properties

### **Value**

Gets or sets the Value for the Field.
 For fields supporting multiple values (e.g. ListBox) use [PdfListBoxField.SelectedIndices](./pdfsharp.pdf.acroforms.pdflistboxfield#selectedindices) instead

```csharp
public PdfItem Value { get; set; }
```

#### Property Value

[PdfItem](./pdfsharp.pdf.pdfitem)<br>

### **DefaultValue**

Gets or sets the Default value for the field

```csharp
public PdfItem DefaultValue { get; set; }
```

#### Property Value

[PdfItem](./pdfsharp.pdf.pdfitem)<br>

### **Options**

Gets or sets the List of options (entries) available for selection.
 This is the list of values shown in the UI.

```csharp
public ICollection<string> Options { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **Values**

Gets the list of values for this Field.<br>
 May or may not be equal to [PdfChoiceField.Options](./pdfsharp.pdf.acroforms.pdfchoicefield#options) but has always the same amount of items.

```csharp
public ICollection<string> Values { get; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **Name**

Gets the name of this field.

```csharp
public string Name { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **AlternateName**

Gets the alternative Name of the Field (/TU)

```csharp
public string AlternateName { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **MappingName**

Gets the mapping Name of the Field (/TM)

```csharp
public string MappingName { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **FullyQualifiedName**

Gets the fully qualified name of this field, that is: "parent-name.field-name"

If the field has no parent, this is equal to [PdfAcroField.Name](./pdfsharp.pdf.acroforms.pdfacrofield#name)

```csharp
public string FullyQualifiedName { get; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Parent**

Gets the Parent of this field or null, if the field has no parent

```csharp
public PdfAcroField Parent { get; internal set; }
```

#### Property Value

[PdfAcroField](./pdfsharp.pdf.acroforms.pdfacrofield)<br>

### **Flags**

Gets the field flags of this instance.

```csharp
public PdfAcroFieldFlags Flags { get; }
```

#### Property Value

[PdfAcroFieldFlags](./pdfsharp.pdf.acroforms.pdfacrofieldflags)<br>

### **Font**

Gets or sets the font used to draw the text of the field.

```csharp
public XFont Font { get; set; }
```

#### Property Value

[XFont](./pdfsharp.drawing.xfont)<br>

### **DeterminedFontSize**

Gets the font size that was obtained by analyzing the Fields' content-stream.

```csharp
public double DeterminedFontSize { get; internal set; }
```

#### Property Value

[Double](https://docs.microsoft.com/en-us/dotnet/api/system.double)<br>

### **ForeColor**

Gets or sets the foreground color of the field.

```csharp
public XColor ForeColor { get; set; }
```

#### Property Value

[XColor](./pdfsharp.drawing.xcolor)<br>

### **TextAlign**

Gets or sets the alignment for the text of this field.

```csharp
public TextAlignment TextAlign { get; set; }
```

#### Property Value

[TextAlignment](./pdfsharp.pdf.acroforms.textalignment)<br>

### **ReadOnly**

Gets or sets a value indicating whether the field is read only.

```csharp
public bool ReadOnly { get; set; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **Item**

```csharp
public PdfAcroField Item { get; }
```

#### Property Value

[PdfAcroField](./pdfsharp.pdf.acroforms.pdfacrofield)<br>

### **HasKids**

Indicates whether the field has child fields and/or annotations.

```csharp
public bool HasKids { get; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **HasChildFields**

Indicates whether the field has child fields.

```csharp
public bool HasChildFields { get; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **DescendantNames**

#### Caution

Use GetDescendantNames

---

Gets the names of all descendants of this field.

```csharp
public String[] DescendantNames { get; }
```

#### Property Value

[String[]](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Fields**

Gets the collection of fields within this field.

```csharp
public PdfAcroFieldCollection Fields { get; }
```

#### Property Value

[PdfAcroFieldCollection](./pdfsharp.pdf.acroforms.pdfacrofield.pdfacrofieldcollection)<br>

### **Annotations**

Gets the annotations for this field.
 The elements in this list are of type [PdfWidgetAnnotation](./pdfsharp.pdf.annotations.pdfwidgetannotation).

```csharp
public PdfAnnotationArray Annotations { get; }
```

#### Property Value

[PdfAnnotationArray](./pdfsharp.pdf.acroforms.pdfacrofield.pdfannotationarray)<br>

### **Elements**

Gets the dictionary containing the elements of this dictionary.

```csharp
public DictionaryElements Elements { get; }
```

#### Property Value

[DictionaryElements](./pdfsharp.pdf.pdfdictionary.dictionaryelements)<br>

### **Stream**

Gets or sets the PDF stream belonging to this dictionary. Returns null if the dictionary has
 no stream. To create the stream, call the CreateStream function.

```csharp
public PdfStream Stream { get; set; }
```

#### Property Value

[PdfStream](./pdfsharp.pdf.pdfdictionary.pdfstream)<br>

### **Owner**

Gets the PdfDocument this object belongs to.

```csharp
public PdfDocument Owner { get; }
```

#### Property Value

[PdfDocument](./pdfsharp.pdf.pdfdocument)<br>

### **IsIndirect**

Indicates whether the object is an indirect object.

```csharp
public bool IsIndirect { get; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **Internals**

Gets the PdfInternals object of this document, that grants access to some internal structures
 which are not part of the public interface of PdfDocument.

```csharp
public PdfObjectInternals Internals { get; }
```

#### Property Value

[PdfObjectInternals](./pdfsharp.pdf.advanced.pdfobjectinternals)<br>

### **Reference**

Gets the indirect reference of this object. If the value is null, this object is a direct object.

```csharp
public PdfReference Reference { get; internal set; }
```

#### Property Value

[PdfReference](./pdfsharp.pdf.advanced.pdfreference)<br>

### **ReferenceNotNull**

Gets the indirect reference of this object. Throws if it is null.

```csharp
public PdfReference ReferenceNotNull { get; }
```

#### Property Value

[PdfReference](./pdfsharp.pdf.advanced.pdfreference)<br>

#### Exceptions

[InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/system.invalidoperationexception)<br>
The indirect reference must be not null here.

## Methods

### **IndexInOptArray(String, Boolean)**

Gets the index of the specified string in the /Opt array or -1, if no such string exists.

```csharp
protected int IndexInOptArray(string value, bool useExportValue)
```

#### Parameters

`value` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
Value, for which the index should be retrieved

`useExportValue` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
true if value is the export value, false if value is the text shown in the UI

#### Returns

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **ValueInOptArray(Int32, Boolean)**

Gets the value or the display text from the index in the /Opt array.

```csharp
internal string ValueInOptArray(int index, bool useExportValue)
```

#### Parameters

`index` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
Index of the value that should be retrieved

`useExportValue` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
true to get the export value, false to get the text shown in the UI

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
