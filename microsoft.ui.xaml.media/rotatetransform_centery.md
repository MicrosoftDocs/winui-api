---
-api-id: P:Microsoft.UI.Xaml.Media.RotateTransform.CenterY
-api-type: winrt property
---

<!-- Property syntax
public double CenterY { get;  set; }
-->

# Microsoft.UI.Xaml.Media.RotateTransform.CenterY

## -description
Gets or sets the y-coordinate of the rotation center point for this transformation.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
<RotateTransform CenterY="double"/>
```


## -property-value
The y-coordinate of the center of rotation, in pixels within the transform's frame of reference. The default is 0.

## -remarks
When a [RotateTransform](rotatetransform.md) is applied as the [RenderTransform](../microsoft.ui.xaml/uielement_rendertransform.md) for a [UIElement](../microsoft.ui.xaml/uielement.md), the [RenderTransformOrigin](../microsoft.ui.xaml/uielement_rendertransformorigin.md) can also affect how the transformation behaves. In particular this affects the center point that the [UIElement](../microsoft.ui.xaml/uielement.md) rotates around. For more info, see Remarks in [RotateTransform](rotatetransform.md).

## -examples

## -see-also
