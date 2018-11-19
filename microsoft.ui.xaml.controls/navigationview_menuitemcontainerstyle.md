---
-api-id: P:Microsoft.UI.Xaml.Controls.NavigationView.MenuItemContainerStyle
-api-type: winrt property
ms.custom: RS5
---
<!-- Property syntax.
public Style MenuItemContainerStyle { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.NavigationView.MenuItemContainerStyle


## -description

Gets or sets the style that is used when rendering the menu item containers.


## -property-value

The style applied to the item containers. The default is **null**.


## -remarks


## -see-also


## -examples


## -xaml-syntax

```xaml
<NavigationView>
  <NavigationView.MenuItemContainerStyle>
    inlineStyle
  </NavigationView.MenuItemContainerStyle>
</NavigationView>
```

```xaml
<NavigationView MenuItemContainerStyle="resourceReferenceToStyle"/>
```


## -xaml-values

<dl><dt>inlineStyle</dt><dd>inlineStyleA single Style object element. That Style would typically have multiple setters that set properties on the item container type being targeted. (For ListBox, that type is ListBoxItem.)</dd>
<dt>resourceReferenceToStyle</dt><dd>resourceReferenceToStyleA {StaticResource} markup extension reference to an existing Style from a XAML resource dictionary.</dd>
</dl>


