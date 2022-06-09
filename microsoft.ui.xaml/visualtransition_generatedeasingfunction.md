---
-api-id: P:Microsoft.UI.Xaml.VisualTransition.GeneratedEasingFunction
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Media.Animation.EasingFunctionBase GeneratedEasingFunction { get;  set; }
-->

# Microsoft.UI.Xaml.VisualTransition.GeneratedEasingFunction

## -description
Gets or sets the easing function applied to the generated animations.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -property-value
An easing function implementation that is applied to the generated animations.

## -remarks
A [VisualTransition](visualtransition.md) typically uses a linear interpolation to control the implicit transition animations that happen over the [GeneratedDuration](visualtransition_generatedduration.md). Setting a value for GeneratedEasingFunction changes this linear behavior and instead applies the timing logic of a particular [EasingFunctionBase](../microsoft.ui.xaml.media.animation/easingfunctionbase.md) derived class to the interpolation. For example, if you wanted an interpolation rate to start off slowly and reach the **To** value rapidly at the end of the transition's duration, you might set GeneratedEasingFunction using a [PowerEase](../microsoft.ui.xaml.media.animation/powerease.md) with [EasingMode.EaseIn](../microsoft.ui.xaml.media.animation/easingmode.md).

## -examples
This XAML example shows the markup for applying a [QuadraticEase](../microsoft.ui.xaml.media.animation/quadraticease.md) easing function to the interpolation of implicit transition animations during the transition. Setting the [EasingMode](../microsoft.ui.xaml.media.animation/easingfunctionbase_easingmode.md) is important if you don't want the default easing mode for all easing functions, which is [EasingMode.EaseIn](../microsoft.ui.xaml.media.animation/easingmode.md).

```xaml

<!--template root-->
<VisualStateManager.VisualStateGroups>
  <VisualStateGroup x:Name="States">
    <VisualState x:Name="FirstState">
       <!--state logic omitted-->
    </VisualState>
    <VisualState x:Name="SecondState">
       <!--state logic omitted-->
    </VisualState>
    <VisualStateGroup.Transitions>
      <VisualTransition To="SecondState" GeneratedDuration="0:0:10">
        <VisualTransition.GeneratedEasingFunction>
          <QuadraticEase EasingMode="EaseOut"/>
        </VisualTransition.GeneratedEasingFunction>
      </VisualTransition>
    </VisualStateGroup.Transitions>
  </VisualStateGroup>
</VisualStateManager.VisualStateGroups>
```



## -see-also
[Key-frame animations and easing function animations](/windows/uwp/graphics/key-frame-and-easing-function-animations), [Quickstart: Control templates](/previous-versions/windows/apps/hh465374(v=win.10)), [Storyboarded animations](/windows/uwp/graphics/storyboarded-animations), [Storyboarded animations for visual states](/previous-versions/windows/apps/jj819808(v=win.10))
