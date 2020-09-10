---
-api-id: T:Microsoft.UI.Xaml.Controls.UniformGridLayoutItemsStretch
-api-type: winrt enum
---

# Microsoft.UI.Xaml.Controls.UniformGridLayoutItemsStretch

<!--
public enum UniformGridLayoutItemsStretch
-->

## -description

Defines constants that specify how items are sized to fill the available space.

## -enum-fields

### -field Fill

The item is sized to fill the available space in the non-scrolling direction. Item size in the scrolling direction is not changed.

### -field None

The item retains its natural size. Use of extra space is determined by the [ItemsJustification](uniformgridlayout_itemsjustification.md) property.

### -field Uniform

The item is sized to both fill the available space in the non-scrolling direction and maintain its aspect ratio.

## -remarks

This enumeration provides values for the [UniformGrid.ItemsStretch](uniformgridlayout_itemsstretch.md) property.

## -see-also

[UniformGridLayout](uniformgridlayout.md), [UniformGrid.ItemsStretch](uniformgridlayout_itemsstretch.md)

## -examples

See the **XAML Controls Gallery** sample app for examples of WinUI features and controls.

If you have the **XAML Controls Gallery** app installed, see the [ItemsRepeater](xamlcontrolsgallery:/item/ItemsRepeater) in action.

Otherwise, download the [XAML Controls Gallery app](https://www.microsoft.com/store/productId/9MSVH128X2ZT) from the Microsoft Store or see the [XAML Controls Gallery app source code](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlUIBasics) on GitHub.

You can also view, clone, and build the XAML Controls Gallery source code from [GitHub](https://github.com/Microsoft/Xaml-Controls-Gallery) (switch to the [WinUI 3 Preview branch](https://github.com/microsoft/Xaml-Controls-Gallery/tree/winui3preview) for WinUI 3 Preview controls and features).
