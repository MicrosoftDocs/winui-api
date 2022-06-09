---
-api-id: T:Microsoft.UI.Xaml.Controls.MenuFlyoutPresenter
-api-type: winrt class
---

<!-- Class syntax.
public class MenuFlyoutPresenter : Windows.UI.Xaml.Controls.ItemsControl, Windows.UI.Xaml.Controls.IMenuFlyoutPresenter, Windows.UI.Xaml.Controls.IMenuFlyoutPresenter2
-->

# Microsoft.UI.Xaml.Controls.MenuFlyoutPresenter

## -description
Displays the content of a [MenuFlyout](menuflyout.md) control.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -remarks
You don't typically use a MenuFlyoutPresenter directly, either in XAML or code. Instead, you reference the MenuFlyoutPresenter type as the [TargetType](../microsoft.ui.xaml/style_targettype.md) of the style you use for the [MenuFlyout.MenuFlyoutPresenterStyle](menuflyout_menuflyoutpresenterstyle.md) property. Then, you use style [Setter](../microsoft.ui.xaml/setter.md) elements to set the various [Control](control.md) properties that influence the appearance of the [MenuFlyout](menuflyout.md) through this presenter. For example you can use a [Setter](../microsoft.ui.xaml/setter.md) to set the [Width](../microsoft.ui.xaml/frameworkelement_width.md) of the [MenuFlyout](menuflyout.md):
```xaml
<MenuFlyout x:Name="optionFlyout">
  <MenuFlyout.MenuFlyoutPresenterStyle>
    <Style TargetType="MenuFlyoutPresenter">
      <Setter Property="Width" Value="300"/>
    </Style>
  </MenuFlyout.MenuFlyoutPresenterStyle>
<!--menu items go here-->
</MenuFlyout>
```

The MenuFlyoutPresenter class is not a [ContentPresenter](contentpresenter.md) derived class, it's actually a control (derived from [ItemsControl](itemscontrol.md)) that plays a special role when creating the visual tree for a [MenuFlyout](menuflyout.md).

### Control style and template

You can modify the default [Style](../microsoft.ui.xaml/style.md) and [ControlTemplate](controltemplate.md) to give the control a unique appearance. For information about modifying a control's style and template, see [Styling controls](/windows/uwp/controls-and-patterns/styling-controls). The default style, template, and resources that define the look of the control are included in the generic.xaml file. For design purposes, generic.xaml is available in the \(Program Files)\Windows Kits\10\DesignTime\CommonConfiguration\Neutral\UAP\ &lt;SDK version&gt;\Generic folder from a Windows Software Development Kit (SDK) installation. Styles and resources from different versions of the SDK might have different values.

Starting in Windows 10, version 1607 (SDK 14393), generic.xaml includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. In apps that target this software development kit (SDK) or later, modifying these resources is preferred to setting properties such as [Background](control_background.md) and [Foreground](control_foreground.md). For more info, see the [Light-weight styling](/windows/uwp/controls-and-patterns/styling-controls) section of the [Styling controls](/windows/uwp/controls-and-patterns/styling-controls) article.

This table shows the resources used by the MenuFlyoutPresenter control.

<table>
   <tr><th>Resource key</th><th>Description</th></tr>
   <tr><td>MenuFlyoutPresenterBackground</td><td>Background color of entire control bounds</td></tr>
   <tr><td>MenuFlyoutPresenterBorderBrush</td><td>Border color of entire control bounds</td></tr>
</table>

## -examples

## -see-also
[ItemsControl](itemscontrol.md), [IItemContainerMapping](iitemcontainermapping.md), [MenuFlyout](menuflyout.md), [MenuFlyoutPresenter styles and templates](/windows/apps/design/style/xaml-styles)
