---
-api-id: M:Microsoft.UI.Xaml.Media.PointCollection.SetAt(System.UInt32,Windows.Foundation.Point)
-api-type: winrt method
---

<!-- Method syntax
public void SetAt(System.UInt32 index, Windows.Foundation.Point value)
-->

# Microsoft.UI.Xaml.Media.PointCollection.SetAt

## -description
Sets the value at the specified index to the [Point](/uwp/api/windows.foundation.point) value specified.

## -parameters
### -param index
The index at which to set the value.

### -param value
The value to set.

## -remarks
[InsertAt](pointcollection_insertat_450968922.md) expands the collection and moves all subsequent index items by one.

In contrast, SetAt replaces the item at the index, and the collection count remains the same.

## -examples

## -see-also
