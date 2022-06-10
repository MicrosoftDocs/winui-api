---
-api-id: T:Microsoft.UI.Xaml.Controls.AnimatedVisuals.AnimatedAcceptVisualSource
-api-type: winrt class
---

# Microsoft.UI.Xaml.Controls.AnimatedVisuals.AnimatedAcceptVisualSource

<!--
public sealed class AnimatedAcceptVisualSource : Microsoft.UI.Xaml.Controls.IAnimatedVisualSource2
-->

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -remarks

This can be used as the [Source](../microsoft.ui.xaml.controls/animatedicon_source.md) of an `AnimatedIcon`. It is used by the XAML [CheckBox](../microsoft.ui.xaml.controls/checkbox.md) control.

Supported [IAnimatedVisualSource2.Markers](../microsoft.ui.xaml.controls/ianimatedvisualsource2_markers.md) for [AnimatedIcon.State](../microsoft.ui.xaml.controls/animatedicon_state.md):

- NormalIndeterminate
- NormalOffToNormalOn
- NormalOffToPointerOverOff
- NormalOffToPressedOff
- NormalOnToNormalOff
- NormalOnToPointerOverOn
- NormalOnToPressedOn
- PointerOverIndeterminate
- PointerOverOffToNormalOff
- PointerOverOffToPointerOverOn
- PointerOverOffToPressedOff
- PointerOverOnToNormalOn
- PointerOverOnToPointerOverOff
- PointerOverOnToPressedOn
- PressedIndeterminate
- PressedOffToNormalOn
- PressedOffToPointerOverOn
- PressedOffToPressedOn
- PressedOnToNormalOff
- PressedOnToPointerOverOff
- PressedOnToPressedOff

## -examples

## -see-also

[AnimatedVisualPlayer](../microsoft.ui.xaml.controls/animatedvisualplayer.md), [VisualStateManager](/uwp/api/windows.ui.xaml.visualstatemanager), [Lottie-Windows](/windows/communitytoolkit/animations/lottie), [IAnimatedVisualSource2](../microsoft.ui.xaml.controls/ianimatedvisualsource2.md), [Animated icons overview](/windows/apps/design/controls/animated-icon)
