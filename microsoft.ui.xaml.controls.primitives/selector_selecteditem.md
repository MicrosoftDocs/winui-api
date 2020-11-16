---
-api-id: P:Microsoft.UI.Xaml.Controls.Primitives.Selector.SelectedItem
-api-type: winrt property
---

<!-- Property syntax
public object SelectedItem { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.Primitives.Selector.SelectedItem

## -description
Gets or sets the selected item.

## -xaml-syntax
```xaml
<selector SelectedItem="bindingReference" .../>
```


## -xaml-values
<dl><dt>bindingReference</dt><dd>bindingReferenceA data binding reference to a specific item from the data collection that populates the selector control. Usually the list as a whole is bound to a data context, and the binding for the selected item adds a path or qualifier to return just one item.</dd>
</dl>
## -property-value
The selected item. The default is null.

## -remarks
Some controls that are derived from [Selector](selector.md), like [ListBox](../microsoft.ui.xaml.controls/listbox.md), [ListView](../microsoft.ui.xaml.controls/listview.md), and [GridView](../microsoft.ui.xaml.controls/gridview.md), also support multi-selection. When multi-selection is enabled in those controls, use their [SelectedItems](../microsoft.ui.xaml.controls/listviewbase_selecteditems.md) property to get the selected item collection.

### Selection behavior and CollectionViewSource

List controls that derive from [Selector](selector.md) have a default selection behavior that depends on what the items source is (the type that's used for [ItemsSource](../microsoft.ui.xaml.controls/itemscontrol_itemssource.md)). If the items source is a [CollectionViewSource](../microsoft.ui.xaml.data/collectionviewsource.md) instance, then the behavior in the selection control is that the selection will default to the current item. When the list is first displayed, the selection defaults to the first item as current item. If you don't want the first item to be selected in this case, set [IsSynchronizedWithCurrentItem](selector_issynchronizedwithcurrentitem.md) to **false** in the [GridView](../microsoft.ui.xaml.controls/gridview.md), the [ListView](../microsoft.ui.xaml.controls/listview.md), or other [Selector](selector.md)-based control that is showing the selection.

## -examples

## -see-also
[ListBox.SelectionMode](../microsoft.ui.xaml.controls/listbox_selectionmode.md), [ListBox.SelectedItems](../microsoft.ui.xaml.controls/listbox_selecteditems.md), [ListViewBase.SelectionMode](../microsoft.ui.xaml.controls/listviewbase_selectionmode.md), [ListViewBase.SelectedItems](../microsoft.ui.xaml.controls/listviewbase_selecteditems.md)
