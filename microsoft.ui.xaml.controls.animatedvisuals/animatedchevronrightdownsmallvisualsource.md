---
-api-id: T:Microsoft.UI.Xaml.Controls.AnimatedVisuals.AnimatedChevronRightDownSmallVisualSource
-api-type: winrt class
---

# Microsoft.UI.Xaml.Controls.AnimatedVisuals.AnimatedChevronRightDownSmallVisualSource

<!--
public sealed class AnimatedChevronRightDownSmallVisualSource : Microsoft.UI.Xaml.Controls.IAnimatedVisualSource2
-->

## -description

Represents an animation for a chevron that rotates from right to down that can be used as an animated icon source.

## -remarks

This can be used as the [Source](../microsoft.ui.xaml.controls/animatedicon_source.md) of an `AnimatedIcon`. It is used by the [TreeView](../microsoft.ui.xaml.controls/treeview.md) control.

Supported [IAnimatedVisualSource2.Markers](../microsoft.ui.xaml.controls/ianimatedvisualsource2_markers.md) for [AnimatedIcon.State](../microsoft.ui.xaml.controls/animatedicon_state.md):

- NormalOffToNormalOn
- NormalOffToPointerOverOff
- NormalOffToPressedOff
- NormalOnToNormalOff
- NormalOnToPointerOverOn
- NormalOnToPressedOn
- PointerOverOffToNormalOff
- PointerOverOffToPointerOverOn
- PointerOverOffToPressedOff
- PointerOverOnToNormalOn
- PointerOverOnToPointerOverOff
- PointerOverOnToPressedOn
- PressedOffToNormalOn
- PressedOffToPointerOverOn
- PressedOffToPressedOn
- PressedOnToNormalOff
- PressedOnToPointerOverOff
- PressedOnToPressedOff

## -examples

## -see-also

[AnimatedVisualPlayer](../microsoft.ui.xaml.controls/animatedvisualplayer.md), [VisualStateManager](/uwp/api/windows.ui.xaml.visualstatemanager), [Lottie-Windows](/windows/communitytoolkit/animations/lottie), [IAnimatedVisualSource2](../microsoft.ui.xaml.controls/ianimatedvisualsource2.md), [Animated icons overview](/windows/apps/design/controls/animated-icon)
