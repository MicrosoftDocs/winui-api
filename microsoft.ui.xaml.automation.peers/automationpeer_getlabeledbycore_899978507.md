---
-api-id: M:Microsoft.UI.Xaml.Automation.Peers.AutomationPeer.GetLabeledByCore
-api-type: winrt method
---

<!-- Method syntax
virtual protected Windows.UI.Xaml.Automation.Peers.AutomationPeer GetLabeledByCore()
-->

# Microsoft.UI.Xaml.Automation.Peers.AutomationPeer.GetLabeledByCore

## -description
Provides the peer's behavior when a Microsoft UI Automation client calls [GetLabeledBy](automationpeer_getlabeledby_1845689.md) or an equivalent Microsoft UI Automation client API.

## -returns
The [AutomationPeer](automationpeer.md) for the element that is targeted by the [UIElement](../microsoft.ui.xaml/uielement.md).

## -remarks
Specifying a control behavior for labeling is uncommon except for composite data presentation controls that use headers or similar metaphors. In most cases apps establish labeling information between the elements in an app-specific UI by applying the [AutomationProperties.LabeledBy](/windows/winui/api/microsoft.ui.xaml.automation.automationproperties#xaml-attached-properties) attached property to the UI definition XAML.

## -examples

## -see-also
[FrameworkElementAutomationPeer](frameworkelementautomationpeer.md), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers), [Accessibility](/windows/uwp/accessibility/accessibility)
