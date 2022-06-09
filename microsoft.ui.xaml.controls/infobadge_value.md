---
-api-id: P:Microsoft.UI.Xaml.Controls.InfoBadge.Value
-api-type: winrt property
---

# Microsoft.UI.Xaml.Controls.InfoBadge.Value

<!--
public int Value { get; set; }
-->

## -description

Gets or sets the integer to be displayed in a numeric [InfoBadge](infobadge.md).

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -property-value

The integer to be displayed in a numeric [InfoBadge](infobadge.md). The defaults is -1.

## -remarks

There is no maximum value for this property, but values must be greater than or equal to zero. Any value less than -1 will result in an argument error. A value of -1 is considered the null value.

The InfoBadge expands to accommodate large numbers. Ensure your layout accounts for this.

## -see-also

[InfoBadge overview](/windows/apps/design/controls/info-badge)

## -examples
