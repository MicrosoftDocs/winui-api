---
-api-id: T:Microsoft.UI.Xaml.Media.PolyLineSegment
-api-type: winrt class
---

<!-- Class syntax.
public class PolyLineSegment : Windows.UI.Xaml.Media.PathSegment, Windows.UI.Xaml.Media.IPolyLineSegment
-->

# Microsoft.UI.Xaml.Media.PolyLineSegment

## -description
Represents a set of line segments defined by a [Point](/uwp/api/windows.foundation.point) collection with each [Point](/uwp/api/windows.foundation.point) specifying the end point of a line segment.

## -xaml-syntax
```xaml
<PolyLineSegment .../>
```


## -remarks

## -examples
This example creates a [PathGeometry](pathgeometry.md) with two [PathFigure](pathfigure.md) objects, each of which contains multiple [PathSegment](pathsegment.md) objects.



[!code-xaml[GeometryOvw7](../microsoft.ui.xaml/code/geometries_snip/csharp/GeometryOvw7.xaml#SnippetGeometryOvw7)]

<img src="images/PolyLineSegment_curves.gif" alt="Various line shapes created by the example" />

## -see-also
[PathSegment](pathsegment.md), [PathFigure](pathfigure.md), [PathGeometry](pathgeometry.md), [Path](../microsoft.ui.xaml.shapes/path.md), [XAML vector-based drawing sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/XAML%20vector-based%20drawing%20sample), [Draw shapes](/windows/uwp/graphics/drawing-shapes)
s.drawing_shapes)
