# PdfGroupingElementTag

Namespace: PdfSharp.UniversalAccessibility

PDF Grouping Element tags for Universal Accessibility.

```csharp
public enum PdfGroupingElementTag
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ValueType](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype) → [Enum](https://docs.microsoft.com/en-us/dotnet/api/system.enum) → [PdfGroupingElementTag](./pdfsharp.universalaccessibility.pdfgroupingelementtag)<br>
Implements [IComparable](https://docs.microsoft.com/en-us/dotnet/api/system.icomparable), [IFormattable](https://docs.microsoft.com/en-us/dotnet/api/system.iformattable), [IConvertible](https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible)

## Fields

| Name | Value | Description |
| --- | --: | --- |
| Document | 0 | (Document) A complete document. This is the root element of any structure tree containing multiple parts or multiple articles. |
| Part | 1 | (Part) A large-scale division of a document. This type of element is appropriate for grouping articles or sections. |
| Article | 2 | (Article) A relatively self-contained body of text constituting a single narrative or exposition. Articles should be disjoint; that is, they should not contain other articles as constituent elements. |
| Art | 2 | (Article) A relatively self-contained body of text constituting a single narrative or exposition. Articles should be disjoint; that is, they should not contain other articles as constituent elements. |
| Section | 3 | (Section) A container for grouping related content elements. For example, a section might contain a heading, several introductory paragraphs, and two or more other sections nested within it as subsections. |
| Sect | 3 | (Section) A container for grouping related content elements. For example, a section might contain a heading, several introductory paragraphs, and two or more other sections nested within it as subsections. |
| Division | 4 | (Division) A generic block-level element or group of elements. |
| Div | 4 | (Division) A generic block-level element or group of elements. |
| BlockQuotation | 5 | (Block quotation) A portion of text consisting of one or more paragraphs attributed to someone other than the author of the surrounding text. |
| BlockQuote | 5 | (Block quotation) A portion of text consisting of one or more paragraphs attributed to someone other than the author of the surrounding text. |
| Caption | 6 | (Caption) A brief portion of text describing a table or figure. |
| TableOfContents | 7 | (Table of contents) A list made up of table of contents item entries (structure type TableOfContentsItem; see below) and/or other nested table of contents entries (TableOfContents). A TableOfContents entry that includes only TableOfContentsItem entries represents a flat hierarchy. A TableOfContents entry that includes other nested TableOfContents entries (and possibly TableOfContentsItem entries) represents a more complex hierarchy. Ideally, the hierarchy of a top level TableOfContents entry reflects the structure of the main body of the document. Note: Lists of figures and tables, as well as bibliographies, can be treated as tables of contents for purposes of the  standard structure types. |
| TOC | 7 | (Table of contents) A list made up of table of contents item entries (structure type TableOfContentsItem; see below) and/or other nested table of contents entries (TableOfContents). A TableOfContents entry that includes only TableOfContentsItem entries represents a flat hierarchy. A TableOfContents entry that includes other nested TableOfContents entries (and possibly TableOfContentsItem entries) represents a more complex hierarchy. Ideally, the hierarchy of a top level TableOfContents entry reflects the structure of the main body of the document. Note: Lists of figures and tables, as well as bibliographies, can be treated as tables of contents for purposes of the  standard structure types. |
| TableOfContentsItem | 8 | (Table of contents item) An individual member of a table of contents. This entry’s children can be any of the following structure types: Label A label. Reference A reference to the title and the page number. NonstructuralElement Non-structure elements for wrapping a leader artifact. Paragraph Descriptive text. TableOfContents Table of content elements for hierarchical tables of content, as described for the TableOfContents entry. |
| TOCI | 8 | (Table of contents item) An individual member of a table of contents. This entry’s children can be any of the following structure types: Label A label. Reference A reference to the title and the page number. NonstructuralElement Non-structure elements for wrapping a leader artifact. Paragraph Descriptive text. TableOfContents Table of content elements for hierarchical tables of content, as described for the TableOfContents entry. |
| Index | 9 | (Index) A sequence of entries containing identifying text accompanied by reference elements (structure type Reference) that point out occurrences of the specified text in the main body of a document. |
| NonstructuralElement | 10 | (Nonstructural element) A grouping element having no inherent structural significance; it serves solely for grouping purposes. This type of element differs from a division (structure type Division; see above) in that it is not interpreted or exported to other document formats; however, its descendants are to be processed normally. |
| NonStruct | 10 | (Nonstructural element) A grouping element having no inherent structural significance; it serves solely for grouping purposes. This type of element differs from a division (structure type Division; see above) in that it is not interpreted or exported to other document formats; however, its descendants are to be processed normally. |
| PrivateElement | 11 | (Private element) A grouping element containing private content belonging to the application producing it. The structural significance of this type of element is unspecified and is determined entirely by the producer application. Neither the Private element nor any of its descendants are to be interpreted or exported to other document formats. |
| Private | 11 | (Private element) A grouping element containing private content belonging to the application producing it. The structural significance of this type of element is unspecified and is determined entirely by the producer application. Neither the Private element nor any of its descendants are to be interpreted or exported to other document formats. |
