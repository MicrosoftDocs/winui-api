---
-api-id: T:Microsoft.UI.Xaml.Controls.PlayerAnimationOptimization
-api-type: winrt enum
---

# Microsoft.UI.Xaml.Controls.PlayerAnimationOptimization

<!--
public enum PlayerAnimationOptimization
-->


## -description
Specifies settings to optimize an [AnimatedVisualPlayer](AnimatedVisualPlayer.md).  


## -enum-fields
If you set the enum to 'latency', AnimatedVisualPlayer will pre-create animations even before `PlayAsync()` is called,
and not destroy any when player is idle. 

If you set the enum to 'resources', AnimatedVisualPlayer will not create animations until `PlayAsync()` is called,
and will destroy them when it completes. If you call pause, this does not free up all 
resources of the player. To truly stop the animation, call Stop.

### -field Latency: 0

### -field Resources: 1

## -remarks

## -see-also
[AnimatedVisualPlayer](AnimatedVisualPlayer.md)

## -examples


