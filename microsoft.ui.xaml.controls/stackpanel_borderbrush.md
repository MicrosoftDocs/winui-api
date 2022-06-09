---
-api-id: P:Microsoft.UI.Xaml.Controls.StackPanel.BorderBrush
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Media.Brush BorderBrush { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.StackPanel.BorderBrush

## -description
Gets or sets a brush that describes the border fill of the panel.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
<Border BorderBrush="{StaticResource resourceName}"/>
- or -
<Border BorderBrush="colorString"/>
- or -
<Border>
  <Border.BorderBrush>singleBrush</Border.BorderBrush>
</Border>

```


## -xaml-values
<dl><dt>resourceName</dt><dd>resourceNameThe resource name (x:Key attribute value) of an existing XAML resource that defines a brush. This is the recommended way to specify Brush values in XAML if you have any intention of using the same colors or brushes in more than one part of your UI. See Remarks in Brush or ResourceDictionary and XAML resource references.</dd>
<dt>colorString</dt><dd>colorStringThe Color for a SolidColorBrush expressed as an attribute string. This can be a named color, an RGB value, or an ScRGB value. RGB or ScRGB may also specify alpha information. See the XAML Values section in Color.</dd>
<dt>singleBrush</dt><dd>singleBrushWithin opening and closing property elements, exactly one object element for an object that derives from Brush. This is typically one of the following classes: LinearGradientBrush, ImageBrush, SolidColorBrush.</dd>
</dl>
## -property-value
The brush that is used to fill the panel's border. The default is **null**, (a null brush) which is evaluated as [Transparent](../microsoft.ui/colors_transparent.md) for rendering.

## -remarks
The [BorderThickness](stackpanel_borderthickness.md) value must be greater than 0 in order to see the BorderBrush value take effect.

## -examples

## -see-also
