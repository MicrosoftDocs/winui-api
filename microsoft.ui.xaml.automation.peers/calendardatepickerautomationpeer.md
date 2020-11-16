---
-api-id: T:Microsoft.UI.Xaml.Automation.Peers.CalendarDatePickerAutomationPeer
-api-type: winrt class
---

<!-- Class syntax.
public class CalendarDatePickerAutomationPeer : FrameworkElementAutomationPeer, FrameworkElementAutomationPeer, IInvokeProvider, IValueProvider
-->

# Microsoft.UI.Xaml.Automation.Peers.CalendarDatePickerAutomationPeer

## -description
Exposes [CalendarDatePicker](../microsoft.ui.xaml.controls/calendardatepicker.md) types to Microsoft UI Automation.

## -remarks
The Windows Runtime [CalendarDatePicker](../microsoft.ui.xaml.controls/calendardatepicker.md) class creates a new CalendarDatePickerAutomationPeer as its [OnCreateAutomationPeer](../microsoft.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) definition. Derive your automation peer from CalendarDatePickerAutomationPeer if you are deriving a custom class from [CalendarDatePicker](../microsoft.ui.xaml.controls/calendardatepicker.md) and want to add automation support for additional features that you enabled in your custom class. Then override [OnCreateAutomationPeer](../microsoft.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) so that it returns your custom peer.

### Default peer implementation and overrides in **DatePickerAutomationPeer**

CalendarDatePickerAutomationPeer has overrides of **Core** methods such that the associated [AutomationPeer](automationpeer.md) methods provide peer-specific information to a Microsoft UI Automation client.

+ [GetClassName](automationpeer_getclassname_614238974.md) returns "CalendarDatePicker".
+ [GetAutomationControlType](automationpeer_getautomationcontroltype_1156384152.md) returns [AutomationControlType.Button](automationcontroltype.md).
+ [GetPattern](automationpeer_getpattern_1700082720.md) reports support for [PatternInterface.Invoke](patterninterface.md) ([IInvokeProvider](../microsoft.ui.xaml.automation.provider/iinvokeprovider.md) ). The peer also has other behaviors that are provided by the base [FrameworkElementAutomationPeer](frameworkelementautomationpeer.md) class. For more info, see "Base implementation in FrameworkElementAutomationPeer" section of [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers).

## -see-also
[FrameworkElementAutomationPeer](frameworkelementautomationpeer.md), [CalendarDatePicker](../microsoft.ui.xaml.controls/calendardatepicker.md)

## -examples

