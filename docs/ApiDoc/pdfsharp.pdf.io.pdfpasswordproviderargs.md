# PdfPasswordProviderArgs

Namespace: PdfSharp.Pdf.IO

Encapsulates the arguments of the PdfPasswordProvider delegate.

```csharp
public class PdfPasswordProviderArgs
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [PdfPasswordProviderArgs](./pdfsharp.pdf.io.pdfpasswordproviderargs)

## Fields

### **Password**

Sets the password to open the document with.

```csharp
public string Password;
```

### **Abort**

When set to true the PdfReader.Open function returns null indicating that no PdfDocument was created.

```csharp
public bool Abort;
```

## Constructors

### **PdfPasswordProviderArgs()**

```csharp
public PdfPasswordProviderArgs()
```
