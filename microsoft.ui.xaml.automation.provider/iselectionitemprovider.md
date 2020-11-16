---
-api-id: T:Microsoft.UI.Xaml.Automation.Provider.ISelectionItemProvider
-api-type: winrt interface
---

<!-- Interface syntax.
public interface ISelectionItemProvider : 
-->

# Microsoft.UI.Xaml.Automation.Provider.ISelectionItemProvider

## -description
Exposes methods and properties to support access by a Microsoft UI Automation client to individual, selectable child controls of containers that implement [ISelectionProvider](iselectionprovider.md). Implement this interface in order to support the capabilities that an automation client requests with a [GetPattern](/uwp/api/windows.ui.xaml.automation.peers.automationpeer.getpattern(windows.ui.xaml.automation.peers.patterninterface)) call and [PatternInterface.SelectionItem](../microsoft.ui.xaml.automation.peers/patterninterface.md).

## -remarks
This pattern has guidelines and conventions that aren't fully documented here. For more info on what this pattern is for, see [SelectionItem Control Pattern](/windows/desktop/WinAuto/uiauto-implementingselectionitem). However, you don't need to follow the guidance regarding [IRawElementProviderFragmentRoot](/windows/desktop/api/uiautomationcore/nn-uiautomationcore-irawelementproviderfragmentroot), that is specific to COM provider implementations and the interface doesn't exist in the Windows Runtime automation provider API.

ISelectionItemProvider is implemented by these existing Windows Runtime classes:
+ [RadioButtonAutomationPeer](../microsoft.ui.xaml.automation.peers/radiobuttonautomationpeer.md)
+ [SelectorItemAutomationPeer](../microsoft.ui.xaml.automation.peers/selectoritemautomationpeer.md)


Use [SelectionItemPatternIdentifiers](../microsoft.ui.xaml.automation/selectionitempatternidentifiers.md) if you want to reference the ISelectionItemProvider pattern properties from control code when you fire automation events or call [RaisePropertyChangedEvent](/uwp/api/windows.ui.xaml.automation.peers.automationpeer.raisepropertychangedevent(windows.ui.xaml.automation.automationproperty,system.object,system.object)).

## -examples

## -see-also
[SelectionItemPatternIdentifiers](../microsoft.ui.xaml.automation/selectionitempatternidentifiers.md), [ISelectionItemProvider (COM interface)](/windows/desktop/api/uiautomationcore/nn-uiautomationcore-iselectionitemprovider), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers), [SelectionItem Control Pattern](/windows/desktop/WinAuto/uiauto-implementingselectionitem)
