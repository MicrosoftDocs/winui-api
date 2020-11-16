---
-api-id: P:Microsoft.UI.Xaml.Controls.SwipeItem.IconSource
-api-type: winrt property
---
<!-- Property syntax.
public IconSource IconSource { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.SwipeItem.IconSource


## -description

Gets or sets the graphic content of the item.


## -property-value

The graphic content of the item. The default is **null**.


## -remarks


## -see-also


## -examples

The value of the IconSource property must be of type [IconSource](iconsource.md). For example, the following uses a [SymbolIconSource](symboliconsource.md):

```Xaml
<SwipeItem Text="Accept">
    <SwipeItem.IconSource>
        <SymbolIconSource Symbol="Accept"
    </SwipeItem.IconSource>
</SwipeItem>
```

## -xaml-syntax

```xaml
<SwipeItem>
  <SwipeItem.IconSource>
    iconSourceElement
  </SwipeItem.IconSource>
</SwipeItem>
```


## -xaml-values

<dt>iconSourceElement</dt><dd>iconSourceElementA single object element that derives from IconSource and describes the graphic content of the button.</dd>
</dl>


