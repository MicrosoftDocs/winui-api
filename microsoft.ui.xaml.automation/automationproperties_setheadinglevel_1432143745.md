---
-api-id: M:Microsoft.UI.Xaml.Automation.AutomationProperties.SetHeadingLevel(Microsoft.UI.Xaml.DependencyObject,Microsoft.UI.Xaml.Automation.Peers.AutomationHeadingLevel)
-api-type: winrt method
---

<!-- Method syntax.
public void AutomationProperties.SetHeadingLevel(DependencyObject element, AutomationHeadingLevel value)
-->

# Microsoft.UI.Xaml.Automation.AutomationProperties.SetHeadingLevel

## -description
Sets the value of the [AutomationProperties.HeadingLevel](automationproperties_headinglevelproperty.md) property for the specified [DependencyObject](../microsoft.ui.xaml/dependencyobject.md).

## -parameters
### -param element
The specified [DependencyObject](../microsoft.ui.xaml/dependencyobject.md).

### -param value
The value for the heading level.

## -remarks
Heading elements organize the user interface and make it easier to navigate. Some assistive technology (AT) allows users to quickly jump between headings. Headings have a level from 1 to 9.  

![Mouse settings page in Windows Ease of Access settings](images/MouseSettings.png)

Examples of headings would be section titles within the Windows Settings app. For instance, under the **Ease of Access** -> **Mouse** page, **Pointer size**, **Pointer color**, and **Mouse keys** would be a heading of level 1.

## -see-also
[GetHeadingLevel](automationproperties_getheadinglevel_1336379589.md), [Landmarks and Headings](/windows/apps/design/accessibility/landmarks-and-headings)

## -examples

