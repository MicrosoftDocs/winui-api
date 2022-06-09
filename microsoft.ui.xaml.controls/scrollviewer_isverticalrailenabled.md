---
-api-id: P:Microsoft.UI.Xaml.Controls.ScrollViewer.IsVerticalRailEnabled
-api-type: winrt property
---

<!-- Property syntax
public bool IsVerticalRailEnabled { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.ScrollViewer.IsVerticalRailEnabled

## -description
Gets or sets a value that indicates whether the scroll rail is enabled for the vertical axis.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -xaml-syntax
```xaml
<ScrollViewer IsVerticalRailEnabled="bool" />
-or-
<object ScrollViewer.IsVerticalRailEnabled="bool"/>
```


## -property-value
**True** to enable the vertical scroll rail; otherwise, **false**. The default is **true**.

## -remarks

When content is scrolled without manipulating the scrollbar directly, for example, by touch, we call it panning. Because content can be both wider and taller than the display area, two-dimensional panning (horizontal and vertical) is often necessary. _Rails_ improve the user experience in these cases by locking the panning to the axis of motion, either vertical or horizontal, as if the content were on a rail.

The following diagram demonstrates the concept of rails.

![diagram of a screen with rails that constrain panning](images/ux-panning-rails.png)

For more info, see [Guidelines for panning](/windows/apps/design/input/guidelines-for-panning).

## -examples

## -see-also

[Scroll viewer controls](/windows/apps/design/controls/scroll-controls), [Guidelines for panning](/windows/apps/design/input/guidelines-for-panning)
