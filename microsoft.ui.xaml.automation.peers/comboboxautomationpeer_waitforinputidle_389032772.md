---
-api-id: M:Microsoft.UI.Xaml.Automation.Peers.ComboBoxAutomationPeer.WaitForInputIdle(System.Int32)
-api-type: winrt method
---

<!-- Method syntax
public bool WaitForInputIdle(System.Int32 milliseconds)
-->

# Microsoft.UI.Xaml.Automation.Peers.ComboBoxAutomationPeer.WaitForInputIdle

## -description
Causes the calling code to block for the specified time or until the associated process enters an idle state, whichever completes first.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -parameters
### -param milliseconds
The amount of time, in milliseconds, to wait for the associated process to become idle. The maximum is **Int32.MaxValue**.

## -returns
**true** if the window has entered the idle state; **false** if the time-out occurred.

## -remarks

## -examples

## -see-also
