---
-api-id: T:Microsoft.UI.Xaml.Controls.PipsPagerButtonVisibility
-api-type: winrt enum
---

# Microsoft.UI.Xaml.Controls.PipsPagerButtonVisibility

<!--
public enum PipsPagerButtonVisibility
-->

## -description

Defines constants that specify how the navigation buttons of the [PipsPager](pipspager.md) are displayed.

## -enum-fields

### -field Visible: 0

The navigation button is visible and enabled, but hidden when content is at one or the other extent. For example, the Previous button is hidden when the current page is the first page, and the Next button is hidden when the current page is the last page.

### -field VisibleOnPointerOver: 1

The button behavior is the same as *Visible* except the button is visible only when the pointer cursor is over the pager, or keyboard focus is inside the pager or on a navigation button.

### -field Collapsed: 2

The button is not visible and does not take up layout space.

## -remarks

## -see-also

[PipsPager](pipspager.md), [PipsPager.PreviousButtonVisibility](pipspager_previousbuttonvisibility.md), [PipsPager.NextButtonVisbility](pipspager_nextbuttonvisibility.md), [PipsPager overview](/windows/apps/design/controls/pipspager)

## -examples

See the **XAML Controls Gallery** sample app for examples of WinUI features and controls.

If you have the **XAML Controls Gallery** app installed, see the [PipsPager](xamlcontrolsgallery:/item/PipsPager) in action.

If you don't have the XAML Controls Gallery app installed, get the WinUI 2.x version from the [Microsoft Store](https://www.microsoft.com/p/xaml-controls-gallery/9msvh128x2zt).

You can also view, clone, and build the XAML Controls Gallery source code from [GitHub](https://github.com/Microsoft/Xaml-Controls-Gallery) (switch to the [WinUI 3 Preview branch](https://github.com/microsoft/Xaml-Controls-Gallery/tree/winui3preview) for WinUI 3 Preview controls and features).
