---
-api-id: M:Microsoft.UI.Xaml.Automation.Peers.AutomationPeer.GetAutomationIdCore
-api-type: winrt method
---

<!-- Method syntax
virtual protected string GetAutomationIdCore()
-->

# Microsoft.UI.Xaml.Automation.Peers.AutomationPeer.GetAutomationIdCore

## -description
Provides the peer's behavior when a Microsoft UI Automation client calls [GetAutomationId](automationpeer_getautomationid_1912681712.md) or an equivalent Microsoft UI Automation client API.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -returns
The automation identifier.

## -remarks
Providing a class-based behavior for **AutomationId** is uncommon. Typically, app authors set values for elements in the app by setting the [AutomationProperties.AutomationId](/windows/winui/api/microsoft.ui.xaml.automation.automationproperties#xaml-attached-properties) attached property in the XAML UI definition.

## -examples

## -see-also
[FrameworkElementAutomationPeer](frameworkelementautomationpeer.md), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers), [Accessibility](/windows/uwp/accessibility/accessibility)
