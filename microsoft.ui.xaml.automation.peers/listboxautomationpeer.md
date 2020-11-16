---
-api-id: T:Microsoft.UI.Xaml.Automation.Peers.ListBoxAutomationPeer
-api-type: winrt class
---

<!-- Class syntax.
public class ListBoxAutomationPeer : Windows.UI.Xaml.Automation.Peers.SelectorAutomationPeer, Windows.UI.Xaml.Automation.Peers.IListBoxAutomationPeer
-->

# Microsoft.UI.Xaml.Automation.Peers.ListBoxAutomationPeer

## -description
Exposes [ListBox](../microsoft.ui.xaml.controls/listbox.md) types to Microsoft UI Automation.

## -remarks
The Windows Runtime  [ListBox](../microsoft.ui.xaml.controls/listbox.md) class creates a new ListBoxAutomationPeer as its [OnCreateAutomationPeer](../microsoft.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) definition. Derive your automation peer from ListBoxAutomationPeer if you are deriving a custom class from [ListBox](../microsoft.ui.xaml.controls/listbox.md) and want to add automation support for additional features that you enabled in your custom class. Then override [OnCreateAutomationPeer](../microsoft.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) so that it returns your custom peer.

### Default peer implementation and overrides in **ListBoxAutomationPeer**

ListBoxAutomationPeer has overrides of **Core** methods such that the associated [AutomationPeer](automationpeer.md) methods provide peer-specific information to a Microsoft UI Automation client.

+ [GetPattern](automationpeer_getpattern_1700082720.md) reports that the peer provides pattern support for [PatternInterface.Selection](patterninterface.md) ([ISelectionProvider](../microsoft.ui.xaml.automation.provider/iselectionprovider.md)) and [PatternInterface.ItemContainer](patterninterface.md) ([IItemContainerProvider](../microsoft.ui.xaml.automation.provider/iitemcontainerprovider.md)). This comes from peer base classes.
+ [GetClassName](automationpeer_getclassname_614238974.md) returns "ListBox".
+ [GetAutomationControlType](automationpeer_getautomationcontroltype_1156384152.md) returns [AutomationControlType.List](automationcontroltype.md).
This peer has the base classes [ItemsControlAutomationPeer](itemscontrolautomationpeer.md) and [SelectorAutomationPeer](selectorautomationpeer.md) and these peers also have behavior that isn't overridden by the notes above, such as a [GetChildren](automationpeer_getchildren_555647254.md) implementation. For more info, see [ItemsControlAutomationPeer](itemscontrolautomationpeer.md) and [SelectorAutomationPeer](selectorautomationpeer.md).

The peer also has other behaviors that are provided by the base [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md) class. For more info, see "Base implementation in FrameworkElementAutomationPeer" section of [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers).

## -examples

## -see-also
[SelectorAutomationPeer](selectorautomationpeer.md), [ItemsControlAutomationPeer](itemscontrolautomationpeer.md), [ListBox](../microsoft.ui.xaml.controls/listbox.md), [IItemContainerProvider](../microsoft.ui.xaml.automation.provider/iitemcontainerprovider.md), [ISelectionProvider](../microsoft.ui.xaml.automation.provider/iselectionprovider.md), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers)
