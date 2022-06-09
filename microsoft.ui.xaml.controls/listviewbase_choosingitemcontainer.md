---
-api-id: E:Microsoft.UI.Xaml.Controls.ListViewBase.ChoosingItemContainer
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler ChoosingItemContainer<Windows.UI.Xaml.Controls.ListViewBase,  Windows.UI.Xaml.Controls.ChoosingItemContainerEventArgs>
-->

# Microsoft.UI.Xaml.Controls.ListViewBase.ChoosingItemContainer

## -description
Occurs when an item container is to be chosen for a data item.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -remarks
This event is raised only if the list or grid's [ItemsPanel](itemscontrol_itemspanel.md) is an [ItemsStackPanel](itemsstackpanel.md) or [ItemsWrapGrid](itemswrapgrid.md). If you replace the [ItemsPanel](itemscontrol_itemspanel.md) with another panel, the event is not raised.

## -examples

## -see-also
