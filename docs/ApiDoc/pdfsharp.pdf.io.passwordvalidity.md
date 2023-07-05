# PasswordValidity

Namespace: PdfSharp.Pdf.IO

Determines the type of the password.

```csharp
public enum PasswordValidity
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ValueType](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype) → [Enum](https://docs.microsoft.com/en-us/dotnet/api/system.enum) → [PasswordValidity](./pdfsharp.pdf.io.passwordvalidity)<br>
Implements [IComparable](https://docs.microsoft.com/en-us/dotnet/api/system.icomparable), [IFormattable](https://docs.microsoft.com/en-us/dotnet/api/system.iformattable), [IConvertible](https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible)

## Fields

| Name | Value | Description |
| --- | --: | --- |
| Invalid | 0 | Password is neither user nor owner password. |
| UserPassword | 1 | Password is user password. |
| OwnerPassword | 2 | Password is owner password. |
