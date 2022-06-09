---
-api-id: P:Microsoft.UI.Xaml.WindowActivatedEventArgs.Handled
-api-type: winrt property
---

# Microsoft.UI.Xaml.WindowActivatedEventArgs.Handled

<!--
public bool Handled { get; set; }
-->

## -description

Gets or sets whether the [Activated](window_activated.md) event was handled.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -property-value

**True**, if the event has been handled by the appropriate delegate. Otherwise, **false**.

## -remarks

Setting this property to true will prevent the window from getting keyboard focus on activation.

## -see-also

## -examples
