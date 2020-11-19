---
-api-id: M:Microsoft.UI.Xaml.Data.BindingOperations.SetBinding(Microsoft.UI.Xaml.DependencyObject,Microsoft.UI.Xaml.DependencyProperty,Microsoft.UI.Xaml.Data.BindingBase)
-api-type: winrt method
---

<!-- Method syntax
public void SetBinding(Windows.UI.Xaml.DependencyObject target, Windows.UI.Xaml.DependencyProperty dp, Windows.UI.Xaml.Data.BindingBase binding)
-->

# Microsoft.UI.Xaml.Data.BindingOperations.SetBinding

## -description
Associates a [Binding](binding.md) with a target property on a target object. This method is the code equivalent to using a [{Binding} markup extension](/windows/uwp/xaml-platform/binding-markup-extension) in XAML markup.

## -parameters
### -param target
The object that should be the target of the evaluated binding.

### -param dp
The property on the target to bind, specified by its identifier. These identifiers are usually available as static read-only properties on the type that defines the *target* object, or one of its base types. You can also bind to attached properties, but see Remarks.

### -param binding
The binding to assign to the target property. This [Binding](binding.md) should be initialized: important [Binding](binding.md) properties such as [Path](binding_path.md) should already be set before passing it as the parameter.

## -remarks
You can bind to custom dependency properties or custom attached properties, the identifier you pass as the *dp* parameter doesn't have to be a Windows Runtime defined property.

BindingOperations.SetBinding is a static utility method, and does basically the same thing as [FrameworkElement.SetBinding](/uwp/api/windows.ui.xaml.frameworkelement.setbinding(windows.ui.xaml.dependencyproperty,windows.ui.xaml.data.bindingbase)). It's more common to use [FrameworkElement.SetBinding](/uwp/api/windows.ui.xaml.frameworkelement.setbinding(windows.ui.xaml.dependencyproperty,windows.ui.xaml.data.bindingbase)) because it's an instance method. One important difference though is that BindingOperations.SetBinding can use a *target* value of any [DependencyObject](../microsoft.ui.xaml/dependencyobject.md), whereas [FrameworkElement.SetBinding](/uwp/api/windows.ui.xaml.frameworkelement.setbinding(windows.ui.xaml.dependencyproperty,windows.ui.xaml.data.bindingbase)) can by definition only be used for a [FrameworkElement](../microsoft.ui.xaml/frameworkelement.md) target. This doesn't usually matter for most Windows Runtime classes used for XAML UI, because these are mostly [FrameworkElement](../microsoft.ui.xaml/frameworkelement.md) subclasses anyways. But the distinction might matter if you are targeting bindings on your own custom classes that derive from [DependencyObject](../microsoft.ui.xaml/dependencyobject.md) or [UIElement](../microsoft.ui.xaml/uielement.md).

<!--Other frameworks provide an expression object as the return value, which can be used to manipulate properties of the binding after it is established but without requiring the binding to be remade. Not clear if anything like that functionality exists.-->

> [!NOTE]
> Calling the SetBinding method and passing in a new [Binding](binding.md) object won't necessarily remove an existing binding. Instead, you should first call the [DependencyObject.ClearValue](/uwp/api/windows.ui.xaml.dependencyobject.clearvalue(windows.ui.xaml.dependencyproperty)) method, then call SetBinding.

### Binding to attached properties

You can put data bindings on any attached properties that a target object supports. Technically an [DependencyObject](../microsoft.ui.xaml/dependencyobject.md) supports all the possible attached properties, but you'd usually only set a binding on an attached property that's relevant to that object or your scenario. For example you would set a binding on [Grid.Row](/windows/winui/api/microsoft.ui.xaml.controls.grid#xaml-attached-properties) only if you anticipate that the target element has a [Grid](../microsoft.ui.xaml.controls/grid.md) parent that will use that info. Specify the *dp* parameter as the dependency property identifier that exists on the attached property's owner class (for the [Grid.Row](/windows/winui/api/microsoft.ui.xaml.controls.grid#xaml-attached-properties) example, that identifier is [Grid.RowProperty](../microsoft.ui.xaml.controls/grid_rowproperty.md)). You won't find that identifier on the target because it's an attached property. For more info on attached properties, see [Attached properties overview](/windows/uwp/xaml-platform/attached-properties-overview).

## -examples

## -see-also
[Binding](binding.md), [XAML data binding sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlBind), [Data binding in depth](/windows/uwp/data-binding/data-binding-in-depth)
