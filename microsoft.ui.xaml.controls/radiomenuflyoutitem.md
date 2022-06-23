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

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -remarks

This control allows you to present users with menus containing multiple options, where a user would choose only one of these options at a given time.

RadioMenuFlyoutItem can be used inside [MenuBarItem](https://docs.microsoft.com/uwp/api/windows.ui.xaml.controls.menubaritem), [MenuFlyout](https://docs.microsoft.com/uwp/api/windows.ui.xaml.controls.menuflyout) and [MenuFlyoutSubItem](https://docs.microsoft.com/uwp/api/windows.ui.xaml.controls.menuflyoutsubitem).

## -see-also

[Creating a menu](/windows/apps/design/controls/menus#create-a-menu-flyout-or-a-context-menu)

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Menu flyout and menu bar](/windows/apps/design/controls/menus).

> [!div class="nextstepaction"]
> [Open the WinUI 2 Gallery app and see the MenuFlyout in action](winui2gallery:/item/MenuFlyout).

> The **WinUI 2 Gallery** app includes interactive examples of most WinUI 2 controls, features, and functionality. Get the app from the [Microsoft Store](https://www.microsoft.com/store/productId/9MSVH128X2ZT) or get the source code on [GitHub](https://github.com/Microsoft/WinUI-Gallery/tree/winui2).

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
