---
-api-id: P:Microsoft.UI.Xaml.Controls.RadioButtons.SelectedItem
-api-type: winrt property
---

# Microsoft.UI.Xaml.Controls.RadioButtons.SelectedItem

<!--
public object SelectedItem { get; set; }
-->

## -description

Gets or sets the selected radio button.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -property-value

The selected radio button. The default is `null`.

## -remarks

> For more info, design guidance, and code examples, see [Radio buttons](/windows/apps/design/controls/radio-button).

`SelectedItem` and [SelectedIndex](radiobuttons_selectedindex.md) are synchronized. Changing either property will result in a change to the other. Setting `SelectedIndex` to any value outside the range of the [Items](radiobuttons_items.md) collection results in `SelectedItem` being `null`.

## -see-also

[RadioButtons](radiobuttons.md), [SelectedIndex](radiobuttons_selectedindex.md)

## -examples

