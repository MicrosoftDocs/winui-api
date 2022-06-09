---
-api-id: M:Microsoft.UI.Xaml.Automation.Peers.AutomationPeer.GetHelpTextCore
-api-type: winrt method
---

<!-- Method syntax
virtual protected string GetHelpTextCore()
-->

# Microsoft.UI.Xaml.Automation.Peers.AutomationPeer.GetHelpTextCore

## -description
Provides the peer's behavior when a Microsoft UI Automation client calls [GetHelpText](automationpeer_gethelptext_1251901404.md) or an equivalent Microsoft UI Automation client API.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -returns
The help text.

## -remarks
Specifying a control behavior for help text is uncommon. In most cases, apps that need it will establish help text information in the UI by applying the [AutomationProperties.HelpText](/windows/winui/api/microsoft.ui.xaml.automation.automationproperties#xaml-attached-properties) attached property to the UI definition XAML.

## -examples

## -see-also
[FrameworkElementAutomationPeer](frameworkelementautomationpeer.md), [AutomationProperties.HelpText](/windows/winui/api/microsoft.ui.xaml.automation.automationproperties#xaml-attached-properties), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers), [Accessibility](/windows/uwp/accessibility/accessibility)
