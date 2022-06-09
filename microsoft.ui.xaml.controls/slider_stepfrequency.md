---
-api-id: P:Microsoft.UI.Xaml.Controls.Slider.StepFrequency
-api-type: winrt property
---

<!-- Property syntax
public double StepFrequency { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.Slider.StepFrequency

## -description
Gets or sets the value part of a value range that steps should be created for.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
<Slider StepFrequency="double" />
```


## -property-value
The value part of a value range that steps should be created for.

## -remarks
When the [SnapsTo](slider_snapsto.md) property is set to [StepValues](../microsoft.ui.xaml.controls.primitives/slidersnapsto.md), set the StepFrequency property to specify the interval between snap points.

## -examples

## -see-also
[SliderSnapsTo](../microsoft.ui.xaml.controls.primitives/slidersnapsto.md), [SnapsTo](slider_snapsto.md), [TickFrequency](slider_tickfrequency.md)
