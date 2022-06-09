---
-api-id: P:Microsoft.UI.Xaml.Media.PolyQuadraticBezierSegment.Points
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Media.PointCollection Points { get;  set; }
-->

# Microsoft.UI.Xaml.Media.PolyQuadraticBezierSegment.Points

## -description
Gets or sets the [Point](/uwp/api/windows.foundation.point) collection that defines this [PolyQuadraticBezierSegment](polyquadraticbeziersegment.md) object.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -xaml-syntax
```xaml
<PolyQuadraticBezierSegment Points="pointSet"/>
```


## -xaml-values
<dl><dt>pointSet</dt><dd>pointSetOne or more Point values with each x-y pair delimited by a single comma and/or one or more spaces. Either space or comma can be the delimiter and they can be used interchangeably. For example, 0,0 100,100, 0,0,100,100, and 0 0 100 100 are all valid and equivalent. The convention is generally to use comma between the X and Y of a Point, and spaces between the x,y pairs.</dd>
</dl>
## -property-value
A collection of points that defines the shape of this [PolyQuadraticBezierSegment](polyquadraticbeziersegment.md) object. The default value is an empty collection.

## -remarks

## -examples
This example creates two curves using a [PolyQuadraticBezierSegment](polyquadraticbeziersegment.md) to specify the coordinates.



[!code-xaml[PolyQuadraticBezierSegment](../microsoft.ui.xaml/code/geometries_snip/csharp/PolyQuadraticBezierSegment.xaml#SnippetPolyQuadraticBezierSegment)]

## -see-also
