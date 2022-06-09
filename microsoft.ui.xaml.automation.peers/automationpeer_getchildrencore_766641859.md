---
-api-id: M:Microsoft.UI.Xaml.Automation.Peers.AutomationPeer.GetChildrenCore
-api-type: winrt method
---

<!-- Method syntax
virtual protected Windows.Foundation.Collections.IVector<Windows.UI.Xaml.Automation.Peers.AutomationPeer> GetChildrenCore()
-->

# Microsoft.UI.Xaml.Automation.Peers.AutomationPeer.GetChildrenCore

## -description
Provides the peer's behavior when a Microsoft UI Automation client calls [GetChildren](automationpeer_getchildren_555647254.md) or an equivalent Microsoft UI Automation client API.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -returns
The collection of [AutomationPeer](automationpeer.md) objects for child elements.

## -remarks
The base implementation returns null. Peers that represent controls with item collections may override this result. Test the behavior of the peer you are using or overriding and override GetChildrenCore if you want to change that behavior.

## -examples

## -see-also
[FrameworkElementAutomationPeer](frameworkelementautomationpeer.md), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers), [Accessibility](/windows/uwp/accessibility/accessibility)
