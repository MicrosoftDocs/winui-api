---
-api-id: P:Microsoft.UI.Xaml.Controls.RadioButtons.MaxColumns
-api-type: winrt property
---

# Microsoft.UI.Xaml.Controls.RadioButtons.MaxColumns

<!--
public int MaxColumns { get; set; }
-->

## -description

Gets or sets the maximum number of columns the radio buttons are arranged in.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -property-value

The maximum number of columns the radio buttons are arranged in. The default is 1.

## -remarks

> For more info, design guidance, and code examples, see [Radio buttons](/windows/apps/design/controls/radio-button).

By default, the `RadioButtons` control arranges its radio buttons vertically in a single column. You can set the `MaxColumns` property to make the control arrange the radio buttons in multiple columns. (When you do this, they are laid out in column-major order, where items fill in from top to bottom, then left to right.)

To have items arranged in a single horizontal row, set `MaxColumns` equal to the number of items in the group.

## -see-also

[RadioButtons](radiobuttons.md)

## -examples

```xaml
<!-- xmlns:muxc="using:Microsoft.UI.Xaml.Controls -->
<muxc:RadioButtons Header="Options" MaxColumns="3">
    <x:String>Item 1</x:String>
    <x:String>Item 2</x:String>
    <x:String>Item 3</x:String>
    <x:String>Item 4</x:String>
    <x:String>Item 5</x:String>
    <x:String>Item 6</x:String>
</muxc:RadioButtons>
```

![Six radio buttons arranged in three columns](images/radiobuttons/radiobuttons-multi-column.png)
