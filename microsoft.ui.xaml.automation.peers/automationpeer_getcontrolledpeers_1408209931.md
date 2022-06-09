---
-api-id: M:Microsoft.UI.Xaml.Automation.Peers.AutomationPeer.GetControlledPeers
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Collections.IVectorView<Windows.UI.Xaml.Automation.Peers.AutomationPeer> GetControlledPeers()
-->

# Microsoft.UI.Xaml.Automation.Peers.AutomationPeer.GetControlledPeers

## -description
Provides the peer's behavior when a Microsoft UI Automation client calls GetControlledPeers or an equivalent Microsoft UI Automation client API such as getting a property value as identified by **UIA_ControllerForPropertyId**.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -returns
A list of the controlled peers for the current automation peer.

## -remarks
Examining controlled peers is an advanced scenario that most peer implementations won't need to use.

The naming of the framework implementation and the Microsoft UI Automation property that clients can use to access this info are slightly different. Microsoft UI Automation clients should use the identifier **UIA_ControllerForPropertyId** to request the value of this property when using the Microsoft UI Automation client interfaces such as [IUIAutomation](/windows/desktop/api/uiautomationclient/nn-uiautomationclient-iuiautomation).

## -examples

## -see-also
