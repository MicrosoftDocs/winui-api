---
-api-id: M:Microsoft.UI.Xaml.UIElementWeakCollection.InsertAt(System.UInt32,Microsoft.UI.Xaml.UIElement)
-api-type: winrt method
---

<!-- Method syntax.
public void UIElementWeakCollection.InsertAt(UInt32 index, UIElement value)
-->

# Microsoft.UI.Xaml.UIElementWeakCollection.InsertAt

## -description

Inserts the specified item at the specified index.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -parameters
### -param index

The zero-based index at which to insert the item.

### -param value

The object to insert into the collection.

## -remarks

InsertAt expands the collection and moves all subsequent index items by one.

In contrast, SetAt replaces the item at the index, and the collection count remains the same.

## -see-also

## -examples

