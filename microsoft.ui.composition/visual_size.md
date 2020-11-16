---
-api-id: P:Microsoft.UI.Composition.Visual.Size
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Numerics.Vector2 Size { get;  set; }
-->

# Microsoft.UI.Composition.Visual.Size

## -description
The width and height of the visual. Animatable.

## -property-value
The width and height of the visual.

## -remarks

This property can be animated. Call [CompositionObject.StartAnimation](compositionobject_startanimation_394405412.md) to associate it with a [CompositionAnimation](/windows/uwp/composition/composition-animation).


The effective size of a `Visual` is found by adding it's `Size` to it's [RelativeSizeAdjustment](visual_relativesizeadjustment.md) combined with the effective size of the [Parent](visual_parent.md) `Visual`:

`var Effective_Size = Size + (RelativeSizeAdjustment * Parent.Effective_Size)`.

## -examples
See the code example in [ContainerVisual](containervisual.md).

## -see-also
