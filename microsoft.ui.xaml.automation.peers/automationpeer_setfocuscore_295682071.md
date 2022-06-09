---
-api-id: M:Microsoft.UI.Xaml.Automation.Peers.AutomationPeer.SetFocusCore
-api-type: winrt method
---

<!-- Method syntax
virtual protected void SetFocusCore()
-->

# Microsoft.UI.Xaml.Automation.Peers.AutomationPeer.SetFocusCore

## -description
Provides the peer's behavior when a Microsoft UI Automation client calls [SetFocus](automationpeer_setfocus_192955311.md) or an equivalent Microsoft UI Automation client API.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -remarks
The standard implementation uses [IsKeyboardFocusable](automationpeer_iskeyboardfocusable_2030365113.md) to determine whether the peer reports that the owner can be focused. [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md) adds behavior that performs the actual focus operation if it is possible.

## -examples

## -see-also
[FrameworkElementAutomationPeer](frameworkelementautomationpeer.md), [Control.Focus](/uwp/api/windows.ui.xaml.controls.control.focus(windows.ui.xaml.focusstate)), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers), [Accessibility](/windows/uwp/accessibility/accessibility)
