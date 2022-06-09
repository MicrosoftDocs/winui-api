---
-api-id: M:Microsoft.UI.Xaml.Controls.ToolTipService.SetToolTip(Microsoft.UI.Xaml.DependencyObject,System.Object)
-api-type: winrt method
---

<!-- Method syntax
public void SetToolTip(Windows.UI.Xaml.DependencyObject element, System.Object value)
-->

# Microsoft.UI.Xaml.Controls.ToolTipService.SetToolTip

## -description
Sets the value of the [ToolTipService.ToolTip](/windows/winui/api/microsoft.ui.xaml.controls.tooltipservice**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

#xaml-attached-properties) XAML attached property.

## -parameters
### -param element
The object to set tooltip content on.

### -param value
The value to set for tooltip content.

## -remarks
A [ToolTip](tooltip.md) must be assigned to another UI element that is its owner. In Extensible Application Markup Language (XAML), use the [ToolTipService.Tooltip](/windows/winui/api/microsoft.ui.xaml.controls.tooltipservice#xaml-attached-properties) attached property to assign the [ToolTip](tooltip.md) to an owner. In code, use the ToolTipService.SetToolTip method to assign the [ToolTip](tooltip.md) to an owner.

See [ToolTipService.ToolTip](/windows/winui/api/microsoft.ui.xaml.controls.tooltipservice#xaml-attached-properties) or [ToolTip](tooltip.md) to learn more about the object content or text that is appropriate to use as tooltip content.

## -examples

## -see-also
