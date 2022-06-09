---
-api-id: T:Microsoft.UI.Xaml.Media.ElementCompositeMode
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Xaml.Media.ElementCompositeMode : int
-->

# ElementCompositeMode

## -description

Specifies values for the alternate composition and blending modes of elements in mixed XAML/Microsoft DirectX UI.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -enum-fields

### -field Inherit:0

Uses values from successive parents in the visual tree. This is the default.

### -field SourceOver:1

Uses standard XAML source-over-destination mode. This corresponds to [D2D1_PRIMITIVE_BLEND_SOURCE_OVER](/windows/desktop/api/d2d1_1/ne-d2d1_1-d2d1_primitive_blend).

### -field MinBlend:2

Uses the minimum of the source and destination value for each pixel. This corresponds to [D2D1_PRIMITIVE_BLEND_MIN](/windows/desktop/api/d2d1_1/ne-d2d1_1-d2d1_primitive_blend).

## -remarks

## -examples

## -see-also

[UIElement.CompositeMode property](../microsoft.ui.xaml/uielement_compositemode.md), [SwapChainPanel](../microsoft.ui.xaml.controls/swapchainpanel.md)
