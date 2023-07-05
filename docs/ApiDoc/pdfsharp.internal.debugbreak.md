# DebugBreak

Namespace: PdfSharp.Internal

Helper class around the Debugger class.

```csharp
public static class DebugBreak
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [DebugBreak](./pdfsharp.internal.debugbreak)

## Methods

### **Break()**

Call Debugger.Break() if a debugger is attached.

```csharp
public static void Break()
```

### **Break(Boolean)**

Call Debugger.Break() if a debugger is attached or when always is set to true.

```csharp
public static void Break(bool always)
```

#### Parameters

`always` [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)<br>
