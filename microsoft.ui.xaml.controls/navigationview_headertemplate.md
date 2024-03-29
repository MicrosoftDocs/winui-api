---
-api-id: P:Microsoft.UI.Xaml.Controls.NavigationView.HeaderTemplate
-api-type: winrt property
---
<!-- Property syntax.
public DataTemplate HeaderTemplate { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.NavigationView.HeaderTemplate


## -description

Gets or sets the DataTemplate used to display the control's header.


**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -property-value

The DataTemplate used to display the control's header.


## -remarks


## -see-also


## -examples


## -xaml-syntax

```xaml
<NavigationView HeaderTemplate="resourceReferenceToDataTemplate"/>
```

```xaml
<NavigationView>
  <NavigationView.HeaderTemplate>
    <DataTemplate>
      dataTemplateDefinition
    </DataTemplate>
  </NavigationView.HeaderTemplate>
</NavigationView>
```


## -xaml-values

<dl><dt>resourceReferenceToDataTemplate</dt><dd>resourceReferenceToDataTemplateA resource reference to an existing DataTemplate from a resources collection. The resource reference must specify the desired DataTemplate by key through a {StaticResource} markup extension usage.</dd>
<dt>dataTemplateDefinition</dt><dd>dataTemplateDefinitionDefinition for the DataTemplate, including its root element container and parts within that present the data-based content.</dd>
</dl>


