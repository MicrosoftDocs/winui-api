---
-api-id: P:Microsoft.UI.Xaml.Controls.NavigationView.FooterMenuItems
-api-type: winrt property
---

# Microsoft.UI.Xaml.Controls.NavigationView.FooterMenuItems

<!--
public System.Collections.Generic.IList<object> FooterMenuItems { get; }
-->


## -description
Gets the list of objects to be used as navigation items in the footer menu.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -property-value
The collection of menu items displayed in the footer section of the NavigationView. The default is an empty collection.

## -remarks
FooterMenuItems participates in the same selection model as [NavigationView.MenuItems](navigationview_menuitems.md). Therefore, only one [NavigationViewItem](navigationviewitem.md) within the NavigationView can be selected at a time, whether it is in the main menu items or footer menu items. 

FooterMenuItems will be displayed above the Settings Item by default. To remove the Settings item, set the `IsSettingsVisible` property to `false`.

## -see-also
[NavigationView](navigationview.md)

## -examples

## Add footer menu items in markup

```xaml
<muxc:NavigationView>

    <muxc:NavigationView.MenuItems>
        <muxc:NavigationViewItem Content="Browse" Icon="Library" />
        <muxc:NavigationViewItem Content="Track an Order" Icon="Map" />
        <muxc:NavigationViewItem Content="Order History" Icon="Tag" />
    </muxc:NavigationView.MenuItems>

    <muxc:NavigationView.FooterMenuItems>
        <muxc:NavigationViewItem Content="Account" Icon="Contact" />
        <muxc:NavigationViewItem Content="Your Cart" Icon="Shop" />
        <muxc:NavigationViewItem Content="Help" Icon="Help" />
    </muxc:NavigationView.FooterMenuItems>
    
</muxc:NavigationView>
```
