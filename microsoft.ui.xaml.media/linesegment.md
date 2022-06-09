---
-api-id: T:Microsoft.UI.Xaml.Media.LineSegment
-api-type: winrt class
---

<!-- Class syntax.
public class LineSegment : Windows.UI.Xaml.Media.PathSegment, Windows.UI.Xaml.Media.ILineSegment
-->

# Microsoft.UI.Xaml.Media.LineSegment

## -description
Represents a line drawn between two points, which can be part of a [PathFigure](pathfigure.md) within [Path](../microsoft.ui.xaml.shapes/path.md) data.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
<LineSegment .../>
```


## -remarks

## -examples
This example creates a simple [PathGeometry](pathgeometry.md) made up of a single [PathFigure](pathfigure.md) with a LineSegment and displays it using a [Path](../microsoft.ui.xaml.shapes/path.md) element. The [PathFigure](pathfigure.md) object's [StartPoint](pathfigure_startpoint.md) is set to `(10,20)` and a LineSegment is defined with an end point of `(100,130)`.



[!code-xaml[GeometryOvw5](../microsoft.ui.xaml/code/geometries_snip/csharp/GeometryOvw5.xaml#SnippetGeometryOvw5)]

## -see-also
[PathSegment](pathsegment.md), [Path](../microsoft.ui.xaml.shapes/path.md), [PathGeometry](pathgeometry.md), [XAML vector-based drawing sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/XAML%20vector-based%20drawing%20sample), [Draw shapes](/windows/uwp/graphics/drawing-shapes)
