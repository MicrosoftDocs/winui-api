---
-api-id: M:Microsoft.UI.Xaml.Media.Animation.DoubleKeyFrameCollection.SetAt(System.UInt32,Microsoft.UI.Xaml.Media.Animation.DoubleKeyFrame)
-api-type: winrt method
---

<!-- Method syntax
public void SetAt(System.UInt32 index, Windows.UI.Xaml.Media.Animation.DoubleKeyFrame value)
-->

# Microsoft.UI.Xaml.Media.Animation.DoubleKeyFrameCollection.SetAt

## -description
Sets the value at the specified index to the [DoubleKeyFrame](doublekeyframe.md) value specified.

## -parameters
### -param index
The index at which to set the value.

### -param value
The value to set.

## -remarks
[InsertAt](doublekeyframecollection_insertat_1821449892.md) expands the collection and moves all subsequent index items by one.

In contrast, SetAt replaces the item at the index, and the collection count remains the same.

## -examples

## -see-also
