---
-api-id: P:Microsoft.UI.Xaml.Controls.TreeView.ItemContainerStyle
-api-type: winrt property
---
<!-- Property syntax.
public Style ItemContainerStyle { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.TreeView.ItemContainerStyle


## -description

Gets or sets the style that is used when rendering the item containers.


**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -property-value

The style applied to the item containers. The default is **null**.


## -remarks


## -see-also


## -examples


## -xaml-syntax

```xaml
<TreeView>
  <TreeView.ItemContainerStyle>
    inlineStyle
  </TreeView.ItemContainerStyle>
</TreeView>
```

```xaml
<TreeView ItemContainerStyle="resourceReferenceToStyle"/>
```


## -xaml-values

<dl><dt>inlineStyle</dt><dd>inlineStyleA single Style object element. That Style would typically have multiple setters that set properties on the item container type being targeted. (For TreeView, that type is TreeViewItem.)</dd>
<dt>resourceReferenceToStyle</dt><dd>resourceReferenceToStyleA {StaticResource} markup extension reference to an existing Style from a XAML resource dictionary.</dd>
</dl>


