---
-api-id: P:Microsoft.UI.Xaml.Controls.AutoSuggestBox.QueryIcon
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Controls.IconElement QueryIcon { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.AutoSuggestBox.QueryIcon

## -description
Gets or sets the graphic content of the button that is clicked to initiate a query.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -xaml-syntax
```xaml
<AutoSuggestBox QueryIcon="symbolName" .../>
- or -
<AutoSuggestBox>
    <AutoSuggestBox.QueryIcon>
        iconElement
    </AutoSuggestBox.QueryIcon>
</AutoSuggestBox>

```


## -xaml-values
<dl><dt>symbolName</dt><dd>symbolNameA named constant of the Symbol enumeration.</dd>
<dt>iconElement</dt><dd>iconElementA single object element that derives from IconElement and describes the graphic content of the button. The object element is typically one of these classes: SymbolIcon, FontIcon, or PathIcon.</dd>
</dl>
## -property-value
The graphic content of the button that is clicked to initiate a query, if present; otherwise, **null**. The default is **null**.

## -remarks

## -examples

## -see-also
