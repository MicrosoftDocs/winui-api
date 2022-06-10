---
-api-id: T:Microsoft.UI.Xaml.Controls.Primitives.TickPlacement
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Xaml.Controls.Primitives.TickPlacement : int
-->

# TickPlacement

## -description
Defines constants that specify the position of tick marks in a [Slider](../microsoft.ui.xaml.controls/slider.md) in relation to the track that the control implements.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -enum-fields
### -field None:0
No tick marks appear.

### -field TopLeft:1
Tick marks appear above the track for a horizontal [Slider](../microsoft.ui.xaml.controls/slider.md), or to the left of the track for a vertical [Slider](../microsoft.ui.xaml.controls/slider.md).

### -field BottomRight:2
Tick marks appear below the track for a horizontal [Slider](../microsoft.ui.xaml.controls/slider.md), or to the right of the track for a vertical [Slider](../microsoft.ui.xaml.controls/slider.md).

### -field Outside:3
Tick marks appear on both sides of either a horizontal or vertical track.

### -field Inline:4
Tick marks appear directly on the track.


## -remarks

## -examples


```xaml
<Slider TickPlacement="Inline"
        TickFrequency="20"
        SnapsTo="Ticks"/>
```



## -see-also
[Slider.TickPlacement](../microsoft.ui.xaml.controls/slider_tickplacement.md)
