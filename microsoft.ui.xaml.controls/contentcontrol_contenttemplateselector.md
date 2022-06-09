---
-api-id: P:Microsoft.UI.Xaml.Controls.ContentControl.ContentTemplateSelector
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Controls.DataTemplateSelector ContentTemplateSelector { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.ContentControl.ContentTemplateSelector

## -description
Gets or sets a selection object that changes the [DataTemplate](../microsoft.ui.xaml/datatemplate.md) to apply for content, based on processing information about the content item or its container at run time.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
<contentControl ContentTemplateSelector="selectorReference" />

```


## -xaml-values
<dl><dt>selectorReference</dt><dd>selectorReferenceA reference to an existing DataTemplateSelector. Typically this is a keyed resource, which you reference through a {StaticResource} markup extension usage.</dd>
</dl>
## -property-value
A selection object that changes the [DataTemplate](../microsoft.ui.xaml/datatemplate.md) to apply for content.

## -remarks

## -examples

## -see-also
[DataTemplateSelector](datatemplateselector.md)
