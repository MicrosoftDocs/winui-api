---
-api-id: T:Microsoft.UI.Composition.ExponentialEasingFunction
-api-type: winrt class
---

# Microsoft.UI.Composition.ExponentialEasingFunction

<!--
public sealed class ExponentialEasingFunction : Microsoft.UI.Composition.CompositionEasingFunction
-->


## -description

Represents an easing function that creates an animation that accelerates and/or decelerates using an exponential formula.

## -remarks

You can control whether the animation accelerates, decelerates or both by specifying the [Mode](exponentialeasingfunction_mode.md) property value on an animation. The following graph demonstrates the different values of `Mode`, where _f(t)_ represents the animation progress and _t_ represents time.

<img alt="Graphs that show the effect of different mode values" src="images/exponentialease-graph.png"/>

The formula used for this function is the following.

<img alt="Mathematical formula for ExponentialEasingFunction" src="images/exponentialease-formula.png"/>

Using the formula above, the following graph illustrates the effect of several different values for the Exponent property:

<img alt="Graph showing exponential ease for three Exponent values" src="images/expo-easeproperty.png"/>

There are several other easing functions besides `ExponentialEasingFunction`. In addition to using the easing functions included in the run-time, you can create your own custom easing functions by inheriting from [CompositionEasingFunction](compositioneasingfunction.md).

## -see-also

## -examples


