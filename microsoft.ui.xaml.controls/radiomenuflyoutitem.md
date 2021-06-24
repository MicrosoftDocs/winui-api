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

See the **XAML Controls Gallery** sample app for examples of WinUI features and controls.

If you have the **XAML Controls Gallery** app installed, see the [MenuFlyout](xamlcontrolsgallery:/item/MenuFlyout) in action.

If you don't have the XAML Controls Gallery app installed, get the WinUI 2.x version from the [Microsoft Store](https://www.microsoft.com/p/xaml-controls-gallery/9msvh128x2zt).

You can also view, clone, and build the XAML Controls Gallery source code from [GitHub](https://github.com/Microsoft/Xaml-Controls-Gallery) (switch to the [WinUI 3 Preview branch](https://github.com/microsoft/Xaml-Controls-Gallery/tree/winui3preview) for WinUI 3 Preview controls and features).
