---
-api-id: M:Microsoft.UI.Xaml.Controls.ToolTipService.SetPlacementTarget(Microsoft.UI.Xaml.DependencyObject,Microsoft.UI.Xaml.UIElement)
-api-type: winrt method
---

<!-- Method syntax
public void SetPlacementTarget(Windows.UI.Xaml.DependencyObject element, Windows.UI.Xaml.UIElement value)
-->

# Microsoft.UI.Xaml.Controls.ToolTipService.SetPlacementTarget

## -description
Sets the [ToolTipService.PlacementTarget](/windows/winui/api/microsoft.ui.xaml.controls.tooltipservice**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

#xaml-attached-properties) XAML attached property value for the specified target element.

## -parameters
### -param element
The target element for the attached property value.

### -param value
The visual element that should be the placement target for the tooltip.

## -remarks
This method supports the [ToolTipService.PlacementTarget](/windows/winui/api/microsoft.ui.xaml.controls.tooltipservice#xaml-attached-properties) attached property usage for Extensible Application Markup Language (XAML). The value for *element* is not necessarily a [ToolTip](tooltip.md), it might be an element that owns an inferred tooltip through usage of [ToolTipService](tooltipservice.md) APIs. You can use the [ToolTipService.PlacementTarget](/windows/winui/api/microsoft.ui.xaml.controls.tooltipservice#xaml-attached-properties) attached property to set the placement target to be different than the element that owns the [ToolTip](tooltip.md) for purposes of UI behavior and built-in [PointerEntered](../microsoft.ui.xaml/uielement_pointerentered.md) / [PointerExited](../microsoft.ui.xaml/uielement_pointerexited.md) handling. This enables controls to act like a unit for tooltip display, so that the tooltip from one control does not obscure an important part of a related control when it displays.

## -examples

## -see-also
