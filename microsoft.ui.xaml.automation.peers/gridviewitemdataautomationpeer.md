---
-api-id: T:Microsoft.UI.Xaml.Automation.Peers.GridViewItemDataAutomationPeer
-api-type: winrt class
---

<!-- Class syntax.
public class GridViewItemDataAutomationPeer : Windows.UI.Xaml.Automation.Peers.SelectorItemAutomationPeer, Windows.UI.Xaml.Automation.Peers.IGridViewItemDataAutomationPeer, Windows.UI.Xaml.Automation.Provider.IScrollItemProvider
-->

# Microsoft.UI.Xaml.Automation.Peers.GridViewItemDataAutomationPeer

## -description
Exposes [GridView](../microsoft.ui.xaml.controls/gridview.md) items to Microsoft UI Automation, using a data representation of the item so that the peer supports scrolling to that item with data awareness.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -remarks
 GridViewItemDataAutomationPeer is generated from [GridViewAutomationPeer](gridviewautomationpeer.md) logic, not an associated control class.

### Default peer implementation and overrides in **GridViewItemDataAutomationPeer**

GridViewItemDataAutomationPeer has overrides of **Core** methods such that the associated [AutomationPeer](automationpeer.md) methods provide peer-specific information to a Microsoft UI Automation client.

+ [GetPattern](automationpeer_getpattern_1700082720.md) reports that the peer supports [PatternInterface.ScrollItem](patterninterface.md) ([IScrollItemProvider](../microsoft.ui.xaml.automation.provider/iscrollitemprovider.md)), [PatternInterface.SelectionItem](patterninterface.md) ([ISelectionItemProvider](../microsoft.ui.xaml.automation.provider/iselectionitemprovider.md)) and [PatternInterface.VirtualizedItem](patterninterface.md) ([IVirtualizedItemProvider](../microsoft.ui.xaml.automation.provider/ivirtualizeditemprovider.md)). All these patterns come from peer base classes.
+ [GetClassName](automationpeer_getclassname_614238974.md) returns "GridViewItem".
+ [GetAutomationControlType](automationpeer_getautomationcontroltype_1156384152.md) returns [AutomationControlType.ListItem](automationcontroltype.md).

The peer also has other behaviors that are provided by the base [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md) class. For more info, see "Base implementation in FrameworkElementAutomationPeer" section of [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers).

## -examples

## -see-also
[GridViewAutomationPeer](gridviewautomationpeer.md), [SelectorItemAutomationPeer](selectoritemautomationpeer.md), [IVirtualizedItemProvider](../microsoft.ui.xaml.automation.provider/ivirtualizeditemprovider.md), [ISelectionItemProvider](../microsoft.ui.xaml.automation.provider/iselectionitemprovider.md), [IScrollItemProvider](../microsoft.ui.xaml.automation.provider/iscrollitemprovider.md), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers)
