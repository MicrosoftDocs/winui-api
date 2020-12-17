---
-api-id: T:Microsoft.UI.Xaml.Media.Animation.DoubleAnimation
-api-type: winrt class
---

<!-- Class syntax.
public class DoubleAnimation : Windows.UI.Xaml.Media.Animation.Timeline, Windows.UI.Xaml.Media.Animation.IDoubleAnimation
-->

# Microsoft.UI.Xaml.Media.Animation.DoubleAnimation

## -description
Animates the value of a [Double](/dotnet/api/system.double?view=dotnet-uwp-10.0&preserve-view=true) property between two target values using linear interpolation over a specified [Duration](timeline_duration.md).

## -xaml-syntax
```xaml
<DoubleAnimation />
```


## -remarks
Use DoubleAnimation to animate the property value of any dependency property that is of type [Double](/dotnet/api/system.double?view=dotnet-uwp-10.0&preserve-view=true).

Sometimes you'll need to use indirect property targeting in order to target a sub-property of another object that's the value of a property on the target. For example, in order to animate the X component of a [RenderTransform](../microsoft.ui.xaml/uielement_rendertransform.md) of a [UIElement](../microsoft.ui.xaml/uielement.md), you need to reference some of the intermediate object-property values, until the last step in the indirect property path is truly a [Double](/dotnet/api/system.double?view=dotnet-uwp-10.0&preserve-view=true) value, as is the case with [TranslateTransform.X](../microsoft.ui.xaml.media/translatetransform_x.md). The correct string to use for [Storyboard.TargetProperty](/windows/winui/api/microsoft.ui.xaml.media.animation.storyboard#xaml-attached-properties) in this example is "(UIElement.RenderTransform).(TranslateTransform.X)". For more info on indirect property targeting and other storyboarded animation concepts, see [Storyboarded animations](/windows/uwp/graphics/storyboarded-animations).

A DoubleAnimation typically has at least one of the [From](doubleanimation_from.md), [By](doubleanimation_by.md) or [To](doubleanimation_to.md) properties set, but never all three.
+ **From only:** The animation progresses from the value specified by the **From** property to the base value of the property being animated.
+ **From and To:** The animation progresses from the value specified by the **From** property to the value specified by the **To** property.
+ **From and By:** The animation progresses from the value specified by the **From** property to the value specified by the sum of the **From** and **By** properties.
+ **To only:** The animation progresses from the animated property's base value or a previous animation's output value to the value specified by the **To** property.
+ **By only:** The animation progresses from the base value of the property being animated or a previous animation's output value to the sum of that value and the value specified by the **By** property.


You can't animate the **X** and **Y** values of a [Point](/uwp/api/windows.foundation.point) using a DoubleAnimation, because these properties aren't dependency properties ([Point](/uwp/api/windows.foundation.point) is a structure and can't have dependency properties.) Instead, use [PointAnimation](pointanimation.md) to animate dependency properties that have a [Point](/uwp/api/windows.foundation.point) value.

You also can't use DoubleAnimation to animate **int** values or **byte** values. Instead, you'll have to use [ObjectAnimationUsingKeyFrames](objectanimationusingkeyframes.md), which won't give you an interpolation behavior, so you might need to define multiple keyframes to get a reasonably smooth animation. There aren't many UI-related dependency properties that use **int** values or **byte** values, so this shouldn't be a common scenario other than for custom properties.

The [From](doubleanimation_from.md), [By](doubleanimation_by.md) or [To](doubleanimation_to.md) properties of a DoubleAnimation aren't strictly a [Double](/dotnet/api/system.double?view=dotnet-uwp-10.0&preserve-view=true). Instead these are a [Nullable](/dotnet/api/system.nullable-1) for [Double](/dotnet/api/system.double?view=dotnet-uwp-10.0&preserve-view=true). The default value for these is **null**, not 0. That **null** value is how the animation system distinguishes that you haven't specifically set a value. Visual C++ component extensions (C++/CX) doesn't have a [Nullable](/dotnet/api/system.nullable-1?view=dotnet-uwp-10.0&preserve-view=true) type, so it uses [IReference](/uwp/api/windows.foundation.ireference`1) instead.

## -examples
The following example shows how to use **DoubleAnimation** to create a rectangle that fades in and out of view after it is loaded.



[!code-xaml[Doubleanimation](../microsoft.ui.xaml.media.animation/code/doubleanimation/csharp/Page.xaml#SnippetDoubleanimation)]

[!code-csharp[Doubleanimation_cs](../microsoft.ui.xaml.media.animation/code/doubleanimation/csharp/Page.xaml.cs#SnippetDoubleanimation_cs)]

[!code-vb[Doubleanimation_cs](../microsoft.ui.xaml.media.animation/code/doubleanimation/vbnet/Page.xaml.vb#SnippetDoubleanimation_cs)]

[!code-xaml[Doubleanimation](../microsoft.ui.xaml.media.animation/code/doubleanimationusingkeyframes/csharp/Page.xaml#SnippetDoubleanimationUsingKeyFrames)]


[!code-csharp[Doubleanimation](../microsoft.ui.xaml.media.animation/code/doubleanimationusingkeyframes2/csharp/Page.xaml.cs#SnippetDoubleanimationUsingKeyframes2)]

[!code-vb[Doubleanimation](../microsoft.ui.xaml.media.animation/code/doubleanimationusingkeyframes2/vbnet/Page.xaml.vb#SnippetDoubleanimationUsingKeyframes2)]



## -see-also
[Storyboarded animations](/windows/uwp/graphics/storyboarded-animations), [XAML animation sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/XAML%20animation%20library%20sample), [Timeline](timeline.md), [DoubleAnimationUsingKeyFrames](doubleanimationusingkeyframes.md), [Double](/dotnet/api/system.double?view=dotnet-uwp-10.0&preserve-view=true)
md), [Double](/dotnet/api/system.double?view=dotnet-uwp-10.0&preserve-view=true)
