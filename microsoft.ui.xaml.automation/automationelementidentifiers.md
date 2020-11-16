---
-api-id: T:Microsoft.UI.Xaml.Automation.AutomationElementIdentifiers
-api-type: winrt class
---

<!-- Class syntax.
public class AutomationElementIdentifiers : Windows.UI.Xaml.Automation.IAutomationElementIdentifiers
-->

# Microsoft.UI.Xaml.Automation.AutomationElementIdentifiers

## -description
Contains values used as automation property identifiers by UI Automation providers and UI Automation clients.

## -remarks
Classes such as **AutomationElementIdentifiers** are the identifiers for the Windows Runtime implementation of a common provider pattern for Microsoft UI Automation. **AutomationElementIdentifiers** identifies the general automation peer properties that are part of the basic peer functionality, as opposed to being related to a specific automation control pattern. You might use these identifiers if you are implementing a Windows Runtime custom automation peer based on [AutomationPeer](../microsoft.ui.xaml.automation.peers/automationpeer.md) or [FrameworkElementAutomationPeer](../microsoft.ui.xaml.automation.peers/frameworkelementautomationpeer.md). These identifiers are needed for the [RaisePropertyChangedEvent](/uwp/api/windows.ui.xaml.automation.peers.automationpeer.raisepropertychangedevent(windows.ui.xaml.automation.automationproperty,system.object,system.object)) calls that you make from control code that references your own peer, or for [FindItemByProperty](/uwp/api/windows.ui.xaml.automation.provider.iitemcontainerprovider.finditembyproperty(windows.ui.xaml.automation.provider.irawelementprovidersimple,windows.ui.xaml.automation.automationproperty,system.object)) in an items container peer.

This same set of property identifiers is usually exposed to clients in a different way, depending on which technology they use to implement the client and examine the Microsoft UI Automation tree. One such property identifier list for clients is documented in the topic [Automation Element Property Identifiers](/windows/desktop/WinAuto/uiauto-automation-element-propids).

## -examples

## -see-also
[FrameworkElementAutomationPeer](../microsoft.ui.xaml.automation.peers/frameworkelementautomationpeer.md), [Automation Element Property Identifiers](/windows/desktop/WinAuto/uiauto-automation-element-propids), [Control patterns and interfaces](/windows/uwp/accessibility/control-patterns-and-interfaces), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers)
