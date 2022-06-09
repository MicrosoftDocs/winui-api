---
-api-id: P:Microsoft.UI.Xaml.Controls.Pivot.HeaderTemplate
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.DataTemplate HeaderTemplate { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.Pivot.HeaderTemplate

## -description
Gets or sets the template for the [Header](pivotitem_header.md) property of [PivotItem](pivotitem.md) children.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
<Pivot HeaderTemplate="resourceReferenceToDataTemplate"/>
- or -
<Pivot>
  <Pivot.HeaderTemplate>
     <DataTemplate>
      dataTemplateDefinition
    </DataTemplate>
  </Pivot.HeaderTemplate>
</Pivot>
```


## -xaml-values
<dl><dt>resourceReferenceToDataTemplate</dt><dd>resourceReferenceToDataTemplateA resource reference to an existing DataTemplate from a resources collection. The resource reference must specify the desired DataTemplate by key through a {StaticResource} markup extension usage.</dd>
<dt>dataTemplateDefinition</dt><dd>dataTemplateDefinitionDefinition for the DataTemplate, including its root element container and parts within that present the data-based content.</dd>
</dl>
## -property-value
The template for the [Header](pivotitem_header.md) property of [PivotItem](pivotitem.md) children.

## -remarks

## -examples

## -see-also
[DataTemplate](../microsoft.ui.xaml/datatemplate.md)
