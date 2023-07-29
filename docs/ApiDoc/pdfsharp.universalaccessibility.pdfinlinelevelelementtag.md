# PdfInlineLevelElementTag

Namespace: PdfSharp.UniversalAccessibility

PDF Inline Level Element tags for Universal Accessibility.

```csharp
public enum PdfInlineLevelElementTag
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ValueType](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype) → [Enum](https://docs.microsoft.com/en-us/dotnet/api/system.enum) → [PdfInlineLevelElementTag](./pdfsharp.universalaccessibility.pdfinlinelevelelementtag)<br>
Implements [IComparable](https://docs.microsoft.com/en-us/dotnet/api/system.icomparable), [IFormattable](https://docs.microsoft.com/en-us/dotnet/api/system.iformattable), [IConvertible](https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible)

## Fields

| Name | Value | Description |
| --- | --: | --- |
| Span | 0 | (Span) A generic inline portion of text having no particular inherent characteristics. It can be used, for example, to delimit a range of text with a given set of styling attributes. |
| Quotation | 1 | (Quotation) An inline portion of text attributed to someone other than the author of the surrounding text. |
| Quote | 1 | (Quotation) An inline portion of text attributed to someone other than the author of the surrounding text. |
| Note | 2 | (Note) An item of explanatory text, such as a footnote or an endnote, that is referred to from within the body of the document. It may have a label (structure type Lbl) as a child. The note may be included as a  child of the structure element in the body text that refers to it, or it may be included elsewhere  (such as in an endnotes section) and accessed by means of a reference (structure type Reference). |
| Reference | 3 | (Reference) A citation to content elsewhere in the document. |
| BibliographyEntry | 4 | (Bibliography entry) A reference identifying the external source of some cited content.  It may contain a label (structure type Lbl) as a child. |
| BibEntry | 4 | (Bibliography entry) A reference identifying the external source of some cited content.  It may contain a label (structure type Lbl) as a child. |
| Code | 5 | (Code) A fragment of computer program text. |
| Link | 6 | (Link) An association between a portion of the ILSE’s content and a corresponding link annotation or annotations.  Its children are one or more content items or child ILSEs and one or more object references identifying the  associated link annotations. |
| Annotation | 7 | (Annotation; PDF 1.5) An association between a portion of the ILSE’s content and a corresponding PDF annotation.  Annotation is used for all PDF annotations except link annotations and widget annotations. |
| Annot | 7 | (Annotation; PDF 1.5) An association between a portion of the ILSE’s content and a corresponding PDF annotation.  Annot is used for all PDF annotations except link annotations and widget annotations. |
| Ruby | 8 | (Ruby; PDF 1.5) A side-note (annotation) written in a smaller text size and placed adjacent to the base text to  which it refers. It is used in Japanese and Chinese to describe the pronunciation of unusual words or to describe  such items as abbreviations and logos. A Rubyelement may also contain the RB, RT, and RP elements. |
| Warichu | 9 | (Warichu; PDF 1.5) A comment or annotation in a smaller text size and formatted onto two smaller lines within the  height of the containing text line and placed following (inline) the base text to which it refers. It is used in  Japanese for descriptive comments and for ruby annotation text that is too long to be aesthetically formatted as  a ruby. A Warichu element may also contain the WT and WP elements. |
