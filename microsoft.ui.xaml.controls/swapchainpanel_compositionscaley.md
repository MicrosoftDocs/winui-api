---
-api-id: P:Microsoft.UI.Xaml.Controls.SwapChainPanel.CompositionScaleY
-api-type: winrt property
---

<!-- Property syntax
public float CompositionScaleY { get; }
-->

# Microsoft.UI.Xaml.Controls.SwapChainPanel.CompositionScaleY

## -description
Gets the y-axis scale factor of the [SwapChainPanel](swapchainpanel.md).

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -property-value
The y-axis scale factor of the [SwapChainPanel](swapchainpanel.md). A value of 1.0 means no scaling is applied.

## -remarks
The CompositionScaleY scale factor is applied to the swap chain content when it's rendered to the screen and composited into the XAML content. The scale factor is derived from calculating the render transformations (implicit or explicit) applied to the [SwapChainPanel](swapchainpanel.md) and its ancestors.

The scale factor will be an estimate if a [Projection](../microsoft.ui.xaml/uielement_projection.md) property value is present on the [SwapChainPanel](swapchainpanel.md) or one of its ancestors.

Check this property any time you are handling [CompositionScaleChanged](swapchainpanel_compositionscalechanged.md) ([CompositionScaleChanged](swapchainpanel_compositionscalechanged.md) doesn't have event data, but if it fires it means that [CompositionScaleX](swapchainpanel_compositionscalex.md), CompositionScaleY, or both have changed values on this [SwapChainPanel](swapchainpanel.md)).

## -examples

## -see-also
[CompositionScaleChanged](swapchainpanel_compositionscalechanged.md)
