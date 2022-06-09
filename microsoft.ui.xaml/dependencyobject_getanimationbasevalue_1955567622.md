---
-api-id: M:Microsoft.UI.Xaml.DependencyObject.GetAnimationBaseValue(Microsoft.UI.Xaml.DependencyProperty)
-api-type: winrt method
---

<!-- Method syntax
public object GetAnimationBaseValue(Windows.UI.Xaml.DependencyProperty dp)
-->

# Microsoft.UI.Xaml.DependencyObject.GetAnimationBaseValue

## -description
Returns any base value established for a dependency property, which would apply in cases where an animation is not active.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -parameters
### -param dp
The identifier for the desired dependency property.

## -returns
The returned base value.

## -remarks
Use GetAnimationBaseValue to get values that might currently be animated but you want to know the value before the animation ran. Note that animations with **HoldEnd** behavior might not have this same value. For more info on the **HoldEnd** concept, see [Storyboarded animations](/windows/uwp/graphics/storyboarded-animations).

Animations that are used for visual states don't have **HoldEnd** behavior but do apply an animated value applied while the state is active. For more info, see [Storyboarded animations for visual states](/previous-versions/windows/apps/jj819808(v=win.10)).

## -examples

## -see-also
[ReadLocalValue](dependencyobject_readlocalvalue_1526948202.md), [Timeline](../microsoft.ui.xaml.media.animation/timeline.md), [Timeline.FillBehavior](../microsoft.ui.xaml.media.animation/timeline_fillbehavior.md), [Dependency properties overview](/windows/uwp/xaml-platform/dependency-properties-overview), [Animations overview](/windows/uwp/graphics/animations-overview), [Storyboarded animations](/windows/uwp/graphics/storyboarded-animations), [Storyboarded animations for visual states](/previous-versions/windows/apps/jj819808(v=win.10))
