---
-api-id: M:Microsoft.UI.Xaml.FrameworkElement.SetBinding(Microsoft.UI.Xaml.DependencyProperty,Microsoft.UI.Xaml.Data.BindingBase)
-api-type: winrt method
---

<!-- Method syntax
public void SetBinding(Windows.UI.Xaml.DependencyProperty dp, Windows.UI.Xaml.Data.BindingBase binding)
-->

# Microsoft.UI.Xaml.FrameworkElement.SetBinding

## -description
Attaches a binding to a [FrameworkElement](frameworkelement.md), using the provided binding object.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -parameters
### -param dp
The dependency property identifier of the property that is data bound.

### -param binding
The binding to use for the property.

## -remarks
This method is a convenience method that calls [BindingOperations.SetBinding](/uwp/api/windows.ui.xaml.data.bindingoperations.setbinding(windows.ui.xaml.dependencyobject,windows.ui.xaml.dependencyproperty,windows.ui.xaml.data.bindingbase)), passing the current instance as the *target* parameter.

The type of the *binding* parameter is [BindingBase](../microsoft.ui.xaml.data/bindingbase.md) for compatibility reasons, but in the Windows Runtime you always pass a [Binding](../microsoft.ui.xaml.data/binding.md) instance. [Binding](../microsoft.ui.xaml.data/binding.md) is derived from [BindingBase](../microsoft.ui.xaml.data/bindingbase.md).

The *dp* parameter takes a dependency property identifier. For more info on dependency properties and how a [DependencyProperty](dependencyproperty.md) value serves as the identifier, see [Dependency properties overview](/windows/uwp/xaml-platform/dependency-properties-overview).

You can bind to custom dependency properties or custom attached properties, the identifier you pass as the *dp* parameter doesn't have to be a Windows Runtime defined property.

Whether a binding created from code will be able to use an acting data context depends on object lifetime considerations. For example, a [DataContext](frameworkelement_datacontext.md) value that is set from XAML won't be available until the XAML is parsed. In that case you may want to use a [Loaded](frameworkelement_loaded.md) handler to add bindings from code.



> [!NOTE]
> Calling the SetBinding method and passing in a new [Binding](../microsoft.ui.xaml.data/binding.md) object won't necessarily remove an existing binding. Instead, you should first call the [DependencyObject.ClearValue](dependencyobject_clearvalue_171358816.md) method, then call SetBinding.

### Binding to attached properties

You can put data bindings on any attached properties that a target object supports. Technically an [DependencyObject](dependencyobject.md) supports all the possible attached properties, but you'd usually only set a binding on an attached property that's relevant to that object or your scenario. For example you would set a binding on [Grid.Row](/windows/winui/api/microsoft.ui.xaml.controls.grid#xaml-attached-properties) only if you anticipate that the target element has a [Grid](../microsoft.ui.xaml.controls/grid.md) parent that will use that info. Specify the *dp* parameter as the dependency property identifier that exists on the attached property's owner class (for the [Grid.Row](/windows/winui/api/microsoft.ui.xaml.controls.grid#xaml-attached-properties) example, that identifier is [Grid.RowProperty](../microsoft.ui.xaml.controls/grid_rowproperty.md)). You won't find that identifier on the target because it's an attached property. For more info on attached properties, see [Attached properties overview](/windows/uwp/xaml-platform/attached-properties-overview).

## -examples
This example establishes a binding to a dependency property on an object by calling SetBinding.



[!code-csharp[BindingObject](../microsoft.ui.xaml/code/BindingInCode/csharp/Page.xaml.cs#SnippetBindingObject)]

[!code-vb[BindingObject](../microsoft.ui.xaml/code/BindingInCode/vbnet/BlankPage.xaml.vb#SnippetBindingObject)]

## -see-also
[Binding](../microsoft.ui.xaml.data/binding.md), [BindingOperations](../microsoft.ui.xaml.data/bindingoperations.md), [Data binding in depth](/windows/uwp/data-binding/data-binding-in-depth), [Dependency properties overview](/windows/uwp/xaml-platform/dependency-properties-overview)
9e66-f71c-4daa-9994-617c886fda7e)
