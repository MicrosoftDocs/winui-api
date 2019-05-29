---
-api-id: P:Microsoft.UI.Xaml.Controls.PathIconSource.Data
-api-type: winrt property
ms.custom: RS5
---
<!-- Property syntax.
public Geometry Data { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.PathIconSource.Data



## -description

Gets or sets a [Geometry](/uwp/api/windows.ui.xaml.media.geometry) that specifies the shape to be drawn. In XAML. this can also be set using a string that describes [Move and draw commands syntax](https://docs.microsoft.com/windows/uwp/xaml-platform/move-draw-commands-syntax).



## -property-value

A description of the shape to be drawn.



## -remarks



## -see-also



## -examples



## -xaml-syntax

```xaml
<PathIconSource>
  <PathIconSource.Data>
    singleGeometry
  </PathIconSource.Data>
</PathIconSource>
```

```xaml
<PathIconSource Data="moveAndDrawCommands"/>
```



## -xaml-values

<dl><dt>singleGeometry</dt><dd>singleGeometryA single object element that derives from Geometry. This can be one of the following: One of the simple geometries EllipseGeometry, LineGeometry, or RectangleGeometry.A single GeometryGroup, which supports other geometries as child elements. A PathGeometry, which supports child object elements that establish a path geometry object model of figures and segments. See the "XAML Values" section of PathGeometry.</dd>
<dt>moveAndDrawCommands</dt><dd>moveAndDrawCommandsThis is a complex syntax that cannot be adequately summarized here. See Move and draw commands syntax.</dd>
</dl>



