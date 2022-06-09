---
-api-id: P:Microsoft.UI.Xaml.Controls.ToolTip.Placement
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Controls.Primitives.PlacementMode Placement { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.ToolTip.Placement

## -description
Gets or sets how a [ToolTip](tooltip.md) is positioned in relation to the placement target element.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
<ToolTip Placement="placementModeMemberName"/>
```


## -xaml-values
<dl><dt>placementModeMemberName</dt><dd>placementModeMemberNameA named constant of the PlacementMode enumeration, such as Top.</dd>
</dl>
## -property-value
One of the [PlacementMode](../microsoft.ui.xaml.controls.primitives/placementmode.md) values.

## -remarks
If there is no explicit [PlacementTarget](tooltip_placementtarget.md), the placement target for a [ToolTip](tooltip.md) is the element that specifies the [ToolTip](slider_isthumbtooltipenabled.md) as the value for its [TooltipService.ToolTip](/windows/winui/api/microsoft.ui.xaml.controls.tooltipservice#xaml-attached-properties) attached property value, and any Placement value applies to that target.

Placement and [PlacementTarget](tooltip_placementtarget.md) are usually left as the defaults. The scenario for specifying either or both of these properties is if you are trying to avoid a case where the tooltip obscures the content it is referring to while the tooltip is displayed.

## -examples
The following code example demonstrates the placement modes for a [ToolTip](tooltip.md).



[!code-xaml[1](../microsoft.ui.xaml.data/code/ToolTipServicePlacementEx/csharp/MainPage.xaml#Snippet1)]

## -see-also
[PlacementMode](../microsoft.ui.xaml.controls.primitives/placementmode.md), [PlacementTarget](tooltip_placementtarget.md)
