---
-api-id: T:Microsoft.UI.Xaml.FrameworkTemplate
-api-type: winrt class
---

<!-- Class syntax.
public class FrameworkTemplate : Windows.UI.Xaml.DependencyObject, Windows.UI.Xaml.IFrameworkTemplate
-->

# Microsoft.UI.Xaml.FrameworkTemplate

## -description
Creates an element tree of elements. FrameworkTemplate is a base class for classes that have specific templating behavior, including [ControlTemplate](../microsoft.ui.xaml.controls/controltemplate.md) and [DataTemplate](datatemplate.md).

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -remarks
FrameworkTemplate has a [ContentPropertyAttribute](../microsoft.ui.xaml.markup/contentpropertyattribute.md) that indicates that its XAML content property is named "Template". FrameworkTemplate doesn't define a property of that name, nor do its derived types that have a practical usage ([ControlTemplate](../microsoft.ui.xaml.controls/controltemplate.md), [DataTemplate](datatemplate.md)). The content of a FrameworkTemplate is a root element that should be created when the template is applied to the object being templated, and isn't a conventional property in the object model. Content of a FrameworkTemplate is handled specially by the XAML parser when content is created from a template.

For more info on how to use templates, see [ControlTemplate](../microsoft.ui.xaml.controls/controltemplate.md) and [Quickstart: Control templates](/previous-versions/windows/apps/hh465374(v=win.10)).

### **FrameworkTemplate** derived classes

FrameworkTemplate is the parent class for several immediately derived classes that each define specific templating behavior. Here are some of the notable derived classes:

+ [ControlTemplate](../microsoft.ui.xaml.controls/controltemplate.md): this is used as the value of the [Control.Template](../microsoft.ui.xaml.controls/control_template.md) property, which defines the visuals of a control by applying the template. You almost always define a [ControlTemplate](../microsoft.ui.xaml.controls/controltemplate.md) as a XAML resource, using an implicit key [TargetType](style_targettype.md) that is the same as a [Style](style.md) that sets [Control.Template](../microsoft.ui.xaml.controls/control_template.md) with a [Setter](setter.md). You rarely if ever assign a value for [Control.Template](../microsoft.ui.xaml.controls/control_template.md) directly on a control instance.
+ [DataTemplate](datatemplate.md): specifies the visual representation of your data when it's supplying items for an items control, such as a [ListView](../microsoft.ui.xaml.controls/listview.md) or [GridView](../microsoft.ui.xaml.controls/gridview.md). A [DataTemplate](datatemplate.md) sets the [ItemTemplate](../microsoft.ui.xaml.controls/itemscontrol_itemtemplate.md) property for an items control. [DataTemplate](datatemplate.md) is also used for [ContentControl.ContentTemplate](../microsoft.ui.xaml.controls/contentcontrol_contenttemplate.md) and other control-specific data templating properties, such as various **Header**, **HeaderTemplate**, **ContentTemplate** and **ItemTemplate** properties on multiple classes.
+ [ItemsPanelTemplate](../microsoft.ui.xaml.controls/itemspaneltemplate.md): supports an alternative technique for representing data in the visuals of a control, by defining a layout container as well as parts within that container that present the data. [ItemsPanelTemplate](../microsoft.ui.xaml.controls/itemspaneltemplate.md) is used as the value of [ItemsControl.ItemsPanel](../microsoft.ui.xaml.controls/itemscontrol_itemspanel.md) for items controls.
<!--Others?-->


## -examples

## -see-also
[DependencyObject](dependencyobject.md), [Control.Template](../microsoft.ui.xaml.controls/control_template.md), [ControlTemplate](../microsoft.ui.xaml.controls/controltemplate.md), [DataTemplate](datatemplate.md), [ItemsPanelTemplate](../microsoft.ui.xaml.controls/itemspaneltemplate.md), [Quickstart: Control templates](/previous-versions/windows/apps/hh465374(v=win.10))
