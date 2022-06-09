---
-api-id: T:Microsoft.UI.Xaml.Automation.Peers.RangeBaseAutomationPeer
-api-type: winrt class
---

<!-- Class syntax.
public class RangeBaseAutomationPeer : Windows.UI.Xaml.Automation.Peers.FrameworkElementAutomationPeer, Windows.UI.Xaml.Automation.Peers.IRangeBaseAutomationPeer, Windows.UI.Xaml.Automation.Provider.IRangeValueProvider
-->

# Microsoft.UI.Xaml.Automation.Peers.RangeBaseAutomationPeer

## -description
A base class that provides a Microsoft UI Automation peer implementation for types that derive from [RangeBase](../microsoft.ui.xaml.controls.primitives/rangebase.md).

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -remarks
The Windows Runtime  [RangeBase](../microsoft.ui.xaml.controls.primitives/rangebase.md) class creates a new RangeBaseAutomationPeer as its [OnCreateAutomationPeer](../microsoft.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) definition. Derive your automation peer from RangeBaseAutomationPeer if you are deriving a custom class from [RangeBase](../microsoft.ui.xaml.controls.primitives/rangebase.md) and want to add automation support for additional features that you enabled in your custom class. Then override [OnCreateAutomationPeer](../microsoft.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) so that it returns your custom peer.

> [!NOTE]
> Base classes for XAML UI don't typically have an [OnCreateAutomationPeer](../microsoft.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) implementation but [RangeBase](../microsoft.ui.xaml.controls.primitives/rangebase.md) does. However, the peer it creates is missing some information. Therefore you should still follow the pattern of defining a new peer based on RangeBaseAutomationPeer and creating an instance of it in [OnCreateAutomationPeer](../microsoft.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) for a custom control that's based on [RangeBase](../microsoft.ui.xaml.controls.primitives/rangebase.md).

### Default peer implementation and overrides in **RangeBaseAutomationPeer**

RangeBaseAutomationPeer has overrides of **Core** methods such that the associated [AutomationPeer](automationpeer.md) methods provide peer-specific information to a Microsoft UI Automation client.

+ [GetPattern](automationpeer_getpattern_1700082720.md) reports pattern support for [PatternInterface.RangeValue](patterninterface.md) ([IRangeValueProvider](../microsoft.ui.xaml.automation.provider/irangevalueprovider.md)).
+ [GetClassName](automationpeer_getclassname_614238974.md) and [GetAutomationControlType](automationpeer_getautomationcontroltype_1156384152.md) don't have implementations. It's expected that you will implement these. A typical [GetAutomationControlTypeCore](automationpeer_getautomationcontroltypecore_1718556232.md) implementation would return [AutomationControlType.ProgressBar](automationcontroltype.md), [AutomationControlType.ScrollBar](automationcontroltype.md) or [AutomationControlType.Slider](automationcontroltype.md).
The peer also has other behaviors that are provided by the base [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md) class. For more info, see "Base implementation in FrameworkElementAutomationPeer" section of [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers).

### **RangeBaseAutomationPeer** derived classes

RangeBaseAutomationPeer is the parent class for these classes:
+ [ProgressBarAutomationPeer](progressbarautomationpeer.md)
+ [ScrollBarAutomationPeer](scrollbarautomationpeer.md)
+ [SliderAutomationPeer](sliderautomationpeer.md)


## -examples

## -see-also
[RangeBase](../microsoft.ui.xaml.controls.primitives/rangebase.md), [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md), [IRangeValueProvider](../microsoft.ui.xaml.automation.provider/irangevalueprovider.md), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers)
