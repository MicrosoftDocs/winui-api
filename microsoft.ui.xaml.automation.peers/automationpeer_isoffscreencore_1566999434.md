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

## -returns
**true** if the element is not on the screen; otherwise, **false**.

## -remarks
The standard implementation returns a result that is based on the owner's [Visibility](../microsoft.ui.xaml/uielement_visibility.md) value.

## -examples

## -see-also
[FrameworkElementAutomationPeer](frameworkelementautomationpeer.md), [UIElement.Visibility](../microsoft.ui.xaml/uielement_visibility.md), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers), [Accessibility](/windows/uwp/accessibility/accessibility)
