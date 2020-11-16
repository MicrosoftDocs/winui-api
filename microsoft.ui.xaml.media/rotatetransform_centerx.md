---
-api-id: P:Microsoft.UI.Xaml.Media.RotateTransform.CenterX
-api-type: winrt property
---

<!-- Property syntax
public double CenterX { get;  set; }
-->

# Microsoft.UI.Xaml.Media.RotateTransform.CenterX

## -description
Gets or sets the x-coordinate of the rotation center point for this transformation.

## -xaml-syntax
```xaml
<RotateTransform CenterX="double"/>
```


## -property-value
The x-coordinate of the center of rotation, in pixels within the transform's frame of reference. The default is 0.

## -remarks
When a [RotateTransform](rotatetransform.md) is applied as the [RenderTransform](../microsoft.ui.xaml/uielement_rendertransform.md) for a [UIElement](../microsoft.ui.xaml/uielement.md), the [RenderTransformOrigin](../microsoft.ui.xaml/uielement_rendertransformorigin.md) can also affect how the transformation behaves. In particular this affects the center point that the [UIElement](../microsoft.ui.xaml/uielement.md) rotates around. For more info, see Remarks in [RotateTransform](rotatetransform.md).

## -examples

## -see-also
