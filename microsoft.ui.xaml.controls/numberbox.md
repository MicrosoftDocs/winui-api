---
-api-id: T:Microsoft.UI.Xaml.Controls.NumberBox
-api-type: winrt class
---

# Microsoft.UI.Xaml.Controls.NumberBox

<!--
public class NumberBox : Windows.UI.Xaml.Controls.Control
-->

## -description

Represents a control that can be used to display and edit numbers.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -remarks

This control supports validation, increment stepping, and computing inline calculations of basic equations such as multiplication, division, addition, and subtraction.

### Control style and template

You can modify the default [Style](/uwp/api/windows.ui.xaml.frameworkelement.style) and [ControlTemplate](/uwp/api/windows.ui.xaml.controls.controltemplate) to give the control a unique appearance. For information about modifying a control's style and template, see [XAML styles](/windows/apps/design/style/xaml-styles). The default style, template, and resources that define the look of the control are included in the `generic.xaml` file. For design purposes, `generic.xaml` is installed with the WinUI (Microsoft.UI.Xaml) NuGet package. By default, this location is `\Users\<username>\.nuget\packages\microsoft.ui.xaml\<version>\lib\uap10.0\Microsoft.UI.Xaml\Themes\generic.xaml`. Styles and resources from different versions of WinUI might have different values.

XAML also includes resources that you can use to modify the colors of a control in different visual states without modifying the control template (modifying these resources is preferred to setting properties). For more info, see the [Light-weight styling](/windows/apps/design/style/xaml-styles#lightweight-styling) section of the [XAML styles](/windows/apps/design/style/xaml-styles) article.

## -see-also

[NumberBoxSpinButtonPlacementMode](numberboxspinbuttonplacementmode.md), [NumberBoxValidationMode](numberboxvalidationmode.md), [NumberBoxValueChangedEventArgs](numberboxvaluechangedeventargs.md)

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Number box](/windows/apps/design/controls/number-box).

> [!div class="nextstepaction"]
> [Open the WinUI 2 Gallery app and see the NumberBox in action](winui2gallery:/item/NumberBox).

> The **WinUI 2 Gallery** app includes interactive examples of most WinUI 2 controls, features, and functionality. Get the app from the [Microsoft Store](https://www.microsoft.com/store/productId/9MSVH128X2ZT) or get the source code on [GitHub](https://github.com/Microsoft/WinUI-Gallery/tree/winui2).
