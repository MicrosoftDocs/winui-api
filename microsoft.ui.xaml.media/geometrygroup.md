---
-api-id: T:Microsoft.UI.Xaml.Media.GeometryGroup
-api-type: winrt class
---

<!-- Class syntax.
public class GeometryGroup : Windows.UI.Xaml.Media.Geometry, Windows.UI.Xaml.Media.IGeometryGroup
-->

# Microsoft.UI.Xaml.Media.GeometryGroup

## -description
Represents a composite geometry, composed of other [Geometry](geometry.md) objects.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -xaml-syntax
```xaml
<GeometryGroup>
  oneOrMoreGeometries
</GeometryGroup>
```


## -remarks

## -examples
Composite geometry objects can be created using a GeometryGroup. The GeometryGroup object creates an amalgamation of the [Geometry](geometry.md) objects it contains without combining their area. Any number of [Geometry](geometry.md) objects can be added to a GeometryGroup. This example uses a GeometryGroup to create a composite geometry.



[!code-xaml[GeometryOvw8](../microsoft.ui.xaml/code/geometries_snip/csharp/GeometryOvw8.xaml#SnippetGeometryOvw8)]

## -see-also
[Geometry](geometry.md)
