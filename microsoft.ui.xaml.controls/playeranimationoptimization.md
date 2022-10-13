---
-api-id: T:Microsoft.UI.Xaml.Controls.PlayerAnimationOptimization
-api-type: winrt enum
---

# Microsoft.UI.Xaml.Controls.PlayerAnimationOptimization

<!--
public enum PlayerAnimationOptimization
-->


## -description

Defines constants that specify how an [AnimatedVisualPlayer](AnimatedVisualPlayer.md) caches animations when the player is idle.

## -enum-fields

### -field Latency: 0

The player optimizes animation caching for lower latency.

### -field Resources: 1

The player optimizes animation caching for lower resource usage.

## -remarks

The values of this enumeration are used by the [AnimatedVisualPlayer.AnimationOptimization](animatedvisualplayer_animationoptimization.md) property.

- If you set the property to `Latency`, the `AnimatedVisualPlayer` will pre-create animations even before [PlayAsync](animatedvisualplayer_playasync_539275755.md) is called, and not destroy any when the player is idle. 
- If you set the property to `Resources`, the `AnimatedVisualPlayer` will not create animations until [PlayAsync](animatedvisualplayer_playasync_539275755.md) is called, and will destroy them when it completes.

If you call [Pause](animatedvisualplayer_pause_1953642114.md), this does not free up all resources of the player. To truly stop the animation, call [Stop](animatedvisualplayer_stop_1201535524.md).

## -see-also

[AnimatedVisualPlayer](AnimatedVisualPlayer.md), [AnimatedVisualPlayer.AnimationOptimization](animatedvisualplayer_animationoptimization.md)

## -examples


