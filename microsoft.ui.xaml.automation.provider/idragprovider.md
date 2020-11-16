---
-api-id: T:Microsoft.UI.Xaml.Automation.Provider.IDragProvider
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IDragProvider : 
-->

# Microsoft.UI.Xaml.Automation.Provider.IDragProvider

## -description
Enables a Microsoft UI Automation element to describe itself as an element that can be dragged as part of a drag-and-drop operation. Implement this interface in order to support the capabilities that an automation client requests with a [GetPattern](/uwp/api/windows.ui.xaml.automation.peers.automationpeer.getpattern(windows.ui.xaml.automation.peers.patterninterface)) call and [PatternInterface.Drag](../microsoft.ui.xaml.automation.peers/patterninterface.md).

## -remarks
The **Drag** control pattern is used to support draggable controls, or controls with draggable items. For more info on what this pattern is for, see [Drag Control Pattern](/windows/desktop/WinAuto/uiauto-implementingdrag).

IDragProvider is implemented by the existing Windows Runtime automation peers for a [ListView](../microsoft.ui.xaml.controls/listview.md) item ([ListViewItemAutomationPeer](../microsoft.ui.xaml.automation.peers/listviewitemautomationpeer.md)) or [GridView](../microsoft.ui.xaml.controls/gridview.md) item ([GridViewItemAutomationPeer](../microsoft.ui.xaml.automation.peers/gridviewitemautomationpeer.md)). This supports the Windows Runtime scenario of dragging list items so that they can be reordered. The peer for the host view of the items ([ListViewAutomationPeer](../microsoft.ui.xaml.automation.peers/listviewautomationpeer.md) or [GridViewAutomationPeer](../microsoft.ui.xaml.automation.peers/gridviewautomationpeer.md)) support the [IDropTargetProvider](idroptargetprovider.md) pattern.

Use [DragPatternIdentifiers](../microsoft.ui.xaml.automation/dragpatternidentifiers.md) if you want to reference the IDragProvider pattern properties from control code when you fire automation events or call [RaisePropertyChangedEvent](/uwp/api/windows.ui.xaml.automation.peers.automationpeer.raisepropertychangedevent(windows.ui.xaml.automation.automationproperty,system.object,system.object)).

## -examples

## -see-also
[DragPatternIdentifiers](../microsoft.ui.xaml.automation/dragpatternidentifiers.md), [IDragProvider (COM interface)](/windows/desktop/api/uiautomationcore/nn-uiautomationcore-idragprovider), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers), [Drag Control Pattern](/windows/desktop/WinAuto/uiauto-implementingdrag)
