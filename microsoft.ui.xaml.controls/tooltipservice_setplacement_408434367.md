---
-api-id: M:Microsoft.UI.Xaml.Controls.ToolTipService.SetPlacement(Microsoft.UI.Xaml.DependencyObject,Microsoft.UI.Xaml.Controls.Primitives.PlacementMode)
-api-type: winrt method
---

<!-- Method syntax
public void SetPlacement(Windows.UI.Xaml.DependencyObject element, Windows.UI.Xaml.Controls.Primitives.PlacementMode value)
-->

# Microsoft.UI.Xaml.Controls.ToolTipService.SetPlacement

## -description
Sets the [ToolTipService.Placement](/windows/winui/api/microsoft.ui.xaml.controls.tooltipservice**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

#xaml-attached-properties) XAML attached property value for the specified target element.

## -parameters
### -param element
The target element for the attached property value.

### -param value
One of the [PlacementMode](../microsoft.ui.xaml.controls.primitives/placementmode.md) values, which specifies where the tooltip should appear relative to the control that is the placement target.

## -remarks
This method supports the [ToolTipService.Placement](/windows/winui/api/microsoft.ui.xaml.controls.tooltipservice#xaml-attached-properties) attached property usage for Extensible Application Markup Language (XAML). The target element is not necessarily a [ToolTip](tooltip.md), it might be an element that owns an inferred tooltip through usage of [ToolTipService](tooltipservice.md) APIs. Also, the target element is not necessarily the final placement target, because that can be reset by setting the [ToolTipService.PlacementTarget](/windows/winui/api/microsoft.ui.xaml.controls.tooltipservice#xaml-attached-properties) attached property.

## -examples

## -see-also
