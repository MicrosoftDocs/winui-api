---
-api-id: T:Microsoft.UI.Composition.BackEasingFunction
-api-type: winrt class
---

# Microsoft.UI.Composition.BackEasingFunction

<!--
public sealed class BackEasingFunction : Microsoft.UI.Composition.CompositionEasingFunction
-->


## -description

Represents an easing function that retracts the motion of an animation slightly before it begins to animate in the path indicated.

## -remarks

You can control when the "back up" behavior occurs in an animation by specifying the [Mode](backeasingfunction_mode.md) property value on an animation. The following graph demonstrates the different values of `Mode`, where _f(t)_ represents the animation progress and _t_ represents time.

<img alt="Graphs that show the effect of different mode values" src="images/backease-graph.png"/>

The formula used for this function is the following.

<img alt="BackEase formula" src="images/backease-formula.png"/>

> [!NOTE]
> Because this animation causes values to retract before progressing, the animation might interpolate into negative numbers unexpectedly. This can cause errors when animating properties that do not allow negative numbers. For example, if you apply this animation to the `Height` of an object (e.g. from 0 to 200 with a `Mode` of `EaseIn`), the animation will attempt to interpolate through negative numbers for `Height` which will throw an error.

There are several other easing functions besides `BackEasingFunction`. In addition to using the easing functions included in the run-time, you can create your own custom easing functions by inheriting from [CompositionEasingFunction](compositioneasingfunction.md).

## -see-also

## -examples


