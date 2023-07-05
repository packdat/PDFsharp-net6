# XFontStretch

Namespace: PdfSharp.Drawing

Describes the degree to which a font has been stretched compared to the normal aspect ratio of that font.

```csharp
public struct XFontStretch
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ValueType](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype) → [XFontStretch](./pdfsharp.drawing.xfontstretch)<br>
Implements [IFormattable](https://docs.microsoft.com/en-us/dotnet/api/system.iformattable)

## Methods

### **FromOpenTypeStretch(Int32)**

Creates a new instance of  that corresponds to the OpenType usStretchClass value.

```csharp
XFontStretch FromOpenTypeStretch(int stretchValue)
```

#### Parameters

`stretchValue` [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
An integer value between one and nine that corresponds to the usStretchValue definition in the OpenType specification.

#### Returns

[XFontStretch](./pdfsharp.drawing.xfontstretch)<br>
A new instance of .

### **ToOpenTypeStretch()**

Returns a value that represents the OpenType usStretchClass for this  object.

```csharp
int ToOpenTypeStretch()
```

#### Returns

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
An integer value between 1 and 999 that corresponds to the usStretchClass definition in the OpenType specification.

### **Compare(XFontStretch, XFontStretch)**

Compares two instances of  objects.

```csharp
int Compare(XFontStretch left, XFontStretch right)
```

#### Parameters

`left` [XFontStretch](./pdfsharp.drawing.xfontstretch)<br>
The first  object to compare.

`right` [XFontStretch](./pdfsharp.drawing.xfontstretch)<br>
The second  object to compare.

#### Returns

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
An [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32) value that represents the relationship between the two instances of .

### **Equals(XFontStretch)**

Compares a  object with the current  object.

```csharp
bool Equals(XFontStretch obj)
```

#### Parameters

`obj` [XFontStretch](./pdfsharp.drawing.xfontstretch)<br>
The instance of the  object to compare for equality.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
if two instances are equal; otherwise, .

### **Equals(Object)**

Compares a [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) with the current  object.

```csharp
bool Equals(object obj)
```

#### Parameters

`obj` [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)<br>
The instance of the [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) to compare for equality.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
if two instances are equal; otherwise, .

### **GetHashCode()**

Retrieves the hash code for this object.

```csharp
int GetHashCode()
```

#### Returns

[Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)<br>
An [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32) value representing the hash code for the object.

### **ToString()**

Creates a [String](https://docs.microsoft.com/en-us/dotnet/api/system.string) representation of the current  object based on the current culture.

```csharp
string ToString()
```

#### Returns

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
A [String](https://docs.microsoft.com/en-us/dotnet/api/system.string) value representation of the object.
