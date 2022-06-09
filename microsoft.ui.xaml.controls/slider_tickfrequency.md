---
-api-id: P:Microsoft.UI.Xaml.Controls.Slider.TickFrequency
-api-type: winrt property
---

<!-- Property syntax
public double TickFrequency { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.Slider.TickFrequency

## -description
Gets or sets the increment of the value range that ticks should be created for.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
<Slider TickFrequency="double" />
```


## -property-value
The increment to create tick marks for. The default is 0.0.

## -remarks
Set the TickFrequency property to specify at which values tick marks are drawn on a [Slider](slider.md). For example, if a [Slider](slider.md) has [Minimum](../microsoft.ui.xaml.controls.primitives/rangebase_minimum.md) of 0, [Maximum](../microsoft.ui.xaml.controls.primitives/rangebase_maximum.md) of 20, and TickFrequency of 2, tick marks are placed at every other step value, starting at 0 and ending at 20.

The drawing of tick marks on a slider depends on both the TickFrequency and [TickPlacement](slider_tickplacement.md) properties. In order for tick marks to be shown, you must set the TickFrequency property to a value greater than 0, and the [TickPlacement](slider_tickplacement.md) property to a value other than **None**.

To prevent tick marks from being packed too densely, the [Slider](slider.md) will only show tick marks that are a minimum of 20 pixels apart. If a combination of [Slider](slider.md) size, value range, and tick frequency results in tick marks that are too close together, some tick marks are not shown.

When the [SnapsTo](slider_snapsto.md) property is set to [Ticks](../microsoft.ui.xaml.controls.primitives/slidersnapsto.md), the TickFrequency property also specifies the interval between snap points.

## -examples
Here's a slider with its TickFrequency set to 2 and its [TickPlacement](slider_tickplacement.md) set to **BottomRight**.



[!code-xaml[3](../microsoft.ui.xaml.data/code/System.Windows.Controls.Extended.SliderSL/csharp/Page.xaml#Snippet3)]

## -see-also
[SliderSnapsTo](../microsoft.ui.xaml.controls.primitives/slidersnapsto.md), [SnapsTo](slider_snapsto.md), [StepFrequency](slider_stepfrequency.md), [TickPlacement](slider_tickplacement.md)
