# ArrayOrSingleItemHelper

Namespace: PdfSharp.Pdf

Provides methods to handle keys that may contain a PdfArray or a single PdfItem.

```csharp
public class ArrayOrSingleItemHelper
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ArrayOrSingleItemHelper](./pdfsharp.pdf.arrayorsingleitemhelper)

## Constructors

### **ArrayOrSingleItemHelper(DictionaryElements)**

Initializes ArrayOrSingleItemHelper with PdfDictionary.DictionaryElements to work with.

```csharp
public ArrayOrSingleItemHelper(DictionaryElements elements)
```

#### Parameters

`elements` [DictionaryElements](./pdfsharp.pdf.pdfdictionary.dictionaryelements)<br>

## Methods

### **Add(String, PdfItem, Boolean)**

Adds a PdfItem to the given key.
 Creates a PdfArray containing the items, if needed.

```csharp
public void Add(string key, PdfItem value, bool prepend)
```

#### Parameters

`key` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The key in the dictionary to work with.

`value` [PdfItem](./pdfsharp.pdf.pdfitem)<br>
The PdfItem to add.

`prepend` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
True, if value shall be prepended instead of appended.

### **GetAll(String)**

Gets all PdfItems saved in the given key.

```csharp
public IEnumerable<PdfItem> GetAll(string key)
```

#### Parameters

`key` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The key in the dictionary to work with.

#### Returns

[IEnumerable&lt;PdfItem&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)<br>

### **Get&lt;T&gt;(String, Func&lt;T, Boolean&gt;)**

Gets the PdfItem(s) of type T saved in the given key, that match a predicate.

```csharp
public IEnumerable<T> Get<T>(string key, Func<T, bool> predicate)
```

#### Type Parameters

`T`<br>

#### Parameters

`key` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The key in the dictionary to work with.

`predicate` Func&lt;T, Boolean&gt;<br>
The predicate, that shall be true for the desired item(s).

#### Returns

IEnumerable&lt;T&gt;<br>

### **Get&lt;T&gt;(String, Object)**

Gets the PdfItem(s) of type T saved in the given key, that are equal to value.

```csharp
public IEnumerable<T> Get<T>(string key, object value)
```

#### Type Parameters

`T`<br>

#### Parameters

`key` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The key in the dictionary to work with.

`value` [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)<br>
The value, the desired item(s) shall be equal to.

#### Returns

IEnumerable&lt;T&gt;<br>

### **Get&lt;T&gt;(String, T)**

Gets the PdfItem(s) of type T saved in the given key, that are equal to value.

```csharp
public IEnumerable<T> Get<T>(string key, T value)
```

#### Type Parameters

`T`<br>

#### Parameters

`key` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The key in the dictionary to work with.

`value` T<br>
The value, the desired item(s) shall be equal to.

#### Returns

IEnumerable&lt;T&gt;<br>

### **Contains&lt;T&gt;(String, Func&lt;T, Boolean&gt;)**

Returns true if the given key contains a PdfItem of type T matching a predicate.

```csharp
public bool Contains<T>(string key, Func<T, bool> predicate)
```

#### Type Parameters

`T`<br>

#### Parameters

`key` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The key in the dictionary to work with.

`predicate` Func&lt;T, Boolean&gt;<br>
The predicate, that shall be true for the desired item(s).

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **Contains&lt;T&gt;(String, Object)**

Returns true if the given key contains a PdfItem of type T, that is equal to value.

```csharp
public bool Contains<T>(string key, object value)
```

#### Type Parameters

`T`<br>

#### Parameters

`key` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The key in the dictionary to work with.

`value` [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)<br>
The value, the desired item(s) shall be equal to.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **Contains&lt;T&gt;(String, T)**

Returns true if the given key contains a PdfItem of type T, that is equal to value.

```csharp
public bool Contains<T>(string key, T value)
```

#### Type Parameters

`T`<br>

#### Parameters

`key` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The key in the dictionary to work with.

`value` T<br>
The value, the desired item(s) shall be equal to.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **Remove&lt;T&gt;(String, Func&lt;T, Boolean&gt;)**

Removes the PdfItem(s) of type T saved in the given key, that match a predicate.
 Removes the PdfArray, if no longer needed.
 Returns true if items were removed.

```csharp
public bool Remove<T>(string key, Func<T, bool> predicate)
```

#### Type Parameters

`T`<br>

#### Parameters

`key` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The key in the dictionary to work with.

`predicate` Func&lt;T, Boolean&gt;<br>
The predicate, that shall be true for the desired item(s).

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **Remove&lt;T&gt;(String, Object)**

Removes the PdfItem(s) of type T saved in the given key, that are equal to value.
 Removes the PdfArray, if no longer needed.
 Returns true if items were removed.

```csharp
public bool Remove<T>(string key, object value)
```

#### Type Parameters

`T`<br>

#### Parameters

`key` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The key in the dictionary to work with.

`value` [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)<br>
The value, the desired item(s) shall be equal to.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **Remove&lt;T&gt;(String, T)**

Removes the PdfItem(s) of type T saved in the given key, that are equal to value.
 Removes the PdfArray, if no longer needed.
 Returns true if items were removed.

```csharp
public bool Remove<T>(string key, T value)
```

#### Type Parameters

`T`<br>

#### Parameters

`key` [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>
The key in the dictionary to work with.

`value` T<br>
The value, the desired item(s) shall be equal to.

#### Returns

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
