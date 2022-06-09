---
-api-id: E:Microsoft.UI.Xaml.FrameworkElement.Unloaded
-api-type: winrt event
---

<!-- Event syntax
public event Windows.UI.Xaml.RoutedEventHandler Unloaded
-->

# Microsoft.UI.Xaml.FrameworkElement.Unloaded

## -description
Occurs when this object is no longer connected to the main object tree.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
<frameworkElement Unloaded="eventhandler"/>
```


## -remarks
Although this event uses the [RoutedEventHandler](routedeventhandler.md) delegate and [RoutedEventArgs](routedeventargs.md) as event data, the event is not truly a routed event. It can only be handled on the element that originates the event (in other words, the sender). [OriginalSource](routedeventargs_originalsource.md) in event data for this event is always null.

## -examples

## -see-also
