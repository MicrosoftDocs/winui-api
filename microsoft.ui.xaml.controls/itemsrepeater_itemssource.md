---
-api-id: P:Microsoft.UI.Xaml.Controls.ItemsRepeater.ItemsSource
-api-type: winrt property
---

# Microsoft.UI.Xaml.Controls.ItemsRepeater.ItemsSource

<!--
public object ItemsSource { get; set; }
-->

## -description

Gets or sets an object source used to generate the content of the ItemsRepeater.

## -property-value

The object that is used to generate the content of the ItemsRepeater. The default is **null**.

## -remarks

Use the ItemsSource property to specify the collection to use to generate the content of items. You can set the ItemsSource to any type that implements **IEnumerable**. Additional collection interfaces implemented by your data source determine what functionality is available to the ItemsRepeater to interact with your data.

This list shows available interfaces and when to consider using each one.

- [IEnumerable&lt;T&gt;](/dotnet/api/system.collections.generic.ienumerable-1?view=dotnet-uwp-10.0&preserve-view=true) (.NET) / [IIterable&lt;T&gt;](/uwp/api/windows.foundation.collections.iiterable_t_)

  - Can be used for small, static data sets.

    At a minimum, the data source must implement the IEnumerable / IIterable interface. If this is all that's supported then the control will iterate through everything once to create a copy that it can use to access items via an index value.

- [IReadonlyList&lt;T&gt;](/dotnet/api/system.collections.generic.ireadonlylist-1?view=dotnet-uwp-10.0&preserve-view=true) (.NET) / [IVectorView&lt;T&gt;](/uwp/api/windows.foundation.collections.ivectorview_t_)

  - Can be used for static, read-only data sets.

    Enables the control to access items by index and avoids the redundant internal copy.

- [IList&lt;T&gt;](/dotnet/api/system.collections.generic.ilist-1?view=dotnet-uwp-10.0&preserve-view=true) (.NET) / [IVector&lt;T&gt;](/uwp/api/windows.foundation.collections.ivector_t_)

  - Can be used for static data sets.

    Enables the control to access items by index and avoids the redundant internal copy.

    **Warning**:
    Changes to the list/vector without implementing [INotifyCollectionChanged](/dotnet/api/system.collections.specialized.inotifycollectionchanged?view=dotnet-uwp-10.0&preserve-view=true) won't be reflected in the UI.

- [INotifyCollectionChanged](/dotnet/api/system.collections.specialized.inotifycollectionchanged?view=dotnet-uwp-10.0&preserve-view=true) (.NET)

  - Recommended to support change notification.

    Enables the control to observe and react to changes in the data source and reflect those changes in the UI.

- [IObservableVector&lt;T&gt;](/uwp/api/windows.foundation.collections.iobservablevector_t_)

  - Supports change notification

    Like the **INotifyCollectionChanged** interface, this enables the control to observe and react to changes in the data source.

    **Warning**:
    The Windows.Foundation.IObservableVector\<T> doesn't support a 'Move' action. This can cause the UI for an item to lose its visual state.  For example, an item that is currently selected and/or has focus where the move is achieved by a 'Remove' followed by an 'Add' will lose focus and no longer be selected.

    The Platform.Collections.Vector\<T> uses IObservableVector\<T> and has this same limitation. If support for a 'Move' action is required then use the **INotifyCollectionChanged** interface.  The .NET ObservableCollection\<T> class uses **INotifyCollectionChanged**.

- [IKeyIndexMapping](ikeyindexmapping.md)

  - When a unique identifier can be associated with each item.  Recommended when using 'Reset' as the collection change action.

    Enables the control to very efficiently recover the existing UI after receiving a hard 'Reset' action as part of an **INotifyCollectionChanged** or **IObservableVector** event. After receiving a reset the control will use the provided unique ID to associate the current data with elements it had already created. Without the key to index mapping the control would have to assume it needs to start over from scratch in creating UI for the data.

The interfaces listed above, other than IKeyIndexMapping, provide the same behavior in ItemsRepeater as they do in ListView and GridView.

The following interfaces on an ItemsSource enable special functionality in the ListView and GridView controls, but currently have no effect on an ItemsRepeater:

- [ISupportIncrementalLoading](/uwp/api/windows.ui.xaml.data.isupportincrementalloading)
- [IItemsRangeInfo](/uwp/api/windows.ui.xaml.data.iitemsrangeinfo)
- [ISelectionInfo](/uwp/api/windows.ui.xaml.data.iselectioninfo)

## -see-also

## -examples

