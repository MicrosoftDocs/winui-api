---
-api-id: M:Microsoft.UI.Xaml.Automation.Peers.AutomationPeer.GetClassNameCore
-api-type: winrt method
---

<!-- Method syntax
virtual protected string GetClassNameCore()
-->

# Microsoft.UI.Xaml.Automation.Peers.AutomationPeer.GetClassNameCore

## -description
Provides the peer's behavior when a Microsoft UI Automation client calls [GetClassName](automationpeer_getclassname_614238974.md) or an equivalent Microsoft UI Automation client API.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -returns
The class name.

## -remarks
You should never invoke the base behavior, and all custom peers should override GetClassNameCore to report the class name that is unique to that peer class. For more info, see [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers).

## -examples

## -see-also
[FrameworkElementAutomationPeer](frameworkelementautomationpeer.md), [GetLocalizedControlTypeCore](automationpeer_getlocalizedcontroltypecore_1799576178.md), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers), [Accessibility](/windows/uwp/accessibility/accessibility)
