# PageGraphicsActionType

Namespace: PdfSharp.Events

The action type of a PageGraphicsEvent.

```csharp
public enum PageGraphicsActionType
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ValueType](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype) → [Enum](https://docs.microsoft.com/en-us/dotnet/api/system.enum) → [PageGraphicsActionType](./pdfsharp.events.pagegraphicsactiontype)<br>
Implements [IComparable](https://docs.microsoft.com/en-us/dotnet/api/system.icomparable), [IFormattable](https://docs.microsoft.com/en-us/dotnet/api/system.iformattable), [IConvertible](https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible)

## Fields

| Name | Value | Description |
| --- | --: | --- |
| GraphicsCreated | 1 | The XGraphics object for the page was created. |
| DrawString | 2 | DrawString() was called on the page's XGraphics object. |
| Draw | 3 | Another method drawing content was called on the page's XGraphics object. |
