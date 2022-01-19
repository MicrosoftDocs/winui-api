---
-api-id: P:Microsoft.UI.Xaml.Controls.IconSource.Foreground
-api-type: winrt property
---
<!-- Property syntax.
public Brush Foreground { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.IconSource.Foreground

## -description

Gets or sets a brush that paints the foreground color of the control.

## -property-value

The brush that paints the foreground of the control. The default is **null**, (a null brush), which is evaluated as [Transparent](/uwp/api/windows.ui.colors.transparent) for rendering. However, this value is typically set by a default system resource at runtime that is tied to the active theme and other settings.

## -remarks

## -see-also

## -examples

## -xaml-syntax

```xaml
<iconSource Foreground="{StaticResource resourceName}"/>
```

```xaml
<iconSource Foreground="colorString"/>
```

## -xaml-values

<dl><dt>resourceName</dt><dd>resourceNameThe resource name (x:Key attribute value) of an existing XAML resource that defines a brush. This is the recommended way to specify Brush values in XAML if you have any intention of using the same colors or brushes in more than one part of your UI. See Remarks in Brush or ResourceDictionary and XAML resource references.</dd>
<dt>colorString</dt><dd>colorStringThe Color for a SolidColorBrush expressed as an attribute string. This can be a named color, an RGB value, or an ScRGB value. RGB or ScRGB may also specify alpha information. See the XAML Values section in Color.</dd>
</dl>
