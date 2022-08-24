---
-api-id: P:Microsoft.UI.Xaml.Controls.Primitives.GridViewItemPresenter.DragOpacity
-api-type: winrt property
---

<!-- Property syntax
public double DragOpacity { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.Primitives.GridViewItemPresenter.DragOpacity

## -description
Gets or sets the opacity of an item that's being dragged.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
<gridViewItemPresenterDragOpacity="themeResourceReference"/>
- or -
<gridViewItemPresenter DragOpacity="double"/>
```


## -xaml-values
<dl><dt>themeResourceReference</dt><dd>themeResourceReferenceA ThemeResource markup extension reference to an existing keyed resource that defines a Double-type resource in a XAML resource dictionary. For example, to reference a resource with the key GridViewItemDragThemeOpacity, the string is {ThemeResource GridViewItemDragThemeOpacity}.</dd>
</dl>
## -property-value
The opacity of an item that's being dragged. The value should be between 0 and 1. 0 is no opacity (transparent), 1 is full opacity (renders normally). The effective default value at run-time comes from themes.

## -remarks
### Notes on XAML syntax

The first XAML usage shown is for referencing a theme resource. This is how values for a presenter are typically defined, so that the values can be changed when the theme changes, and potentially so that values can be shared by different templates.

## -examples

## -see-also
