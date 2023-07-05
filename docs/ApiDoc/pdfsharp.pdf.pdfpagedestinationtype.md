# PdfPageDestinationType

Namespace: PdfSharp.Pdf

Specifies the type of a page destination in outline items, annotations, or actions.

```csharp
public enum PdfPageDestinationType
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ValueType](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype) → [Enum](https://docs.microsoft.com/en-us/dotnet/api/system.enum) → [PdfPageDestinationType](./pdfsharp.pdf.pdfpagedestinationtype)<br>
Implements [IComparable](https://docs.microsoft.com/en-us/dotnet/api/system.icomparable), [IFormattable](https://docs.microsoft.com/en-us/dotnet/api/system.iformattable), [IConvertible](https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible)

## Fields

| Name | Value | Description |
| --- | --: | --- |
| Xyz | 0 | Display the page with the coordinates (left, top) positioned at the upper-left corner of the window and the contents of the page magnified by the factor zoom. |
| Fit | 1 | Display the page with its contents magnified just enough to fit the  entire page within the window both horizontally and vertically. |
| FitH | 2 | Display the page with the vertical coordinate top positioned at the top edge of  the window and the contents of the page magnified just enough to fit the entire width of the page within the window. |
| FitV | 3 | Display the page with the horizontal coordinate left positioned at the left edge of  the window and the contents of the page magnified just enough to fit the entire height of the page within the window. |
| FitR | 4 | Display the page designated by page, with its contents magnified just enough to fit the rectangle specified by the coordinates left, bottom, right, and top entirely within the window both horizontally and vertically. If the required horizontal and vertical magnification factors are different, use the smaller of the two, centering the rectangle within the window in the other dimension. A null value for any of the parameters may result in unpredictable behavior. |
| FitB | 5 | Display the page with its contents magnified just enough to fit the rectangle specified by the coordinates left, bottom, right, and top entirely within the window both  horizontally and vertically. |
| FitBH | 6 | Display the page with the vertical coordinate top positioned at the top edge of the window and the contents of the page magnified just enough to fit the entire width of its bounding box within the window. |
| FitBV | 7 | Display the page with the horizontal coordinate left positioned at the left edge of the window and the contents of the page magnified just enough to fit the entire height of its bounding box within the window. |
