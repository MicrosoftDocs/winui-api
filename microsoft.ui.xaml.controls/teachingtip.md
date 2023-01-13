---
-api-id: T:Microsoft.UI.Xaml.Controls.TeachingTip
-api-type: winrt class
---

# Microsoft.UI.Xaml.Controls.TeachingTip

<!--
public class TeachingTip : Windows.UI.Xaml.Controls.ContentControl
-->

## -description

A teaching tip is a notification flyout used to provide contextually relevant information. It supports rich content (including titles, subtitles, icons, images, and text) and can be configured for either explicit or light-dismiss.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -remarks

Teaching tips are often used for informing, reminding, and teaching users about new or important features that might enhance their experience.

### Control style and template

You can modify the default [Style](/uwp/api/windows.ui.xaml.frameworkelement.style) and [ControlTemplate](/uwp/api/windows.ui.xaml.controls.controltemplate) to give the control a unique appearance. For information about modifying a control's style and template, see [XAML styles](/windows/apps/design/style/xaml-styles). XAML also includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. Modifying these resources is preferred to setting properties such as [Background](/uwp/api/windows.ui.xaml.controls.control.background) and [Foreground](/uwp/api/windows.ui.xaml.controls.control.foreground). For more info, see the [Light-weight styling](/windows/apps/design/style/xaml-styles#lightweight-styling) section of the [XAML styles](/windows/apps/design/style/xaml-styles) article.

The resources for this control are listed in the [ThemeDictionaries](/windows/apps/design/style/xaml-theme-resources) section of the [TeachingTip_rs2_themeresources.xaml](https://github.com/microsoft/microsoft-ui-xaml/blob/main/dev/TeachingTip/TeachingTip_rs2_themeresources.xaml) file on GitHub. The `ResourceKey` value for each `StaticResource` references a brush and color in the [Common_themeresources_any.xaml](https://github.com/microsoft/microsoft-ui-xaml/blob/main/dev/CommonStyles/Common_themeresources_any.xaml) file.

## -see-also

[TeachingTipClosedEventArgs](teachingtipclosedeventargs.md), [TeachingTipCloseReason](teachingtipclosereason.md), [TeachingTipClosingEventArgs](teachingtipclosingeventargs.md), [TeachingTipHeroContentPlacementMode](teachingtipherocontentplacementmode.md), [TeachingTipPlacementMode](teachingtipplacementmode.md), [TeachingTipTailVisibility](teachingtiptailvisibility.md), [TeachingTipTemplateSettings](teachingtiptemplatesettings.md), [Teaching tip overview](/windows/apps/design/controls/dialogs-and-flyouts/teaching-tip)

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Teaching tip](/windows/apps/design/controls/teaching-tip).

> [!div class="nextstepaction"]
> [Open the WinUI 2 Gallery app and see TeachingTip in action](winui2gallery:/item/TeachingTip).

> The **WinUI 2 Gallery** app includes interactive examples of most WinUI 2 controls, features, and functionality. Get the app from the [Microsoft Store](https://www.microsoft.com/store/productId/9MSVH128X2ZT) or get the source code on [GitHub](https://github.com/Microsoft/WinUI-Gallery/tree/winui2).

