---
-api-id: P:Microsoft.UI.Xaml.Controls.GroupStyle.HeaderTemplateSelector
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Controls.DataTemplateSelector HeaderTemplateSelector { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.GroupStyle.HeaderTemplateSelector

## -description
Gets or sets a reference to a custom [DataTemplateSelector](datatemplateselector.md) logic class. The [DataTemplateSelector](datatemplateselector.md) returns different [DataTemplate](../microsoft.ui.xaml/datatemplate.md) values to use for the header area of group item content.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
<GroupStyle HeaderTemplateSelector="dataTemplateSelectorReference" />
```


## -xaml-values
<dl><dt>dataTemplateSelectorReference</dt><dd>dataTemplateSelectorReferenceA reference to an existing DataTemplateSelector. Typically this is a keyed resource, which you reference through {StaticResource} markup extension.</dd>
</dl>
## -property-value
An object that derives from [DataTemplateSelector](datatemplateselector.md). The default is **null**.

## -remarks
For example XAML that references a custom [DataTemplateSelector](datatemplateselector.md) as the HeaderTemplateSelector value, and example code that shows the overrides for HeaderTemplateSelector methods, see [How to group items in a list or grid](/previous-versions/windows/apps/hh780627(v=win.10)).

## -examples

## -see-also
