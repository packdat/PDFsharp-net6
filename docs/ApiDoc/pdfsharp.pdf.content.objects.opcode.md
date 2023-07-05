# OpCode

Namespace: PdfSharp.Pdf.Content.Objects

Represents a PDF content stream operator description.

```csharp
public sealed class OpCode
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [OpCode](./pdfsharp.pdf.content.objects.opcode)

## Fields

### **Name**

The name of the operator.

```csharp
public string Name;
```

### **OpCodeName**

The enum value of the operator.

```csharp
public OpCodeName OpCodeName;
```

### **Operands**

The number of operands. -1 indicates a variable number of operands.

```csharp
public int Operands;
```

### **Flags**

The flags.

```csharp
public OpCodeFlags Flags;
```

### **Postscript**

The postscript equivalent, or null if no such operation exists.

```csharp
public string Postscript;
```

### **Description**

The description from Adobe PDF Reference.

```csharp
public string Description;
```
