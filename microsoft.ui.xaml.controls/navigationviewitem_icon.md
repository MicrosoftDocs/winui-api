---
-api-id: P:Microsoft.UI.Xaml.Controls.NavigationViewItem.Icon
-api-type: winrt property
---
<!-- Property syntax.
public IconElement Icon { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.NavigationViewItem.Icon

## -description

Gets or sets the icon to show next to the menu item text.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -property-value

The icon to show next to the menu item text. The default is **null**.

## -remarks

You can assign a value from the [Symbol](/uwp/api/windows.ui.xaml.controls.symbol) enumeration, or a Unicode string that references a glyph in the [Segoe MDL2 Assets font](https://docs.microsoft.com/windows/apps/design/style/segoe-ui-symbol-font).

You can use the Character Map application that comes with Windows to browse the font's glyphs and find their Unicode values. Then, use the format **"&#x/_(UNICODE)_;"** in XAML, or the format **"\u/_(UNICODE)_"** in code, where **_(UNICODE)_** is the value of the glyph that indicates the location in the font file.

The Segoe MDL2 Assets font ships with Windows 10, and new glyphs might be added in every release. You should verify that the Unicode value you choose is available in the minimum SDK build version your project targets.

NavigationViewItem also supports <xref:Microsoft.UI.Xaml.Controls.AnimatedIcon>. If you set an AnimatedIcon as the value of the Icon property, the NavigationViewItem will set the states of the AnimatedIcon for you, according to the states of the control.

The NavigationViewItem will automatically set the following states on the AnimatedIcon:

* Normal
* PointerOver
* Pressed
* Selected
* PressedSelected
* PointerOverSelected

## -see-also

## -examples

## -xaml-syntax

```xaml
<NavigationViewItem Icon="symbolName" .../>


<NavigationViewItem>
  <NavigationViewItem.Icon>
    iconElement
  </NavigationViewItem.Icon>
</NavigationViewItem>
```

## -xaml-values

<dl><dt>symbolName</dt><dd>symbolNameA named constant of the Symbol enumeration.</dd>
<dt>iconElement</dt><dd>iconElementA single object element that derives from IconElement and describes the graphic content of the button. The object element is typically one of these classes: SymbolIcon, FontIcon, or PathIcon.</dd>
</dl>
