---
-api-id: T:Microsoft.UI.Xaml.Controls.ColorSpectrumComponents
-api-type: winrt enum
---
<!-- Enumeration syntax.
public enum ColorSpectrumComponents : int 
-->

# Microsoft.UI.Xaml.Controls.ColorSpectrumComponents

## -description

Defines constants that specify how the Hue-Saturation-Value (HSV) color components are mapped onto the [ColorSpectrum](../microsoft.ui.xaml.controls.primitives/colorspectrum.md).

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -enum-fields

### -field ValueSaturation:5

Value is mapped to the X axis. Saturation is mapped to the Y axis.

### -field ValueHue:1

Value is mapped to the X axis. Hue is mapped to the Y axis.

### -field SaturationValue:4

Saturation is mapped to the X axis. Value is mapped to the Y axis.

### -field SaturationHue:3

Saturation is mapped to the X axis. Hue is mapped to the Y axis.

### -field HueValue:0

Hue is mapped to the X axis. Value is mapped to the Y axis.

### -field HueSaturation:2

Hue is mapped to the X axis. Saturation is mapped to the Y axis.

## -remarks

The order of the two components in each value indicates the X/Y axis when the spectrum is a box, or the degree/radius when the spectrum is a ring.

## -see-also

[ColorPicker.ColorSpectrumComponents](colorpicker_colorspectrumcomponents.md), [ColorSpectrum.Components](../microsoft.ui.xaml.controls.primitives/colorspectrum_components.md), [Color picker](https://docs.microsoft.com/windows/uwp/controls-and-patterns/color-picker)

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Color picker](/windows/apps/design/controls/color-picker).
>
> The **WinUI 3 Gallery** and **WinUI 2 Gallery** apps include interactive examples of most WinUI 3 and WinUI 2 controls, features, and functionality.
>
> If installed already, open them by clicking the following links: [**WinUI 3 Gallery**](winui3gallery:/item/ColorPicker) or [**WinUI 2 Gallery**](winui2gallery:/item/ColorPicker).
>
> If they are not installed, you can download the [**WinUI 3 Gallery**](https://www.microsoft.com/store/productId/9P3JFPWWDZRC) and the [**WinUI 2 Gallery**](https://www.microsoft.com/store/productId/9MSVH128X2ZT) from the Microsoft Store.
>
> You can also get the source code for both from [GitHub](https://github.com/Microsoft/WinUI-Gallery) (use the *main* branch for WinUI 3 and the *winui2* branch for WinUI 2).
