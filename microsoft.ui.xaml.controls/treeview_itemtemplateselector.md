---
-api-id: P:Microsoft.UI.Xaml.Controls.TreeView.ItemTemplateSelector
-api-type: winrt property
---
<!-- Property syntax.
public DataTemplateSelector ItemTemplateSelector { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.TreeView.ItemTemplateSelector



## -description

Gets or sets a reference to a custom [DataTemplateSelector](/uwp/api/windows.ui.xaml.controls.datatemplateselector) logic class. The DataTemplateSelector referenced by this property returns a template to apply to items.



**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -property-value

A reference to a custom [DataTemplateSelector](/uwp/api/windows.ui.xaml.controls.datatemplateselector) logic class.



## -remarks



## -see-also



## -examples



## -xaml-syntax

```xaml
<TreeView ItemTemplateSelector="dataTemplateSelectorReference" />
```



## -xaml-values
<dl><dt>dataTemplateSelectorReference</dt><dd>dataTemplateSelectorReferenceA reference to an existing DataTemplateSelector. Typically this is a keyed resource, which you reference through {StaticResource} markup extension.</dd>
</dl>



