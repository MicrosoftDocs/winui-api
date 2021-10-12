---
-api-id: M:Microsoft.UI.Composition.CompositionEasingFunction.CreateElasticEasingFunction(Microsoft.UI.Composition.Compositor,Microsoft.UI.Composition.CompositionEasingFunctionMode,System.Int32,System.Single)
-api-type: winrt method
---

# Microsoft.UI.Composition.CompositionEasingFunction.CreateElasticEasingFunction(Microsoft.UI.Composition.Compositor,Microsoft.UI.Composition.CompositionEasingFunctionMode,System.Int32,System.Single)

<!--
public static Microsoft.UI.Composition.ElasticEasingFunction CreateElasticEasingFunction (Microsoft.UI.Composition.Compositor owner, Microsoft.UI.Composition.CompositionEasingFunctionMode mode, int oscillations, float springiness);
-->


## -description

Creates a new instance of [ElasticEasingFunction](elasticeasingfunction.md).

## -parameters

### -param owner

The compositor used to create the easing function.

### -param mode

A value that specifies how the animation interpolates.

### -param oscillations

The number of times the target slides back and forth over the animation destination.

### -param springiness

The stiffness of the spring. The smaller the _springiness_ value is, the stiffer the spring and the faster the elasticity decreases in intensity over each oscillation.

## -returns

The created `ElasticEasingFunction` object.

## -remarks

## -see-also

[ElasticEasingFunction](elasticeasingfunction.md)

## -examples


