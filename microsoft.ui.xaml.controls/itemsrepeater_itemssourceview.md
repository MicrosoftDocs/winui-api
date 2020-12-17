---
-api-id: P:Microsoft.UI.Xaml.Controls.ItemsRepeater.ItemsSourceView
-api-type: winrt property
---

# Microsoft.UI.Xaml.Controls.ItemsRepeater.ItemsSourceView

<!--
public Microsoft.UI.Xaml.Controls.ItemsSourceView ItemsSourceView { get; }
-->

## -description

Gets a standardized view of the supported interactions between a given ItemsSource object and the ItemsRepeater control and its associated components.

## -property-value

A standardized view of the supported interactions between an ItemsSource object and the ItemsRepeater.

## -remarks

ItemsSourceView gives the ItemsRepeater and associated components a standardized _view_ of the available interactions with the data based on the interfaces the data source implements and that the control supports. For example, you might set the [ItemsSource](itemsrepeater_itemssource.md) to a derived [ObservableCollection\<T>](/dotnet/api/system.collections.objectmodel.observablecollection-1?view=dotnet-uwp-10.0&preserve-view=true) that implements one or more of the [IItemsRangeInfo](), [ISelectionInfo](), and [ISupportIncrementalLoading]() interfaces, which alter the interaction between the data and the control.

## -see-also

## -examples

