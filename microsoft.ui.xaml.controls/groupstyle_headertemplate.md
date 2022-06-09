---
-api-id: P:Microsoft.UI.Xaml.Controls.GroupStyle.HeaderTemplate
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.DataTemplate HeaderTemplate { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.GroupStyle.HeaderTemplate

## -description
Gets or sets the template that is used to display the group header.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
<GroupStyle HeaderTemplate="dataTemplateReference" />
- or -
<GroupStyle>
  <GroupStyle.HeaderTemplate>
    <DataTemplate>
      dataTemplateDefinition
    </DataTemplate>
  </GroupStyle.HeaderTemplate>
</GroupStyle>
```


## -xaml-values
<dl><dt>dataTemplateReference</dt><dd>dataTemplateReferenceA reference to an existing DataTemplate. Typically this is a keyed resource, which you reference through {StaticResource} markup extension.</dd>
<dt>dataTemplateDefinition</dt><dd>dataTemplateDefinitionDefinition for the DataTemplate, including its root element container and parts within that present the view's header items.</dd>
</dl>
## -property-value
A [DataTemplate](../microsoft.ui.xaml/datatemplate.md) object that is used to display the group header. The default is **null**.

## -remarks

## -examples

## -see-also
[How to group items in a list or grid](/previous-versions/windows/apps/hh780627(v=win.10))
