---
-api-id: P:Microsoft.UI.Xaml.UIElement.Clip
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Media.RectangleGeometry Clip { get;  set; }
-->

# Microsoft.UI.Xaml.UIElement.Clip

## -description
Gets or sets the [RectangleGeometry](../microsoft.ui.xaml.media/rectanglegeometry.md) used to define the outline of the contents of a [UIElement](uielement.md).

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
<uiElement>
  <uiElement.Clip>
    rectangleGeometry
  </uiElement.Clip>
</uiElement>
```


## -property-value
The rectangle geometry to be used for clipping area sizing. The default value is **null** (no clipping).

## -remarks
The clipping geometry for UIElement.Clip in the Windows Runtime  API must be a [RectangleGeometry](../microsoft.ui.xaml.media/rectanglegeometry.md). You can't specify a non-rectangular geometry, as is permitted in some XAML frameworks like Microsoft Silverlight.

The clipped area is the "outside" of the geometry. In other words, the content that is shown (not clipped) is the area of the rectangle that is drawn with [Fill](../microsoft.ui.xaml.shapes/shape_fill.md) if the geometry were used as data for a [Path](../microsoft.ui.xaml.shapes/path.md) rather than for clipping. The clipped area is any area that falls outside the rectangle. The clipped area isn't hit-testable.

## -examples
This example is simple XAML markup that specifies a Clip using an inline [RectangleGeometry](../microsoft.ui.xaml.media/rectanglegeometry.md) that specifies its dimensions through an attribute syntax.



[!code-xaml[GeometryOvw4](../microsoft.ui.xaml/code/geometries_snip/csharp/GeometryOvw4.xaml#SnippetGeometryOvw4)]

## -see-also
