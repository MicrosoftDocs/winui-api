---
-api-id: P:Microsoft.UI.Xaml.Automation.AutomationProperties.HelpTextProperty
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.DependencyProperty HelpTextProperty { get; }
-->

# Microsoft.UI.Xaml.Automation.AutomationProperties.HelpTextProperty

## -description
Identifies the [AutomationProperties.HelpText](/windows/winui/api/microsoft.ui.xaml.automation.automationproperties#xaml-attached-properties) attached property, which is a help text string associated with the automation element.

## -property-value
The identifier for the [AutomationProperties.HelpText](/windows/winui/api/microsoft.ui.xaml.automation.automationproperties#xaml-attached-properties) attached property.

## -remarks
The [HelpText](/windows/winui/api/microsoft.ui.xaml.automation.automationproperties#xaml-attached-properties) property is typically obtained from [tooltip](../microsoft.ui.xaml.controls/tooltip.md) text associated with the element. The property can also be supported with placeholder text appearing in edit or list controls. For example, "Type text here for search" is a good candidate the [HelpText](/windows/winui/api/microsoft.ui.xaml.automation.automationproperties#xaml-attached-properties) property for an edit control that places the text prior to the user's actual input. However, it is not adequate for the name property of the edit control.

When [HelpText](/windows/winui/api/microsoft.ui.xaml.automation.automationproperties#xaml-attached-properties) is supported, the string must match the application UI language or the operating system default UI language.

## -examples

## -see-also
