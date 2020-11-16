---
-api-id: E:Microsoft.UI.Xaml.Controls.Primitives.Selector.SelectionChanged
-api-type: winrt event
---

<!-- Event syntax
public event Windows.UI.Xaml.Controls.SelectionChangedEventHandler SelectionChanged
-->

# Microsoft.UI.Xaml.Controls.Primitives.Selector.SelectionChanged

## -description
Occurs when the currently selected item changes.

## -xaml-syntax
```xaml
<selector SelectionChanged="eventhandler"/>
```


## -remarks
> [!NOTE]
> For [ListView](../microsoft.ui.xaml.controls/listview.md) and [GridView](../microsoft.ui.xaml.controls/gridview.md): If the [ItemsSource](../microsoft.ui.xaml.controls/itemscontrol_itemssource.md) implements [IItemsRangeInfo](../microsoft.ui.xaml.data/iitemsrangeinfo.md), and selection is modified using [SelectRange](/uwp/api/windows.ui.xaml.controls.listviewbase.selectrange(windows.ui.xaml.data.itemindexrange)) or [DeselectRange](/uwp/api/windows.ui.xaml.controls.listviewbase.deselectrange(windows.ui.xaml.data.itemindexrange)), the [AddedItems](../microsoft.ui.xaml.controls/selectionchangedeventargs_addeditems.md) and [RemovedItems](../microsoft.ui.xaml.controls/selectionchangedeventargs_removeditems.md) properties are not set in the [SelectionChangedEventArgs](../microsoft.ui.xaml.controls/selectionchangedeventargs.md). Setting these properties requires devirtualizing the item object. Use the [SelectedRanges](../microsoft.ui.xaml.controls/listviewbase_selectedranges.md) property to get the items instead.



## -examples

## -see-also
