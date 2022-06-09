---
-api-id: P:Microsoft.UI.Xaml.Controls.ListBox.SelectedItems
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVector<object> SelectedItems { get; }
-->

# Microsoft.UI.Xaml.Controls.ListBox.SelectedItems

## -description
Gets the list of currently selected items for the [ListBox](listbox.md) control.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -property-value
The list of currently selected items for the [ListBox](listbox.md) control.

## -remarks
When [SelectionMode](listbox_selectionmode.md) is **Multiple** or **Extended**, use the [SelectedItems](listviewbase_selecteditems.md) property to get the items that are selected. When [SelectionMode](listbox_selectionmode.md) is **Single**, use the [Selector.SelectedItem](../microsoft.ui.xaml.controls.primitives/selector_selecteditem.md) property to get the item that's selected.

## -examples

## -see-also
[SelectionMode](listviewbase_selectionmode.md), [Selector.SelectedItem](../microsoft.ui.xaml.controls.primitives/selector_selecteditem.md), [Selector.SelectedIndex](../microsoft.ui.xaml.controls.primitives/selector_selectedindex.md), [Selector.SelectionChanged](../microsoft.ui.xaml.controls.primitives/selector_selectionchanged.md)
