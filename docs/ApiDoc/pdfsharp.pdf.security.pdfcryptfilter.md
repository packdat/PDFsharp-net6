# PdfCryptFilter

Namespace: PdfSharp.Pdf.Security

Represents a crypt filter dictionary as written into the CF dictionary of a security handler (PDFCryptFilters).

```csharp
public class PdfCryptFilter : CryptFilterBase, System.ICloneable, System.Collections.Generic.IEnumerable`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib, Version=6.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e],[PdfSharp.Pdf.PdfItem, PdfSharp, Version=0.1.3.0, Culture=neutral, PublicKeyToken=null]], System.Private.CoreLib, Version=6.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e]], System.Collections.IEnumerable
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [PdfItem](./pdfsharp.pdf.pdfitem) → [PdfObject](./pdfsharp.pdf.pdfobject) → [PdfDictionary](./pdfsharp.pdf.pdfdictionary) → [CryptFilterBase](./pdfsharp.pdf.security.cryptfilterbase) → [PdfCryptFilter](./pdfsharp.pdf.security.pdfcryptfilter)<br>
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

### **PdfCryptFilter(PdfStandardSecurityHandler)**

Initializes a new instance of the [PdfCryptFilter](./pdfsharp.pdf.security.pdfcryptfilter) class.

```csharp
public PdfCryptFilter(PdfStandardSecurityHandler parentStandardSecurityHandler)
```

#### Parameters

`parentStandardSecurityHandler` [PdfStandardSecurityHandler](./pdfsharp.pdf.security.pdfstandardsecurityhandler)<br>
The parent standard security handler.

## Methods

### **Initialize(PdfStandardSecurityHandler)**

Initializes _parentStandardSecurityHandler to do the correct interpretation of the length key.

```csharp
public void Initialize(PdfStandardSecurityHandler parentStandardSecurityHandler)
```

#### Parameters

`parentStandardSecurityHandler` [PdfStandardSecurityHandler](./pdfsharp.pdf.security.pdfstandardsecurityhandler)<br>

### **SetEncryptionToNone()**

The encryption shall be handled by the security handler.

```csharp
public void SetEncryptionToNone()
```

### **SetEncryptionToRC4ForV4(Int32)**

Encrypt with RC4 and the given file encryption key length, using the algorithms of encryption V4 (PDF 1.5).
 For encryption V4 the file encryption key length shall be 128 bits.

```csharp
public void SetEncryptionToRC4ForV4(int length)
```

#### Parameters

`length` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The file encryption key length - a multiple of 8 from 40 to 256 bit.

### **SetEncryptionToAESForV4()**

Encrypt with AES and a file encryption key length of 128 bits, using the algorithms of encryption V4 (PDF 1.6).

```csharp
public void SetEncryptionToAESForV4()
```

### **SetEncryptionToAESForV5()**

Encrypt with AES and a file encryption key length of 256 bits, using the algorithms of encryption V5 (PDF 2.0).

```csharp
public void SetEncryptionToAESForV5()
```

### **SetAuthEventForEmbeddedFiles()**

Sets the AuthEvent Key to /EFOpen, in order authenticate embedded file streams when accessing the embedded file.

```csharp
public void SetAuthEventForEmbeddedFiles()
```

### **PrepareForProcessing()**

Does all necessary initialization for reading and decrypting or encrypting and writing the document with this crypt filter.

```csharp
internal void PrepareForProcessing()
```

### **EncryptForEnteredObject(Byte[]&)**

Encrypts the given bytes.

```csharp
internal bool EncryptForEnteredObject(Byte[]& bytes)
```

#### Parameters

`bytes` [Byte[]&](https://docs.microsoft.com/en-us/dotnet/api/system.byte&)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
True, if the crypt filter encrypted the bytes, or false, if the security handler shall do it.

### **DecryptForEnteredObject(Byte[]&)**

Decrypts the given bytes.

```csharp
internal bool DecryptForEnteredObject(Byte[]& bytes)
```

#### Parameters

`bytes` [Byte[]&](https://docs.microsoft.com/en-us/dotnet/api/system.byte&)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
True, if the crypt filter decrypted the bytes, or false, if the security handler shall do it.
