# FeatureNotAvailableAction

Namespace: PdfSharp

Defines the action to be taken if a requested feature is not available
 in the current build.

```csharp
public enum FeatureNotAvailableAction
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ValueType](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype) → [Enum](https://docs.microsoft.com/en-us/dotnet/api/system.enum) → [FeatureNotAvailableAction](./pdfsharp.featurenotavailableaction)<br>
Implements [IComparable](https://docs.microsoft.com/en-us/dotnet/api/system.icomparable), [IFormattable](https://docs.microsoft.com/en-us/dotnet/api/system.iformattable), [IConvertible](https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible)

## Fields

| Name | Value | Description |
| --- | --: | --- |
| DoNothing | 0 | Do nothing. |
| LogInformation | 2 | The log warning. |
| LogWarning | 3 | The log warning. |
| LogError | 4 | The log error. |
| FailWithException | 1 | The fail with exception. |
