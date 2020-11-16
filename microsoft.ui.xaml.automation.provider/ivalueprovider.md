---
-api-id: T:Microsoft.UI.Xaml.Automation.Provider.IValueProvider
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IValueProvider : 
-->

# Microsoft.UI.Xaml.Automation.Provider.IValueProvider

## -description
Exposes methods and properties to support access by a Microsoft UI Automation client to controls that have an intrinsic value that does not span a range and that can be represented as a string. Implement this interface in order to support the capabilities that an automation client requests with a [GetPattern](/uwp/api/windows.ui.xaml.automation.peers.automationpeer.getpattern(windows.ui.xaml.automation.peers.patterninterface)) call and [PatternInterface.Value](../microsoft.ui.xaml.automation.peers/patterninterface.md).

## -remarks
The value string can be editable, depending on the control and its settings. This pattern has guidelines and conventions that aren't fully documented here. For more info on what this pattern is for, see [Value Control Pattern](/windows/desktop/WinAuto/uiauto-implementingvalue).

IValueProvider is implemented by the existing Windows Runtime class [ComboBoxAutomationPeer](../microsoft.ui.xaml.automation.peers/comboboxautomationpeer.md).

The text models supported by Windows Runtime text controls such as [TextBox](../microsoft.ui.xaml.controls/textbox.md) and [RichTextBlock](../microsoft.ui.xaml.controls/richtextblock.md) don't use the IValueProvider pattern.

Use [ValuePatternIdentifiers](../microsoft.ui.xaml.automation/valuepatternidentifiers.md) if you want to reference the IValueProvider pattern properties from control code when you fire automation events or call [RaisePropertyChangedEvent](/uwp/api/windows.ui.xaml.automation.peers.automationpeer.raisepropertychangedevent(windows.ui.xaml.automation.automationproperty,system.object,system.object)).

## -examples

## -see-also
[ValuePatternIdentifiers](../microsoft.ui.xaml.automation/valuepatternidentifiers.md), [IValueProvider (COM interface)](/windows/desktop/api/uiautomationcore/nn-uiautomationcore-ivalueprovider), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers), [Value Control Pattern](/windows/desktop/WinAuto/uiauto-implementingvalue)
