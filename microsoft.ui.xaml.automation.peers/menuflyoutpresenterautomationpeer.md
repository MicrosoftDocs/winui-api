---
-api-id: T:Microsoft.UI.Xaml.Automation.Peers.MenuFlyoutPresenterAutomationPeer
-api-type: winrt class
---

<!-- Class syntax.
public class MenuFlyoutPresenterAutomationPeer : Windows.UI.Xaml.Automation.Peers.ItemsControlAutomationPeer, Windows.UI.Xaml.Automation.Peers.IMenuFlyoutPresenterAutomationPeer
-->

# Microsoft.UI.Xaml.Automation.Peers.MenuFlyoutPresenterAutomationPeer

## -description
Exposes [MenuFlyoutPresenter](../microsoft.ui.xaml.controls/menuflyoutpresenter.md) types to Microsoft UI Automation.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -remarks
The Windows Runtime  [MenuFlyoutPresenter](../microsoft.ui.xaml.controls/menuflyoutpresenter.md) class creates a new MenuFlyoutPresenterAutomationPeer as its [OnCreateAutomationPeer](../microsoft.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) definition. Derive your automation peer from MenuFlyoutPresenterAutomationPeer if you are deriving a custom class from [MenuFlyoutPresenter](../microsoft.ui.xaml.controls/menuflyoutpresenter.md) and want to add automation support for additional features that you enabled in your custom class. Then override [OnCreateAutomationPeer](../microsoft.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) so that it returns your custom peer.

### Default peer implementation and overrides in **MenuFlyoutPresenterAutomationPeer**

MenuFlyoutPresenterAutomationPeer has overrides of **Core** methods such that the associated [AutomationPeer](automationpeer.md) methods provide peer-specific information to a Microsoft UI Automation client.

+ [GetClassName](automationpeer_getclassname_614238974.md) returns "MenuFlyout".
+ [GetAutomationControlType](automationpeer_getautomationcontroltype_1156384152.md) returns [AutomationControlType.Menu](automationcontroltype.md).
This peer has the base class [ItemsControlAutomationPeer](itemscontrolautomationpeer.md) and inherits its behavior other than the overrides indicated above. This includes the pattern support for [IItemContainerProvider](../microsoft.ui.xaml.automation.provider/iitemcontainerprovider.md) and possibly [IScrollProvider](../microsoft.ui.xaml.automation.provider/iscrollprovider.md). For more info, see [ItemsControlAutomationPeer](itemscontrolautomationpeer.md).

The peer also has other behaviors that are provided by the base [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md) class. For more info, see "Base implementation in FrameworkElementAutomationPeer" section of [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers).

## -examples

## -see-also
[ItemsControlAutomationPeer](itemscontrolautomationpeer.md), [IItemContainerProvider](../microsoft.ui.xaml.automation.provider/iitemcontainerprovider.md), [MenuFlyoutPresenter](../microsoft.ui.xaml.controls/menuflyoutpresenter.md)
