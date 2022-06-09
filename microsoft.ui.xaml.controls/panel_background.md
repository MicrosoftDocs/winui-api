---
-api-id: P:Microsoft.UI.Xaml.Controls.Panel.Background
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Media.Brush Background { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.Panel.Background

## -description
Gets or sets a [Brush](../microsoft.ui.xaml.media/brush.md) that fills the panel content area.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
<panel Background="{StaticResource resourceName}"/>
- or -
<panel Background="colorString"/>
- or -
<panel>
  <panel.Background>singleBrush</panel.Background>
</panel>

```


## -xaml-values
<dl><dt>resourceName</dt><dd>resourceNameThe resource name (x:Key attribute value) of an existing XAML resource that defines a brush. This is the recommended way to specify Brush values in XAML if you have any intention of using the same colors or brushes in more than one part of your UI. See Remarks in Brush or ResourceDictionary and XAML resource references.</dd>
<dt>colorString</dt><dd>colorStringThe Color for a SolidColorBrush expressed as an attribute string. This can be a named color, an RGB value, or an ScRGB value. RGB or ScRGB may also specify alpha information. See the XAML Values section in Color.</dd>
<dt>singleBrush</dt><dd>singleBrushWithin opening and closing property elements, exactly one object element for an object that derives from Brush. This is typically one of the following classes: LinearGradientBrush, ImageBrush, SolidColorBrush.</dd>
</dl>
## -property-value
The brush that fills the panel content area. The default is **null**, (a null brush) which is evaluated as [Transparent](../microsoft.ui/colors_transparent.md) for rendering.

## -remarks
The Background value for a [Panel](panel.md)-derived panel is visible underneath the inner area if the elements that are in the [Children](panel_children.md) collection have transparency or null brushes for any of their defining area. It displays in the child margin area for any case where a child element has a nonzero [Margin](../microsoft.ui.xaml/frameworkelement_margin.md) affecting its position. It is also visible between the layout positions of any child elements regardless of margin, although that can depend on how the panel implements its layout behavior. For example, in a [Canvas](canvas.md), any pixel in the content area where there's not an absolutely positioned element covering it will show the panel Background brush.

If you're using a [Panel](panel.md) class such as [Grid](grid.md) or [StackPanel](stackpanel.md) as the root element of a control template, it's a common practice to use a [{TemplateBinding} markup extension](/windows/uwp/xaml-platform/templatebinding-markup-extension) to bind the panel's background to the [Control.Background](control_background.md) property of the template parent (the control class that uses your template).

## -examples

## -see-also
[Use brushes](/windows/uwp/graphics/using-brushes)
