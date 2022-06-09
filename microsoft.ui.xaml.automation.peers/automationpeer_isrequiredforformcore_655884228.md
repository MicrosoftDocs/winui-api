---
-api-id: M:Microsoft.UI.Xaml.Automation.Peers.AutomationPeer.IsRequiredForFormCore
-api-type: winrt method
---

<!-- Method syntax
virtual protected bool IsRequiredForFormCore()
-->

# Microsoft.UI.Xaml.Automation.Peers.AutomationPeer.IsRequiredForFormCore

## -description
Provides the peer's behavior when a Microsoft UI Automation client calls [IsRequiredForForm](automationpeer_isrequiredforform_1300796554.md) or an equivalent Microsoft UI Automation client API.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -returns
**true** if the element must be completed; otherwise, **false**.

## -remarks
The standard implementation returns false. Overriding this value at the peer level to return true is probably an uncommon scenario, because you are implying that every instance of your control has a required-for-form behavior no matter what app or UI situation it is used for. It's more typical for apps to specify a required-for-form behavior that is declared in the app's XAML UI definitions, by setting [AutomationProperties.IsRequiredForForm](/windows/winui/api/microsoft.ui.xaml.automation.automationproperties#xaml-attached-properties).

## -examples

## -see-also
[FrameworkElementAutomationPeer](frameworkelementautomationpeer.md), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers), [Accessibility](/windows/uwp/accessibility/accessibility)
