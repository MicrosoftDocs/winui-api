---
-api-id: P:Microsoft.UI.Xaml.Controls.ItemsStackPanel.CacheLength
-api-type: winrt property
---

<!-- Property syntax
public double CacheLength { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.ItemsStackPanel.CacheLength

## -description
Gets or sets the size of the buffers for items outside the viewport, in multiples of the viewport size.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
ItemsStackPanel CacheLength="double" />
```


## -property-value
The size of the buffers for items outside the viewport, in multiples of the viewport size. The default is 4.0.

## -remarks
To improve scrolling performance, [ItemsStackPanel](itemsstackpanel.md) creates and caches item containers for items that are off-screen on both sides of the viewport. The CacheLength property specifies the size of the buffers for the off-screen items. You specify CacheLength in multiples of the current viewport size. For example, if the CacheLength is 4.0, 2 viewports worth of items are buffered on each side of the viewport.

You can set a smaller cache length to optimize startup time, or set a larger cache size to optimize scrolling performance. Item containers that are off-screen are created at a lower priority than those in the viewport.

## -examples

## -see-also
