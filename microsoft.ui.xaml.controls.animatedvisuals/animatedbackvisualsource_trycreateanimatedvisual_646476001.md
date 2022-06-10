---
-api-id: M:Microsoft.UI.Xaml.Controls.AnimatedVisuals.AnimatedBackVisualSource.TryCreateAnimatedVisual(Windows.UI.Composition.Compositor,System.Object@)
-api-type: winrt method
---

# Microsoft.UI.Xaml.Controls.AnimatedVisuals.AnimatedBackVisualSource.TryCreateAnimatedVisual(Windows.UI.Composition.Compositor,System.Object@)

<!--
public Microsoft.UI.Xaml.Controls.IAnimatedVisual TryCreateAnimatedVisual (Windows.UI.Composition.Compositor compositor, out object diagnostics);
-->

## -description

Attempts to create an instance of an `AnimatedBackVisualSource` object for an [AnimatedIcon](AnimatedIcon.md).

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -parameters

### -param compositor

The [Compositor](../microsoft.ui.composition/compositor.md) used to create objects for the animated visual.

### -param diagnostics

Diagnostics information about the [IAnimatedVisualSource](ianimatedvisualsource.md) result. The type and contents of the object depend on the [IAnimatedVisualSource](ianimatedvisualsource.md) implementation.

This parameter is optional.

## -returns

An [IAnimatedVisual](ianimatedvisual.md), or `null`.

## -remarks

## -see-also

[IAnimatedVisualSource](ianimatedvisualsource.md), [Animated icons guidance](/windows/apps/design/controls/animated-icon)

## -examples
