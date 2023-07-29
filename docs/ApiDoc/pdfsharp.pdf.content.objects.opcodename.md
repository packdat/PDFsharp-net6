# OpCodeName

Namespace: PdfSharp.Pdf.Content.Objects

The names of the op-codes.

```csharp
public enum OpCodeName
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ValueType](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype) → [Enum](https://docs.microsoft.com/en-us/dotnet/api/system.enum) → [OpCodeName](./pdfsharp.pdf.content.objects.opcodename)<br>
Implements [IComparable](https://docs.microsoft.com/en-us/dotnet/api/system.icomparable), [IFormattable](https://docs.microsoft.com/en-us/dotnet/api/system.iformattable), [IConvertible](https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible)

## Fields

| Name | Value | Description |
| --- | --: | --- |
| Dictionary | 0 | Pseudo op-code for the name of a dictionary. |
| b | 1 | Close, fill, and stroke path using non-zero winding number rule. |
| B | 2 | Fill and stroke path using non-zero winding number rule. |
| bx | 3 | Close, fill, and stroke path using even-odd rule. |
| Bx | 4 | Fill and stroke path using even-odd rule. |
| BDC | 5 | (PDF 1.2) Begin marked-content sequence with property list |
| BI | 6 | Begin inline image object. |
| BMC | 7 | (PDF 1.2) Begin marked-content sequence. |
| BT | 8 | Begin text object. |
| BX | 9 | (PDF 1.1) Begin compatibility section. |
| c | 10 | Append curved segment to path (three control points). |
| cm | 11 | Concatenate matrix to current transformation matrix. |
| CS | 12 | (PDF 1.1) Set color space for stroking operations. |
| cs | 13 | (PDF 1.1) Set color space for nonstroking operations. |
| d | 14 | Set line dash pattern. |
| d0 | 15 | Set glyph width in Type 3 font. |
| d1 | 16 | Set glyph width and bounding box in Type 3 font. |
| Do | 17 | Invoke named XObject. |
| DP | 18 | (PDF 1.2) Define marked-content point with property list. |
| EI | 19 | End inline image object. |
| EMC | 20 | (PDF 1.2) End marked-content sequence. |
| ET | 21 | End text object. |
| EX | 22 | (PDF 1.1) End compatibility section. |
| f | 23 | Fill path using non-zero winding number rule. |
| F | 24 | Fill path using non-zero winding number rule (deprecated in PDF 2.0). |
| fx | 25 | Fill path using even-odd rule. |
| G | 26 | Set gray level for stroking operations. |
| g | 27 | Set gray level for nonstroking operations. |
| gs | 28 | (PDF 1.2) Set parameters from graphics state parameter dictionary. |
| h | 29 | Close subpath. |
| i | 30 | Set flatness tolerance. |
| ID | 31 | Begin inline image data |
| j | 32 | Set line join style. |
| J | 33 | Set line cap style |
| K | 34 | Set CMYK color for stroking operations. |
| k | 35 | Set CMYK color for nonstroking operations. |
| l | 36 | Append straight line segment to path. |
| m | 37 | Begin new subpath. |
| M | 38 | Set miter limit. |
| MP | 39 | (PDF 1.2) Define marked-content point. |
| n | 40 | End path without filling or stroking. |
| q | 41 | Save graphics state. |
| Q | 42 | Restore graphics state. |
| re | 43 | Append rectangle to path. |
| RG | 44 | Set RGB color for stroking operations. |
| rg | 45 | Set RGB color for nonstroking operations. |
| ri | 46 | Set color rendering intent. |
| s | 47 | Close and stroke path. |
| S | 48 | Stroke path. |
| SC | 49 | (PDF 1.1) Set color for stroking operations. |
| sc | 50 | (PDF 1.1) Set color for nonstroking operations. |
| SCN | 51 | (PDF 1.2) Set color for stroking operations (ICCBased and special color spaces). |
| scn | 52 | (PDF 1.2) Set color for nonstroking operations (ICCBased and special color spaces). |
| sh | 53 | (PDF 1.3) Paint area defined by shading pattern. |
| Tx | 54 | Move to start of next text line. |
| Tc | 55 | Set character spacing. |
| Td | 56 | Move text position. |
| TD | 57 | Move text position and set leading. |
| Tf | 58 | Set text font and size. |
| Tj | 59 | Show text. |
| TJ | 60 | Show text, allowing individual glyph positioning. |
| TL | 61 | Set text leading. |
| Tm | 62 | Set text matrix and text line matrix. |
| Tr | 63 | Set text rendering mode. |
| Ts | 64 | Set text rise. |
| Tw | 65 | Set word spacing. |
| Tz | 66 | Set horizontal text scaling. |
| v | 67 | Append curved segment to path (initial point replicated). |
| w | 68 | Set line width. |
| W | 69 | Set clipping path using non-zero winding number rule. |
| Wx | 70 | Set clipping path using even-odd rule. |
| y | 71 | Append curved segment to path (final point replicated). |
| QuoteSingle | 72 | Move to next line and show text. |
| QuoteDouble | 73 | Set word and character spacing, move to next line, and show text. |
| QuoteDbl | 73 | Set word and character spacing, move to next line, and show text. |
