# PdfStandardSecurityHandler

Namespace: PdfSharp.Pdf.Security

Represents the standard PDF security handler.

```csharp
public sealed class PdfStandardSecurityHandler : PdfSecurityHandler, System.ICloneable, System.Collections.Generic.IEnumerable`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib, Version=6.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e],[PdfSharp.Pdf.PdfItem, PdfSharp, Version=0.1.2.0, Culture=neutral, PublicKeyToken=null]], System.Private.CoreLib, Version=6.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e]], System.Collections.IEnumerable
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [PdfItem](./pdfsharp.pdf.pdfitem) → [PdfObject](./pdfsharp.pdf.pdfobject) → [PdfDictionary](./pdfsharp.pdf.pdfdictionary) → [PdfSecurityHandler](./pdfsharp.pdf.security.pdfsecurityhandler) → [PdfStandardSecurityHandler](./pdfsharp.pdf.security.pdfstandardsecurityhandler)<br>
Implements [ICloneable](https://docs.microsoft.com/en-us/dotnet/api/system.icloneable), [IEnumerable&lt;KeyValuePair&lt;String, PdfItem&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1), [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.ienumerable)

## Properties

### **UserPassword**

Sets the user password of the document.

```csharp
public string UserPassword { internal get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **OwnerPassword**

Sets the owner password of the document.

```csharp
public string OwnerPassword { internal get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

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

### **SetEncryptionToNoneAndResetPasswords()**

Do not encrypt the PDF file. Resets the user and owner password.

```csharp
public void SetEncryptionToNoneAndResetPasswords()
```

### **SetEncryption(DefaultEncryption)**

Set the encryption according to the given parameter.

```csharp
public void SetEncryption(DefaultEncryption encryption)
```

#### Parameters

`encryption` [DefaultEncryption](./pdfsharp.pdf.security.pdfstandardsecurityhandler.defaultencryption)<br>

### **SetEncryptionToV1()**

Encrypt with Version 1 (RC4 and a file encryption key length of 40 bits).

```csharp
public void SetEncryptionToV1()
```

### **SetEncryptionToV2(Int32)**

Encrypt with Version 2 (RC4 and a file encryption key length of more than 40 bits, PDF 1.4).

```csharp
public void SetEncryptionToV2(int length)
```

#### Parameters

`length` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
The file encryption key length - a multiple of 8 from 40 to 128 bit.

### **SetEncryptionToV2With128Bits()**

Encrypt with Version 2 (RC4 and a file encryption key length of more than 40 bits, PDF 1.4) with a file encryption key length of 128 bits.
 This was the default encryption in PDFsharp 1.5.

```csharp
public void SetEncryptionToV2With128Bits()
```

### **SetEncryptionToV4UsingRC4(Boolean)**

Encrypt with Version 4 (RC4 or AES and a file encryption key length of 128 bits using a crypt filter, PDF 1.5) using RC4.

```csharp
public void SetEncryptionToV4UsingRC4(bool encryptMetadata)
```

#### Parameters

`encryptMetadata` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
The document metadata stream shall be encrypted (default: true).

### **SetEncryptionToV4UsingAES(Boolean)**

Encrypt with Version 4 (RC4 or AES and a file encryption key length of 128 bits using a crypt filter, PDF 1.5) using AES (PDF 1.6).

```csharp
public void SetEncryptionToV4UsingAES(bool encryptMetadata)
```

#### Parameters

`encryptMetadata` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
The document metadata stream shall be encrypted (default: true).

### **SetEncryptionToV5(Boolean)**

Encrypt with Version 5 (AES and a file encryption key length of 256 bits using a crypt filter, PDF 2.0).

```csharp
public void SetEncryptionToV5(bool encryptMetadata)
```

#### Parameters

`encryptMetadata` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
The document metadata stream shall be encrypted (default: true).

### **GetIfEncryptionActive()**

Returns this SecurityHandler, if it shall be written to PDF (if an encryption is chosen).

```csharp
internal PdfStandardSecurityHandler GetIfEncryptionActive()
```

#### Returns

[PdfStandardSecurityHandler](./pdfsharp.pdf.security.pdfstandardsecurityhandler)<br>

### **GetCorrectedPermissionsValue()**

Gets the PermissionsValue with some corrections that shall be done for saving.

```csharp
internal uint GetCorrectedPermissionsValue()
```

#### Returns

[UInt32](https://docs.microsoft.com/en-us/dotnet/api/system.uint32)<br>

### **DecryptObjectStream(PdfObjectStream)**

Decrypts an ObjectStream. ObjectStreams have to be decrypted before document decryption to allow the removing of the compression filter.

```csharp
internal void DecryptObjectStream(PdfObjectStream objectStream)
```

#### Parameters

`objectStream` [PdfObjectStream](./pdfsharp.pdf.advanced.pdfobjectstream)<br>

### **DecryptDocument()**

Decrypts the whole document (except ObjectStreams which are decrypted once when read in).

```csharp
internal void DecryptDocument()
```

### **EnterObject(PdfObjectID)**

Has to be called if an indirect PdfObject is entered for encryption/decryption.

```csharp
internal void EnterObject(PdfObjectID id)
```

#### Parameters

`id` [PdfObjectID](./pdfsharp.pdf.pdfobjectid)<br>

### **LeaveObject()**

Should be called if a PdfObject is leaved from encryption/decryption.

```csharp
internal void LeaveObject()
```

### **DecryptObject(PdfObject)**

Decrypts an indirect PdfObject.

```csharp
internal void DecryptObject(PdfObject value)
```

#### Parameters

`value` [PdfObject](./pdfsharp.pdf.pdfobject)<br>

### **EncryptString(Byte[]&)**

Encrypts a string.

```csharp
internal void EncryptString(Byte[]& bytes)
```

#### Parameters

`bytes` [Byte[]&](https://docs.microsoft.com/en-us/dotnet/api/system.byte&)<br>
The byte representation of the string.

### **DecryptString(Byte[]&)**

Decrypts a string.

```csharp
internal void DecryptString(Byte[]& bytes)
```

#### Parameters

`bytes` [Byte[]&](https://docs.microsoft.com/en-us/dotnet/api/system.byte&)<br>
The byte representation of the string.

### **EncryptStream(Byte[]&, PdfDictionary)**

Encrypts a stream.

```csharp
internal void EncryptStream(Byte[]& bytes, PdfDictionary dictionary)
```

#### Parameters

`bytes` [Byte[]&](https://docs.microsoft.com/en-us/dotnet/api/system.byte&)<br>
The byte representation of the stream.

`dictionary` [PdfDictionary](./pdfsharp.pdf.pdfdictionary)<br>
The PdfDictionary holding the stream.

### **DecryptStream(Byte[]&, PdfDictionary)**

Decrypts a stream.

```csharp
internal void DecryptStream(Byte[]& bytes, PdfDictionary dictionary)
```

#### Parameters

`bytes` [Byte[]&](https://docs.microsoft.com/en-us/dotnet/api/system.byte&)<br>
The byte representation of the stream.

`dictionary` [PdfDictionary](./pdfsharp.pdf.pdfdictionary)<br>
The PdfDictionary holding the stream.

### **PrepareForReading()**

Does all necessary initialization for reading and decrypting the document with this security handler.

```csharp
internal void PrepareForReading()
```

### **PrepareForWriting()**

Does all necessary initialization for encrypting and writing the document with this security handler.

```csharp
internal void PrepareForWriting()
```

### **ValidatePassword(String)**

Checks the password.

```csharp
internal PasswordValidity ValidatePassword(string inputPassword)
```

#### Parameters

`inputPassword` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
Password or null if no password is provided.

#### Returns

[PasswordValidity](./pdfsharp.pdf.io.passwordvalidity)<br>

### **WriteObject(PdfWriter)**

```csharp
internal void WriteObject(PdfWriter writer)
```

#### Parameters

`writer` [PdfWriter](./pdfsharp.pdf.io.pdfwriter)<br>

### **GetEncryption()**

Gets the encryption (not nullable). Use this in cases where the encryption must be set.

```csharp
internal PdfEncryptionBase GetEncryption()
```

#### Returns

[PdfEncryptionBase](./pdfsharp.pdf.security.encryption.pdfencryptionbase)<br>

### **RemoveCryptFilters()**

Removes all crypt filters from the document.

```csharp
public void RemoveCryptFilters()
```

### **CreateCryptFilter()**

Creates a crypt filter belonging to standard security handler.

```csharp
public PdfCryptFilter CreateCryptFilter()
```

#### Returns

[PdfCryptFilter](./pdfsharp.pdf.security.pdfcryptfilter)<br>

### **GetOrAddStandardCryptFilter(Boolean)**

Returns the StdCF as it shall be used in encryption version 4 and 5.
 If not yet existing, it is created regarding the asDefaultIfNew parameter, which will set StdCF as default for streams, strings, and embedded file streams.

```csharp
public PdfCryptFilter GetOrAddStandardCryptFilter(bool asDefaultIfNew)
```

#### Parameters

`asDefaultIfNew` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
If true and the crypt filter is newly created, the crypt filter is referred to as default for any strings, and streams in StmF, StrF and EFF keys.

#### Returns

[PdfCryptFilter](./pdfsharp.pdf.security.pdfcryptfilter)<br>

### **AddCryptFilter(String, PdfCryptFilter, Boolean)**

Adds a crypt filter to the document.

```csharp
public void AddCryptFilter(string name, PdfCryptFilter cryptFilter, bool asDefault)
```

#### Parameters

`name` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The name to identify the crypt filter.

`cryptFilter` [PdfCryptFilter](./pdfsharp.pdf.security.pdfcryptfilter)<br>
The crypt filter.

`asDefault` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
If true, the crypt filter is referred to as default for any strings and streams in StmF, StrF and EFF keys.

### **EncryptEmbeddedFilesOnly()**

Encrypts embedded file streams only by setting a crypt filter only in the security handler's EFF key and
 setting the crypt filter's AuthEvent Key to /EFOpen, in order authenticate embedded file streams when accessing the embedded file.

```csharp
public void EncryptEmbeddedFilesOnly()
```

### **SetCryptFilterAsDefault(String)**

Sets the given crypt filter as default for streams, strings, and embedded streams.
 The crypt filter must be manually added crypt filter, "Identity" or null to remove the StmF, StrF and EFF key.

```csharp
public void SetCryptFilterAsDefault(string name)
```

#### Parameters

`name` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **SetCryptFilterAsDefaultForStreams(String)**

Sets the given crypt filter as default for streams.
 The crypt filter must be manually added crypt filter, "Identity" or null to remove the StmF key.

```csharp
public void SetCryptFilterAsDefaultForStreams(string name)
```

#### Parameters

`name` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **SetCryptFilterAsDefaultForStrings(String)**

Sets the given crypt filter as default for strings.
 The crypt filter must be manually added crypt filter, "Identity" or null to remove the StrF key.

```csharp
public void SetCryptFilterAsDefaultForStrings(string name)
```

#### Parameters

`name` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **SetCryptFilterAsDefaultForEmbeddedFileStreams(String)**

Sets the given crypt filter as default for embedded file streams.
 The crypt filter must be manually added crypt filter, "Identity" or null to remove the EFF key.

```csharp
public void SetCryptFilterAsDefaultForEmbeddedFileStreams(string name)
```

#### Parameters

`name` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **ResetCryptFilter(PdfDictionary)**

Resets the explicitly set crypt filter of a dictionary.

```csharp
public void ResetCryptFilter(PdfDictionary dictionary)
```

#### Parameters

`dictionary` [PdfDictionary](./pdfsharp.pdf.pdfdictionary)<br>

### **SetIdentityCryptFilter(PdfDictionary)**

Sets the dictionary's explicitly set crypt filter to the Identity crypt filter.

```csharp
public void SetIdentityCryptFilter(PdfDictionary dictionary)
```

#### Parameters

`dictionary` [PdfDictionary](./pdfsharp.pdf.pdfdictionary)<br>

### **SetCryptFilter(PdfDictionary, String)**

Sets the dictionary's explicitly set crypt filter to the desired crypt filter.

```csharp
public void SetCryptFilter(PdfDictionary dictionary, string cryptFilterName)
```

#### Parameters

`dictionary` [PdfDictionary](./pdfsharp.pdf.pdfdictionary)<br>

`cryptFilterName` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **GetCryptFilter(PdfDictionary)**

Gets the crypt filter that shall be used to decrypt or encrypt the dictionary.

```csharp
public CryptFilterBase GetCryptFilter(PdfDictionary dictionary)
```

#### Parameters

`dictionary` [PdfDictionary](./pdfsharp.pdf.pdfdictionary)<br>

#### Returns

[CryptFilterBase](./pdfsharp.pdf.security.cryptfilterbase)<br>
