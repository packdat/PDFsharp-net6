# FilterParms

Namespace: PdfSharp.Pdf.Filters

Reserved for future extension.

```csharp
public class FilterParms
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [FilterParms](./pdfsharp.pdf.filters.filterparms)

## Properties

### **DecodeParms**

Gets the decoding-parameters for a filter. May be null.

```csharp
public PdfDictionary DecodeParms { get; private set; }
```

#### Property Value

[PdfDictionary](./pdfsharp.pdf.pdfdictionary)<br>

## Constructors

### **FilterParms(PdfDictionary)**

Initializes a new instance of the [FilterParms](./pdfsharp.pdf.filters.filterparms) class.

```csharp
public FilterParms(PdfDictionary decodeParms)
```

#### Parameters

`decodeParms` [PdfDictionary](./pdfsharp.pdf.pdfdictionary)<br>
The decode parms dictionary.
