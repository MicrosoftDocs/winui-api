---
-api-id: T:Microsoft.UI.Composition.PowerEasingFunction
-api-type: winrt class
---

# Microsoft.UI.Composition.PowerEasingFunction

<!--
public sealed class PowerEasingFunction : Microsoft.UI.Composition.CompositionEasingFunction
-->


## -description

Represents an easing function that creates an animation that accelerates and/or decelerates using the formula _f_(_t_) = _t_<sup>p</sup> where _p_ is equal to the `Power` property.

## -remarks

You can control whether the animation accelerates, decelerates, or both by specifying the [Mode](powereasingfunction_mode.md) property value on an animation. The following graph demonstrates the different values of `Mode`, where _f(t)_ represents the animation progress and _t_ represents time.

<img alt="Graphs that show the effect of different mode values" src="images/cubicease-graph.png"/>

Using `PowerEasingFunction`, you can specify how quickly acceleration/deceleration takes place by specifying the [Power](powereasingfunction_power.md) property:

_f_(_t_) = _t_<sup>p</sup> where _p_ is equal to the `Power` property.

Because of this, `PowerEasingFunction` can be substituted for a Quadratic easing function (_f_(_t_) = _t_<sup>2</sup>), Cubic easing function (_f_(_t_) = _t_<sup>3</sup>), Quartic easing function (_f_(_t_) = _t_<sup>4</sup>), and Quintic easing function (_f_(_t_) = _t_<sup>5</sup>). For example, if you wanted to use a `PowerEasingFunction` to create the same behavior as a Quadratic easing function (_f_(_t_) = _t_<sup>2</sup>), you would specify a `Power` property value of 2.

There are several other easing functions besides `PowerEasingFunction`. In addition to using the easing functions included in the run-time, you can create your own custom easing functions by inheriting from [CompositionEasingFunction](compositioneasingfunction.md).

## -see-also

## -examples


