---
-api-id: P:Microsoft.UI.Xaml.UIElement.Projection
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Media.Projection Projection { get;  set; }
-->

# Microsoft.UI.Xaml.UIElement.Projection

## -description
Gets or sets the perspective projection (3-D effect) to apply when rendering this element.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
<uiElement>
  <uiElement.Projection>
    singleProjection
  </uiElement.Projection>
</uiElement>
```


## -xaml-values
<dl><dt>singleProjection</dt><dd>singleProjectionA single object element that defines a specific projection. Typically this is a Matrix3DProjection or PlaneProjection.</dd>
</dl>
## -property-value
A 3-D projection effect applied to the element.
## -remarks
Projection and [RenderTransform](uielement_rendertransform.md) with a [SkewTransform](../microsoft.ui.xaml.media/skewtransform.md) can achieve similar results, a Projection is probably more versatile, especially if you want a sense of perspective change applied to the element.

Projection is the base class type that this property uses, but Projection does not implement a practical behavior. Use either [Matrix3DProjection](../microsoft.ui.xaml.media/matrix3dprojection.md) or [PlaneProjection](../microsoft.ui.xaml.media/planeprojection.md).

The value of Projection is overridden by [PointerDownThemeAnimation](../microsoft.ui.xaml.media.animation/pointerdownthemeanimation.md) and [PointerUpThemeAnimation](../microsoft.ui.xaml.media.animation/pointerupthemeanimation.md).

## -examples
This example shows how to apply a basic [PlaneProjection](../microsoft.ui.xaml.media/planeprojection.md) in the initial page XAML.



[!code-xaml[BasicPerspectiveTransforms](../microsoft.ui.xaml/code/BasicPerspectiveTransforms/csharp/MainPage.xaml#SnippetBasicPerspectiveTransforms)]

## -see-also
[Matrix3DProjection](../microsoft.ui.xaml.media/matrix3dprojection.md), [Matrix3D](../microsoft.ui.xaml.media.media3d/matrix3d.md), [3-D effects for  using XAML](/previous-versions/windows/apps/hh700359(v=win.10)), [XAML two-dimensional transforms sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/XAML%20two-dimensional%20transforms%20sample)
