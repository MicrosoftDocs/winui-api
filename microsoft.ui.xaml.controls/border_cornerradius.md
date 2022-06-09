---
-api-id: P:Microsoft.UI.Xaml.Controls.Border.CornerRadius
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.CornerRadius CornerRadius { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.Border.CornerRadius

## -description
Gets or sets the radius for the corners of the border.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
<Border CornerRadius="uniformRadius"/>
- or -
<Border CornerRadius="topLeft,topRight,bottomRight,bottomLeft"/>

```


## -xaml-values
<dl><dt>uniformRadius</dt><dd>uniformRadiusA value that specifies a uniform radius size in pixels. The uniformRadius value is applied to all four CornerRadius values.</dd>
<dt>topLeft</dt><dd>topLeftSets the initial TopLeft value.</dd>
<dt>topRight</dt><dd>topRightSets the initial TopRight value.</dd>
<dt>bottomRight</dt><dd>bottomRightSets the initial BottomRight value.</dd>
<dt>bottomLeft</dt><dd>bottomLeftSets the initial BottomLeft value.If you specify an attribute string with two or three values, only the first value is respected and is treated as the uniformRadius (the other values are ignored). You must specify all four values to use a different behavior than uniformRadius. In the XAML syntaxes shown, you can use a space rather than a comma as the delimiter between values.</dd>
</dl>
## -property-value
The degree to which the corners are rounded, expressed as values of the [CornerRadius](../microsoft.ui.xaml/cornerradius.md) structure.

## -remarks
Member components of a [CornerRadius](../microsoft.ui.xaml/cornerradius.md) value cannot be negative.

## -examples

## -see-also
