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

## -remarks

You can add other controls to a CommandBarFlyout by wrapping them in an [AppBarElementContainer](/uwp/api/windows.ui.xaml.controls.appbarelementcontainer?view=winrt-19041). This includes controls such as [DropDownButton](dropdownbutton.md) or [SplitButton](splitbutton.md), or containers like [StackPanel](/uwp/api/windows.ui.xaml.controls.stackpanel?view=winrt-19041) for more complex UI.

## -see-also

[Command bar flyout](/windows/apps/design/controls/command-bar-flyout)

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Command bar flyout](/windows/apps/design/controls/command-bar-flyout).
>
> The **WinUI 3 Gallery** and **WinUI 2 Gallery** apps include interactive examples of most WinUI 3 and WinUI 2 controls, features, and functionality.
>
> If installed already, open them by clicking the following links: [**WinUI 3 Gallery**](winui3gallery:/item/CommandBarFlyout) or [**WinUI 2 Gallery**](winui2gallery:/item/CommandBarFlyout).
>
> If they are not installed, you can download the [**WinUI 3 Gallery**](https://www.microsoft.com/p/winui-3-controls-gallery/9p3jfpwwdzrc) and the [**WinUI 2 Gallery**](https://www.microsoft.com/p/xaml-controls-gallery/9msvh128x2zt) from the Microsoft Store.
>
> You can also get the source code for both from [GitHub](https://github.com/Microsoft/WinUI-Gallery) (use the *main* branch for WinUI 3 and the *winui2* branch for WinUI 2).

## -xaml-syntax

```xaml
<CommandBarFlyout .../>
-or-
<CommandBarFlyout>
  commandBarElements
</CommandBarFlyout>
```
