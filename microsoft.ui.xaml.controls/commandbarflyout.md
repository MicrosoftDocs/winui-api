---
-api-id: T:Microsoft.UI.Xaml.Controls.CommandBarFlyout
-api-type: winrt class
---
<!-- Class syntax.
public class CommandBarFlyout : FlyoutBase, FlyoutBase
-->

# Microsoft.UI.Xaml.Controls.CommandBarFlyout

## -description

Represents a specialized flyout that provides layout for [AppBarButton](/uwp/api/windows.ui.xaml.controls.appbarbutton), [AppBarToggleButton](/uwp/api/Windows.UI.Xaml.Controls.AppBarToggleButton), and [AppBarSeparator](/uwp/api/Windows.UI.Xaml.Controls.AppBarSeparator) controls.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -remarks

You can add other controls to a CommandBarFlyout by wrapping them in an [AppBarElementContainer](/uwp/api/windows.ui.xaml.controls.appbarelementcontainer?view=winrt-19041). This includes controls such as [DropDownButton](dropdownbutton.md) or [SplitButton](splitbutton.md), or containers like [StackPanel](/uwp/api/windows.ui.xaml.controls.stackpanel?view=winrt-19041) for more complex UI.

## -see-also

[Command bar flyout](/windows/apps/design/controls/command-bar-flyout)

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Command bar flyout](/windows/apps/design/controls/command-bar-flyout).

> [!div class="nextstepaction"]
> [Open the WinUI 2 Gallery app and see the CommandBarFlyout in action](winui2gallery:/item/CommandBarFlyout).

> The **WinUI 2 Gallery** app includes interactive examples of most WinUI 2 controls, features, and functionality. Get the app from the [Microsoft Store](https://www.microsoft.com/store/productId/9MSVH128X2ZT) or get the source code on [GitHub](https://github.com/Microsoft/WinUI-Gallery/tree/winui2).

## -xaml-syntax

```xaml
<CommandBarFlyout .../>
-or-
<CommandBarFlyout>
  commandBarElements
</CommandBarFlyout>
```
