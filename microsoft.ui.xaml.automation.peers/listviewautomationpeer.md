---
-api-id: T:Microsoft.UI.Xaml.Automation.Peers.ListViewAutomationPeer
-api-type: winrt class
---

<!-- Class syntax.
public class ListViewAutomationPeer : Windows.UI.Xaml.Automation.Peers.ListViewBaseAutomationPeer, Windows.UI.Xaml.Automation.Peers.IListViewAutomationPeer
-->

# Microsoft.UI.Xaml.Automation.Peers.ListViewAutomationPeer

## -description
Exposes [ListView](../microsoft.ui.xaml.controls/listview.md) types to Microsoft UI Automation.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -remarks
The Windows Runtime  [ListView](../microsoft.ui.xaml.controls/listview.md) class creates a new ListViewAutomationPeer as its [OnCreateAutomationPeer](../microsoft.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) definition. Derive your automation peer from ListViewAutomationPeer if you are deriving a custom class from [ListView](../microsoft.ui.xaml.controls/listview.md) and want to add automation support for additional features that you enabled in your custom class. Then override [OnCreateAutomationPeer](../microsoft.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) so that it returns your custom peer.

### Default peer implementation and overrides in **ListViewAutomationPeer**

ListViewAutomationPeer has overrides of **Core** methods such that the associated [AutomationPeer](automationpeer.md) methods provide peer-specific information to a Microsoft UI Automation client.

+ [GetPattern](automationpeer_getpattern_1700082720.md) reports that the peer provides pattern support for these patterns:
  + [PatternInterface.Selection](patterninterface.md) ([ISelectionProvider](../microsoft.ui.xaml.automation.provider/iselectionprovider.md))
  + [PatternInterface.ItemContainer](patterninterface.md) ([IItemContainerProvider](../microsoft.ui.xaml.automation.provider/iitemcontainerprovider.md))
  + [PatternInterface.DropTarget](patterninterface.md) ([IDropTargetProvider](../microsoft.ui.xaml.automation.provider/idroptargetprovider.md) )
  + This is the accumulated pattern support from each of the peer base classes.

+ [GetClassName](automationpeer_getclassname_614238974.md) returns "ListView".
+ [GetAutomationControlType](automationpeer_getautomationcontroltype_1156384152.md) returns [AutomationControlType.List](automationcontroltype.md).
+ [GetChildren](automationpeer_getchildren_555647254.md) has an implementation from [ListViewBaseAutomationPeer](listviewbaseautomationpeer.md) that returns the item peers.
The peer also has other behaviors that are provided by the base [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md) class. For more info, see "Base implementation in FrameworkElementAutomationPeer" section of [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers).

The API that supports the control patterns is all on [ListViewBaseAutomationPeer](listviewbaseautomationpeer.md), [SelectorAutomationPeer](selectorautomationpeer.md) or [ItemsControlAutomationPeer](itemscontrolautomationpeer.md).

## -examples

## -see-also
[ListView](../microsoft.ui.xaml.controls/listview.md), [ListViewBaseAutomationPeer](listviewbaseautomationpeer.md), [ItemsControlAutomationPeer](itemscontrolautomationpeer.md), [SelectorAutomationPeer](selectorautomationpeer.md), [IItemContainerProvider](../microsoft.ui.xaml.automation.provider/iitemcontainerprovider.md), [ISelectionProvider](../microsoft.ui.xaml.automation.provider/iselectionprovider.md), [IDropTargetProvider](../microsoft.ui.xaml.automation.provider/idroptargetprovider.md), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers)
