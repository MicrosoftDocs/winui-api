---
-api-id: T:Microsoft.UI.Xaml.Automation.Provider.IScrollProvider
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IScrollProvider : 
-->

# Microsoft.UI.Xaml.Automation.Provider.IScrollProvider

## -description
Exposes methods and properties to support access by a Microsoft UI Automation client to a control that acts as a scrollable container for a collection of child objects. The children of this element must implement [IScrollItemProvider](iscrollitemprovider.md). Implement IScrollProvider in order to support the capabilities that an automation client requests with a [GetPattern](/uwp/api/windows.ui.xaml.automation.peers.automationpeer.getpattern(windows.ui.xaml.automation.peers.patterninterface)) call and [PatternInterface.Scroll](../microsoft.ui.xaml.automation.peers/patterninterface.md).

## -remarks
This pattern has guidelines and conventions that aren't fully documented here. For more info on what this pattern is for, see [Scroll Control Pattern](/windows/desktop/WinAuto/uiauto-implementingscroll).

IScrollProvider is implemented by the existing Windows Runtime class [ScrollViewerAutomationPeer](../microsoft.ui.xaml.automation.peers/scrollviewerautomationpeer.md), which is the peer for the [ScrollViewer](../microsoft.ui.xaml.controls/scrollviewer.md) component part used in many other list controls.

Also, IScrollProvider is reported as a supported pattern by [ItemsControlAutomationPeer](../microsoft.ui.xaml.automation.peers/itemscontrolautomationpeer.md), but only if a [ScrollViewer](../microsoft.ui.xaml.controls/scrollviewer.md) exists in the owner's template and is active. The [ScrollViewerAutomationPeer](../microsoft.ui.xaml.automation.peers/scrollviewerautomationpeer.md) for this [ScrollViewer](../microsoft.ui.xaml.controls/scrollviewer.md) provides the pattern implementation, [ItemsControlAutomationPeer](../microsoft.ui.xaml.automation.peers/itemscontrolautomationpeer.md) is only forwarding it.

Use [ScrollPatternIdentifiers](../microsoft.ui.xaml.automation/scrollpatternidentifiers.md) if you want to reference the IScrollProvider pattern properties from control code when you fire automation events or call [RaisePropertyChangedEvent](/uwp/api/windows.ui.xaml.automation.peers.automationpeer.raisepropertychangedevent(windows.ui.xaml.automation.automationproperty,system.object,system.object)).

## -examples

## -see-also
[IScrollItemProvider](iscrollitemprovider.md), [IScrollProvider (COM interface)](/windows/desktop/api/uiautomationcore/nn-uiautomationcore-iscrollprovider), [ScrollViewerAutomationPeer](../microsoft.ui.xaml.automation.peers/scrollviewerautomationpeer.md), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers), [Scroll Control Pattern](/windows/desktop/WinAuto/uiauto-implementingscroll)
