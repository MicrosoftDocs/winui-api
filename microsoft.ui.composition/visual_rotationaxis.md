---
-api-id: P:Microsoft.UI.Composition.Visual.RotationAxis
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Numerics.Vector3 RotationAxis { get;  set; }
-->

# Microsoft.UI.Composition.Visual.RotationAxis

## -description
The axis to rotate the visual around. Animatable.

## -property-value
The axis to rotate the visual around. For example, a value of Vector3(1,0,0) indicates rotation along the x-axis.

## -remarks

This property can be animated. Call [CompositionObject.StartAnimation](compositionobject_startanimation_394405412.md) to associate it with a [CompositionAnimation](/windows/uwp/composition/composition-animation).

[Visual](visual.md) supports two forms of rotation, by axis-angle, and by orientation.

## -examples

## -see-also
