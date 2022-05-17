---
-api-id: T:Microsoft.UI.Xaml.Controls.TabViewCloseButtonOverlayMode
-api-type: winrt enum
---

# Microsoft.UI.Xaml.Controls.TabViewCloseButtonOverlayMode

<!--
public enum TabViewCloseButtonOverlayMode
-->

## -description

Defines constants that describe the behavior of the close button contained within each [TabViewItem](tabviewitem.md).

## -enum-fields

### -field Always

The selected tab always shows the close button if it is closable. Unselected tabs always show the close button if they are closable.

### -field Auto

Behavior is defined by the framework. Default.

This value maps to **Always**.

### -field OnPointerOver

The selected tab always shows the close button if it is closable. Unselected tabs show the close button when the tab is closable and the user has their pointer over the tab.

## -remarks

Selected TabViewItems that are closable always show their close button regardless of the value of the TabViewCloseButtonOverlayMode property. The TabViewCloseButtonOverlayMode only effects the behavior of the unselected TabViewItems.

## -see-also

[TabView](tabview.md), [TabViewItem](tabviewitem.md), [Guidelines for TabView](/windows/apps/design/controls/tab-view)

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [TabView](/windows/apps/design/controls/tab-view).
>
> The **WinUI 3 Gallery** and **WinUI 2 Gallery** apps include interactive examples of most WinUI 3 and WinUI 2 controls, features, and functionality.
>
> If installed already, open them by clicking the following links: [**WinUI 3 Gallery**](winui3gallery:/item/TabView) or [**WinUI 2 Gallery**](winui2gallery:/item/TabView).
>
> If they are not installed, you can download the [**WinUI 3 Gallery**](https://www.microsoft.com/store/productId/9P3JFPWWDZRC) and the [**WinUI 2 Gallery**](https://www.microsoft.com/store/productId/9MSVH128X2ZT) from the Microsoft Store.
>
> You can also get the source code for both from [GitHub](https://github.com/Microsoft/WinUI-Gallery) (use the *main* branch for WinUI 3 and the *winui2* branch for WinUI 2).

