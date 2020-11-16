---
-api-id: T:Microsoft.UI.Xaml.Automation.Provider.ISelectionProvider
-api-type: winrt interface
---

<!-- Interface syntax.
public interface ISelectionProvider : 
-->

# Microsoft.UI.Xaml.Automation.Provider.ISelectionProvider

## -description
Exposes methods and properties to support access by a Microsoft UI Automation client to controls that act as containers for a collection of individual, selectable child items. The children of this element must implement [ISelectionItemProvider](iselectionitemprovider.md). Implement ISelectionProvider in order to support the capabilities that an automation client requests with a [GetPattern](/uwp/api/windows.ui.xaml.automation.peers.automationpeer.getpattern(windows.ui.xaml.automation.peers.patterninterface)) call and [PatternInterface.SelectionItem](../microsoft.ui.xaml.automation.peers/patterninterface.md).

## -remarks
This pattern has guidelines and conventions that aren't fully documented here. For more info on what this pattern is for, see [Selection Control Pattern](/windows/desktop/WinAuto/uiauto-implementingselection). However, you don't need to follow the guidance regarding [IRawElementProviderFragmentRoot](/windows/desktop/api/uiautomationcore/nn-uiautomationcore-irawelementproviderfragmentroot), that is specific to COM provider implementations and the interface doesn't exist in the Windows Runtime automation provider API.

ISelectionProvider is implemented by the existing Windows Runtime class [SelectorAutomationPeer](../microsoft.ui.xaml.automation.peers/selectorautomationpeer.md), which is the base class for [ComboBoxAutomationPeer](../microsoft.ui.xaml.automation.peers/comboboxautomationpeer.md) and [ListBoxAutomationPeer](../microsoft.ui.xaml.automation.peers/listboxautomationpeer.md).

Use [SelectionPatternIdentifiers](../microsoft.ui.xaml.automation/selectionpatternidentifiers.md) if you want to reference the ISelectionProvider pattern properties from control code when you fire automation events or call [RaisePropertyChangedEvent](/uwp/api/windows.ui.xaml.automation.peers.automationpeer.raisepropertychangedevent(windows.ui.xaml.automation.automationproperty,system.object,system.object)).

## -examples

## -see-also
[SelectionPatternIdentifiers](../microsoft.ui.xaml.automation/selectionpatternidentifiers.md), [Selector](../microsoft.ui.xaml.controls.primitives/selector.md), [ISelectionProvider (COM interface)](/windows/desktop/api/uiautomationcore/nn-uiautomationcore-iselectionprovider), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers), [Selection Control Pattern](/windows/desktop/WinAuto/uiauto-implementingselection)
