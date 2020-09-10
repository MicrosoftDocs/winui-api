---
-api-id: T:Microsoft.UI.Xaml.Controls.NumberBoxSpinButtonPlacementMode
-api-type: winrt enum
---

# Microsoft.UI.Xaml.Controls.NumberBoxSpinButtonPlacementMode

<!--
public enum NumberBoxSpinButtonPlacementMode
-->

## -description

Defines values that specify how the spin buttons used to increment or decrement the [Value](numberbox_value.md) of a [NumberBox](numberbox.md) are displayed.

## -enum-fields

### -field Hidden

The spin buttons are not displayed.

### -field Compact

The spin buttons have two visual states, depending on focus. By default, the spin buttons are displayed in a compact, vertical orientation. When the Numberbox gets focus, the spin buttons expand.

:::image type="content" source="images/controls/numberbox-spinbuttonplacementmode-compact.png" alt-text="NumberBox showing both visual states for Compact spin buttons":::

### -field Inline

The spin buttons are displayed in an expanded, horizontal orientation.

:::image type="content" source="images/controls/numberbox-spinbuttonplacementmode-inline.png" alt-text="NumberBox with Inline spin buttons":::

## -remarks

## -see-also

## -examples

See the **XAML Controls Gallery** sample app for examples of WinUI features and controls.

If you have the **XAML Controls Gallery** app installed, see the [NumberBox](xamlcontrolsgallery:/item/NumberBox) in action.

If you don't have the XAML Controls Gallery app installed, get the WinUI 2.x version from the [Microsoft Store](https://www.microsoft.com/p/xaml-controls-gallery/9msvh128x2zt).

You can also view, clone, and build the XAML Controls Gallery source code from [GitHub](https://github.com/Microsoft/Xaml-Controls-Gallery) (switch to the [WinUI 3 Preview branch](https://github.com/microsoft/Xaml-Controls-Gallery/tree/winui3preview) for WinUI 3 Preview controls and features).
