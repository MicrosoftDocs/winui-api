---
-api-id: M:Microsoft.UI.Xaml.Media.BrushCollection.InsertAt(System.UInt32,Microsoft.UI.Xaml.Media.Brush)
-api-type: winrt method
---

<!-- Method syntax
public void InsertAt(System.UInt32 index, Windows.UI.Xaml.Media.Brush value)
-->

# Microsoft.UI.Xaml.Media.BrushCollection.InsertAt

## -description
Inserts the specified item at the specified index.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -parameters
### -param index
The index at which to set the value.

### -param value
The value to set.

## -remarks
InsertAt expands the collection and moves all subsequent index items by one.

In contrast, [SetAt](brushcollection_setat_1573814144.md) replaces the item at the index, and the collection count remains the same.

## -examples

## -see-also
