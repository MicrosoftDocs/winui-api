---
-api-id: T:Microsoft.UI.Xaml.Automation.Provider.ITableItemProvider
-api-type: winrt interface
---

<!-- Interface syntax.
public interface ITableItemProvider : 
-->

# Microsoft.UI.Xaml.Automation.Provider.ITableItemProvider

## -description
Exposes methods and properties to support Microsoft UI Automation client access to child controls of containers that implement [ITableProvider](itableprovider.md). Implement this interface in order to support the capabilities that an automation client requests with a [GetPattern](/uwp/api/windows.ui.xaml.automation.peers.automationpeer.getpattern(windows.ui.xaml.automation.peers.patterninterface)) call and [PatternInterface.TableItem](../microsoft.ui.xaml.automation.peers/patterninterface.md).

## -remarks
This pattern has guidelines and conventions that aren't fully documented here. For more info on what this pattern is for, see [TableItem Control Pattern](/windows/desktop/WinAuto/uiauto-implementingtableitem).

ITableItemProvider isn't implemented by any existing Windows Runtime automation peers. The interface exists so that custom control authors can support the automation pattern in a custom control, and implement their automation support using the same Windows Runtime managed or C++ API as they use to define control logic or other automation support.

Use the [TableItemPatternIdentifiers](../microsoft.ui.xaml.automation/tableitempatternidentifiers.md) if you want to reference the ITableItemProvider pattern properties from control code when you call [RaisePropertyChangedEvent](/uwp/api/windows.ui.xaml.automation.peers.automationpeer.raisepropertychangedevent(windows.ui.xaml.automation.automationproperty,system.object,system.object)).

## -examples

## -see-also
[IGridItemProvider](igriditemprovider.md), [ITableProvider](itableprovider.md), [ITableItemProvider (COM interface)](/windows/desktop/api/uiautomationcore/nn-uiautomationcore-itableitemprovider), [TableItem Control Pattern](/windows/desktop/WinAuto/uiauto-implementingtableitem), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers)
