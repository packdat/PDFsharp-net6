# PdfDictionary

Namespace: PdfSharp.Pdf

Represents a PDF dictionary object.

```csharp
public class PdfDictionary : PdfObject, System.ICloneable, System.Collections.Generic.IEnumerable`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib, Version=6.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e],[PdfSharp.Pdf.PdfItem, PdfSharp, Version=0.1.3.0, Culture=neutral, PublicKeyToken=null]], System.Private.CoreLib, Version=6.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e]], System.Collections.IEnumerable
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [PdfItem](./pdfsharp.pdf.pdfitem) → [PdfObject](./pdfsharp.pdf.pdfobject) → [PdfDictionary](./pdfsharp.pdf.pdfdictionary)<br>
Implements [ICloneable](https://docs.microsoft.com/en-us/dotnet/api/system.icloneable), [IEnumerable&lt;KeyValuePair&lt;String, PdfItem&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1), [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.ienumerable)

## Properties

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

## Constructors

### **PdfDictionary()**

Initializes a new instance of the [PdfDictionary](./pdfsharp.pdf.pdfdictionary) class.

```csharp
public PdfDictionary()
```

### **PdfDictionary(PdfDocument)**

Initializes a new instance of the [PdfDictionary](./pdfsharp.pdf.pdfdictionary) class.

```csharp
public PdfDictionary(PdfDocument document)
```

#### Parameters

`document` [PdfDocument](./pdfsharp.pdf.pdfdocument)<br>
The document.

## Methods

### **Clone()**

Creates a copy of this dictionary. Direct values are deep copied. Indirect references are not
 modified.

```csharp
public PdfDictionary Clone()
```

#### Returns

[PdfDictionary](./pdfsharp.pdf.pdfdictionary)<br>

### **Copy()**

This function is useful for importing objects from external documents. The returned object is not
 yet complete. irefs refer to external objects and directed objects are cloned but their document
 property is null. A cloned dictionary or array needs a 'fix-up' to be a valid object.

```csharp
protected object Copy()
```

#### Returns

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)<br>

### **GetEnumerator()**

Returns an enumerator that iterates through the dictionary elements.

```csharp
public IEnumerator<KeyValuePair<string, PdfItem>> GetEnumerator()
```

#### Returns

[IEnumerator&lt;KeyValuePair&lt;String, PdfItem&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerator-1)<br>

### **ToString()**

Returns a string with the content of this object in a readable form. Useful for debugging purposes only.

```csharp
public string ToString()
```

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **WriteObject(PdfWriter)**

```csharp
internal void WriteObject(PdfWriter writer)
```

#### Parameters

`writer` [PdfWriter](./pdfsharp.pdf.io.pdfwriter)<br>

### **WriteDictionaryElement(PdfWriter, PdfName)**

Writes a key/value pair of this dictionary. This function is intended to be overridden
 in derived classes.

```csharp
internal void WriteDictionaryElement(PdfWriter writer, PdfName key)
```

#### Parameters

`writer` [PdfWriter](./pdfsharp.pdf.io.pdfwriter)<br>

`key` [PdfName](./pdfsharp.pdf.pdfname)<br>

### **WriteDictionaryStream(PdfWriter)**

Writes the stream of this dictionary. This function is intended to be overridden
 in a derived class.

```csharp
internal void WriteDictionaryStream(PdfWriter writer)
```

#### Parameters

`writer` [PdfWriter](./pdfsharp.pdf.io.pdfwriter)<br>

### **CreateStream(Byte[])**

Creates the stream of this dictionary and initializes it with the specified byte array.
 The function must not be called if the dictionary already has a stream.

```csharp
public PdfStream CreateStream(Byte[] value)
```

#### Parameters

`value` [Byte[]](https://docs.microsoft.com/en-us/dotnet/api/system.byte)<br>

#### Returns

[PdfStream](./pdfsharp.pdf.pdfdictionary.pdfstream)<br>
