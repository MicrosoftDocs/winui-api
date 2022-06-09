---
-api-id: M:Microsoft.UI.Xaml.Media.GradientStopCollection.SetAt(System.UInt32,Microsoft.UI.Xaml.Media.GradientStop)
-api-type: winrt method
---

<!-- Method syntax
public void SetAt(System.UInt32 index, Windows.UI.Xaml.Media.GradientStop value)
-->

# Microsoft.UI.Xaml.Media.GradientStopCollection.SetAt

## -description
Sets the value at the specified index to the **GradientStop** value specified.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -parameters
### -param index
The index at which to set the value.

### -param value
The value to set.

## -remarks
[InsertAt](gradientstopcollection_insertat_249004778.md) expands the collection and moves all subsequent index items by one.

In contrast, SetAt replaces the item at the index, and the collection count remains the same.

## -examples

## -see-also
