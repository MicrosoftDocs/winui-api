---
-api-id: T:Microsoft.UI.Xaml.Automation.Provider.IGridItemProvider
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IGridItemProvider : 
-->

# Microsoft.UI.Xaml.Automation.Provider.IGridItemProvider

## -description
Exposes methods and properties to support access by a Microsoft UI Automation client to individual child controls of containers that implement [IGridProvider](igridprovider.md). Implement this interface in order to support the capabilities that an automation client requests with a [GetPattern](/uwp/api/windows.ui.xaml.automation.peers.automationpeer.getpattern(windows.ui.xaml.automation.peers.patterninterface)) call and [PatternInterface.GridItem](../microsoft.ui.xaml.automation.peers/patterninterface.md).

## -remarks
This pattern has guidelines and conventions that aren't fully documented here. For more info on what this pattern is for, see [GridItem Control Pattern](/windows/desktop/WinAuto/uiauto-implementinggriditem).

IGridItemProvider isn't implemented by any existing Windows Runtime automation peers. Notably, IGridItemProvider doesn't exist for the elements contained in a [Grid](../microsoft.ui.xaml.controls/grid.md) and using the [Grid](../microsoft.ui.xaml.controls/grid.md) as a layout container, or for [GridViewItem](../microsoft.ui.xaml.controls/gridviewitem.md). The interface exists so that custom control authors can support the automation pattern in a custom control, and implement their automation support using the same Windows Runtime managed or C++ API as they use to define control logic or other automation support.

Use [GridItemPatternIdentifiers](../microsoft.ui.xaml.automation/griditempatternidentifiers.md) if you want to reference the IGridItemProvider pattern properties from control code when you fire automation events or call [RaisePropertyChangedEvent](/uwp/api/windows.ui.xaml.automation.peers.automationpeer.raisepropertychangedevent(windows.ui.xaml.automation.automationproperty,system.object,system.object)).

## -examples

## -see-also
[IGridProvider](igridprovider.md), [GridItemPatternIdentifiers](../microsoft.ui.xaml.automation/griditempatternidentifiers.md), [IGridItemProvider (COM interface)](/windows/desktop/api/uiautomationcore/nn-uiautomationcore-igriditemprovider), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers), [GridItem Control Pattern](/windows/desktop/WinAuto/uiauto-implementinggriditem)
