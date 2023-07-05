# PdfSecuritySettings

Namespace: PdfSharp.Pdf.Security

Encapsulates access to the security settings of a PDF document.

```csharp
public sealed class PdfSecuritySettings
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [PdfSecuritySettings](./pdfsharp.pdf.security.pdfsecuritysettings)

## Properties

### **HasOwnerPermissions**

Indicates whether the granted access to the document is 'owner permission'. Returns true if the document 
 is unprotected or was opened with the owner password. Returns false if the document was opened with the
 user password.

```csharp
public bool HasOwnerPermissions { internal get; set; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **UserPassword**

Sets the user password of the document. Setting a password automatically sets the
 PdfDocumentSecurityLevel to PdfDocumentSecurityLevel.Encrypted128Bit if its current
 value is PdfDocumentSecurityLevel.None.

```csharp
public string UserPassword { set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **OwnerPassword**

Sets the owner password of the document. Setting a password automatically sets the
 PdfDocumentSecurityLevel to PdfDocumentSecurityLevel.Encrypted128Bit if its current
 value is PdfDocumentSecurityLevel.None.

```csharp
public string OwnerPassword { set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **PermitPrint**

Permits printing the document. Should be used in conjunction with PermitFullQualityPrint.

```csharp
public bool PermitPrint { get; set; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **PermitModifyDocument**

Permits modifying the document.

```csharp
public bool PermitModifyDocument { get; set; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **PermitExtractContent**

Permits content copying or extraction.

```csharp
public bool PermitExtractContent { get; set; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **PermitAnnotations**

Permits commenting the document.

```csharp
public bool PermitAnnotations { get; set; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **PermitFormsFill**

Permits filling of form fields.

```csharp
public bool PermitFormsFill { get; set; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **PermitAssembleDocument**

Permits to insert, rotate, or delete pages and create bookmarks or thumbnail images even if
 PermitModifyDocument is not set.

```csharp
public bool PermitAssembleDocument { get; set; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **PermitFullQualityPrint**

Permits to print in high quality. insert, rotate, or delete pages and create bookmarks or thumbnail images
 even if PermitModifyDocument is not set.

```csharp
public bool PermitFullQualityPrint { get; set; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

## Methods

### **CanSave(String&)**

Determines whether the document can be saved.

```csharp
internal bool CanSave(String& message)
```

#### Parameters

`message` [String&](https://docs.microsoft.com/en-us/dotnet/api/system.string&)<br>

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **HasPermissionsOfRevision3OrHigherSetTo0(UInt32)**

Returns true if there are permissions set to zero, that were introduced with security handler revision 3.

```csharp
public static bool HasPermissionsOfRevision3OrHigherSetTo0(uint permission)
```

#### Parameters

`permission` [UInt32](https://docs.microsoft.com/en-us/dotnet/api/system.uint32)<br>
The permission uint value containing the PdfUserAccessPermission flags.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
