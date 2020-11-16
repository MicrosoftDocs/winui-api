---
-api-id: T:Microsoft.UI.Xaml.Automation.Provider.IToggleProvider
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IToggleProvider : 
-->

# Microsoft.UI.Xaml.Automation.Provider.IToggleProvider

## -description
Exposes methods and properties to support Microsoft UI Automation client access to controls that can cycle through a set of states and maintain a particular state. Implement this interface in order to support the capabilities that an automation client requests with a [GetPattern](/uwp/api/windows.ui.xaml.automation.peers.automationpeer.getpattern(windows.ui.xaml.automation.peers.patterninterface)) call and [PatternInterface.Toggle](../microsoft.ui.xaml.automation.peers/patterninterface.md).

## -remarks
Controls that do not maintain state when activated, such as buttons, toolbar buttons, and hyperlinks, must implement [IInvokeProvider](iinvokeprovider.md) instead. The **Toggle** pattern has guidelines and conventions that aren't fully documented here. For more info on what this pattern is for, see [Toggle Control Pattern](/windows/desktop/WinAuto/uiauto-implementingtoggle).

IToggleProvider is implemented by these existing Windows Runtime classes:
+ [AppBarAutomationPeer](../microsoft.ui.xaml.automation.peers/appbarautomationpeer.md)
+ [SemanticZoomAutomationPeer](../microsoft.ui.xaml.automation.peers/semanticzoomautomationpeer.md)
+ [ToggleSwitchAutomationPeer](../microsoft.ui.xaml.automation.peers/toggleswitchautomationpeer.md)
+ [ToggleButtonAutomationPeer](../microsoft.ui.xaml.automation.peers/togglebuttonautomationpeer.md), which is the base class for [RadioButtonAutomationPeer](../microsoft.ui.xaml.automation.peers/radiobuttonautomationpeer.md) and [CheckBoxAutomationPeer](../microsoft.ui.xaml.automation.peers/checkboxautomationpeer.md)


Use [TogglePatternIdentifiers](../microsoft.ui.xaml.automation/togglepatternidentifiers.md) if you want to reference the IToggleProvider pattern properties from control code when you fire automation events or call [RaisePropertyChangedEvent](/uwp/api/windows.ui.xaml.automation.peers.automationpeer.raisepropertychangedevent(windows.ui.xaml.automation.automationproperty,system.object,system.object)).

## -examples

## -see-also
[TogglePatternIdentifiers](../microsoft.ui.xaml.automation/togglepatternidentifiers.md), [IToggleProvider (COM interface)](/windows/desktop/api/uiautomationcore/nn-uiautomationcore-itoggleprovider), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers), [Toggle Control Pattern](/windows/desktop/WinAuto/uiauto-implementingtoggle)
