---
-api-id: T:Microsoft.UI.Xaml.Media.LineGeometry
-api-type: winrt class
---

<!-- Class syntax.
public class LineGeometry : Windows.UI.Xaml.Media.Geometry, Windows.UI.Xaml.Media.ILineGeometry
-->

# Microsoft.UI.Xaml.Media.LineGeometry

## -description
Represents the geometry of a line.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -xaml-syntax
```xaml
<LineGeometry .../>
```


## -remarks

## -examples
This example shows how to create and render a LineGeometry object. A [Geometry](geometry.md) object only defines the geometry of the object—it does not render anything directly—so the example uses a [Path](../microsoft.ui.xaml.shapes/path.md) shape to render the line. Because a line has no area, setting the [Fill](../microsoft.ui.xaml.shapes/shape_fill.md) property of the [Path](../microsoft.ui.xaml.shapes/path.md) would have no effect; instead, only the [Stroke](../microsoft.ui.xaml.shapes/shape_stroke.md) and [StrokeThickness](../microsoft.ui.xaml.shapes/shape_strokethickness.md) properties are specified.



[!code-xaml[GeometryOvw1](../microsoft.ui.xaml/code/geometries_snip/csharp/GeometryOvw1.xaml#SnippetGeometryOvw1)]

## -see-also
[Geometry](geometry.md), [LineSegment](linesegment.md), [PolyLineSegment](polylinesegment.md)
