---
-api-id: M:Microsoft.UI.Xaml.Media.Animation.ColorKeyFrameCollection.SetAt(System.UInt32,Microsoft.UI.Xaml.Media.Animation.ColorKeyFrame)
-api-type: winrt method
---

<!-- Method syntax
public void SetAt(System.UInt32 index, Windows.UI.Xaml.Media.Animation.ColorKeyFrame value)
-->

# Microsoft.UI.Xaml.Media.Animation.ColorKeyFrameCollection.SetAt

## -description
Sets the value at the specified index to the [ColorKeyFrame](colorkeyframe.md) value specified.

## -parameters
### -param index
The index at which to set the value.

### -param value
The value to set.

## -remarks
[InsertAt](colorkeyframecollection_insertat_35988440.md) expands the collection and moves all subsequent index items by one.

In contrast, SetAt replaces the item at the index, and the collection count remains the same.

## -examples

## -see-also
