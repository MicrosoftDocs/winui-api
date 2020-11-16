---
-api-id: T:Microsoft.UI.Xaml.Data.BindingMode
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Xaml.Data.BindingMode : int
-->

# BindingMode

## -description
Describes how the data propagates in a binding.

## -xaml-syntax
```xaml
<object property="enumMemberName"/>
```


## -enum-fields
### -field OneWay:1
Updates the target property when the binding is created. Changes to the source object can also propagate to the target.

### -field OneTime:2
Updates the target property when the binding is created.

### -field TwoWay:3
Updates either the target or the source object when either changes. When the binding is created, the target property is updated from the source.


## -remarks
For **OneWay** and **TwoWay** bindings, dynamic changes to the source don't automatically propagate to the target. You must implement the [INotifyPropertyChanged](inotifypropertychanged.md) interface on the source object for this to happen.

For **TwoWay** bindings, changes to the target automatically propagate to the source, except if the binding target is the [Text](../microsoft.ui.xaml.controls/textbox_text.md) property. In that case, the update happens only when the [TextBox](../microsoft.ui.xaml.controls/textbox.md) loses focus.

For **OneTime** and **OneWay** bindings, calls to [DependencyObject.SetValue](/uwp/api/windows.ui.xaml.dependencyobject.setvalue(windows.ui.xaml.dependencyproperty,system.object)) automatically change the target value and delete the binding.

## -examples
This example demonstrates how to set the binding mode in XAML.



[!code-xaml[BindingMode](../microsoft.ui.xaml.controls.primitives/code/Binding_Simple/csharp/Page.xaml#SnippetBindingMode)]

## -see-also
[Binding](binding.md), [Binding.Mode](binding_mode.md), [XAML data binding sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlBind), [Data binding in depth](/windows/uwp/data-binding/data-binding-in-depth)
