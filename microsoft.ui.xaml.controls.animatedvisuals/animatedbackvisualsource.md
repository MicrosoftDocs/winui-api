---
-api-id: T:Microsoft.UI.Xaml.Controls.AnimatedVisuals.AnimatedBackVisualSource
-api-type: winrt class
---

# Microsoft.UI.Xaml.Controls.AnimatedVisuals.AnimatedBackVisualSource

<!--
public sealed class AnimatedBackVisualSource : Microsoft.UI.Xaml.Controls.IAnimatedVisualSource2
-->

## -description

Represents an animation for a back arrow that can be used as an animated icon source.

## -remarks

This can be used as the [Source](../microsoft.ui.xaml.controls/animatedicon_source.md) of an `AnimatedIcon`.

Supported [IAnimatedVisualSource2.Markers](../microsoft.ui.xaml.controls/ianimatedvisualsource2_markers.md) for [AnimatedIcon.State](../microsoft.ui.xaml.controls/animatedicon_state.md):

- NormalToPointerOver  
- NormalToPressed
- PointerOverToNormal  
- PointerOverToPressed
- PressedToNormal
- PressedToPointerOver

## -examples

## -see-also

[AnimatedVisualPlayer](../microsoft.ui.xaml.controls/animatedvisualplayer.md), [VisualStateManager](/uwp/api/windows.ui.xaml.visualstatemanager), [Lottie-Windows](/windows/communitytoolkit/animations/lottie), [IAnimatedVisualSource2](../microsoft.ui.xaml.controls/ianimatedvisualsource2.md), [Animated icons overview](/windows/apps/design/controls/animated-icon)
