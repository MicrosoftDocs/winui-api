---
-api-id: T:Microsoft.UI.Composition.BounceEasingFunction
-api-type: winrt class
---

# Microsoft.UI.Composition.BounceEasingFunction

<!--
public sealed class BounceEasingFunction : Microsoft.UI.Composition.CompositionEasingFunction
-->


## -description

Represents an easing function that creates an animated bouncing effect.

## -remarks

The following graph demonstrates `BounceEase` using different values of [Mode](bounceeasingfunction_mode.md), where _f(t)_ represents the animation progress and _t_ represents time.

<img alt="Graphs that show the effect of different mode values" src="images/bounceease-graph.png"/>

You can specify how many bounces occur using the [Bounces](bounceeasingfunction_bounces.md) property and specify how bouncy (how elastic the bounces are) using the [Bounciness](bounceeasingfunction_bounciness.md) property. The `Bounciness` property specifies the amplitude scaling of the next bounce. For example, a bounciness value of 2 doubles the amplitude of the next bounce during an ease in, and it halves the amplitude of the next bounce during an ease out.

There are several other easing functions besides `BounceEasingFunction`. In addition to using the easing functions included in the run-time, you can create your own custom easing functions by inheriting from [CompositionEasingFunction](compositioneasingfunction.md).

## -see-also

## -examples


