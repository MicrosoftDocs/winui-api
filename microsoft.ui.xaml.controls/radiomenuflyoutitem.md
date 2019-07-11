---
-api-id: T:Microsoft.UI.Xaml.Controls.RadioMenuFlyoutItem
-api-type: winrt class
---

## -description
Represents a menu item that is mutually exclusive with other radio menu items in its group.

## -remarks
This control allows you to present users with menus containing multiple options, where a user would choose only one of these options at a given time. 

RadioMenuFlyoutItem can be used inside [MenuBarItem](https://docs.microsoft.com/uwp/api/windows.ui.xaml.controls.menubaritem), [MenuFlyout](https://docs.microsoft.com/uwp/api/windows.ui.xaml.controls.menuflyout) and [MenuFlyoutSubItem](https://docs.microsoft.com/uwp/api/windows.ui.xaml.controls.menuflyoutsubitem).

## -see-also
[Creating a menu](https://docs.microsoft.com/windows/uwp/design/controls-and-patterns/menus#create-a-menu-flyout-or-a-context-menu)

## -examples
```Xaml
<MenuFlyout>
    <MenuFlyoutSubItem Text="View">
        <muxc:RadioMenuFlyoutItem Text="Small icons" GroupName="ViewGroup"/>
        <muxc:RadioMenuFlyoutItem Text="Medium icons" GroupName="ViewGroup" IsChecked="True"/>
        <muxc:RadioMenuFlyoutItem Text="Large icons" GroupName="ViewGroup"/>
    </MenuFlyoutSubItem>
</MenuFlyout>
```
