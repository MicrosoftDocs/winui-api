---
-api-id: T:Microsoft.UI.Xaml.Controls.Primitives.CornerRadiusFilterKind
-api-type: winrt enum
---

# Microsoft.UI.Xaml.Controls.Primitives.CornerRadiusFilterKind

<!--
public enum CornerRadiusFilterKind
-->

## -description

Defines constants that specify the filter type for a [CornerRadiusFilterConverter](cornerradiusfilterconverter.md) instance.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -enum-fields

### -field Bottom

Filters BottomLeft and BottomRight values, sets TopLeft and TopRight to 0.

### -field Left

Filters TopLeft and BottomLeft values, sets TopRight and BottomRight to 0.

### -field None

No filter applied.

### -field Right

Filters TopRight and BottomRight values, sets TopLeft and BottomLeft to 0.

### -field Top

Filters TopLeft and TopRight values, sets BottomLeft and BottomRight to 0.

### -field BottomRightValue

Gets the double value of BottomRight corner.

### -field TopLeftValue

Gets the double value of TopLeft corner.

## -remarks

## -see-also

## -examples

See the **XAML Controls Gallery** sample app for examples of WinUI features and controls.

If you have the **XAML Controls Gallery** app installed, [open the app to see the controls in action](xamlcontrolsgallery:).

If you don't have the XAML Controls Gallery app installed, get the WinUI 2.x version from the [Microsoft Store](https://www.microsoft.com/p/xaml-controls-gallery/9msvh128x2zt).

You can also view, clone, and build the XAML Controls Gallery source code from [GitHub](https://github.com/Microsoft/Xaml-Controls-Gallery) (switch to the [WinUI 3 Preview branch](https://github.com/microsoft/Xaml-Controls-Gallery/tree/winui3preview) for WinUI 3 Preview controls and features).
