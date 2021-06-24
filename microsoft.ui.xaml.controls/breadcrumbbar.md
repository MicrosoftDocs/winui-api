---
-api-id: T:Microsoft.UI.Xaml.Controls.BreadcrumbBar
-api-type: winrt class
---

# Microsoft.UI.Xaml.Controls.BreadcrumbBar

<!--
public class BreadcrumbBar : Windows.UI.Xaml.Controls.Control
-->


## -description

The `BreadcrumbBar` control provides the direct path of pages or folders to the current location.

## -remarks

> [!TIP]
> For more info, design guidance, and code examples, see [Breadcrumb bar overview](/windows/uwp/design/controls-and-patterns/breadcrumbbar).

A [BreadcrumbBar](/windows/winui/api/microsoft.ui.xaml.controls.breadcrumbbar) provides the direct path of pages or folders to the current location. It is often used for situations where the user's navigation trail (in a file system or menu system) needs to be persistently visible and the user may need to go back to a previous location.

If the app is resized so that there is not enough space to show all the nodes, the breadcrumbs collapse and an ellipsis replaces the leftmost nodes. Clicking the ellipsis opens a flyout to show the collapsed nodes.

### Control style and template

You can modify the default [Style](../microsoft.ui.xaml/style.md) and [ControlTemplate](controltemplate.md) to give the control a unique appearance. For information about modifying a control's style and template, see [Styling controls](/windows/uwp/controls-and-patterns/styling-controls). The default style, template, and resources that define the look of the control are included in the generic.xaml file. For design purposes, generic.xaml is available in the \(Program Files)\Windows Kits\10\DesignTime\CommonConfiguration\Neutral\UAP\ &lt;SDK version&gt;\Generic folder from a Windows Software Development Kit (SDK) installation. Styles and resources from different versions of the SDK might have different values.

Starting in Windows 10, version 1607 (SDK 14393), generic.xaml includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. In apps that target this software development kit (SDK) or later, modifying these resources is preferred to setting properties such as [Background](control_background.md) and [Foreground](control_foreground.md). For more info, see the [Light-weight styling](/windows/uwp/controls-and-patterns/styling-controls) section of the [Styling controls](/windows/uwp/controls-and-patterns/styling-controls) article.

This table shows the resources used by the BreadcrumbBar control.

| Resource key | Description |
|:-:|:--|
| BreadcrumbBackgroundBrush | Sets the background color |
| BreadcrumbBorderBrush | Sets the border color |
| BreadcrumbItemThemeFontSize | Sets the item font size |

| Resource key | Description |
|:-:|:--|
| BreadcrumbBarChevronLeftToRight | Chevron for left to right mode |
| BreadcrumbBarChevronRightToLeft | Chevron for right to left mode |
| BreadcrumbBarChevronPadding | Chevron padding thickness |
| BreadcrumbBarItemFontWeight | Item font weight |
| BreadcrumbBarNormalForegroundBrush | Foreground color at rest |
| BreadcrumbBarHoverForegroundBrush | Foreground color on hover |
| BreadcrumbBarPressedForegroundBrush | Foreground color when pressed |
| BreadcrumbBarDisabledForegroundBrush | Foreground color when disabled |
| BreadcrumbBarFocusForegroundBrush | Foreground color on focus |
| BreadcrumbBarCurrentNormalForegroundBrush | Current item foreground color at rest |
| BreadcrumbBarCurrentHoverForegroundBrush | Current item foreground color on hover |
| BreadcrumbBarCurrentPressedForegroundBrush | Current item foreground color when pressed |
| BreadcrumbBarCurrentDisabledForegroundBrush | Current item foreground color when disabled |
| BreadcrumbBarCurrentFocusForegroundBrush | Current item foreground color on focus |
| BreadcrumbBarEllipsisDropDownItemBackground | Ellipsis dropdown item background color at rest |
| BreadcrumbBarEllipsisDropDownItemBackgroundPointerOver | Ellipsis dropdown item background color on pointer over |
| BreadcrumbBarEllipsisDropDownItemBackgroundPressed | Ellipsis dropdown item background color when pressed |
| BreadcrumbBarEllipsisDropDownItemBackgroundDisabled | Ellipsis dropdown item background color when disabled |
| BreadcrumbBarEllipsisDropDownItemForegroundPointerOver | Ellipsis dropdown item foreground color on pointer over |
| BreadcrumbBarEllipsisDropDownItemForegroundPressed | Ellipsis dropdown item foreground color when pressed |
| BreadcrumbBarEllipsisDropDownItemForegroundDisabled | Ellipsis dropdown item foreground color when disabled |
| BreadcrumbBarForegroundBrush | Foreground color at rest |
| BreadcrumbBarBackgroundBrush | Background color |
| BreadcrumbBarBorderBrush | Border color at rest |
| BreadcrumbBarEllipsisFlyoutPresenterBackground | Ellipsis flyout presenter background color |
| BreadcrumbBarEllipsisFlyoutPresenterBorderBrush | Ellipsis flyout presenter border color |
| BreadcrumbBarEllipsisFlyoutPresenterBorderThemeThickness | Ellipsis flyout presenter border thickness |
| BreadcrumbBarItemThemeFontSize | Item font size |
| BreadcrumbBarChevronFontSize | Chevron font size |

## -see-also

[Breadcrumb bar overview](/windows/uwp/design/controls-and-patterns/breadcrumbbar)

## -examples

See the **XAML Controls Gallery** sample app for examples of WinUI features and controls.

If you have the **XAML Controls Gallery** app installed, see the [BreadcrumbBar](xamlcontrolsgallery:/item/BreadcrumbBar) in action.

If you don't have the XAML Controls Gallery app installed, get the WinUI 2.x version from the [Microsoft Store](https://www.microsoft.com/p/xaml-controls-gallery/9msvh128x2zt).

You can also view, clone, and build the XAML Controls Gallery source code from [GitHub](https://github.com/Microsoft/Xaml-Controls-Gallery) (switch to the [WinUI 3 Preview branch](https://github.com/microsoft/Xaml-Controls-Gallery/tree/winui3preview) for WinUI 3 Preview controls and features).
