---
-api-id: T:Microsoft.UI.Xaml.Controls.ItemsUpdatingScrollMode
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Xaml.Controls.ItemsUpdatingScrollMode : int
-->

# ItemsUpdatingScrollMode

## -description
Defines constants that specify the scrolling behavior of items while updating.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -enum-fields
### -field KeepItemsInView:0
Adjusts the scroll offset to keep the first visible item in the viewport when items are added to the [ItemsSource](itemscontrol_itemssource.md).

### -field KeepScrollOffset:1
Maintains the scroll offset relative to the beginning of the list, forcing items in the viewport to move down when items are added to the [ItemsSource](itemscontrol_itemssource.md).

### -field KeepLastItemInView:2
Adjusts the scroll offset to keep the last visible item in the viewport when items are added to the [ItemsSource](itemscontrol_itemssource.md).


## -remarks
See [ItemsStackPanel.ItemsUpdatingScrollMode](itemsstackpanel_itemsupdatingscrollmode.md) for more info.

## -examples

## -see-also
[ItemsStackPanel.ItemsUpdatingScrollMode](itemsstackpanel_itemsupdatingscrollmode.md)
