---
-api-id: T:Microsoft.UI.Xaml.Controls.ToolTip
-api-type: winrt class
---

<!-- Class syntax.
public class ToolTip : Windows.UI.Xaml.Controls.ContentControl, Windows.UI.Xaml.Controls.IToolTip
-->

# Microsoft.UI.Xaml.Controls.ToolTip

## -description

Represents a pop-up window for displaying information about an element in the UI.

## -xaml-syntax

```xaml
<ToolTip .../>
-or-
<ToolTip ...>
  singleObject
</ToolTip ...>
-or-
<ToolTip ...>stringContent</ToolTip>
```

## -remarks

A tooltip is a popup that contains additional information about another control or object. Tooltips display automatically when the user moves focus to, presses and holds, or hovers the pointer over the associated control. The tooltip disappears when the user moves focus from, stops pressing on, or stops hovering the pointer over the associated control (unless the pointer is moving towards the tooltip).

> [!NOTE]
> Starting with Windows 11 version 21H2, a tooltip can also be dismissed by pressing the CTRL key.

Here's a ToolTip for a [Button](button.md).

<img alt="Tool tip control" src="images/controls/ToolTip.png" />

For design guidelines, see [Guidelines for tooltips](/windows/uwp/controls-and-patterns/tooltips).

### Usage

A ToolTip must be assigned to another UI element that is its owner. The [ToolTipService](tooltipservice.md) class provides static methods to display a ToolTip.

+ In XAML, use the [ToolTipService.Tooltip](/windows/winui/api/microsoft.ui.xaml.controls.tooltipservice#xaml-attached-properties) attached property to assign the ToolTip to an owner.
```xaml
<Button Content="Submit" ToolTipService.ToolTip="Click to submit"/>
```

+ In code, use the [ToolTipService.SetToolTip](tooltipservice_settooltip_436756233.md) method to assign the ToolTip to an owner.
```xaml
<Button x:Name="submitButton" Content="Submit"/>
```

```csharp
ToolTip toolTip = new ToolTip();
toolTip.Content = "Click to submit";
ToolTipService.SetToolTip(submitButton, toolTip);
```

You can use any object as the [Content](contentcontrol_content.md) of a ToolTip. Here's an example of using an [Image](image.md) in a ToolTip.

```xaml
<TextBlock Text="store logo">
    <ToolTipService.ToolTip>
        <Image Source="Assets/StoreLogo.png"/>
    </ToolTipService.ToolTip>
</TextBlock> 
```

### Placement

By default, a ToolTip is displayed centered above the pointer. The placement is not constrained by the app window, so the ToolTip might be displayed partially or completely outside of the app window bounds.

If a ToolTip obscures the content it is referring to, you can adjust it's placement. Use the [Placement](tooltip_placement.md) property or [ToolTipService.Placement](/windows/winui/api/microsoft.ui.xaml.controls.tooltipservice#xaml-attached-properties) attached property to place the ToolTip above, below, left, or right of the pointer. You can set the [VerticalOffset](tooltip_verticaloffset.md) and [HorizontalOffset](tooltip_horizontaloffset.md) properties to change the distance between the pointer and the ToolTip.

### Control style and template

You can modify the default [Style](../microsoft.ui.xaml/style.md) and [ControlTemplate](controltemplate.md) to give the control a unique appearance. For information about modifying a control's style and template, see [Styling controls](/windows/uwp/controls-and-patterns/styling-controls). The default style, template, and resources that define the look of the control are included in the generic.xaml file. For design purposes, generic.xaml is available in the \(Program Files)\Windows Kits\10\DesignTime\CommonConfiguration\Neutral\UAP\ &lt;SDK version&gt;\Generic folder from a Windows Software Development Kit (SDK) installation. Styles and resources from different versions of the SDK might have different values.

Starting in Windows 10, version 1607 (SDK 14393), generic.xaml includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. In apps that target this software development kit (SDK) or later, modifying these resources is preferred to setting properties such as [Background](control_background.md) and [Foreground](control_foreground.md). For more info, see the [Light-weight styling](/windows/uwp/controls-and-patterns/styling-controls) section of the [Styling controls](/windows/uwp/controls-and-patterns/styling-controls) article.

This table shows the resources used by the ToolTip control.

<table>
   <tr><th>Resource key</th><th>Description</th></tr>
   <tr><td>ToolTipForeground</td><td>Text color in tool tip</td></tr>
   <tr><td>ToolTipBackground</td><td>Background color</td></tr>
   <tr><td>ToolTipBorderBrush</td><td>Border color</td></tr>
</table>

### Notes for previous versions

> **Windows 8.x**
>   ToolTip is intended only for use in Windows. The ToolTip type is available in Windows Phone projects for compatibility with universal project templates, but the ToolTip is not shown in the Windows Phone  UI.

   ToolTip is displayed only within the bounds of the app window. It's placement might be adjusted to stay within those bounds.

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Tooltips](/windows/apps/design/controls/tooltips).
>
> The **WinUI 3 Gallery** and **WinUI 2 Gallery** apps include interactive examples of most WinUI 3 and WinUI 2 controls, features, and functionality.
>
> If installed already, open them by clicking the following links: [**WinUI 3 Gallery**](winui3gallery:/item/ToolTip) or [**WinUI 2 Gallery**](winui2gallery:/item/ToolTip).
>
> If they are not installed, you can download the [**WinUI 3 Gallery**](https://www.microsoft.com/store/productId/9P3JFPWWDZRC) and the [**WinUI 2 Gallery**](https://www.microsoft.com/store/productId/9MSVH128X2ZT) from the Microsoft Store.
>
> You can also get the source code for both from [GitHub](https://github.com/Microsoft/WinUI-Gallery) (use the *main* branch for WinUI 3 and the *winui2* branch for WinUI 2).


This example demonstrates basic tooltips and the properties for placement.

[!code-xaml[1](../microsoft.ui.xaml.controls.primitives/code/System.Windows.Controls.ToolTip/csharp/Page.xaml#Snippet1)]

## -see-also
[ContentControl](contentcontrol.md), [ToolTipService](tooltipservice.md), [Tooltips overview](/windows/apps/design/controls/tooltips), [ToolTip styles and templates](/windows/apps/design/style/xaml-styles), [XAML essential controls sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/XAML%20essential%20controls%20sample)
