---
-api-id: P:Microsoft.UI.Xaml.Controls.TreeView.ItemsSource
-api-type: winrt property

---
<!-- Property syntax.
public object ItemsSource { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.TreeView.ItemsSource


## -description

Gets or sets an object source used to generate the content of the TreeView.


## -property-value

The object that is used to generate the content of the TreeView. The default is **null**.


## -remarks


## -see-also


## -examples


## -xaml-syntax

```xaml
<TreeView ItemsSource="bindingDeclaration"/>
-or-
<TreeView ItemsSource="resourceReferenceToSource"/>
```


## -xaml-values

<dl><dt>bindingDeclaration</dt><dd>bindingDeclarationA Binding declaration using a {Binding ....} markup extension. For more information, see {Binding} markup extension.</dd>
<dt>resourceReferenceToSource</dt><dd>resourceReferenceToSourceA resource reference to an existing iterable/enumerable items source from a resources collection. The resource reference must specify the desired items source by key.</dd>
</dl>


