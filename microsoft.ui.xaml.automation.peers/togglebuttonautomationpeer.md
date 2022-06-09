---
-api-id: T:Microsoft.UI.Xaml.Automation.Peers.ToggleButtonAutomationPeer
-api-type: winrt class
---

<!-- Class syntax.
public class ToggleButtonAutomationPeer : Windows.UI.Xaml.Automation.Peers.ButtonBaseAutomationPeer, Windows.UI.Xaml.Automation.Peers.IToggleButtonAutomationPeer, Windows.UI.Xaml.Automation.Provider.IToggleProvider
-->

# Microsoft.UI.Xaml.Automation.Peers.ToggleButtonAutomationPeer

## -description
Exposes [ToggleButton](../microsoft.ui.xaml.controls.primitives/togglebutton.md) types to Microsoft UI Automation.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -remarks
The Windows Runtime  [ToggleButton](../microsoft.ui.xaml.controls.primitives/togglebutton.md) class creates a new ToggleButtonAutomationPeer as its [OnCreateAutomationPeer](../microsoft.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) definition.

[ToggleButton](../microsoft.ui.xaml.controls.primitives/togglebutton.md) has several derived classes such as [RadioButton](../microsoft.ui.xaml.controls/radiobutton.md), which have template support and practical implementations of some important functionality. Make sure that you really want to derive from the base class. If you're sure you want to derive from [ToggleButton](../microsoft.ui.xaml.controls.primitives/togglebutton.md), directly, derive your automation peer from ToggleButtonAutomationPeer and override [OnCreateAutomationPeer](../microsoft.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) so that it returns your custom peer.

### Default peer implementation and overrides in **ToggleButtonAutomationPeer**

ToggleButtonAutomationPeer has overrides of **Core** methods such that the associated [AutomationPeer](automationpeer.md) methods provide peer-specific information to a Microsoft UI Automation client.

+ [GetPattern](automationpeer_getpattern_1700082720.md) reports that the peer provides pattern support for [PatternInterface.Toggle](patterninterface.md) ([IToggleProvider](../microsoft.ui.xaml.automation.provider/itoggleprovider.md)).
+ [GetClassName](automationpeer_getclassname_614238974.md) returns "ToggleButton".
+ [GetAutomationControlType](automationpeer_getautomationcontroltype_1156384152.md) returns [AutomationControlType.Button](automationcontroltype.md).
This peer raises toggle-related automation events on behalf of its owner class.

This peer has the base class [ButtonBaseAutomationPeer](buttonbaseautomationpeer.md) and inherits behavior other than the overrides indicated above. Notably, [GetName](automationpeer_getname_1386609741.md) returns a string value based on examining the current **Content**. For more info, see [ButtonBaseAutomationPeer](buttonbaseautomationpeer.md).

The peer also has other behaviors that are provided by the base [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md) class. For more info, see "Base implementation in FrameworkElementAutomationPeer" section of [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers).

### **ToggleButtonAutomationPeer** derived classes

ToggleButtonAutomationPeer is the parent class for several immediately derived classes that implement peer support for Windows Runtime controls. Here is the list of classes that directly derive from ToggleButtonAutomationPeer:

+ [AppBarToggleButtonAutomationPeer](appbartogglebuttonautomationpeer.md)
+ [CheckBoxAutomationPeer](checkboxautomationpeer.md)
+ [RadioButtonAutomationPeer](radiobuttonautomationpeer.md)


## -examples

## -see-also
[ToggleButton](../microsoft.ui.xaml.controls.primitives/togglebutton.md), [ButtonBaseAutomationPeer](buttonbaseautomationpeer.md), [IToggleProvider](../microsoft.ui.xaml.automation.provider/itoggleprovider.md), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers)
