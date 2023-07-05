# PageEventType

Namespace: PdfSharp.Events

The event type of a PageEvent.

```csharp
public enum PageEventType
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ValueType](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype) → [Enum](https://docs.microsoft.com/en-us/dotnet/api/system.enum) → [PageEventType](./pdfsharp.events.pageeventtype)<br>
Implements [IComparable](https://docs.microsoft.com/en-us/dotnet/api/system.icomparable), [IFormattable](https://docs.microsoft.com/en-us/dotnet/api/system.iformattable), [IConvertible](https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible)

## Fields

| Name | Value | Description |
| --- | --: | --- |
| Created | 0 | A new page was created. |
| Moved | 1 | A page was moved. |
| Imported | 2 | A page was imported from another document. |
| Removed | 3 | A page was removed. |
