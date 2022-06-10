---
-api-id: P:Microsoft.UI.Xaml.Controls.Primitives.ListViewItemPresenter.ReorderHintOffset
-api-type: winrt property
---

<!-- Property syntax
public double ReorderHintOffset { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.Primitives.ListViewItemPresenter.ReorderHintOffset

## -description
Gets or sets the amount that the reorder hint is offset. This property is ignored for a Windows 10 app.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
<listViewItemPresenterReorderHintOffset="themeResourceReference"/>
- or -
<listViewItemPresenter ReorderHintOffset="double"/>
```


## -xaml-values
<dl><dt>themeResourceReference</dt><dd>themeResourceReferenceA ThemeResource markup extension reference to an existing keyed resource that defines a Double-type resource in a XAML resource dictionary. For example, to reference a resource with the key ListViewItemReorderHintThemeOffset, the string is {ThemeResource ListViewItemReorderHintThemeOffset}.</dd>
</dl>
## -property-value
The amount that the reorder hint is offset, in pixels. The effective default value at run-time comes from themes.

## -remarks
### Notes on XAML syntax

The first XAML usage shown is for referencing a theme resource. This is how values for a presenter are typically defined, so that the values can be changed when the theme changes, and potentially so that values can be shared by different templates.

## -examples

## -see-also
