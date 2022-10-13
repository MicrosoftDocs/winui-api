---
-api-id: P:Microsoft.UI.Xaml.Controls.AnimatedVisualPlayer.AnimationOptimization
-api-type: winrt property
---

# Microsoft.UI.Xaml.Controls.AnimatedVisualPlayer.AnimationOptimization

<!--
public Microsoft.UI.Xaml.Controls.PlayerAnimationOptimization AnimationOptimization { get; set; }
-->


## -description
Gets or sets a value that specifies how animations are cached when the `AnimatedVisualPlayer` is idle (when `PlayAsync` is not active).


## -property-value
A value that specifies how animations are cached when the `AnimatedVisualPlayer` is idle (when `PlayAsync` is not active). The default is `Latency`.

## -remarks
If you set the `Source` or `AnimationOptimization` of your player, the player will defer processing of the source file until the layout is being processed.

## -see-also
[AnimatedVisualPlayer](AnimatedVisualPlayer.md), [PlayerAnimationOptimization](playeranimationoptimization.md), [Lottie-Windows](https://aka.ms/lottie), [Tutorials with code examples](https://aka.ms/lottiedocs#tutorials)

## -examples

If you have an animation that starts on a click, initialize the property to `Resources`. Then, set `AnimationOptimization` to `Latency` when the mouse enters the control and back to `Resources` when the mouse leaves the control. This ensures that the animation starts immediately on click without using resources unnecessarily.

If you call PlayAsync before animations are loaded, then the player won't start until all animations are loaded completely.

```c#
private void Player_PointerEntered(object sender, PointerRoutedEventArgs e)
{
    myanimatedvisualplayer.AnimationOptimization = AnimationOptimization.Latency;
}
async private void Player_PointerExited(object sender, PointerRoutedEventArgs e)
{              
    myanimatedvisualplayer.AnimationOptimization = AnimationOptimization.Resources;
}
async private void Player_OnClick(object sender, PointerRoutedEventArgs e)
{              
    myanimatedvisualplayer.PlayAsync(0.0, 1.0);
}
```
