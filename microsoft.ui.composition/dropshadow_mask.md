---
-api-id: P:Microsoft.UI.Composition.DropShadow.Mask
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Composition.CompositionBrush Mask { get;  set; }
-->

# Microsoft.UI.Composition.DropShadow.Mask

## -description
Brush used to specify an opacity mask for the shadow. Defaults to the SpriteVisual's brush. Animatable.

## -property-value
Brush used to specify an opacity mask for the shadow. Defaults to the SpriteVisual's brush.

## -remarks
A non-rectangular shadow can be casted by setting the Mask of the Shadow property to a SurfaceBrush that represents the shape.

This property can be animated. Call [CompositionObject.StartAnimation](compositionobject_startanimation_394405412.md) to associate it with a [CompositionAnimation](/windows/uwp/composition/composition-animation).

## -examples

## -see-also
