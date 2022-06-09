---
-api-id: M:Microsoft.UI.Xaml.DependencyObjectCollection.SetAt(System.UInt32,Microsoft.UI.Xaml.DependencyObject)
-api-type: winrt method
---

<!-- Method syntax
public void SetAt(System.UInt32 index, Windows.UI.Xaml.DependencyObject value)
-->

# Microsoft.UI.Xaml.DependencyObjectCollection.SetAt

## -description
Sets the value at the specified index to the [DependencyObject](dependencyobject.md) value specified.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -parameters
### -param index
The index at which to set the value.

### -param value
The value to set.

## -remarks
[InsertAt](dependencyobjectcollection_insertat_2143893086.md) expands the collection and moves all subsequent index items by one. In contrast, SetAt replaces the item at the index, and the collection count remains the same.



> [!NOTE]
> The equivalent Microsoft .NET  API is [Item](dependencyobjectcollection_item.md) (the indexer).

## -examples

## -see-also
