---
-api-id: T:Microsoft.UI.Xaml.Automation.Peers.ToggleSwitchAutomationPeer
-api-type: winrt class
---

<!-- Class syntax.
public class ToggleSwitchAutomationPeer : Windows.UI.Xaml.Automation.Peers.FrameworkElementAutomationPeer, Windows.UI.Xaml.Automation.Peers.IToggleSwitchAutomationPeer, Windows.UI.Xaml.Automation.Provider.IToggleProvider
-->

# Microsoft.UI.Xaml.Automation.Peers.ToggleSwitchAutomationPeer

## -description
Exposes [ToggleSwitch](../microsoft.ui.xaml.controls/toggleswitch.md) types to Microsoft UI Automation.

## -remarks
The Windows Runtime  [ToggleSwitch](../microsoft.ui.xaml.controls/toggleswitch.md) class creates a new ToggleSwitchAutomationPeer as its [OnCreateAutomationPeer](../microsoft.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) definition. [ToggleSwitch](../microsoft.ui.xaml.controls/toggleswitch.md) is sealed, so the normal scenario of deriving from the [ToggleSwitch](../microsoft.ui.xaml.controls/toggleswitch.md) class and its existing peer isn't applicable to ToggleSwitchAutomationPeer.

### Default peer implementation and overrides in **ToggleSwitchAutomationPeer**

ToggleSwitchAutomationPeer has overrides of **Core** methods such that the associated [AutomationPeer](automationpeer.md) methods provide peer-specific information to a Microsoft UI Automation client.

+ [GetPattern](automationpeer_getpattern_1700082720.md) reports that the peer provides pattern support for [PatternInterface.Toggle](patterninterface.md) ([IToggleProvider](../microsoft.ui.xaml.automation.provider/itoggleprovider.md)).
+ [GetClassName](automationpeer_getclassname_614238974.md) returns "ToggleSwitch".
+ [GetAutomationControlType](automationpeer_getautomationcontroltype_1156384152.md) returns [AutomationControlType.Button](automationcontroltype.md).
+ [GetLocalizedControlType](automationpeer_getlocalizedcontroltype_677460473.md) returns a localized resource string. This is usually handled in [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md) but ToggleSwitchAutomationPeer has its own implementation.
This peer raises toggle-related automation events on behalf of its owner class.

Although a [ToggleSwitch](../microsoft.ui.xaml.controls/toggleswitch.md) can have text content, there is no [GetName](automationpeer_getname_1386609741.md) implementation that can use a string representation. You should set a value for automation **Name** using the [AutomationProperties](../microsoft.ui.xaml.automation/automationproperties.md) attached properties.

The peer also has other behaviors that are provided by the base [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md) class. For more info, see "Base implementation in FrameworkElementAutomationPeer" section of [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers).

## -examples

## -see-also
[ToggleSwitch](../microsoft.ui.xaml.controls/toggleswitch.md), [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md), [IToggleProvider](../microsoft.ui.xaml.automation.provider/itoggleprovider.md), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers)
