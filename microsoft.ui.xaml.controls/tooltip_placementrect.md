---
-api-id: P:Microsoft.UI.Xaml.Controls.ToolTip.PlacementRect
-api-type: winrt property
---

<!-- Property syntax.
public Rect PlacementRect { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.ToolTip.PlacementRect

## -description
Gets or sets the rectangular area that the tooltip should be positioned in relation to when opened by the [ToolTipService](tooltipservice.md). If space allows, the open tooltip will not occlude the area defined by its PlacementRect. 

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -property-value
The rectangular area that the tooltip is positioned in relation to when opened by the [ToolTipService](tooltipservice.md). The default is **null**.

## -remarks
PlacementRect anchors the tooltip's position and also serves as an area that the opened tooltip will not occlude, provided there's sufficient space to draw tooltip outside this area. You can specify the origin of the rectangle relative to the tooltip's owner, and the height and width of the exclusion area. The [Placement](tooltip_placement.md) property will define if tooltip should draw above, below, left, or right of the PlacementRect.

## -see-also
[PlacementTarget](tooltip_placementtarget.md), [Placement](tooltip_placement.md)

## -examples

