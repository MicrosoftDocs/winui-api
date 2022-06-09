---
-api-id: T:Microsoft.UI.Xaml.Controls.ToolTipService
-api-type: winrt class
---

<!-- Class syntax.
public class ToolTipService : Windows.UI.Xaml.Controls.IToolTipService
-->

# Microsoft.UI.Xaml.Controls.ToolTipService

## -description
Represents a service that provides static methods to display a [ToolTip](tooltip.md).

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -remarks

A [ToolTip](tooltip.md) must be assigned to another UI element that is its owner. In Extensible Application Markup Language (XAML), use the ToolTipService.ToolTip attached property to assign the [ToolTip](tooltip.md) to an owner. In code, use the [ToolTipService.SetToolTip](tooltipservice_settooltip_436756233.md) method to assign the [ToolTip](tooltip.md) to an owner.

### Placement

By default, a [ToolTip](tooltip.md) is displayed centered above the pointer. The placement is not constrained by the app window, so the [ToolTip](tooltip.md) might be displayed partially or completely outside of the app window bounds.

If a [ToolTip](tooltip.md) obscures the content it is referring to, you can adjust it's placement. Use the ToolTipService.Placement attached property to place the [ToolTip](tooltip.md) above, below, left, or right of the pointer.

If there is no explicit PlacementTarget, the placement target for a tooltip is the element that specifies a value for its TooltipService.ToolTip attached property value. Any Placement value (either as an attached property or as an attribute on an explicit ToolTip element) applies to that target.

### Notes for previous versions

> **Windows 8.x**
>   [ToolTip](tooltip.md) is intended only for use in Windows. The [ToolTip](tooltip.md) type is available in Windows Phone projects for compatibility with universal project templates, but the [ToolTip](tooltip.md) is not shown in the Windows Phone  UI.
>
>   [ToolTip](tooltip.md) is displayed only within the bounds of the app window. It's placement might be adjusted to stay within those bounds.

### XAML attached properties

ToolTipService is the host service class for several [XAML attached properties](/windows/uwp/xaml-platform/attached-properties-overview).

In order to support XAML processor access to the attached properties, and also to expose equivalent _get_ and _set_ operations to code, each XAML attached property has a pair of Get and Set accessor methods. Another way to get or set the value in code is to use the dependency property system, calling either [GetValue](/uwp/api/windows.ui.xaml.dependencyobject.getvalue(windows.ui.xaml.dependencyproperty)) or [SetValue](/uwp/api/windows.ui.xaml.dependencyobject.setvalue(windows.ui.xaml.dependencyproperty,system.object)) and passing the identifier field as the dependency property identifier.

| Attached property | Description |
| - | - |
| Placement | Gets or sets a value that indicates how a ToolTip is positioned in relation to the placement target.<ul><li>Type: [PlacementMode](../microsoft.ui.xaml.controls.primitives/placementmode.md)</li><li>Identifier field: <a href="/uwp/api/windows.ui.xaml.controls.tooltipservice.placementproperty">PlacementProperty</a></li><li>Accessor methods: <a href="/uwp/api/windows.ui.xaml.controls.tooltipservice.getplacement">GetPlacement</a>, <a href="/uwp/api/windows.ui.xaml.controls.tooltipservice.setplacement">SetPlacement</a></li></ul> |
| PlacementTarget | Gets or sets the object relative to which a tooltip is positioned.<ul><li>Type: [UIElement](../microsoft.ui.xaml/uielement.md)</li><li>Identifier field: <a href="/uwp/api/windows.ui.xaml.controls.tooltipservice.placementtargetproperty">PlacementTargetProperty</a></li><li>Accessor methods: <a href="/uwp/api/windows.ui.xaml.controls.tooltipservice.getplacementtarget">GetPlacementTarget</a>, <a href="/uwp/api/windows.ui.xaml.controls.tooltipservice.setplacementtarget">SetPlacementTarget</a></li></ul> |
| ToolTip | Gets or sets the object or string content of an element's ToolTip.<ul><li>Type: object</li><li>Identifier field: <a href="/uwp/api/windows.ui.xaml.controls.tooltipservice.tooltipproperty">ToolTipProperty</a></li><li>Accessor methods: <a href="/uwp/api/windows.ui.xaml.controls.tooltipservice.gettooltip">GetToolTip</a>, <a href="/uwp/api/windows.ui.xaml.controls.tooltipservice.settooltip">SetToolTip</a></li></ul> |

## -examples
The following code example demonstrates the placement modes for a [ToolTip](tooltip.md).



[!code-xaml[1](../microsoft.ui.xaml.data/code/ToolTipServicePlacementEx/csharp/MainPage.xaml#Snippet1)]

## -see-also
[ToolTip](tooltip.md), [How to add a tooltip](/previous-versions/windows/apps/hh868199(v=win.10)), [XAML essential controls sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/XAML%20essential%20controls%20sample)
