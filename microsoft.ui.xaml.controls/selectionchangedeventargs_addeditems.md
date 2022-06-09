---
-api-id: P:Microsoft.UI.Xaml.Controls.SelectionChangedEventArgs.AddedItems
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVector<object> AddedItems { get; }
-->

# Microsoft.UI.Xaml.Controls.SelectionChangedEventArgs.AddedItems

## -description
Gets a list that contains the items that were selected.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -property-value
The loosely typed collection of items that were selected in this event.

## -remarks
> [!NOTE]
> For [ListView](listview.md) and [GridView](gridview.md): If the [ItemsSource](itemscontrol_itemssource.md) implements [IItemsRangeInfo](../microsoft.ui.xaml.data/iitemsrangeinfo.md), and selection is modified using [SelectRange](listviewbase_selectrange_118136163.md) or [DeselectRange](listviewbase_deselectrange_183074056.md), the AddedItems and [RemovedItems](selectionchangedeventargs_removeditems.md) properties are not set. Setting these properties requires devirtualizing the item object. Use the [SelectedRanges](listviewbase_selectedranges.md) property to get the items instead.



## -examples

## -see-also
