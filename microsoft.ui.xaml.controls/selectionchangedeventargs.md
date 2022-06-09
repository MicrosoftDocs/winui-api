---
-api-id: T:Microsoft.UI.Xaml.Controls.SelectionChangedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class SelectionChangedEventArgs : Windows.UI.Xaml.RoutedEventArgs, Windows.UI.Xaml.Controls.ISelectionChangedEventArgs
-->

# Microsoft.UI.Xaml.Controls.SelectionChangedEventArgs

## -description
Provides data for the [SelectionChanged](../microsoft.ui.xaml.controls.primitives/selector_selectionchanged.md) event.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -remarks
> [!NOTE]
> For [ListView](listview.md) and [GridView](gridview.md): If the [ItemsSource](itemscontrol_itemssource.md) implements [IItemsRangeInfo](../microsoft.ui.xaml.data/iitemsrangeinfo.md), and selection is modified using [SelectRange](listviewbase_selectrange_118136163.md) or [DeselectRange](listviewbase_deselectrange_183074056.md), the [AddedItems](selectionchangedeventargs_addeditems.md) and [RemovedItems](selectionchangedeventargs_removeditems.md) properties are not set. Setting these properties requires devirtualizing the item object. Use the [SelectedRanges](listviewbase_selectedranges.md) property to get the items instead.



## -examples

## -see-also
[RoutedEventArgs](../microsoft.ui.xaml/routedeventargs.md)
