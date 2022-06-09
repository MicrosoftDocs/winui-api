---
-api-id: T:Microsoft.UI.Xaml.Media.PathFigure
-api-type: winrt class
---

<!-- Class syntax.
public class PathFigure : Windows.UI.Xaml.DependencyObject, Windows.UI.Xaml.Media.IPathFigure
-->

# Microsoft.UI.Xaml.Media.PathFigure

## -description
Represents a subsection of a geometry, a single connected series of two-dimensional geometric segments.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
<PathFigure .../>
-or-
<PathFigure ...>
  oneOrMorePathSegments
</PathFigure
```


## -remarks
[PathFigureCollection](pathfigurecollection.md) is a strongly typed collection for PathFigure items. [PathFigureCollection](pathfigurecollection.md) is the type used by the [PathGeometry.Figures](pathgeometry_figures.md) property. In XAML, specify one or more PathFigure elements for this property.

This class is relevant for setting the vector data for either a [Path](../microsoft.ui.xaml.shapes/path.md) or a [PathIcon](../microsoft.ui.xaml.controls/pathicon.md).

Rather than creating an instance or an object element, you can also define segments and a single PathFigure as part of a vector within the string for a [Move and draw commands syntax](/windows/uwp/xaml-platform/move-draw-commands-syntax).

## -examples
This example creates a simple [PathGeometry](pathgeometry.md) made up of a single **PathFigure** with a [LineSegment](linesegment.md) and displays it using a [Path](../microsoft.ui.xaml.shapes/path.md) element. The **PathFigure** object's [StartPoint](pathfigure_startpoint.md) is set to (10,20) and a **LineSegment** is defined with an end point of (100,130).



[!code-xaml[GeometryOvw5](../microsoft.ui.xaml/code/geometries_snip/csharp/GeometryOvw5.xaml#SnippetGeometryOvw5)]



[!code-xaml[GeometryOvw6](../microsoft.ui.xaml/code/geometries_snip/csharp/GeometryOvw6.xaml#SnippetGeometryOvw6)]

 

## -see-also
[DependencyObject](../microsoft.ui.xaml/dependencyobject.md), [PathGeometry](pathgeometry.md), [PathSegment](pathsegment.md), [PathFigureCollection](pathfigurecollection.md), [XAML vector-based drawing sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/XAML%20vector-based%20drawing%20sample), [Draw shapes](/windows/uwp/graphics/drawing-shapes), [Move and draw commands syntax](/windows/uwp/xaml-platform/move-draw-commands-syntax)
