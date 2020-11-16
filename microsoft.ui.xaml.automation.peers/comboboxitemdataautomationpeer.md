---
-api-id: T:Microsoft.UI.Xaml.Automation.Peers.ComboBoxItemDataAutomationPeer
-api-type: winrt class
---

<!-- Class syntax.
public class ComboBoxItemDataAutomationPeer : Windows.UI.Xaml.Automation.Peers.SelectorItemAutomationPeer, Windows.UI.Xaml.Automation.Peers.IComboBoxItemDataAutomationPeer, Windows.UI.Xaml.Automation.Provider.IScrollItemProvider
-->

# Microsoft.UI.Xaml.Automation.Peers.ComboBoxItemDataAutomationPeer

## -description
Exposes the data content of a [ComboBoxItem](../microsoft.ui.xaml.controls/comboboxitem.md) to Microsoft UI Automation.

## -remarks
 ComboBoxItemDataAutomationPeer is generated from [ComboBoxAutomationPeer](comboboxautomationpeer.md) logic, not an associated control class.

### Default peer implementation and overrides in **ComboBoxItemDataAutomationPeer**

ComboBoxItemDataAutomationPeer has overrides of **Core** methods such that the associated [AutomationPeer](automationpeer.md) methods provide peer-specific information to a Microsoft UI Automation client.

+ [GetPattern](automationpeer_getpattern_1700082720.md) reports that the peer supports [PatternInterface.ScrollItem](patterninterface.md) ([IScrollItemProvider](../microsoft.ui.xaml.automation.provider/iscrollitemprovider.md)). The base [SelectorItemAutomationPeer](selectoritemautomationpeer.md) supports [PatternInterface.SelectionItem](patterninterface.md) ([ISelectionItemProvider](../microsoft.ui.xaml.automation.provider/iselectionitemprovider.md)) and the base [ItemAutomationPeer](itemautomationpeer.md) supports [PatternInterface.VirtualizedItem](patterninterface.md) ([IVirtualizedItemProvider](../microsoft.ui.xaml.automation.provider/ivirtualizeditemprovider.md)).
+ [GetClassName](automationpeer_getclassname_614238974.md) returns "ComboBoxItem".
+ [GetAutomationControlType](automationpeer_getautomationcontroltype_1156384152.md) returns [AutomationControlType.ListItem](automationcontroltype.md).
+ Although [ItemAutomationPeer](itemautomationpeer.md) reported [IVirtualizedItemProvider](../microsoft.ui.xaml.automation.provider/ivirtualizeditemprovider.md) support, ComboBoxItemDataAutomationPeer re-implements this to call [ScrollIntoView](comboboxitemdataautomationpeer_scrollintoview_1265805467.md).

The peer also has other behaviors that are provided by the base [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md) class. For more info, see "Base implementation in FrameworkElementAutomationPeer" section of [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers).

## -examples

## -see-also
[SelectorItemAutomationPeer](selectoritemautomationpeer.md), [ComboBoxAutomationPeer](comboboxautomationpeer.md), [IVirtualizedItemProvider](../microsoft.ui.xaml.automation.provider/ivirtualizeditemprovider.md), [ISelectionItemProvider](../microsoft.ui.xaml.automation.provider/iselectionitemprovider.md), [IScrollItemProvider](../microsoft.ui.xaml.automation.provider/iscrollitemprovider.md), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers)
