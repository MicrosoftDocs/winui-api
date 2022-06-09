---
-api-id: P:Microsoft.UI.Xaml.Controls.Slider.ThumbToolTipValueConverter
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Data.IValueConverter ThumbToolTipValueConverter { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.Slider.ThumbToolTipValueConverter

## -description
Gets or sets the converter logic that converts the range value of the [Slider](slider.md) into tool tip content.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -xaml-syntax
```xaml
<Slider ThumbToolTipValueConverter="referenceToValueConverter" />
```


## -xaml-values
<dl><dt>referenceToValueConverter</dt><dd>referenceToValueConverterA inline reference to an existing implementation of a converter. Typically this is done by instantiating an object element for the IValueConverter implementing class as a resource and giving that resource a key. Then you reference the resource by key through a {StaticResource} markup extension usage to provide the attribute value for ThumbToolTipValueConverter.</dd>
</dl>
## -property-value
A converter implementation.

## -remarks
By default, the [Slider](slider.md)'s thumb tooltip shows the numeric value of the slider. To show other values in the thumb tooltip, you create a custom value converter and assign it to the ThumbToolTipValueConverter property.

## -examples

## -see-also
[IsThumbToolTipEnabled](slider_isthumbtooltipenabled.md)
