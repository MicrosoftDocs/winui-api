---
-api-id: P:Microsoft.UI.Xaml.Automation.AutomationProperties.AcceleratorKeyProperty
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.DependencyProperty AcceleratorKeyProperty { get; }
-->

# Microsoft.UI.Xaml.Automation.AutomationProperties.AcceleratorKeyProperty

## -description
Identifies the [AutomationProperties.AcceleratorKey](/windows/winui/api/microsoft.ui.xaml.automation.automationproperties#xaml-attached-properties) attached property, which is a string containing the accelerator key (also called shortcut key) combinations for the automation element.

## -property-value
The identifier for the [AutomationProperties.AcceleratorKey](/windows/winui/api/microsoft.ui.xaml.automation.automationproperties#xaml-attached-properties) attached property.

## -remarks
Shortcut key combinations invoke an action. For example, CTRL+O is often used to invoke the Open file common dialog box. An automation element that has the [AcceleratorKey](/windows/winui/api/microsoft.ui.xaml.automation.automationproperties#xaml-attached-properties) property can implement the [Invoke](/previous-versions/windows/desktop/api/oaidl/nf-oaidl-idispatch-invoke) control pattern for the action that is equivalent to the shortcut command.

## -examples

## -see-also
