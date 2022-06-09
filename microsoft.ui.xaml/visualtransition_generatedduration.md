---
-api-id: P:Microsoft.UI.Xaml.VisualTransition.GeneratedDuration
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Duration GeneratedDuration { get;  set; }
-->

# Microsoft.UI.Xaml.VisualTransition.GeneratedDuration

## -description
Gets or sets the amount of time it takes to move from one state to another, and the time that any implicit transition animations should run as part of the transition behavior.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -xaml-syntax
```xaml
<object GeneratedDuration="duration"/>
```


## -property-value
The amount of time it takes to move from one state to another.

## -remarks
GeneratedDuration is mainly for controlling implicit transitions. If you want your transition animations to be limited only to the specific animations in your [Storyboard](../microsoft.ui.xaml.media.animation/storyboard.md), you don't to set a value for GeneratedDuration. Instead, set specific [Duration](duration.md) values on the animations in the [Storyboard](../microsoft.ui.xaml.media.animation/storyboard.md) or the main [Storyboard](../microsoft.ui.xaml.media.animation/storyboard.md) element within it. If you do set a GeneratedDuration value, it won't truncate or change any [Storyboard](../microsoft.ui.xaml.media.animation/storyboard.md) with a [Duration](../microsoft.ui.xaml.media.animation/timeline_duration.md) value; the total length of the transition is the longest [Duration](../microsoft.ui.xaml.media.animation/timeline_duration.md) value that you've set in the animations for [Storyboard](../microsoft.ui.xaml.media.animation/storyboard.md), or the GeneratedDuration, whichever is longer.

### Implicit transitions

You can define a [VisualTransition](visualtransition.md) such that it has a GeneratedDuration, but does not have any specific dependency properties being targeted and animated in its [Storyboard](visualtransition_storyboard.md) value. This creates an implicit transition. Any dependency property that is specifically targeted for animation in either the [From](visualtransition_from.md) or [To](visualtransition_to.md) visual states and thus has different values across the state change will use a generated transition animation. This generated animation transitions between the [From](visualtransition_from.md) state value and the [To](visualtransition_to.md) state value using interpolation, and lasts for the time stated by GeneratedDuration. This only works if there can be a [DoubleAnimation](../microsoft.ui.xaml.media.animation/doubleanimation.md), [PointAnimation](../microsoft.ui.xaml.media.animation/pointanimation.md) or [ColorAnimation](../microsoft.ui.xaml.media.animation/coloranimation.md) on a dependency property, for more info, see Remarks in [VisualTransition](visualtransition.md).

By default, an implicit transition animation uses linear interpolation to animate a value through the GeneratedDuration. You can change the linear interpolation to an interpolation behavior of your choice by setting [GeneratedEasingFunction](visualtransition_generatedeasingfunction.md) as well as GeneratedDuration on a [VisualTransition](visualtransition.md).



## -examples
This example specifies that the control takes one half second to go into the "PointerOver" state.



[!code-xaml[PointerOverTransition](../microsoft.ui.xaml.data/code/StylingTemplatingOverview/csharp/SkinnedButton.xaml#SnippetPointerOverTransition)]

## -see-also
[GeneratedEasingFunction](visualtransition_generatedeasingfunction.md), [VisualStateManager](visualstatemanager.md), [GoToState](visualstatemanager_gotostate_51722231.md), [Key-frame animations and easing function animations](/windows/uwp/graphics/key-frame-and-easing-function-animations), [Quickstart: Control templates](/previous-versions/windows/apps/hh465374(v=win.10)), [Storyboarded animations](/windows/uwp/graphics/storyboarded-animations), [Storyboarded animations for visual states](/previous-versions/windows/apps/jj819808(v=win.10))
