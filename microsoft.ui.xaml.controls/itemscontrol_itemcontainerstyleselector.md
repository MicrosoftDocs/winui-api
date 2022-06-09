---
-api-id: P:Microsoft.UI.Xaml.Controls.ItemsControl.ItemContainerStyleSelector
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Controls.StyleSelector ItemContainerStyleSelector { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.ItemsControl.ItemContainerStyleSelector

## -description
Gets or sets a reference to a custom [StyleSelector](styleselector.md) logic class. The [StyleSelector](styleselector.md) returns different [Style](../microsoft.ui.xaml/style.md) values to use for the item container based on characteristics of the object being displayed.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -xaml-syntax
```xaml
<itemsControl ItemContainerStyleSelector="styleSelectorReference" />
```


## -xaml-values
<dl><dt>styleSelectorReference</dt><dd>styleSelectorReferenceA reference to an existing StyleSelector. Typically this is a keyed resource, which you reference through a {StaticResource} markup extension usage.</dd>
</dl>
## -property-value
A custom [StyleSelector](styleselector.md) logic class.

## -remarks

## -examples

## -see-also
