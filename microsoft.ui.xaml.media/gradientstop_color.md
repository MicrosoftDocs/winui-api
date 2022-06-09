---
-api-id: P:Microsoft.UI.Xaml.Media.GradientStop.Color
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Color Color { get;  set; }
-->

# Microsoft.UI.Xaml.Media.GradientStop.Color

## -description
Gets or sets the color of the gradient stop.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -xaml-syntax
```xaml
<GradientStop Color="colorString" .../>
```


## -xaml-values
<dl><dt>colorString</dt><dd>colorStringThe Color for a SolidColorBrush expressed as an attribute string. This can be a named color, an RGB value, or an ScRGB value. RGB or ScRGB may also specify alpha information. For more information, see the XAML Attribute Usage in Color.</dd>
</dl>
## -property-value
The color of the gradient stop. The default is [Transparent](../microsoft.ui/colors_transparent.md).

## -remarks

## -examples
This example creates a [LinearGradientBrush](lineargradientbrush.md) with four gradient stops in the implicit [GradientStopCollection](gradientstopcollection.md), which is used to paint a **Rectangle**.



[!code-xaml[Gradient1](../microsoft.ui.xaml.media/code/Gradients/csharp/Page.xaml#SnippetGradient1)]

## -see-also
