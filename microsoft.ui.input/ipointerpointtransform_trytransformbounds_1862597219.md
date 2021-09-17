---
-api-id: M:Microsoft.UI.Input.IPointerPointTransform.TryTransformBounds(Windows.Foundation.Rect,Windows.Foundation.Rect@)
-api-type: winrt method
---

# Microsoft.UI.Input.IPointerPointTransform.TryTransformBounds(Windows.Foundation.Rect,Windows.Foundation.Rect@)

<!--
public bool TryTransformBounds (Windows.Foundation.Rect inRect, out Windows.Foundation.Rect outRect);
-->

## -description

Transforms the specified bounding rectangle.

## -parameters

### -param inRect

The bounding rectangle to transform.

### -param outRect

The smallest, axis-aligned bounding box that encloses *rect* after the transformation. (An axis-aligned bounding box is one which has all sides parallel to the coordinate axes.)

## -returns

True, if transform was successful. Otherwise, false.

## -remarks

*rect* is typically the [ContactRect](pointerpointproperties_contactrect.md) associated with the input point that is transformed through the [TryTransform](ipointerpointtransform_trytransform_509328310.md) method. *rect* must be recalculated as it does not change with the transformation of the input point.

## -see-also

## -examples
