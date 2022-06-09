---
-api-id: T:Microsoft.UI.Xaml.PropertyPath
-api-type: winrt class
---

<!-- Class syntax.
public class PropertyPath : Windows.UI.Xaml.DependencyObject, Windows.UI.Xaml.IPropertyPath
-->

# Microsoft.UI.Xaml.PropertyPath

## -description
Implements a data structure for describing a property as a path below another property, or below an owning type. Property paths are used in data binding to objects.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -remarks
The main reason you might work with a PropertyPath object is to clone existing binding properties and use them somewhere else:
+ Get the [Path](propertypath_path_1221375020.md) from an existing binding ([Binding.Path](../microsoft.ui.xaml.data/binding_path.md)).
+ Use that string value to construct a new PropertyPath.
+ Create a new [Binding](../microsoft.ui.xaml.data/binding.md). Use the new PropertyPath for its [Binding.Path](../microsoft.ui.xaml.data/binding_path.md) (and probably adjust some other properties too).
+ Apply the new [Binding](../microsoft.ui.xaml.data/binding.md) to a different object-property combination, using [SetBinding](frameworkelement_setbinding_632680108.md).


Animation targeting also uses a property path concept, as documented in the [Property-path syntax](/windows/uwp/xaml-platform/property-path-syntax) topic. However, animation targeting doesn't use PropertyPath as the underlying type, it expresses the paths as strings and uses strings for all related API calls.

## -examples

## -see-also
[DependencyObject](dependencyobject.md), [Property-path syntax](/windows/uwp/xaml-platform/property-path-syntax), [{Binding} markup extension](/windows/uwp/xaml-platform/binding-markup-extension)
