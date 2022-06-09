---
-api-id: M:Microsoft.UI.Xaml.Controls.ListViewBase.DeselectRange(Microsoft.UI.Xaml.Data.ItemIndexRange)
-api-type: winrt method
---

<!-- Method syntax
public void DeselectRange(Windows.UI.Xaml.Data.ItemIndexRange itemIndexRange)
-->

# Microsoft.UI.Xaml.Controls.ListViewBase.DeselectRange

## -description
Deselects a block of items described by the [ItemIndexRange](../microsoft.ui.xaml.data/itemindexrange.md).

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -parameters
### -param itemIndexRange
Information about the range of items, including the index of the first and last items in the range, and the number of items.

## -remarks
[SelectRange](listviewbase_selectrange_118136163.md) and DeselectRange provide a more efficient way to modify the selection than using the [SelectedItems](listviewbase_selecteditems.md) property. When you select items using index ranges, use the [SelectedRanges](listviewbase_selectedranges.md) property to get all selected ranges in the list.

When you call DeselectRange, all items in the specified range are deselected, regardless of their original selection state. You can deselect all items in a collection by using an [ItemIndexRange](../microsoft.ui.xaml.data/itemindexrange.md) with a [FirstIndex](../microsoft.ui.xaml.data/itemindexrange_firstindex.md) value of 0 and a [Length](../microsoft.ui.xaml.data/itemindexrange_length.md) value equal to the number of items in the collection.

> [!NOTE]
> If the [ItemsSource](itemscontrol_itemssource.md) implements [IItemsRangeInfo](../microsoft.ui.xaml.data/iitemsrangeinfo.md), the [SelectedItems](listviewbase_selecteditems.md) collection is not updated based on selection in the list. Use the [SelectedRanges](listviewbase_selectedranges.md) property instead.

## -examples
Here's how to deselect the first 9 items in a [ListView](listview.md) named `itemListView`.

```csharp
if (itemListView.SelectionMode == ListViewSelectionMode.Multiple ||
    itemListView.SelectionMode == ListViewSelectionMode.Extended)
{
    itemListView.DeselectRange(new ItemIndexRange(0, 9));
}
```



## -see-also
[SelectedRanges](listviewbase_selectedranges.md), [SelectRange](listviewbase_selectrange_118136163.md), [ItemIndexRange](../microsoft.ui.xaml.data/itemindexrange.md)
