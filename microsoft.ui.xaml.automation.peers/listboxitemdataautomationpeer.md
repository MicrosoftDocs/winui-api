---
-api-id: T:Microsoft.UI.Xaml.Automation.Peers.ListBoxItemDataAutomationPeer
-api-type: winrt class
---

<!-- Class syntax.
public class ListBoxItemDataAutomationPeer : Windows.UI.Xaml.Automation.Peers.SelectorItemAutomationPeer, Windows.UI.Xaml.Automation.Peers.IListBoxItemDataAutomationPeer, Windows.UI.Xaml.Automation.Provider.IScrollItemProvider
-->

# Microsoft.UI.Xaml.Automation.Peers.ListBoxItemDataAutomationPeer

## -description
Exposes [ListBox](../microsoft.ui.xaml.controls/listbox.md) items to Microsoft UI Automation, using a data representation of the item so that the peer supports scrolling to that item with data awareness.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -remarks
 ListBoxItemDataAutomationPeer is generated from [ListBoxAutomationPeer](listboxautomationpeer.md) logic, not an associated control class.

### Default peer implementation and overrides in **ListBoxItemDataAutomationPeer**

ListBoxItemDataAutomationPeer has overrides of **Core** methods such that the associated [AutomationPeer](automationpeer.md) methods provide peer-specific information to a Microsoft UI Automation client.

+ [GetPattern](automationpeer_getpattern_1700082720.md) reports that the peer supports [PatternInterface.ScrollItem](patterninterface.md) ([IScrollItemProvider](../microsoft.ui.xaml.automation.provider/iscrollitemprovider.md)). The base [SelectorItemAutomationPeer](selectoritemautomationpeer.md) supports [PatternInterface.SelectionItem](patterninterface.md) ([ISelectionItemProvider](../microsoft.ui.xaml.automation.provider/iselectionitemprovider.md)) and the base [ItemAutomationPeer](itemautomationpeer.md) supports [PatternInterface.VirtualizedItem](patterninterface.md) ([IVirtualizedItemProvider](../microsoft.ui.xaml.automation.provider/ivirtualizeditemprovider.md)).
+ [GetClassName](automationpeer_getclassname_614238974.md) returns "ListBoxItem".
+ [GetAutomationControlType](automationpeer_getautomationcontroltype_1156384152.md) returns [AutomationControlType.ListItem](automationcontroltype.md).
+ Although [ItemAutomationPeer](itemautomationpeer.md) reported [IVirtualizedItemProvider](../microsoft.ui.xaml.automation.provider/ivirtualizeditemprovider.md) support, ListBoxItemDataAutomationPeer re-implements this to call [ScrollIntoView](listboxitemdataautomationpeer_scrollintoview_1265805467.md).

The peer also has other behaviors that are provided by the base [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md) class. For more info, see "Base implementation in FrameworkElementAutomationPeer" section of [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers).

## -examples

## -see-also
[SelectorItemAutomationPeer](selectoritemautomationpeer.md), [ItemAutomationPeer](itemautomationpeer.md), [IVirtualizedItemProvider](../microsoft.ui.xaml.automation.provider/ivirtualizeditemprovider.md), [ISelectionItemProvider](../microsoft.ui.xaml.automation.provider/iselectionitemprovider.md), [IScrollItemProvider](../microsoft.ui.xaml.automation.provider/iscrollitemprovider.md)
