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

[TabView](tabview.md), [TabViewItem](tabviewitem.md), [Guidelines for TabView](/windows/uwp/design/controls-and-patterns/tab-view)

## -examples

See the **XAML Controls Gallery** sample app for examples of WinUI features and controls.

If you have the **XAML Controls Gallery** app installed, see the [TabView](xamlcontrolsgallery:/item/TabView) in action.

If you don't have the XAML Controls Gallery app installed, get the WinUI 2.x version from the [Microsoft Store](https://www.microsoft.com/p/xaml-controls-gallery/9msvh128x2zt).

You can also view, clone, and build the XAML Controls Gallery source code from [GitHub](https://github.com/Microsoft/Xaml-Controls-Gallery) (switch to the [WinUI 3 Preview branch](https://github.com/microsoft/Xaml-Controls-Gallery/tree/winui3preview) for WinUI 3 Preview controls and features).
