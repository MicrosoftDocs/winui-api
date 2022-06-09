---
-api-id: T:Microsoft.UI.Xaml.Automation.Peers.AppBarToggleButtonAutomationPeer
-api-type: winrt class
---

<!-- Class syntax.
public class AppBarToggleButtonAutomationPeer : Windows.UI.Xaml.Automation.Peers.ToggleButtonAutomationPeer, Windows.UI.Xaml.Automation.Peers.IAppBarToggleButtonAutomationPeer
-->

# Microsoft.UI.Xaml.Automation.Peers.AppBarToggleButtonAutomationPeer

## -description
Exposes [AppBarToggleButton](../microsoft.ui.xaml.controls/appbartogglebutton.md) types to Microsoft UI Automation.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -remarks
The Windows Runtime  [AppBarToggleButton](../microsoft.ui.xaml.controls/appbartogglebutton.md) class creates a new AppBarToggleButtonAutomationPeer as its [OnCreateAutomationPeer](../microsoft.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) definition. Derive your automation peer from AppBarToggleButtonAutomationPeer if you are deriving a custom class from [AppBarToggleButton](../microsoft.ui.xaml.controls/appbartogglebutton.md) and want to add automation support for additional features that you enabled in your custom class. Then override [OnCreateAutomationPeer](../microsoft.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) so that it returns your custom peer.

### Default peer implementation and overrides in **AppBarToggleButtonAutomationPeer**

AppBarToggleButtonAutomationPeer has overrides of **Core** methods such that the associated [AutomationPeer](automationpeer.md) methods provide peer-specific information to a Microsoft UI Automation client.

+ [GetClassName](automationpeer_getclassname_614238974.md) returns "AppBarToggleButton".
+ [GetName](automationpeer_getname_1386609741.md) does not use the [ButtonBaseAutomationPeer](buttonbaseautomationpeer.md) behavior that returns a string based on **Content**. Instead, it looks for a label / **LabeledBy** value. Otherwise, values from apps should come from [AutomationProperties.Name](/windows/winui/api/microsoft.ui.xaml.automation.automationproperties#xaml-attached-properties) usages in XAML UI definitions, not from values forwarded from the control by the peer.
This peer has the base class [ToggleButtonAutomationPeer](togglebuttonautomationpeer.md) and inherits its behavior other than the overrides indicated above. This includes the pattern support for [IToggleProvider](/windows/desktop/api/uiautomationcore/nn-uiautomationcore-itoggleprovider) and the [GetPattern](automationpeer_getpattern_1700082720.md) behavior that returns that pattern when requested, and [GetAutomationControlType](automationpeer_getautomationcontroltype_1156384152.md) returns [AutomationControlType.Button](automationcontroltype.md). For more info, see [ToggleButtonAutomationPeer](togglebuttonautomationpeer.md).

The peer also has other behaviors that are provided by the base [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md) class. For more info, see "Base implementation in FrameworkElementAutomationPeer" section of [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers).

## -examples

## -see-also
[ToggleButtonAutomationPeer](togglebuttonautomationpeer.md), [IToggleProvider](../microsoft.ui.xaml.automation.provider/itoggleprovider.md), [AppBarToggleButton](../microsoft.ui.xaml.controls/appbartogglebutton.md)
