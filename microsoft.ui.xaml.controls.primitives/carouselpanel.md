---
-api-id: T:Microsoft.UI.Xaml.Controls.Primitives.CarouselPanel
-api-type: winrt class
---

<!-- Class syntax.
public class CarouselPanel : Windows.UI.Xaml.Controls.VirtualizingPanel, Windows.UI.Xaml.Controls.Primitives.ICarouselPanel, Windows.UI.Xaml.Controls.Primitives.IScrollSnapPointsInfo
-->

# Microsoft.UI.Xaml.Controls.Primitives.CarouselPanel

## -description
Represents a panel that arranges its items in a line and circles around to the first item when the last item is reached.

## -xaml-syntax
```xaml
<!--somewhere within items panel templates-->
<CarouselPanel .../>
```


## -remarks
> [!NOTE]
> CarouselPanel can't be used as a stand-alone control, it can only be used as the [ItemsPanel](../microsoft.ui.xaml.controls/itemscontrol_itemspanel.md) of an [ItemsControl](../microsoft.ui.xaml.controls/itemscontrol.md). It's the default [ItemsPanel](../microsoft.ui.xaml.controls/itemscontrol_itemspanel.md) for the [ComboBox](../microsoft.ui.xaml.controls/combobox.md) control, and is not supported for use with any other [ItemsControl](../microsoft.ui.xaml.controls/itemscontrol.md).

## -examples

## -see-also
[VirtualizingPanel](../microsoft.ui.xaml.controls/virtualizingpanel.md), [IScrollSnapPointsInfo](iscrollsnappointsinfo.md)
