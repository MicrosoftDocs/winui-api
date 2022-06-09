---
-api-id: M:Microsoft.UI.Xaml.Automation.Peers.AutomationPeer.GetAutomationControlTypeCore
-api-type: winrt method
---

<!-- Method syntax
virtual protected Windows.UI.Xaml.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
-->

# Microsoft.UI.Xaml.Automation.Peers.AutomationPeer.GetAutomationControlTypeCore

## -description
Provides the peer's behavior when a Microsoft UI Automation client calls [GetAutomationControlType](automationpeer_getautomationcontroltype_1156384152.md) or an equivalent Microsoft UI Automation client API.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -returns
The control type.

## -remarks
The base implementation for [AutomationPeer](automationpeer.md) and [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md) return **Custom**. If you keep this behavior, you must override [GetLocalizedControlTypeCore](automationpeer_getlocalizedcontroltypecore_1799576178.md).

The more common scenario for defining an automation peer is overriding one of the existing peer classes that pairs with the control class you are overriding. In this case each such peer class reports a practical value of [AutomationControlType](automationcontroltype.md) that makes sense for the original owner control that the peer was implemented for. Often you can leave this behavior alone. It isn't typical to derive from a control-specific peer and use its behavior but then change the **AutomationControlType**, which is probably the most basic information that a peer reports. Check the existing behavior of the peer class you are overriding, and verify that you're reporting the correct control type. Also, double-check that there isn't a more specific peer class available that could already be reporting the correct control type as well as providing other behavior that's more appropriate for your peer. For more info, see [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers).

## -examples

## -see-also
[FrameworkElementAutomationPeer](frameworkelementautomationpeer.md), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers), [Accessibility](/windows/uwp/accessibility/accessibility)
