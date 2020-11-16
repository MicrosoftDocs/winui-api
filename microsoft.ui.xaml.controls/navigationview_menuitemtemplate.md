---
-api-id: P:Microsoft.UI.Xaml.Controls.NavigationView.MenuItemTemplate
-api-type: winrt property
---
<!-- Property syntax.
public DataTemplate MenuItemTemplate { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.NavigationView.MenuItemTemplate

## -description

Gets or sets the [DataTemplate](/uwp/api/windows.ui.xaml.datatemplate) used to display each menu item.

## -property-value

The template that specifies the visualization of the menu data objects. The default is **null**.

## -remarks

## -see-also

## -examples

## -xaml-syntax

```xaml
<NavigationView>
  <NavigationView.MenuItemTemplate>
    singleDataTemplate
  </NavigationView.MenuItemTemplate>
</NavigationView>

or

<NavigationView MenuItemTemplate="resourceReferenceToDataTemplate"/>
```

## -xaml-values

<dl><dt>singleDataTemplate</dt><dd>singleDataTemplateA single DataTemplate object element. That DataTemplate would typically have multiple child elements that define the visual appearance of the data representation.</dd>
<dt>resourceReferenceToDataTemplate</dt><dd>resourceReferenceToDataTemplateA resource reference to an existing DataTemplate from a resources collection. The resource reference must specify the desired DataTemplate by key through a {StaticResource} markup extension usage.</dd>
</dl>



