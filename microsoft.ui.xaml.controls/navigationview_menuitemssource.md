---
-api-id: P:Microsoft.UI.Xaml.Controls.NavigationView.MenuItemsSource
-api-type: winrt property
---
<!-- Property syntax.
public object MenuItemsSource { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.NavigationView.MenuItemsSource


## -description

Gets or sets an object source used to generate the content of the NavigationView menu.


## -property-value

The object that is used to generate the content of the NavigationView menu. The default is **null**.


## -remarks


## -see-also


## -examples


## -xaml-syntax

```xaml
<NavigationView MenuItemsSource="bindingDeclaration"/>
-or-
<NavigationView MenuItemsSource="resourceReferenceToSource"/>
```



## -xaml-values

<dl><dt>bindingDeclaration</dt><dd>bindingDeclarationA Binding declaration using a {Binding ....} markup extension. For more information, see {Binding} markup extension.</dd>
<dt>resourceReferenceToSource</dt><dd>resourceReferenceToSourceA resource reference to an existing iterable/enumerable items source from a resources collection. The resource reference must specify the desired items source by key.</dd>
</dl>


