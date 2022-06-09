---
-api-id: P:Microsoft.UI.Xaml.Controls.ToolTip.IsOpen
-api-type: winrt property
---

<!-- Property syntax
public bool IsOpen { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.ToolTip.IsOpen

## -description
Gets or sets a value that indicates whether the [ToolTip](tooltip.md) is visible.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -property-value
**true** if the [ToolTip](tooltip.md) is visible; otherwise, **false**. The default is **false**.

## -remarks
This property is not typically set in XAML.

A [ToolTip](tooltip.md) must be assigned to another UI element that is its owner. In XAML, use the [ToolTipService.Tooltip](/windows/winui/api/microsoft.ui.xaml.controls.tooltipservice#xaml-attached-properties) attached property to assign the [ToolTip](tooltip.md) to an owner. In code, use the [ToolTipService.SetToolTip](tooltipservice_settooltip_436756233.md) method to assign the [ToolTip](tooltip.md) to an owner. If you set the IsOpen property to **true** in your app code before the [ToolTip](tooltip.md) is assigned to an owner, an exception is thrown.

## -examples

## -see-also
[ToolTipService.Tooltip](/windows/winui/api/microsoft.ui.xaml.controls.tooltipservice#xaml-attached-properties)
