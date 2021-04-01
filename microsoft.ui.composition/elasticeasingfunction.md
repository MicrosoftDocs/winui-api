---
-api-id: T:Microsoft.UI.Composition.ElasticEasingFunction
-api-type: winrt class
---

# Microsoft.UI.Composition.ElasticEasingFunction

<!--
public sealed class ElasticEasingFunction : Microsoft.UI.Composition.CompositionEasingFunction
-->


## -description

Represents an easing function that creates an animation that resembles a spring oscillating back and forth until it comes to rest.

## -remarks

You can control when in the "spring" behavior occurs in an animation by specifying the [Mode](elasticeasingfunction_mode.md) property value on an animation. The following graph demonstrates the different values of `Mode`, where _f(t)_ represents the animation progress and _t_ represents time.

<img alt="Graphs that show the effect of different mode values" src="images/elasticease-graph.png"/>

You can specify how many times the animation oscillates back and forth using the [Oscillations](elasticeasingfunction_oscillations.md) property and how tight the springiness of the oscillations are using the [Springiness](elasticeasingfunction_springiness.md) property.

> [!NOTE]
> Because this animation causes values to oscillate back and forth, the animation might interpolate into negative numbers unexpectedly. This can cause errors when animating properties that do not allow negative numbers. For example, if you apply this animation to the `Height` of an object (e.g. from 0 to 200 with a `Mode` of `EaseIn`), the animation will attempt to interpolate through negative numbers for `Height` which will throw an error.

There are several other easing functions besides `ElasticEasingFunction`. In addition to using the easing functions included in the run-time, you can create your own custom easing functions by inheriting from [CompositionEasingFunction](compositioneasingfunction.md).

## -see-also

## -examples


