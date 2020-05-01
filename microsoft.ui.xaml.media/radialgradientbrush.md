---
-api-id: T:Microsoft.UI.Xaml.Media.RadialGradientBrush
-api-type: winrt class
---

# Microsoft.UI.Xaml.Media.RadialGradientBrush

<!--
public class RadialGradientBrush : Windows.UI.Xaml.Media.XamlCompositionBrushBase
-->

## -description

RadialGradientBrush paints an area with a radial gradient. A center point defines the origin of the gradient, and an ellipse defines the outer bounds of the gradient.

## -remarks

### Gradient layout

The gradient is drawn within an ellipse that is defined by the [Center](radialgradientbrush_center.md), [RadiusX](radialgradientbrush_radiusx.md), and [RadiusY](radialgradientbrush_radiusy.md) properties. Colors for the gradient start at the center of the ellipse and end at the radius.

The colors for the radial gradient are defined by color stops added to the [GradientStops](radialgradientbrush_gradientstops.md) collection property. Each gradient stop specifies a color and an offset along the gradient.

The gradient origin defaults to center and can be offset using the [GradientOrigin](radialgradientbrush_gradientorigin.md) property.

[MappingMode](radialgradientbrush_mappingmode.md) defines whether [Center](radialgradientbrush_center.md), [RadiusX](radialgradientbrush_radiusx.md), [RadiusY](radialgradientbrush_radiusy.md) and [GradientOrigin](radialgradientbrush_gradientorigin.md) represent relative or absolute coordinates.

When [MappingMode](radialgradientbrush_mappingmode.md) is set to `RelativeToBoundingBox`, the X and Y values of the three properties are treated as relative to the element bounds, where `(0,0)` represents the top left and `(1,1)` represents the bottom right of the element bounds for the [Center](radialgradientbrush_center.md), [RadiusX](radialgradientbrush_radiusx.md), and [RadiusY](radialgradientbrush_radiusy.md) properties and `(0,0)` represents the center for the [GradientOrigin](radialgradientbrush_gradientorigin.md) property.

When [MappingMode](radialgradientbrush_mappingmode.md) is set to `Absolute`, the X and Y values of the three properties are treated as absolute coordinates within the element bounds.

### Windows 10 Version Support

Gradient rendering is supported on Windows 10 version 1903 (v10.0.18362.0) and higher. On previous OS versions the brush will render a solid color specified by the `FallbackColor` property.

### Brushes as XAML resources

Each of the [Brush](brush.md) types that can be declared in XAML ([SolidColorBrush](solidcolorbrush.md), LinearGradientBrush, [ImageBrush](imagebrush.md)) is intended to be defined as a resource, so that you can reuse that brush as a resource throughout your app. The XAML syntax shown for [Brush](brush.md) types is appropriate for defining the brush as a resource. When you declare a brush as a resource, you also need an [x:Key attribute](https://docs.microsoft.com/windows/uwp/xaml-platform/x-key-attribute) that you'll later use to refer to that resource from other UI definitions. For more info on XAML resources and how to use [x:Key attribute](https://docs.microsoft.com/windows/uwp/xaml-platform/x-key-attribute), see [ResourceDictionary and XAML resource references](https://docs.microsoft.com/windows/uwp/controls-and-patterns/resourcedictionary-and-xaml-resource-references).

The advantage of declaring brushes as resources is that it reduces the number of runtime objects that are needed to construct a UI: the brush is now shared as a common resource that's providing values for multiple parts of the object graph.

If you look at the existing control template definitions for Windows Runtime XAML controls, you'll see that the templates use brush resources extensively (although these are usually [SolidColorBrush](solidcolorbrush.md), not LinearGradientBrush). Many of these resources are system resources, and they use the [{ThemeResource} markup extension](https://docs.microsoft.com/windows/uwp/xaml-platform/themeresource-markup-extension) for the resource reference rather than [{StaticResource} markup extension](https://docs.microsoft.com/windows/uwp/xaml-platform/staticresource-markup-extension). For more info on how to use system resource brushes in your own control template XAML, see [XAML theme resources](https://docs.microsoft.com/windows/uwp/controls-and-patterns/xaml-theme-resources).

## -see-also

[Brush](brush.md), [SolidColorBrush](solidcolorbrush.md), [LinearGradientBrush](lineargradientbrush.md), [GradientBrush](gradientbrush.md), [GradientStop](gradientstop.md), [Use brushes](https://docs.microsoft.com/windows/uwp/graphics/using-brushes), [ResourceDictionary and XAML resource references](https://docs.microsoft.com/windows/uwp/controls-and-patterns/resourcedictionary-and-xaml-resource-references)

## -examples

This example creates a radial gradient with six gradient stops and uses it to paint a Rectangle.

```xaml
<Page
  xmlns:media="using:Microsoft.UI.Xaml.Media">

  <Rectangle Width="200" Height="200">
      <Rectangle.Fill>
          <media:RadialGradientBrush>
              <GradientStop Color="Blue" Offset="0.0" />
              <GradientStop Color="Yellow" Offset="0.2" />
              <GradientStop Color="LimeGreen" Offset="0.4" />
              <GradientStop Color="LightBlue" Offset="0.6" />
              <GradientStop Color="Blue" Offset="0.8" />
              <GradientStop Color="LightGray" Offset="1" />
          </media:RadialGradientBrush>
      </Rectangle.Fill>
  </Rectangle>

</Page>
```

![A rectangle filled with a radial gradient](Images/ColorRadialGradientBrush.png)

This example creates a radial gradient that uses Absolute mapping mode with custom values for `Center`, `RadiusX`, `RadiusY` and `GradientOrigin`:

```xaml
<Page
  xmlns:media="using:Microsoft.UI.Xaml.Media">

  <Rectangle Width="200" Height="200">
      <Rectangle.Fill>
          <media:RadialGradientBrush
            MappingMode="Absolute"
            Center="50,50"
            RadiusX="100"
            RadiusY="100"
            GradientOrigin="100,50"
            >
              <GradientStop Color="Yellow" Offset="0.0" />
              <GradientStop Color="Blue" Offset="1" />
          </media:RadialGradientBrush>
      </Rectangle.Fill>
  </Rectangle>

</Page>
```

![Gradient axis for a vertical gradient](Images/OffsetRadialGradientBrush.png)
