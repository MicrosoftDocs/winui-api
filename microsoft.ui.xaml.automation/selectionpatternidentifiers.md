---
-api-id: T:Microsoft.UI.Xaml.Automation.SelectionPatternIdentifiers
-api-type: winrt class
---

<!-- Class syntax.
public class SelectionPatternIdentifiers : Windows.UI.Xaml.Automation.ISelectionPatternIdentifiers
-->

# Microsoft.UI.Xaml.Automation.SelectionPatternIdentifiers

## -description
Contains values used as identifiers by [ISelectionProvider](../microsoft.ui.xaml.automation.provider/iselectionprovider.md).

## -remarks
Classes such as SelectionPatternIdentifiers are the identifiers for the Windows Runtime implementation of a common provider pattern for Microsoft UI Automation. You might use these identifiers if you are implementing a Windows Runtime custom automation peer that reports support for [ISelectionProvider](../microsoft.ui.xaml.automation.provider/iselectionprovider.md) in its [GetPattern](/uwp/api/windows.ui.xaml.automation.peers.automationpeer.getpattern(windows.ui.xaml.automation.peers.patterninterface)) implementation. These identifiers are needed for the [RaisePropertyChangedEvent](/uwp/api/windows.ui.xaml.automation.peers.automationpeer.raisepropertychangedevent(windows.ui.xaml.automation.automationproperty,system.object,system.object)) calls that you make from control code that references your own peer, or for [FindItemByProperty](/uwp/api/windows.ui.xaml.automation.provider.iitemcontainerprovider.finditembyproperty(windows.ui.xaml.automation.provider.irawelementprovidersimple,windows.ui.xaml.automation.automationproperty,system.object)) in an items container peer.

This same pattern is usually exposed to clients in a different way, depending on which technology they use to implement the client and examine the Microsoft UI Automation tree. [ISelectionProvider](/windows/desktop/api/uiautomationcore/nn-uiautomationcore-iselectionprovider) is also presented as a Component Object Model (COM) interface.

## -examples

## -see-also
[ISelectionProvider](../microsoft.ui.xaml.automation.provider/iselectionprovider.md), [ISelectionItemProvider](../microsoft.ui.xaml.automation.provider/iselectionitemprovider.md), [Control patterns and interfaces](/windows/uwp/accessibility/control-patterns-and-interfaces), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers)
