---
-api-id: T:Microsoft.UI.Xaml.Controls.InfoBadge
-api-type: winrt class
---

# Microsoft.UI.Xaml.Controls.InfoBadge

<!--
public class InfoBadge : Windows.UI.Xaml.Controls.Control
-->

## -description

Represents a control for indicating notifications, alerts, new content, or to attract focus to an area within an app.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -remarks

If neither [InfoBadge.Value](infobadge_value.md) and [InfoBadge.IconSource](infobadge_iconsource.md) are set (default values are used), the InfoBadge defaults to a dot indicator. If both Value and IconSource properties are set, the Value property is used.

### Control style and template

You can modify the default [Style](/uwp/api/windows.ui.xaml.frameworkelement.style) and [ControlTemplate](/uwp/api/windows.ui.xaml.controls.controltemplate) to give the control a unique appearance. For information about modifying a control's style and template, see [XAML styles](/windows/apps/design/style/xaml-styles). The default style, template, and resources that define the look of the control are included in the `generic.xaml` file. For design purposes, `generic.xaml` is installed with the WinUI (Microsoft.UI.Xaml) NuGet package. By default, this location is `\Users\<username>\.nuget\packages\microsoft.ui.xaml\<version>\lib\uap10.0\Microsoft.UI.Xaml\Themes\generic.xaml`. Styles and resources from different versions of WinUI might have different values.

XAML also includes resources that you can use to modify the colors of a control in different visual states without modifying the control template (modifying these resources is preferred to setting properties). For more info, see the [Light-weight styling](/windows/apps/design/style/xaml-styles#lightweight-styling) section of the [XAML styles](/windows/apps/design/style/xaml-styles) article.

## -see-also

[InfoBadge overview](/windows/apps/design/controls/info-badge)

## -examples

Here's an example of a simple InfoBadge that's set to display the number of unread emails:

```xml
<InfoBadge x:Name="emailInfoBadge" Value="{x:Bind numUnreadMail}"/>
```
