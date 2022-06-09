---
-api-id: P:Microsoft.UI.Xaml.Controls.ListBox.SelectionMode
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Controls.SelectionMode SelectionMode { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.ListBox.SelectionMode

## -description
Gets or sets the selection behavior for the [ListBox](listbox.md) control.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -xaml-syntax
```xaml
<ListBox SelectionMode="selectionModeValue"/>
```


## -xaml-values
<dl><dt>selectionModeValue</dt><dd>selectionModeValueA named constant of the SelectionMode enumeration, such as Extended.</dd>
</dl>
## -property-value
One of the [SelectionMode](selectionmode.md) values.

## -remarks
By default, a user can select a single item in a [ListBox](listbox.md). You can set the ListBox.SelectionMode property to a [SelectionMode](selectionmode.md) enumeration value to enable multi-selection. Here are the selection mode values.

| Mode | Behavior |
|---|---|
| [Single](selectionmode.md) | A user can select a single item using the space bar, mouse click, or touch tap. A user can deselect an item using a downward swipe gesture.<br/><br/>While pressing Ctrl: a user can deselect the item by using the space bar, mouse click, or touch tap. Using the arrow keys, a user can move focus independently of selection. |
| [Multiple](listviewselectionmode.md) | A user can select multiple items using the space bar, mouse click, or touch tap to toggle selection on the focused item. Using the arrow keys, a user can move focus independently of selection. |
| [Extended](listviewselectionmode.md) | With no modifier keys: the behavior is the same as [Single](listviewselectionmode.md) selection.<br/><br/>While pressing Ctrl: a user can select multiple items using the space bar, mouse click, or touch tap to toggle selection on the focused item. Using the arrow keys, a user can move focus independently of selection.<br/><br/>While pressing Shift: a user can select multiple contiguous items by clicking or tapping the first item in the selection and then the last item in the selection. Using the arrow keys, a user can create a contiguous selection starting with the item selected when Shift is pressed. |

When SelectionMode is **Single**, use the [Selector.SelectedItem](../microsoft.ui.xaml.controls.primitives/selector_selecteditem.md) property to get the item that's selected. When SelectionMode is **Multiple** or **Extended**, use the [SelectedItems](listviewbase_selecteditems.md) property to get the items that are selected.

## -examples

## -see-also
[Selector.SelectedItem](../microsoft.ui.xaml.controls.primitives/selector_selecteditem.md), [SelectedItems](listviewbase_selecteditems.md)
