---
-api-id: P:Microsoft.UI.Xaml.Controls.RadioButtons.SelectedIndex
-api-type: winrt property
---

# Microsoft.UI.Xaml.Controls.RadioButtons.SelectedIndex

<!--
public static Windows.UI.Xaml.DependencyProperty SelectedIndex { get; set; }
-->

## -description

Gets or sets the index of the selected radio button.

## -property-value

The index of the selected radio button. The default is -1, which indicates that no radio button is selected.

## -remarks

> For more info, design guidance, and code examples, see [Radio buttons](/windows/apps/design/controls/radio-button).

[SelectedItem](radiobuttons_selecteditem.md) and `SelectedIndex` are synchronized. Changing either property will result in a change to the other. Setting `SelectedIndex` to any value outside the range of the [Items](radiobuttons_items.md) collection results in `SelectedItem` being `null`.

## -see-also

[RadioButtons](radiobuttons.md), [SelectedItem](radiobuttons_selecteditem.md)

## -examples

