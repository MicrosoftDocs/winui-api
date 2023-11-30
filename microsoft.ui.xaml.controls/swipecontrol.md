---
-api-id: T:Microsoft.UI.Xaml.Controls.SwipeControl
-api-type: winrt class
---
<!-- Class syntax.
public class SwipeControl : ContentControl, ContentControl
-->

# Microsoft.UI.Xaml.Controls.SwipeControl

## -description

Represents a container that provides access to, and the ability to invoke, contextual commands through a basic touch interaction.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -remarks

The following image shows how a small set of contextual commands can be exposed through the SwipeControl.

:::image type="content" source="images/controls/lightthemeswipe.png" alt-text="Contextual commands exposed through a Swipe gesture":::

### Control style and template

You can modify the default [Style](/uwp/api/windows.ui.xaml.frameworkelement.style) and [ControlTemplate](/uwp/api/windows.ui.xaml.controls.controltemplate) to give the control a unique appearance. For information about modifying a control's style and template, see [XAML styles](/windows/apps/design/style/xaml-styles). The default style, template, and resources that define the look of the control are included in the `generic.xaml` file. For design purposes, `generic.xaml` is installed with the WinUI (Microsoft.UI.Xaml) NuGet package. By default, this location is `\Users\<username>\.nuget\packages\microsoft.ui.xaml\<version>\lib\uap10.0\Microsoft.UI.Xaml\Themes\generic.xaml`. Styles and resources from different versions of WinUI might have different values.

XAML also includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. Modifying these resources is preferred to setting properties such as [Background](control_background.md) and [Foreground](control_foreground.md). For more info, see the [Light-weight styling](/windows/apps/design/style/xaml-styles#lightweight-styling) section of the [XAML styles](/windows/apps/design/style/xaml-styles) article.

## -see-also

[SwipeItem](swipeitem.md), [SwipeItems](swipeitems.md), [SwipeMode](swipemode.md), [SwipeBehaviorOnInvoked](swipebehavioroninvoked.md)

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Swipe](/windows/apps/design/controls/swipe).

> [!div class="nextstepaction"]
> [Open the WinUI 2 Gallery app and see SwipeControl in action](winui2gallery:/item/SwipeControl).

> The **WinUI 2 Gallery** app includes interactive examples of most WinUI 2 controls, features, and functionality. Get the app from the [Microsoft Store](https://www.microsoft.com/store/productId/9MSVH128X2ZT) or get the source code on [GitHub](https://github.com/Microsoft/WinUI-Gallery/tree/winui2).

## -xaml-syntax

```xaml
<SwipeControl .../>
```
