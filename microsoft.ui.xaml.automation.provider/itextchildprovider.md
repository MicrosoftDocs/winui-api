---
-api-id: T:Microsoft.UI.Xaml.Automation.Provider.ITextChildProvider
-api-type: winrt interface
---

<!-- Interface syntax.
public interface ITextChildProvider : 
-->

# Microsoft.UI.Xaml.Automation.Provider.ITextChildProvider

## -description
Provides access to a text-based control that is a child of another text-based control. Implement this interface in order to support the capabilities that an automation client requests with a [GetPattern](/uwp/api/windows.ui.xaml.automation.peers.automationpeer.getpattern(windows.ui.xaml.automation.peers.patterninterface)) call and [PatternInterface.TextChild](../microsoft.ui.xaml.automation.peers/patterninterface.md).

## -remarks
This pattern has guidelines and conventions that aren't fully documented here. For more info on what this pattern is for, see [TextChild Control Pattern](/windows/desktop/WinAuto/textchild-control-pattern).

ITextChildProvider isn't implemented by any existing Windows Runtime automation peers. The interface exists so that custom control authors can support the automation pattern in a custom control, and implement their automation support using the same Windows Runtime managed or C++ API as they use to define control logic or other automation support.

The [ITableItemProvider](itableitemprovider.md) pattern doesn't have a pattern property identifier class.

## -examples

## -see-also
[ITextChildProvider (COM interface)](/windows/desktop/api/uiautomationcore/nn-uiautomationcore-itextchildprovider), [TextChild Control Pattern](/windows/desktop/WinAuto/textchild-control-pattern), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers)
