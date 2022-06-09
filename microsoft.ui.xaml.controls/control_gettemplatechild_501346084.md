---
-api-id: M:Microsoft.UI.Xaml.Controls.Control.GetTemplateChild(System.String)
-api-type: winrt method
---

<!-- Method syntax
protected Windows.UI.Xaml.DependencyObject GetTemplateChild(System.String childName)
-->

# Microsoft.UI.Xaml.Controls.Control.GetTemplateChild

## -description
Retrieves the named element in the instantiated [ControlTemplate](controltemplate.md) visual tree.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -parameters
### -param childName
The name of the element to find.

## -returns
The named element from the template, if the element is found. Can return null if no element with name *childName* was found in the template.

## -remarks
You call GetTemplateChild to get references to objects in a controls [Template](control_template.md) after it's instantiated. The [ControlTemplate](controltemplate.md) is instantiated in the [OnApplyTemplate](../microsoft.ui.xaml/frameworkelement_onapplytemplate_1955470198.md) method. You can use the GetTemplateChild method inside your [OnApplyTemplate](../microsoft.ui.xaml/frameworkelement_onapplytemplate_1955470198.md) override and keep a reference to the objects you need.

## -examples

## -see-also
[OnApplyTemplate](../microsoft.ui.xaml/frameworkelement_onapplytemplate_1955470198.md)
