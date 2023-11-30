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

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -remarks

> [!TIP]
> For more info, design guidance, and code examples, see [Breadcrumb bar overview](/windows/apps/design/controls/breadcrumbbar).

A `BreadcrumbBar` provides the direct path of pages or folders to the current location. It is often used for situations where the user's navigation trail (in a file system or menu system) needs to be persistently visible and the user may need to go back to a previous location.

If the app is resized so that there is not enough space to show all the nodes, the breadcrumbs collapse and an ellipsis replaces the leftmost nodes. Clicking the ellipsis opens a flyout to show the collapsed nodes.

### Control style and template

You can modify the default [Style](/uwp/api/windows.ui.xaml.frameworkelement.style) and [ControlTemplate](/uwp/api/windows.ui.xaml.controls.controltemplate) to give the control a unique appearance. For information about modifying a control's style and template, see [XAML styles](/windows/apps/design/style/xaml-styles). The default style, template, and resources that define the look of the control are included in the `generic.xaml` file. For design purposes, `generic.xaml` is installed with the WinUI (Microsoft.UI.Xaml) NuGet package. By default, this location is `\Users\<username>\.nuget\packages\microsoft.ui.xaml\<version>\lib\uap10.0\Microsoft.UI.Xaml\Themes\generic.xaml`. Styles and resources from different versions of WinUI might have different values.

XAML also includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. Modifying these resources is preferred to setting properties such as [Background](control_background.md) and [Foreground](control_foreground.md). For more info, see the [Light-weight styling](/windows/apps/design/style/xaml-styles#lightweight-styling) section of the [XAML styles](/windows/apps/design/style/xaml-styles) article.

## -see-also

[Breadcrumb bar overview](/windows/apps/design/controls/breadcrumbbar)

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Breadcrumb bar](/windows/apps/design/controls/breadcrumbbar).

> [!div class="nextstepaction"]
> [Open the WinUI 2 Gallery app and see the BreadcrumbBar in action](winui2gallery:/item/BreadcrumbBar).

> The **WinUI 2 Gallery** app includes interactive examples of most WinUI 2 controls, features, and functionality. Get the app from the [Microsoft Store](https://www.microsoft.com/store/productId/9MSVH128X2ZT) or get the source code on [GitHub](https://github.com/Microsoft/WinUI-Gallery/tree/winui2).
