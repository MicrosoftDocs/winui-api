---
-api-id: T:Microsoft.UI.Xaml.Controls.MenuFlyoutSubItem
-api-type: winrt class
---

<!-- Class syntax.
public class MenuFlyoutSubItem : Windows.UI.Xaml.Controls.MenuFlyoutItemBase, Windows.UI.Xaml.Controls.IMenuFlyoutSubItem
-->

# Microsoft.UI.Xaml.Controls.MenuFlyoutSubItem

## -description

Represents a menu item that displays a sub-menu in a [MenuFlyout](menuflyout.md) control.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -xaml-syntax

```xaml
<MenuFlyoutSubItem>
  oneOrMoreItems
</MenuFlyoutSubItem>
```

## -remarks

### Control style and template

You can modify the default [Style](../microsoft.ui.xaml/style.md) and [ControlTemplate](controltemplate.md) to give the control a unique appearance. For information about modifying a control's style and template, see [Styling controls](/windows/uwp/controls-and-patterns/styling-controls). The default style, template, and resources that define the look of the control are included in the generic.xaml file. For design purposes, generic.xaml is available in the \(Program Files)\Windows Kits\10\DesignTime\CommonConfiguration\Neutral\UAP\ &lt;SDK version&gt;\Generic folder from a Windows Software Development Kit (SDK) installation. Styles and resources from different versions of the SDK might have different values.

Starting in Windows 10, version 1607 (SDK 14393), generic.xaml includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. In apps that target this software development kit (SDK) or later, modifying these resources is preferred to setting properties such as [Background](control_background.md) and [Foreground](control_foreground.md). For more info, see the [Light-weight styling](/windows/uwp/controls-and-patterns/styling-controls) section of the [Styling controls](/windows/uwp/controls-and-patterns/styling-controls) article.

This table shows the resources used by the MenuFlyoutSubItem control.

<table>
   <tr><th>Resource key</th><th>Description</th></tr>
   <tr><td>MenuFlyoutSubItemBackground</td><td>Background color of entire control bounds at rest</td></tr>
   <tr><td>MenuFlyoutSubItemBackgroundPointerOver</td><td>Background color on hover</td></tr>
   <tr><td>MenuFlyoutSubItemBackgroundPressed</td><td>Background color when pressed</td></tr>
   <tr><td>MenuFlyoutSubItemBackgroundDisabled</td><td>Background color when disabled</td></tr>
   <tr><td>MenuFlyoutSubItemForeground</td><td>Text color at rest</td></tr>
   <tr><td>MenuFlyoutSubItemForegroundPointerOver</td><td>Text color on hover</td></tr>
   <tr><td>MenuFlyoutSubItemForegroundPressed</td><td>Text color when pressed</td></tr>
   <tr><td>MenuFlyoutSubItemForegroundDisabled</td><td>Text color when disabled</td></tr>
   <tr><td>MenuFlyoutSubItemChevron</td><td>Chevron color at rest</td></tr>
   <tr><td>MenuFlyoutSubItemChevronPointerOver</td><td>Chevron color on hover</td></tr>
   <tr><td>MenuFlyoutSubItemChevronPressed</td><td>Chevron color when pressed</td></tr>
   <tr><td>MenuFlyoutSubItemChevronDisabled</td><td>Chevron color when disabled</td></tr>
   <tr><td>MenuFlyoutSubItemChevronSubMenuOpened</td><td>Chevron color when opened</td></tr>
</table>

## -examples

## -see-also

[MenuFlyoutItemBase](menuflyoutitembase.md), [MenuFlyoutSubItem styles and templates](/windows/apps/design/style/xaml-styles), [Context menu (XAML) sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlContextMenu)
