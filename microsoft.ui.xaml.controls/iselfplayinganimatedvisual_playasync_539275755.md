---
-api-id: M:Microsoft.UI.Xaml.Controls.ISelfPlayingAnimatedVisual.PlayAsync(System.Double,System.Double,System.Boolean)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public IAsyncAction ISelfPlayingAnimatedVisual.PlayAsync(Double fromProgress, Double toProgress, Boolean looped)
-->

# Microsoft.UI.Xaml.Controls.ISelfPlayingAnimatedVisual.PlayAsync

## -description

Starts playing the animated visual. If another play is active, that play will be stopped and this new play will replace it.

## -parameters

### -param fromProgress

The point from which to start the animation, as a value from 0 to 1.

### -param toProgress

The point at which to finish the animation, as a value from 0 to 1.

### -param looped

If **true**, the animation loops continuously between _fromProgress_ and _toProgress_. If **false**, the animation plays once then stops.

## -returns

An async action that is completed when the play is stopped or, if _looped_ is not set, when the play reaches _toProgress_.

## -remarks

If _toProgress_ is less than _fromProgress_, the animated visual will play from _fromProgress_ to the end, then play from the beginning until it reaches _toProgress_. To play an animated visual in reverse, set the playback rate to a negative value.

## -see-also

[SetPlaybackRate](iselfplayinganimatedvisual_setplaybackrate_1805984646.md)

## -examples
