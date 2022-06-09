---
-api-id: M:Microsoft.UI.Xaml.DispatcherTimer.Stop
-api-type: winrt method
---

<!-- Method syntax
public void Stop()
-->

# Microsoft.UI.Xaml.DispatcherTimer.Stop

## -description
Stops the [DispatcherTimer](dispatchertimer.md).

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -remarks
If Stop is called when the timer interval has just elapsed, it's possible that the timer already queued a Tick event. This event will still be raised.

## -examples

## -see-also
