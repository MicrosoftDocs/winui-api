---
-api-id: T:Microsoft.UI.Xaml.Automation.Peers.SliderAutomationPeer
-api-type: winrt class
---

<!-- Class syntax.
public class SliderAutomationPeer : Windows.UI.Xaml.Automation.Peers.RangeBaseAutomationPeer, Windows.UI.Xaml.Automation.Peers.ISliderAutomationPeer
-->

# Microsoft.UI.Xaml.Automation.Peers.SliderAutomationPeer

## -description
Exposes [Slider](../microsoft.ui.xaml.controls/slider.md) types to Microsoft UI Automation.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -remarks
The Windows Runtime  [Slider](../microsoft.ui.xaml.controls/slider.md) class creates a new SliderAutomationPeer as its [OnCreateAutomationPeer](../microsoft.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) definition. Derive your automation peer from SliderAutomationPeer if you are deriving a custom class from [Slider](../microsoft.ui.xaml.controls/slider.md) and want to add automation support for additional features that you enabled in your custom class. Then override [OnCreateAutomationPeer](../microsoft.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) so that it returns your custom peer.

### Default peer implementation and overrides in **SliderAutomationPeer**

SliderAutomationPeer has overrides of **Core** methods such that the associated [AutomationPeer](automationpeer.md) methods provide peer-specific information to a Microsoft UI Automation client.

+ [GetPattern](automationpeer_getpattern_1700082720.md) defers to base peers. [GetPattern](automationpeer_getpattern_1700082720.md) returns a pattern for [IRangeValueProvider](../microsoft.ui.xaml.automation.provider/irangevalueprovider.md) though the base [RangeBaseAutomationPeer](rangebaseautomationpeer.md).
+ [GetClassName](automationpeer_getclassname_614238974.md) returns "Slider".
+ [GetAutomationControlType](automationpeer_getautomationcontroltype_1156384152.md) returns [AutomationControlType.Slider](automationcontroltype.md).
+  [GetClickablePoint](automationpeer_getclickablepoint_955785073.md) returns a "not a number"  [Point](/uwp/api/windows.foundation.point) value that indicates that there isn't just one such point; clicking at various points along the range has different results.
+ [GetOrientation](automationpeer_getorientation_419829207.md) reports a value that parallels the [Orientation](../microsoft.ui.xaml.controls/slider_orientation.md) of the [Slider](../microsoft.ui.xaml.controls/slider.md) owner.
The peer also has other behaviors that are provided by the base [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md) class. For more info, see "Base implementation in FrameworkElementAutomationPeer" section of [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers).

## -examples

## -see-also
[Slider](../microsoft.ui.xaml.controls/slider.md), [RangeBaseAutomationPeer](rangebaseautomationpeer.md), [IRangeValueProvider](../microsoft.ui.xaml.automation.provider/irangevalueprovider.md), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers)
