---
-api-id: T:Microsoft.UI.Xaml.Automation.Provider.IItemContainerProvider
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IItemContainerProvider : 
-->

# Microsoft.UI.Xaml.Automation.Provider.IItemContainerProvider

## -description
Exposes a Microsoft UI Automation method to enable applications to find an element in a container, such as a virtualized list. Implement this interface in order to support the capabilities that an automation client requests with a [GetPattern](/uwp/api/windows.ui.xaml.automation.peers.automationpeer.getpattern(windows.ui.xaml.automation.peers.patterninterface)) call and [PatternInterface.ItemContainer](../microsoft.ui.xaml.automation.peers/patterninterface.md).

## -remarks
Controls that contain a large number of child items can use virtualization to efficiently manage the items. With virtualization, the control maintains full information in memory for only a subset of items at any given time. Typically, the subset includes only those items that are currently visible to the user. Full information about the remaining virtualized items is kept in storage and is loaded into memory, or realized, as the control needs it, for example, as new items become visible to the user. A related pattern is [IVirtualizedItemProvider](ivirtualizeditemprovider.md). For more info on what this pattern is for, see [ItemContainer Control Pattern](/windows/desktop/WinAuto/uiauto-implementingitemcontainer).

IItemContainerProvider is implemented by the existing Windows Runtime automation peers for various list controls or views, controls that share the base class [ItemsControl](../microsoft.ui.xaml.controls/itemscontrol.md). Each of these peers inherits from [ItemsControlAutomationPeer](../microsoft.ui.xaml.automation.peers/itemscontrolautomationpeer.md), and [ItemsControlAutomationPeer](../microsoft.ui.xaml.automation.peers/itemscontrolautomationpeer.md) provides the common [FindItemByProperty](/uwp/api/windows.ui.xaml.automation.peers.itemscontrolautomationpeer.finditembyproperty(windows.ui.xaml.automation.provider.irawelementprovidersimple,windows.ui.xaml.automation.automationproperty,system.object)) implementation.

The IItemContainerProvider pattern doesn't have a pattern property identifier class, the only API to implement is [FindItemByProperty](iitemcontainerprovider_finditembyproperty_632840925.md), a method.

## -examples

## -see-also
[IVirtualizedItemProvider](ivirtualizeditemprovider.md), [IItemContainerProvider (COM interface)](/windows/desktop/api/uiautomationcore/nn-uiautomationcore-iitemcontainerprovider), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers), [ItemContainer Control Pattern](/windows/desktop/WinAuto/uiauto-implementingitemcontainer)
