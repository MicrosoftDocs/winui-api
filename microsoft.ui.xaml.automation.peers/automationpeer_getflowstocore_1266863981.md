---
-api-id: M:Microsoft.UI.Xaml.Automation.Peers.AutomationPeer.GetFlowsToCore
-api-type: winrt method
---

<!-- Method syntax
virtual protected Windows.Foundation.Collections.IIterable<Windows.UI.Xaml.Automation.Peers.AutomationPeer> GetFlowsToCore()
-->

# Microsoft.UI.Xaml.Automation.Peers.AutomationPeer.GetFlowsToCore

## -description
Provides the peer's behavior when a Microsoft UI Automation client calls [GetFlowsTo](/uwp/api/windows.ui.xaml.automation.automationproperties.getflowsto(windows.ui.xaml.dependencyobject)) or an equivalent Microsoft UI Automation client API.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -returns
A list of automation elements that suggests the reading order after the current automation element.

## -remarks
The "Core" methods are the standard implementations that perform the default action of an associated UI Automation client-callable method. You can override any of the "Core" methods to return alternative values in a custom automation peer. In this case, GetFlowsToCore is invoked any time that [GetFlowsTo](/uwp/api/windows.ui.xaml.automation.automationproperties.getflowsto(windows.ui.xaml.dependencyobject)) is called.

The base implementation for [AutomationPeer](automationpeer.md) returns null.

## -examples

## -see-also
