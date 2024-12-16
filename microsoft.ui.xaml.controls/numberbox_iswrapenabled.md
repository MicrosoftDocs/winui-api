---
-api-id: P:Microsoft.UI.Xaml.Controls.NumberBox.IsWrapEnabled
-api-type: winrt property
---

# Microsoft.UI.Xaml.Controls.NumberBox.IsWrapEnabled

<!--
public bool IsWrapEnabled { get; set; }
-->

## -description

Gets or sets a value that indicates whether line breaking occurs when header text extends beyond the available width of the control.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -property-value

`true` if line breaking occurs when header text extends beyond the available width of the control; otherwise, `false`. The default is `false`.

## -remarks

This property affects only the [Header](numberbox_header.md) text; it doesn't cause [Description](numberbox_description.md) text to wrap.

If you need to wrap `Description` text, you can use a [TextBlock](textblock.md) as the `Description` property value and set it to wrap, like this.

```xaml
xmlns:muxc="using:Microsoft.UI.Xaml.Controls"

<muxc:NumberBox Header="Header" Width="160">
    <muxc:NumberBox.Description>
        <TextBlock Text="This is a long description for NumberBox."
                   TextWrapping="WrapWholeWords"/>
    </muxc:NumberBox.Description>
</muxc:NumberBox>
```

## -see-also

[Number box](/windows/apps/design/controls/number-box)

## -examples
