---
-api-id: T:Microsoft.UI.Xaml.Controls.Primitives.Selector
-api-type: winrt class
---

<!-- Class syntax.
public class Selector : Windows.UI.Xaml.Controls.ItemsControl, Windows.UI.Xaml.Controls.Primitives.ISelector
-->

# Microsoft.UI.Xaml.Controls.Primitives.Selector

## -description
Represents a control that enables a user to select an item from a collection of items.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -remarks

Selector has properties that enable selection of a single item in a collection.

- [SelectedIndex](selector_selectedindex.md): The 0-based index of the selected item. The default is -1, which indicates no item is selected.
- [SelectedItem](selector_selecteditem.md): The selected data item. The default is **null**, which indicates no item is selected.
- [SelectedValue](selector_selectedindex.md): The value of the selected data item, obtained by using the [SelectedValuePath](selector_selectedvaluepath.md).

Some controls that are derived from Selector, like [ListBox](../microsoft.ui.xaml.controls/listbox.md), [ListView](../microsoft.ui.xaml.controls/listview.md), and [GridView](../microsoft.ui.xaml.controls/gridview.md), also support multi-selection. When multi-selection is enabled in those controls, use their [SelectedItems](../microsoft.ui.xaml.controls/listviewbase_selecteditems.md) property to get the selected item collection.

### Selection behavior and CollectionViewSource

List controls that derive from Selector have a default selection behavior that depends on what the items source is (the type that's used for [ItemsSource](../microsoft.ui.xaml.controls/itemscontrol_itemssource.md)). If the items source is a [CollectionViewSource](../microsoft.ui.xaml.data/collectionviewsource.md) instance, then the behavior in the selection control is that the selection will default to the current item. When the list is first displayed, the selection defaults to the first item as current item. If you don't want the first item to be selected in this case, set [IsSynchronizedWithCurrentItem](selector_issynchronizedwithcurrentitem.md) to **false** in the [GridView](../microsoft.ui.xaml.controls/gridview.md), the [ListView](../microsoft.ui.xaml.controls/listview.md), or other Selector-based control that is showing the selection.

### **Selector** derived classes

Selector is the parent class for these controls:
+ [ComboBox](../microsoft.ui.xaml.controls/combobox.md)
+ [FlipView](../microsoft.ui.xaml.controls/flipview.md)
+ [ListBox](../microsoft.ui.xaml.controls/listbox.md)
+ [ListViewBase](../microsoft.ui.xaml.controls/listviewbase.md) (parent of [GridView](../microsoft.ui.xaml.controls/gridview.md) and [ListView](../microsoft.ui.xaml.controls/listview.md))


> [!NOTE]
> [SemanticZoom](../microsoft.ui.xaml.controls/semanticzoom.md) is a similar control but it doesn't enable selection itself. [SemanticZoom](../microsoft.ui.xaml.controls/semanticzoom.md) inherits directly from [Control](../microsoft.ui.xaml.controls/control.md) . A [SemanticZoom](../microsoft.ui.xaml.controls/semanticzoom.md) typically displays one of the Selector derived controls in each of its views.

## -examples

## -see-also
[ItemsControl](../microsoft.ui.xaml.controls/itemscontrol.md), [Adding ListView and GridView controls](/previous-versions/windows/apps/hh780618(v=win.10)), [Adding ListView, SemanticZoom, and other data controls](/previous-versions/windows/apps/hh780615(v=win.10)), [How to add a list box](/previous-versions/windows/apps/hh868196(v=win.10))
