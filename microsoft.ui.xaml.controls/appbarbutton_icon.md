---
-api-id: P:Microsoft.UI.Xaml.Controls.AppBarButton.Icon
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Controls.IconElement Icon { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.AppBarButton.Icon

## -description

Gets or sets the image displayed on the app bar button.

## -xaml-syntax

```xaml
<AppBarButton Icon="symbolName" .../>
- or -
<AppBarButton>
    <AppBarButton.Icon>
        iconElement
    </AppBarButton.Icon>
</AppBarButton>

```

## -xaml-values

<dl><dt>symbolName</dt><dd>symbolNameA named constant of the Symbol enumeration.</dd>
<dt>iconElement</dt><dd>iconElementA single object element that derives from IconElement and describes the graphic content of the button. The object element is typically one of these classes: SymbolIcon, FontIcon, PathIcon, or ImageIcon.</dd>
</dl>

## -property-value

The image displayed on the app bar button.

## -remarks

## -examples

## -see-also

[Symbol](symbol.md), [IconElement](iconelement.md), [SymbolIcon](symbolicon.md), [FontIcon](fonticon.md), [PathIcon](pathicon.md), [ImageIcon](imageicon.md)
