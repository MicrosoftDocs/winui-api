---
-api-id: P:Microsoft.UI.Xaml.Controls.Primitives.GridViewItemPresenter.CheckHintBrush
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Media.Brush CheckHintBrush { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.Primitives.GridViewItemPresenter.CheckHintBrush

## -description
Gets or sets the brush used to render the check mark hint.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
<GridViewItemPresenter CheckHintBrush="themeResourceReference"/>

```


## -xaml-values
<dl><dt>themeResourceReference</dt><dd>themeResourceReferenceA ThemeResource markup extension reference to an existing keyed resource that defines a Brush-type resource in a XAML resource dictionary. For example, to reference a resource with the key GridViewItemCheckHintThemeBrush, the string is {ThemeResource GridViewItemCheckHintThemeBrush}.</dd>
</dl>
## -property-value
The brush used to render the check mark hint.

## -remarks
### Notes on XAML syntax

The XAML usage shown is for referencing a theme resource. This is how [Brush](../microsoft.ui.xaml.media/brush.md) values for a presenter are typically defined, so that the values can be changed when the theme changes, and potentially so that [Brush](../microsoft.ui.xaml.media/brush.md) values can be shared by different templates. It's possible but less common to use a XAML syntax that refers to a [Brush](../microsoft.ui.xaml.media/brush.md) value directly. For examples of direct XAML usages for a [Brush](../microsoft.ui.xaml.media/brush.md), see the XAML section in the [Brush](../microsoft.ui.xaml.media/brush.md) class topic.

If you're setting this property as an attribute on a custom [GridViewItemPresenter](gridviewitempresenter.md), substitute the prefixed name of your custom class in the XAML usage shown.

## -examples

## -see-also
[XAML theme resources](/windows/uwp/controls-and-patterns/xaml-theme-resources)
