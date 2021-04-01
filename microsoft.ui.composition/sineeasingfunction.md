---
-api-id: T:Microsoft.UI.Composition.SineEasingFunction
-api-type: winrt class
---

# Microsoft.UI.Composition.SineEasingFunction

<!--
public sealed class SineEasingFunction : Microsoft.UI.Composition.CompositionEasingFunction
-->


## -description

Represents an easing function that creates an animation that accelerates and/or decelerates using a sine formula.

## -remarks

You can control when the animation accelerates, decelerates or both by specifying the [Mode](sineeasingfunction_mode.md) property value on an animation. The following graph demonstrates the different values of `Mode`, where _f(t)_ represents the animation progress and _t_ represents time.

<img alt="Graphs that show the effect of different mode values" src="images/sineease-graph.png"/>

The formula used for this function is the following.

<img alt="SineEase formula" src="images/sine-formula.png"/>

There are several other easing functions besides `SineEasingFunction`. In addition to using the easing functions included in the run-time, you can create your own custom easing functions by inheriting from [CompositionEasingFunction](compositioneasingfunction.md).

## -see-also

## -examples


