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

> [!TIP]
> For more info, design guidance, and code examples, see [ItemsRepeater](/windows/apps/design/controls/items-repeater).
>
> The **WinUI 3 Gallery** and **WinUI 2 Gallery** apps include interactive examples of most WinUI 3 and WinUI 2 controls, features, and functionality.
>
> If installed already, open them by clicking the following links: [**WinUI 3 Gallery**](winui3gallery:/item/ItemsRepeater) or [**WinUI 2 Gallery**](winui2gallery:/item/ItemsRepeater).
>
> If they are not installed, you can download the [**WinUI 3 Gallery**](https://www.microsoft.com/store/productId/9P3JFPWWDZRC) and the [**WinUI 2 Gallery**](https://www.microsoft.com/store/productId/9MSVH128X2ZT) from the Microsoft Store.
>
> You can also get the source code for both from [GitHub](https://github.com/Microsoft/WinUI-Gallery) (use the *main* branch for WinUI 3 and the *winui2* branch for WinUI 2).

