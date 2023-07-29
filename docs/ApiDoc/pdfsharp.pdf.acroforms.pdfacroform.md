# PdfAcroForm

Namespace: PdfSharp.Pdf.AcroForms

Represents an interactive form (or AcroForm), a collection of fields for
 gathering information interactively from the user.

```csharp
public sealed class PdfAcroForm : PdfSharp.Pdf.PdfDictionary, System.ICloneable, System.Collections.Generic.IEnumerable`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib, Version=6.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e],[PdfSharp.Pdf.PdfItem, PdfSharp, Version=0.1.3.0, Culture=neutral, PublicKeyToken=null]], System.Private.CoreLib, Version=6.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e]], System.Collections.IEnumerable
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [PdfItem](./pdfsharp.pdf.pdfitem) → [PdfObject](./pdfsharp.pdf.pdfobject) → [PdfDictionary](./pdfsharp.pdf.pdfdictionary) → [PdfAcroForm](./pdfsharp.pdf.acroforms.pdfacroform)<br>
Implements [ICloneable](https://docs.microsoft.com/en-us/dotnet/api/system.icloneable), [IEnumerable&lt;KeyValuePair&lt;String, PdfItem&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1), [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.ienumerable)

## Properties

### **Fields**

Gets the fields collection (i.e. the root fields) of this of this AcroForm.<br>
 To retrieve all fields (including child-fields), use [PdfAcroForm.GetAllFields()](./pdfsharp.pdf.acroforms.pdfacroform#getallfields)

```csharp
public PdfAcroFieldCollection Fields { get; }
```

#### Property Value

[PdfAcroFieldCollection](./pdfsharp.pdf.acroforms.pdfacrofield.pdfacrofieldcollection)<br>

### **FieldRenderer**

Gets the [PdfAcroFieldRenderer](./pdfsharp.pdf.acroforms.rendering.pdfacrofieldrenderer) used to render [PdfAcroField](./pdfsharp.pdf.acroforms.pdfacrofield)s

```csharp
public PdfAcroFieldRenderer FieldRenderer { get; }
```

#### Property Value

[PdfAcroFieldRenderer](./pdfsharp.pdf.acroforms.rendering.pdfacrofieldrenderer)<br>

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

### **GetAllFields()**

Gets the flattened field-hierarchy of this AcroForm

```csharp
public IEnumerable<PdfAcroField> GetAllFields()
```

#### Returns

[IEnumerable&lt;PdfAcroField&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)<br>

### **GetOrCreateResources()**

Gets the [PdfResources](./pdfsharp.pdf.advanced.pdfresources) of this [PdfAcroForm](./pdfsharp.pdf.acroforms.pdfacroform) or creates a new one if none exist

```csharp
internal PdfResources GetOrCreateResources()
```

#### Returns

[PdfResources](./pdfsharp.pdf.advanced.pdfresources)<br>
The [PdfResources](./pdfsharp.pdf.advanced.pdfresources) of this AcroForm

### **PrepareForSave()**

```csharp
internal void PrepareForSave()
```

### **Flatten()**

Flattens the AcroForm by rendering Field-contents directly onto the page

```csharp
internal void Flatten()
```

### **AddTextField(Action&lt;PdfTextField&gt;)**

Adds a new [PdfTextField](./pdfsharp.pdf.acroforms.pdftextfield) to the [PdfAcroForm](./pdfsharp.pdf.acroforms.pdfacroform)

```csharp
public PdfTextField AddTextField(Action<PdfTextField> configure)
```

#### Parameters

`configure` [Action&lt;PdfTextField&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.action-1)<br>
A method that receives the new [PdfTextField](./pdfsharp.pdf.acroforms.pdftextfield) for further customization<br>

#### Returns

[PdfTextField](./pdfsharp.pdf.acroforms.pdftextfield)<br>
The created and configured [PdfTextField](./pdfsharp.pdf.acroforms.pdftextfield)

#### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)<br>

### **AddCheckBoxField(Action&lt;PdfCheckBoxField&gt;)**

Adds a new [PdfCheckBoxField](./pdfsharp.pdf.acroforms.pdfcheckboxfield) to the [PdfAcroForm](./pdfsharp.pdf.acroforms.pdfacroform)

```csharp
public PdfCheckBoxField AddCheckBoxField(Action<PdfCheckBoxField> configure)
```

#### Parameters

`configure` [Action&lt;PdfCheckBoxField&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.action-1)<br>
A method that receives the new [PdfCheckBoxField](./pdfsharp.pdf.acroforms.pdfcheckboxfield) for further customization<br>

#### Returns

[PdfCheckBoxField](./pdfsharp.pdf.acroforms.pdfcheckboxfield)<br>
The created and configured [PdfCheckBoxField](./pdfsharp.pdf.acroforms.pdfcheckboxfield)

#### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)<br>

### **AddRadioButtonField(Action&lt;PdfRadioButtonField&gt;)**

Adds a new [PdfRadioButtonField](./pdfsharp.pdf.acroforms.pdfradiobuttonfield) to the [PdfAcroForm](./pdfsharp.pdf.acroforms.pdfacroform)

```csharp
public PdfRadioButtonField AddRadioButtonField(Action<PdfRadioButtonField> configure)
```

#### Parameters

`configure` [Action&lt;PdfRadioButtonField&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.action-1)<br>
A method that receives the new [PdfRadioButtonField](./pdfsharp.pdf.acroforms.pdfradiobuttonfield) for further customization<br>

#### Returns

[PdfRadioButtonField](./pdfsharp.pdf.acroforms.pdfradiobuttonfield)<br>
The created and configured [PdfRadioButtonField](./pdfsharp.pdf.acroforms.pdfradiobuttonfield)

#### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)<br>

### **AddComboBoxField(Action&lt;PdfComboBoxField&gt;)**

Adds a new [PdfComboBoxField](./pdfsharp.pdf.acroforms.pdfcomboboxfield) to the [PdfAcroForm](./pdfsharp.pdf.acroforms.pdfacroform)

```csharp
public PdfComboBoxField AddComboBoxField(Action<PdfComboBoxField> configure)
```

#### Parameters

`configure` [Action&lt;PdfComboBoxField&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.action-1)<br>
A method that receives the new [PdfComboBoxField](./pdfsharp.pdf.acroforms.pdfcomboboxfield) for further customization<br>

#### Returns

[PdfComboBoxField](./pdfsharp.pdf.acroforms.pdfcomboboxfield)<br>
The created and configured [PdfComboBoxField](./pdfsharp.pdf.acroforms.pdfcomboboxfield)

#### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)<br>

### **AddListBoxField(Action&lt;PdfListBoxField&gt;)**

Adds a new [PdfListBoxField](./pdfsharp.pdf.acroforms.pdflistboxfield) to the [PdfAcroForm](./pdfsharp.pdf.acroforms.pdfacroform)

```csharp
public PdfListBoxField AddListBoxField(Action<PdfListBoxField> configure)
```

#### Parameters

`configure` [Action&lt;PdfListBoxField&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.action-1)<br>
A method that receives the new [PdfListBoxField](./pdfsharp.pdf.acroforms.pdflistboxfield) for further customization<br>

#### Returns

[PdfListBoxField](./pdfsharp.pdf.acroforms.pdflistboxfield)<br>
The created and configured [PdfListBoxField](./pdfsharp.pdf.acroforms.pdflistboxfield)

#### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)<br>

### **AddPushButtonField(Action&lt;PdfPushButtonField&gt;)**

Adds a new [PdfPushButtonField](./pdfsharp.pdf.acroforms.pdfpushbuttonfield) to the [PdfAcroForm](./pdfsharp.pdf.acroforms.pdfacroform)

```csharp
public PdfPushButtonField AddPushButtonField(Action<PdfPushButtonField> configure)
```

#### Parameters

`configure` [Action&lt;PdfPushButtonField&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.action-1)<br>
A method that receives the new [PdfPushButtonField](./pdfsharp.pdf.acroforms.pdfpushbuttonfield) for further customization<br>

#### Returns

[PdfPushButtonField](./pdfsharp.pdf.acroforms.pdfpushbuttonfield)<br>
The created and configured [PdfPushButtonField](./pdfsharp.pdf.acroforms.pdfpushbuttonfield)

#### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)<br>

### **AddSignatureField(Action&lt;PdfSignatureField&gt;)**

Adds a new [PdfSignatureField](./pdfsharp.pdf.acroforms.pdfsignaturefield) to the [PdfAcroForm](./pdfsharp.pdf.acroforms.pdfacroform)

```csharp
public PdfSignatureField AddSignatureField(Action<PdfSignatureField> configure)
```

#### Parameters

`configure` [Action&lt;PdfSignatureField&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.action-1)<br>
A method that receives the new [PdfSignatureField](./pdfsharp.pdf.acroforms.pdfsignaturefield) for further customization<br>

#### Returns

[PdfSignatureField](./pdfsharp.pdf.acroforms.pdfsignaturefield)<br>
The created and configured [PdfSignatureField](./pdfsharp.pdf.acroforms.pdfsignaturefield)

#### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)<br>

### **AddGenericField(Action&lt;PdfGenericField&gt;)**

Adds a new [PdfGenericField](./pdfsharp.pdf.acroforms.pdfgenericfield) to the [PdfAcroForm](./pdfsharp.pdf.acroforms.pdfacroform)<br>
 Typically used as a container for other fields

```csharp
public PdfGenericField AddGenericField(Action<PdfGenericField> configure)
```

#### Parameters

`configure` [Action&lt;PdfGenericField&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.action-1)<br>
A method that receives the new [PdfGenericField](./pdfsharp.pdf.acroforms.pdfgenericfield) for further customization<br>

#### Returns

[PdfGenericField](./pdfsharp.pdf.acroforms.pdfgenericfield)<br>
The created and configured [PdfGenericField](./pdfsharp.pdf.acroforms.pdfgenericfield)

#### Exceptions

[ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception)<br>
