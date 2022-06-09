---
-api-id: P:Microsoft.UI.Xaml.Controls.SymbolIcon.Symbol
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Controls.Symbol Symbol { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.SymbolIcon.Symbol

## -description
Gets or sets the Segoe MDL2 Assets glyph used as the icon content.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -xaml-syntax
```xaml
<SymbolIcon Symbol="symbolName"/>
```


## -xaml-values
<dl><dt>symbolName</dt><dd>symbolNameA named constant of the Symbol enumeration, which enumerates a subset of the Segoe MDL2 Assets font.</dd>
</dl>
## -property-value
A named constant of the numeration that specifies the Segoe MDL2 Assets glyph to use.

## -remarks
> **Windows 8/8.1**
> On Windows 8, the standard glyphs are provided by the Segoe UI Symbol font.

## -examples
```xaml

<AppBarButton Label="Accept">
    <AppBarButton.Icon>
        <SymbolIcon Symbol="Accept"/>
    </AppBarButton.Icon>
</AppBarButton>
```



## -see-also
