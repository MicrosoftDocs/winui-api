---
-api-id: P:Microsoft.UI.Xaml.Controls.ItemsControl.ItemTemplate
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.DataTemplate ItemTemplate { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.ItemsControl.ItemTemplate

## -description
Gets or sets the [DataTemplate](../microsoft.ui.xaml/datatemplate.md) used to display each item.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
<itemsControl>
  <itemsControl.ItemTemplate>
    singleDataTemplate
  </itemsControl.ItemTemplate>
</itemsControl>
- or -
<itemsControl ItemTemplate="resourceReferenceToDataTemplate"/>
```


## -xaml-values
<dl><dt>singleDataTemplate</dt><dd>singleDataTemplateA single DataTemplate object element. That DataTemplate would typically have multiple child elements that define the visual appearance of the data representation.</dd>
<dt>resourceReferenceToDataTemplate</dt><dd>resourceReferenceToDataTemplateA resource reference to an existing DataTemplate from a resources collection. The resource reference must specify the desired DataTemplate by key through a {StaticResource} markup extension usage.</dd>
</dl>
## -property-value
The template that specifies the visualization of the data objects. The default is null.

## -remarks

## -examples

## -see-also
