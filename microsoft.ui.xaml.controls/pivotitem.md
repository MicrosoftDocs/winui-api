---
-api-id: T:Microsoft.UI.Xaml.Controls.PivotItem
-api-type: winrt class
---

<!-- Class syntax.
public class PivotItem : Windows.UI.Xaml.Controls.ContentControl, Windows.UI.Xaml.Controls.IPivotItem
-->

# Microsoft.UI.Xaml.Controls.PivotItem

## -description
Represents the container for an item in a [Pivot](pivot.md) control.

> [!Important]
> The **Pivot** control is no longer recommended and could be removed in future releases of the Windows UI Library (WinUI). Note that information and images in this topic might be out of date.
>
> Please use the [NavigationView](navigationview.md) ([NavigationViewPaneDisplayMode](navigationviewpanedisplaymode.md) of Top) instead.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -xaml-syntax
```xaml
<PivotItem .../>
```


## -remarks
### Control style and template

You can modify the default [Style](../microsoft.ui.xaml/style.md) and [ControlTemplate](controltemplate.md) to give the control a unique appearance. For information about modifying a control's style and template, see [Styling controls](/windows/uwp/controls-and-patterns/styling-controls). The default style, template, and resources that define the look of the control are included in the generic.xaml file. For design purposes, generic.xaml is available in the \(Program Files)\Windows Kits\10\DesignTime\CommonConfiguration\Neutral\UAP\ &lt;SDK version&gt;\Generic folder from a Windows Software Development Kit (SDK) installation. Styles and resources from different versions of the SDK might have different values.

Starting in Windows 10, version 1607 (SDK 14393), generic.xaml includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. In apps that target this software development kit (SDK) or later, modifying these resources is preferred to setting properties such as [Background](control_background.md) and [Foreground](control_foreground.md). For more info, see the [Light-weight styling](/windows/uwp/controls-and-patterns/styling-controls) section of the [Styling controls](/windows/uwp/controls-and-patterns/styling-controls) article.

This table shows the resources used by the PivotItem control.

<table>
   <tr><th>Resource key</th><th>Description</th></tr>
   <tr><td>PivotItemBackground</td><td>Item background color</td></tr>
</table>

## -examples

## -see-also
[ContentControl](contentcontrol.md), [PivotItem styles and templates](/windows/apps/design/style/xaml-styles)
