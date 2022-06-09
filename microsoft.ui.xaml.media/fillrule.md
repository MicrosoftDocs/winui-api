---
-api-id: T:Microsoft.UI.Xaml.Media.FillRule
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Xaml.Media.FillRule : int
-->

# FillRule

## -description
Specifies how the intersecting areas of [PathFigure](pathfigure.md) objects contained in a [Geometry](geometry.md) are combined to form the area of the [Geometry](geometry.md).

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
<object property="enumMemberName"/>
```


## -enum-fields
### -field EvenOdd:0
Rule that determines whether a point is in the fill region by drawing a ray from that point to infinity in any direction and counting the number of path segments within the given shape that the ray crosses. If this number is odd, the point is inside; if even, the point is outside.

### -field Nonzero:1
Rule that determines whether a point is in the fill region of the path by drawing a ray from that point to infinity in any direction and then examining the places where a segment of the shape crosses the ray. Starting with a count of zero, add one each time a segment crosses the ray from left to right and subtract one each time a path segment crosses the ray from right to left. After counting the crossings, if the result is zero then the point is outside the path. Otherwise, it is inside.


## -remarks

## -examples

## -see-also
