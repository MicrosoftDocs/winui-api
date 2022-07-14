---
-api-id: P:Microsoft.UI.Xaml.Controls.AnimatedVisualPlayer.AnimationOptimization
-api-type: winrt property
---

# Microsoft.UI.Xaml.Controls.AnimatedVisualPlayer.AnimationOptimization

<!--
public Microsoft.UI.Xaml.Controls.PlayerAnimationOptimization AnimationOptimization { get; set; }
-->


## -description
Gets or sets a value that specifies how animations are cached. 


## -property-value
The property will specify the behavior the AnimatedVisualPlayer will have
when the player is idle (when `PlayAsync` is not active). Defaults to 'Latency'.

|Mode| Behavior|
|---- | -------|
|Latency| AnimatedVisualPlayer will pre-create animations even before `PlayAsync()` is called, and not destroy any when player is idle. |
|Resources | AnimatedVisualPlayer will not create animations until `PlayAsync()` is called,
and will destroy them when it completes. If you call pause, this does not free up all 
resources of the player. To truly stop the animation, call Stop. 

## -remarks
If you set the `Source` or `AnimationOptimization` of your player, the player will defer 
processing of the source file until the layout is being processed.

## -see-also
[AnimatedVisualPlayer](AnimatedVisualPlayer.md), [PlayerAnimationOptimization](playeranimationoptimization.md), [Lottie-Windows](https://aka.ms/lottie), [Tutorials with code examples](https://aka.ms/lottiedocs#tutorials)

## -examples

If you have an animation that will start on click, you may want to initialize 
the property to `Resources` and set `AnimationOptimization` to 'Latency'
when the mouse enters this control, 
and back to `Resources` when mouse leaves to ensure that the animation starts immediately on click,
but don't use up resources otherwise.

Setting the `AnimationOptimization` to `Latency` when the mouse enters the control will ensure that
the animation objects are preloaded so that the animation may start immediately when it needs to play. 

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
