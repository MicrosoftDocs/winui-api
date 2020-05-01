---
-api-id: P:Microsoft.UI.Xaml.Controls.RadioMenuFlyoutItem.IsChecked
-api-type: winrt property
---

# Microsoft.UI.Xaml.Controls.RadioMenuFlyoutItem.IsChecked

<!--
public bool IsChecked { get; set; }
-->

## -description
Gets or sets whether the RadioMenuFlyoutItem is checked.

## -property-value

## -remarks

## -see-also

## -examples
*RadioMenuFlyoutItem* can be added into a *MenuBarItem*, *MenuFlyout*, or *MenuFlyoutSubItem*. The following example shows three radio menu flyout items as the content of a cascading menu flyout. The "Medium icons" item is checked.

![Three radio menu flyout items in a View goup that allow a user to select the size of icons](images/RadioMenuFlyoutItems.png)

```xaml
<MenuFlyout>
    <MenuFlyoutSubItem Text="View">
        <muxc:RadioMenuFlyoutItem Text="Small icons"/>
        <muxc:RadioMenuFlyoutItem Text="Medium icons" IsChecked="True"/>
        <muxc:RadioMenuFlyoutItem Text="Large icons"/>
    </MenuFlyoutSubItem>
</MenuFlyout>
```
