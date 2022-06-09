---
-api-id: T:Microsoft.UI.Xaml.Automation.Peers.ThumbAutomationPeer
-api-type: winrt class
---

<!-- Class syntax.
public class ThumbAutomationPeer : Windows.UI.Xaml.Automation.Peers.FrameworkElementAutomationPeer, Windows.UI.Xaml.Automation.Peers.IThumbAutomationPeer
-->

# Microsoft.UI.Xaml.Automation.Peers.ThumbAutomationPeer

## -description
Exposes [Thumb](../microsoft.ui.xaml.controls.primitives/thumb.md) types to Microsoft UI Automation.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -remarks
The Windows Runtime  [Thumb](../microsoft.ui.xaml.controls.primitives/thumb.md) class creates a new ThumbAutomationPeer as its [OnCreateAutomationPeer](../microsoft.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) definition. [Thumb](../microsoft.ui.xaml.controls.primitives/thumb.md) is sealed, so the normal scenario of deriving from the [Thumb](../microsoft.ui.xaml.controls.primitives/thumb.md) class and its existing peer isn't applicable to ThumbAutomationPeer.

### Default peer implementation and overrides in **ThumbAutomationPeer**

ThumbAutomationPeer has overrides of **Core** methods such that the associated [AutomationPeer](automationpeer.md) methods provide peer-specific information to a Microsoft UI Automation client.

+ [GetPattern](automationpeer_getpattern_1700082720.md) reports no pattern support.
+ [GetClassName](automationpeer_getclassname_614238974.md) returns "Thumb".
+ [GetAutomationControlType](automationpeer_getautomationcontroltype_1156384152.md) returns [AutomationControlType.Thumb](automationcontroltype.md).
+ [IsControlElement](automationpeer_iscontrolelement_1004644794.md) returns a value based on the template parent. If there is a template parent then it returns **true**, otherwise the value is **false**.
The peer also has other behaviors that are provided by the base [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md) class. For more info, see "Base implementation in FrameworkElementAutomationPeer" section of [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers).

## -examples

## -see-also
[Thumb](../microsoft.ui.xaml.controls.primitives/thumb.md), [Slider](../microsoft.ui.xaml.controls/slider.md), [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers)
