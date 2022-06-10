---
-api-id: P:Microsoft.UI.Xaml.Controls.Primitives.Selector.SelectedIndex
-api-type: winrt property
---

<!-- Property syntax
public int SelectedIndex { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.Primitives.Selector.SelectedIndex

## -description
Gets or sets the index of the selected item.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
<selector SelectedIndex="int" .../>
```


## -property-value
The index of the selected item. The default is -1, which indicates that no item is selected.

## -remarks
Some controls that are derived from [Selector](selector.md), like [ListBox](../microsoft.ui.xaml.controls/listbox.md), [ListView](../microsoft.ui.xaml.controls/listview.md), and [GridView](../microsoft.ui.xaml.controls/gridview.md), also support multi-selection. When multi-selection is enabled in those controls, use their [SelectedItems](../microsoft.ui.xaml.controls/listviewbase_selecteditems.md) property to get the selected item collection.

## -examples

## -see-also
[ListBox.SelectionMode](../microsoft.ui.xaml.controls/listbox_selectionmode.md), [ListBox.SelectedItems](../microsoft.ui.xaml.controls/listbox_selecteditems.md), [ListViewBase.SelectionMode](../microsoft.ui.xaml.controls/listviewbase_selectionmode.md), [ListViewBase.SelectedItems](../microsoft.ui.xaml.controls/listviewbase_selecteditems.md)
