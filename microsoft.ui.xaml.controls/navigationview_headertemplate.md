---
-api-id: P:Microsoft.UI.Xaml.Controls.NavigationView.HeaderTemplate
-api-type: winrt property
ms.custom: RS5
---
<!-- Property syntax.
public DataTemplate HeaderTemplate { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.NavigationView.HeaderTemplate


## -description

Gets or sets the DataTemplate used to display the control's header.


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


