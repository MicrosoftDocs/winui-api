---
-api-id: T:Microsoft.UI.Xaml.Automation.TogglePatternIdentifiers
-api-type: winrt class
---

<!-- Class syntax.
public class TogglePatternIdentifiers : Windows.UI.Xaml.Automation.ITogglePatternIdentifiers
-->

# Microsoft.UI.Xaml.Automation.TogglePatternIdentifiers

## -description
Contains values used as identifiers by [IToggleProvider](../microsoft.ui.xaml.automation.provider/itoggleprovider.md).

## -remarks
Classes such as TogglePatternIdentifiers are the identifiers for the Windows Runtime implementation of a common provider pattern for Microsoft UI Automation. You might use these identifiers if you are implementing a Windows Runtime custom automation peer that reports support for [IToggleProvider](../microsoft.ui.xaml.automation.provider/itoggleprovider.md) in its [GetPattern](/uwp/api/windows.ui.xaml.automation.peers.automationpeer.getpattern(windows.ui.xaml.automation.peers.patterninterface)) implementation. These identifiers are needed for the [RaisePropertyChangedEvent](/uwp/api/windows.ui.xaml.automation.peers.automationpeer.raisepropertychangedevent(windows.ui.xaml.automation.automationproperty,system.object,system.object)) calls that you make from control code that references your own peer, or for [FindItemByProperty](/uwp/api/windows.ui.xaml.automation.provider.iitemcontainerprovider.finditembyproperty(windows.ui.xaml.automation.provider.irawelementprovidersimple,windows.ui.xaml.automation.automationproperty,system.object)) in an items container peer.

This same pattern is usually exposed to clients in a different way, depending on which technology they use to implement the client and examine the Microsoft UI Automation tree. [IToggleProvider](/windows/desktop/api/uiautomationcore/nn-uiautomationcore-itoggleprovider) is also presented as a Component Object Model (COM) interface.

## -examples

## -see-also
[IToggleProvider](../microsoft.ui.xaml.automation.provider/itoggleprovider.md), [Control patterns and interfaces](/windows/uwp/accessibility/control-patterns-and-interfaces), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers)
