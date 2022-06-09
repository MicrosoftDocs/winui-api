---
-api-id: M:Microsoft.UI.Xaml.Automation.Peers.AutomationPeer.IsOffscreenCore
-api-type: winrt method
---

<!-- Method syntax
virtual protected bool IsOffscreenCore()
-->

# Microsoft.UI.Xaml.Automation.Peers.AutomationPeer.IsOffscreenCore

## -description
Provides the peer's behavior when a Microsoft UI Automation client calls [IsOffscreen](automationpeer_isoffscreen_970705929.md) or an equivalent Microsoft UI Automation client API.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -returns
**true** if the element is not on the screen; otherwise, **false**.

## -remarks
The standard implementation returns a result that is based on the owner's [Visibility](../microsoft.ui.xaml/uielement_visibility.md) value.

## -examples

## -see-also
[FrameworkElementAutomationPeer](frameworkelementautomationpeer.md), [UIElement.Visibility](../microsoft.ui.xaml/uielement_visibility.md), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers), [Accessibility](/windows/uwp/accessibility/accessibility)
