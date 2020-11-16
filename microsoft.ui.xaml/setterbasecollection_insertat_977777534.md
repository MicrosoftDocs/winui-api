---
-api-id: M:Microsoft.UI.Xaml.SetterBaseCollection.InsertAt(System.UInt32,Microsoft.UI.Xaml.SetterBase)
-api-type: winrt method
---

<!-- Method syntax
public void InsertAt(System.UInt32 index, Windows.UI.Xaml.SetterBase value)
-->

# Microsoft.UI.Xaml.SetterBaseCollection.InsertAt

## -description
Inserts the specified item at the specified index.

## -parameters
### -param index
The index at which to set the value.

### -param value
The value to set.

## -remarks
InsertAt expands the collection and moves all subsequent index items by one. In contrast, [SetAt](setterbasecollection_setat_1259918094.md) replaces the item at the index, and the collection count remains the same.



> [!NOTE]
> The equivalent Microsoft .NET  API is [Insert](setterbasecollection_insert.md).

## -examples

## -see-also
[Insert](setterbasecollection_insert.md)
