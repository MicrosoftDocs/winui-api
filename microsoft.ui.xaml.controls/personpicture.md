---
-api-id: T:Microsoft.UI.Xaml.Controls.PersonPicture
-api-type: winrt class
---
<!-- Class syntax.
public class PersonPicture : Control, Control
-->

# Microsoft.UI.Xaml.Controls.PersonPicture

## -description

Represents a control that displays the avatar image for a person, if one is available; if not, it displays the person's initials or a generic glyph.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -remarks

### Control style and template

You can modify the default [Style](/uwp/api/windows.ui.xaml.frameworkelement.style) and [ControlTemplate](/uwp/api/windows.ui.xaml.controls.controltemplate) to give the control a unique appearance. For information about modifying a control's style and template, see [XAML styles](/windows/apps/design/style/xaml-styles). XAML also includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. Modifying these resources is preferred to setting properties such as [Background](/uwp/api/windows.ui.xaml.controls.control.background) and [Foreground](/uwp/api/windows.ui.xaml.controls.control.foreground). For more info, see the [Light-weight styling](/windows/apps/design/style/xaml-styles#lightweight-styling) section of the [XAML styles](/windows/apps/design/style/xaml-styles) article.

The resources for this control are listed in the [ThemeDictionaries](/windows/apps/design/style/xaml-theme-resources) section of the [PersonPicture_themeresources.xaml](https://github.com/microsoft/microsoft-ui-xaml/blob/main/dev/PersonPicture/PersonPicture_themeresources.xaml) file on GitHub. The `ResourceKey` value for each `StaticResource` references a brush and color in the [Common_themeresources_any.xaml](https://github.com/microsoft/microsoft-ui-xaml/blob/main/dev/CommonStyles/Common_themeresources_any.xaml) file.

## -see-also

[Person picture control](https://docs.microsoft.com/windows/apps/design/controls/person-picture)

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Person picture](/windows/apps/design/controls/person-picture).

> [!div class="nextstepaction"]
> [Open the WinUI 2 Gallery app and see the PersonPicture in action](winui2gallery:/item/NavigationView).

> The **WinUI 2 Gallery** app includes interactive examples of most WinUI 2 controls, features, and functionality. Get the app from the [Microsoft Store](https://www.microsoft.com/store/productId/9MSVH128X2ZT) or get the source code on [GitHub](https://github.com/Microsoft/WinUI-Gallery/tree/winui2).

## -xaml-syntax

```xaml
<PersonPicture/>
```
