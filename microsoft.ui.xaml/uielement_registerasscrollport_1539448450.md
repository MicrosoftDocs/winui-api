---
-api-id: M:Microsoft.UI.Xaml.UIElement.RegisterAsScrollPort(Microsoft.UI.Xaml.UIElement)
-api-type: winrt method
---

<!-- Method syntax.
public void UIElement.RegisterAsScrollPort(UIElement element)
-->

# Microsoft.UI.Xaml.UIElement.RegisterAsScrollPort

## -description

Registers an element as representing a scrollable viewport.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -parameters

### -param element

The element to register as a scrollable viewport.

## -remarks

This method informs the framework that the element's applied clip (either due to layout or an explicitly assigned [Clip](uielement_clip.md)) is acting as a viewport and should receive special consideration.

This method is intended for use by custom controls that do not use the platform's native controls to display a scrollable area. For example, a custom scrolling control could be built using [InteractionTracker](../microsoft.ui.composition.interactions/interactiontracker.md).

### Effective Viewport

The [Clip](uielement_clip.md) of the registered element is recognized by the framework as the bounds of a *viewport*, which will be used in calculating the property values for the [EffectiveViewportChanged](frameworkelement_effectiveviewportchanged.md) event.

### System Focus Visuals

By default, the focus visual is fully rendered around the outside of the focused element taking into account all clips. When an element is only partially visible within a viewport the framework needs to disambiguate which clip in the element's ancestor chain represents the viewport. The framework uses this knowledge to correctly apply the viewport clip to the rendered focus visual.

## -see-also

[UseSystemFocusVisuals](/uwp/api/windows.ui.xaml.controls.control.usesystemfocusvisuals), [InteractionTracker](../microsoft.ui.composition.interactions/interactiontracker.md), [EffectiveViewportChanged](frameworkelement_effectiveviewportchanged.md), [InvalidateViewport](frameworkelement_invalidateviewport_528063221.md)

## -examples
