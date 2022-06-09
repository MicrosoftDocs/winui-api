---
-api-id: M:Microsoft.UI.Xaml.Automation.Peers.AutomationPeer.IsContentElementCore
-api-type: winrt method
---

<!-- Method syntax
virtual protected bool IsContentElementCore()
-->

# Microsoft.UI.Xaml.Automation.Peers.AutomationPeer.IsContentElementCore

## -description
Provides the peer's behavior when a Microsoft UI Automation client calls [IsContentElement](automationpeer_iscontentelement_545450603.md) or an equivalent Microsoft UI Automation client API.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -returns
**true** if the element is a content element; otherwise, **false**.

## -remarks
The standard implementation at the [AutomationPeer](automationpeer.md) level returns **false**. However, [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md) adds behavior that changes the default to **true**. Other specific peers also may affect this behavior; for example [ItemAutomationPeer](itemautomationpeer.md) defers to its container. Test the existing return value in the peer that you are using or overriding and then override that behavior if necessary.

## -examples

## -see-also
[FrameworkElementAutomationPeer](frameworkelementautomationpeer.md), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers), [Accessibility](/windows/uwp/accessibility/accessibility)
