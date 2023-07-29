# PdfBlockLevelElementTag

Namespace: PdfSharp.UniversalAccessibility

PDF Block Level Element tags for Universal Accessibility.

```csharp
public enum PdfBlockLevelElementTag
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ValueType](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype) → [Enum](https://docs.microsoft.com/en-us/dotnet/api/system.enum) → [PdfBlockLevelElementTag](./pdfsharp.universalaccessibility.pdfblocklevelelementtag)<br>
Implements [IComparable](https://docs.microsoft.com/en-us/dotnet/api/system.icomparable), [IFormattable](https://docs.microsoft.com/en-us/dotnet/api/system.iformattable), [IConvertible](https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible)

## Fields

| Name | Value | Description |
| --- | --: | --- |
| P | 0 | (Paragraph) A low-level division of text. |
| Paragraph | 0 | A low-level division of text. |
| H | 1 | (Heading) A label for a subdivision of a document’s content. It should be the first child of the division that it heads. |
| Heading | 1 | A label for a subdivision of a document’s content. It should be the first child of the division that it heads. |
| H1 | 2 | Headings with specific levels, for use in applications that cannot hierarchically nest their sections and thus cannot  determine the level of a heading from its level of nesting. Obsolete: Use Heading1 etc. instead. |
| H2 | 3 | Headings with specific levels, for use in applications that cannot hierarchically nest their sections and thus cannot  determine the level of a heading from its level of nesting. Obsolete: Use Heading1 etc. instead. |
| H3 | 4 | Headings with specific levels, for use in applications that cannot hierarchically nest their sections and thus cannot  determine the level of a heading from its level of nesting. Obsolete: Use Heading1 etc. instead. |
| H4 | 5 | Headings with specific levels, for use in applications that cannot hierarchically nest their sections and thus cannot  determine the level of a heading from its level of nesting. Obsolete: Use Heading1 etc. instead. |
| H5 | 6 | Headings with specific levels, for use in applications that cannot hierarchically nest their sections and thus cannot  determine the level of a heading from its level of nesting. Obsolete: Use Heading1 etc. instead. |
| H6 | 7 | Headings with specific levels, for use in applications that cannot hierarchically nest their sections and thus cannot  determine the level of a heading from its level of nesting. Obsolete: Use Heading1 etc. instead. |
| Heading1 | 2 | Headings with specific level 1, for use in applications that cannot hierarchically nest their sections and thus cannot  determine the level of a heading from its level of nesting. |
| Heading2 | 3 | Headings with specific level 2, for use in applications that cannot hierarchically nest their sections and thus cannot  determine the level of a heading from its level of nesting. |
| Heading3 | 4 | Headings with specific level 3, for use in applications that cannot hierarchically nest their sections and thus cannot  determine the level of a heading from its level of nesting. |
| Heading4 | 5 | Headings with specific level 4, for use in applications that cannot hierarchically nest their sections and thus cannot  determine the level of a heading from its level of nesting. |
| Heading5 | 6 | Headings with specific level 5, for use in applications that cannot hierarchically nest their sections and thus cannot  determine the level of a heading from its level of nesting. |
| Heading6 | 7 | Headings with specific level 6, for use in applications that cannot hierarchically nest their sections and thus cannot  determine the level of a heading from its level of nesting. |
| L | 8 | (List) A sequence of items of like meaning and importance. Its immediate children should be an optional caption (structure type Caption). |
| List | 8 | A sequence of items of like meaning and importance. Its immediate children should be an optional caption (structure type Caption). |
| Lbl | 9 | (Label) A name or number that distinguishes a given item from others in the same list or other group of like items. In a dictionary list, for example, it contains the term being defined; in a bulleted or numbered list, it contains the bullet character or the number of the  list item and associated punctuation. |
| Label | 9 | A name or number that distinguishes a given item from others in the same list or other group of like items. In a dictionary list, for example, it contains the term being defined; in a bulleted or numbered list, it contains the bullet character or the number of the  list item and associated punctuation. |
| LI | 10 | (List item) An individual member of a list. Its children may be one or more labels, list bodies, or both (structure types Lbl or LBody; see below). |
| ListItem | 10 | An individual member of a list. Its children may be one or more labels, list bodies, or both (structure types Lbl or LBody; see below). |
| LBody | 11 | (List body) The descriptive content of a list item. In a dictionary list, for example, it contains the definition of the term. It can either contain the content directly or have other BLSEs, perhaps including nested lists, as children. |
| ListBody | 11 | The descriptive content of a list item. In a dictionary list, for example, it contains the definition of the term. It can either contain the content directly or have other BLSEs, perhaps including nested lists, as children. |
| Table | 12 | A two-dimensional layout of rectangular data cells, possibly having a complex substructure. It contains either one or more table rows (structure type TR) as children; or an optional table head (structure type THead) followed by one or more table body elements (structure type TBody) and an optional table footer (structure type TFoot). In addition, a table may have an optional caption (structure type Caption) as its first or last child. |
| TR | 13 | (Table row) A row of headings or data in a table. It may contain table header cells and table data cells (structure types TH and TD). |
| TableRow | 13 | A row of headings or data in a table. It may contain table header cells and table data cells (structure types TH and TD). |
| TH | 14 | (Table header cell) A table cell containing header text describing one or more rows or columns of the table. |
| TableHeaderCell | 14 | A table cell containing header text describing one or more rows or columns of the table. |
| TD | 15 | (Table data cell) A table cell containing data that is part of the table’s content. |
| TableDataCell | 15 | A table cell containing data that is part of the table’s content. |
| THead | 16 | (Table header row group; PDF 1.5) A group of rows that constitute the header of a table. If the table is split across multiple pages, these rows may be redrawn at the top of each table fragment (although there is only one THead element). |
| TableHeadRowGroup | 16 | (PDF 1.5) A group of rows that constitute the header of a table. If the table is split across multiple pages, these rows may be redrawn at the top of each table fragment (although there is only one THead element). |
| TBody | 17 | (Table body row group; PDF 1.5) A group of rows that constitute the main body portion of a table. If the table is split across multiple pages, the body area may be broken apart on a row boundary. A table may have multiple TBody elements to allow for the drawing of a border or background for a set of rows. |
| TableBodyRowGroup | 17 | (PDF 1.5) A group of rows that constitute the main body portion of a table. If the table is split across multiple pages, the body area may be broken apart on a row boundary. A table may have multiple TBody elements to allow for the drawing of a border or background for a set of rows. |
| TFoot | 18 | (Table footer row group; PDF 1.5) A group of rows that constitute the footer of a table. If the table is split across multiple pages, these rows may be redrawn at the bottom of each table fragment (although there is only one TFoot element.) |
| TableFooterRowGroup | 18 | (PDF 1.5) A group of rows that constitute the footer of a table. If the table is split across multiple pages, these rows may be redrawn at the bottom of each table fragment (although there is only one TFoot element.) |
