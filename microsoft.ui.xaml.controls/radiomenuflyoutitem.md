---
-api-id: T:Microsoft.UI.Xaml.Controls.RadioMenuFlyoutItem
-api-type: winrt class
---

# Microsoft.UI.Xaml.Controls.RadioMenuFlyoutItem

<!--
public class RadioMenuFlyoutItem : Windows.UI.Xaml.Controls.MenuFlyoutItem
-->

## -description

Represents a menu item that is mutually exclusive with other radio menu items in its group.

## -remarks

This control allows you to present users with menus containing multiple options, where a user would choose only one of these options at a given time.

RadioMenuFlyoutItem can be used inside [MenuBarItem](https://docs.microsoft.com/uwp/api/windows.ui.xaml.controls.menubaritem), [MenuFlyout](https://docs.microsoft.com/uwp/api/windows.ui.xaml.controls.menuflyout) and [MenuFlyoutSubItem](https://docs.microsoft.com/uwp/api/windows.ui.xaml.controls.menuflyoutsubitem).

## -see-also

[Creating a menu](/windows/apps/design/controls/menus#create-a-menu-flyout-or-a-context-menu)

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Menu flyout and menu bar](/windows/apps/design/controls/menus).
>
> The **WinUI 3 Gallery** and **WinUI 2 Gallery** apps include interactive examples of most WinUI 3 and WinUI 2 controls, features, and functionality.
>
> If installed already, open them by clicking the following links: [**WinUI 3 Gallery**](winui3gallery:/item/MenuFlyout) or [**WinUI 2 Gallery**](winui2gallery:/item/MenuFlyout).
>
> If they are not installed, you can download the [**WinUI 3 Gallery**](https://www.microsoft.com/store/productId/9P3JFPWWDZRC) and the [**WinUI 2 Gallery**](https://www.microsoft.com/store/productId/9MSVH128X2ZT) from the Microsoft Store.
>
> You can also get the source code for both from [GitHub](https://github.com/Microsoft/WinUI-Gallery) (use the *main* branch for WinUI 3 and the *winui2* branch for WinUI 2).


This example shows how to create a three item radio menu flyout experience.

```Xaml
<Button Content="Options">
    <Button.Flyout>
        <MenuFlyout>
            <MenuFlyoutSubItem Text="View">
                <muxc:RadioMenuFlyoutItem Text="Small icons" GroupName="ViewGroup"/>
                <muxc:RadioMenuFlyoutItem Text="Medium icons" GroupName="ViewGroup" IsChecked="True"/>
                <muxc:RadioMenuFlyoutItem Text="Large icons" GroupName="ViewGroup"/>
            </MenuFlyoutSubItem>
        </MenuFlyout>
    </Button.Flyout>
</Button>
```
