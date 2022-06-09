---
-api-id: T:Microsoft.UI.Xaml.Automation.Peers.FlyoutPresenterAutomationPeer
-api-type: winrt class
---

<!-- Class syntax.
public class FlyoutPresenterAutomationPeer : Windows.UI.Xaml.Automation.Peers.FrameworkElementAutomationPeer, Windows.UI.Xaml.Automation.Peers.IFlyoutPresenterAutomationPeer
-->

# Microsoft.UI.Xaml.Automation.Peers.FlyoutPresenterAutomationPeer

## -description
Exposes [FlyoutPresenter](../microsoft.ui.xaml.controls/flyoutpresenter.md) types to Microsoft UI Automation.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -remarks
The Windows Runtime  [FlyoutPresenter](../microsoft.ui.xaml.controls/flyoutpresenter.md) class creates a new FlyoutPresenterAutomationPeer as its [OnCreateAutomationPeer](../microsoft.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) definition. Derive your automation peer from FlyoutPresenterAutomationPeer if you are deriving a custom class from [FlyoutPresenter](../microsoft.ui.xaml.controls/flyoutpresenter.md) and want to add automation support for additional features that you enabled in your custom class. Then override [OnCreateAutomationPeer](../microsoft.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) so that it returns your custom peer.

### Default peer implementation and overrides in **FlyoutPresenterAutomationPeer**

FlyoutPresenterAutomationPeer has overrides of **Core** methods such that the associated [AutomationPeer](automationpeer.md) methods provide peer-specific information to a Microsoft UI Automation client.

+ [GetClassName](automationpeer_getclassname_614238974.md) returns "Flyout".
+ [GetAutomationControlType](automationpeer_getautomationcontroltype_1156384152.md) returns [AutomationControlType.Pane](automationcontroltype.md).
+ [GetPattern](automationpeer_getpattern_1700082720.md) reports that the peer provides pattern support for [PatternInterface.Invoke](patterninterface.md) ([IInvokeProvider](/windows/desktop/api/uiautomationcore/nn-uiautomationcore-iinvokeprovider)).
The peer also has other behaviors that are provided by the base [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md) class. For more info, see "Base implementation in FrameworkElementAutomationPeer" section of [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers).

## -examples

## -see-also
[FrameworkElementAutomationPeer](frameworkelementautomationpeer.md), [FlyoutPresenter](../microsoft.ui.xaml.controls/flyoutpresenter.md)
