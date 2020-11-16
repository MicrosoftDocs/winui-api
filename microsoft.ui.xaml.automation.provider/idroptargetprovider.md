---
-api-id: T:Microsoft.UI.Xaml.Automation.Provider.IDropTargetProvider
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IDropTargetProvider : 
-->

# Microsoft.UI.Xaml.Automation.Provider.IDropTargetProvider

## -description
Enables a Microsoft UI Automation element to describe itself as an element that can receive a drop of a dragged element as part of a drag-and-drop operation. Implement this interface in order to support the capabilities that an automation client requests with a [GetPattern](/uwp/api/windows.ui.xaml.automation.peers.automationpeer.getpattern(windows.ui.xaml.automation.peers.patterninterface)) call and [PatternInterface.DropTarget](../microsoft.ui.xaml.automation.peers/patterninterface.md).

## -remarks
A drop target reports the action if the user drops the dragged item on the peer's owner as drop target. These action results are called *effects*. The effects are descriptive strings, not visual effects in a UI and design sense. For more info on what this pattern is for, see [DropTarget Control Pattern](/windows/desktop/WinAuto/uiauto-implementingdroptarget).

IDropTargetProvider is implemented by the existing Windows Runtime automation peers for a [ListView](../microsoft.ui.xaml.controls/listview.md) or [GridView](../microsoft.ui.xaml.controls/gridview.md) ([ListViewAutomationPeer](../microsoft.ui.xaml.automation.peers/listviewautomationpeer.md), [GridViewAutomationPeer](../microsoft.ui.xaml.automation.peers/gridviewautomationpeer.md)). This supports the Windows Runtime scenario of dragging list items so that they can be reordered. There are a limited number of Windows Runtime classes that can be a drag source; these sources support the [IDragProvider](idragprovider.md) pattern for automation purposes.

Use [DropTargetPatternIdentifiers](../microsoft.ui.xaml.automation/droptargetpatternidentifiers.md) if you want to reference the IDropTargetProvider pattern properties from control code when you fire automation events or call [RaisePropertyChangedEvent](/uwp/api/windows.ui.xaml.automation.peers.automationpeer.raisepropertychangedevent(windows.ui.xaml.automation.automationproperty,system.object,system.object)).

## -examples

## -see-also
[DropTargetPatternIdentifiers](../microsoft.ui.xaml.automation/droptargetpatternidentifiers.md), [IDropTargetProvider (COM interface)](/windows/desktop/api/uiautomationcore/nn-uiautomationcore-idroptargetprovider), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers), [DropTarget Control Pattern](/windows/desktop/WinAuto/uiauto-implementingdroptarget)
