---
-api-id: T:Microsoft.UI.Xaml.Media.RectangleGeometry
-api-type: winrt class
---

<!-- Class syntax.
public class RectangleGeometry : Windows.UI.Xaml.Media.Geometry, Windows.UI.Xaml.Media.IRectangleGeometry
-->

# Microsoft.UI.Xaml.Media.RectangleGeometry

## -description
Describes a two-dimensional rectangular geometry.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -xaml-syntax
```xaml
<RectangleGeometry .../>
```


## -remarks

## -examples
This example shows how to create and render a RectangleGeometry object. The position and dimensions of the rectangle are defined by a [Rect](rectanglegeometry_rect.md) property value, provided as an attribute. The position is (50,50) and the height and width are both 25, which creates a square.



[!code-xaml[GeometryOvw3](../microsoft.ui.xaml/code/geometries_snip/csharp/GeometryOvw3.xaml#SnippetGeometryOvw3)]

## -see-also
[Geometry](geometry.md)
