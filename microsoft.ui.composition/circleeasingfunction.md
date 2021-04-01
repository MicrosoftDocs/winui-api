---
-api-id: T:Microsoft.UI.Composition.CircleEasingFunction
-api-type: winrt class
---

# Microsoft.UI.Composition.CircleEasingFunction

<!--
public sealed class CircleEasingFunction : Microsoft.UI.Composition.CompositionEasingFunction
-->


## -description

Represents an easing function that creates an animation that accelerates and/or decelerates using a circular function.

## -remarks

You can control whether the animation accelerates, decelerates, or both by specifying the [Mode](circleeasingfunction_mode.md) property value on an animation. The following graph demonstrates the different values of `Mode`, where _f(t)_ represents the animation progress and _t_ represents time.

<img alt="Graphs that show the effect of different mode values" src="images/circleease-graph.png"/>

The formula used for this function is the following.

<img alt="Mathematical formula for CircleEase" src="images/circleease-formula.png"/>

The valid values for _t_ are -1 <= _t_ <= 1. Values greater than 1 are evaluated as 1, and values less than -1 are evaluated as -1. This means that for values outside this interval, the animation continues, but the easing function pauses when it enters the invalid domain, and it resumes after it leaves the invalid domain.

There are several other easing functions besides `CircleEasingFunction`. In addition to using the easing functions included in the run-time, you can create your own custom easing functions by inheriting from [CompositionEasingFunction](compositioneasingfunction.md).

## -see-also

## -examples


