---
-api-id: P:Microsoft.UI.Xaml.Controls.RelativePanel.AboveProperty
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.DependencyProperty AboveProperty { get; }
-->

# Microsoft.UI.Xaml.Controls.RelativePanel.AboveProperty

## -description
Identifies the [RelativePanel.Above](/windows/winui/api/microsoft.ui.xaml.controls.relativepanel#xaml-attached-properties) XAML attached property.

## -property-value
The identifier for the [RelativePanel.Above](/windows/winui/api/microsoft.ui.xaml.controls.relativepanel#xaml-attached-properties) XAML attached property.

## -remarks
This property is only an identifier for the property system, and isn't used in most app scenarios. In most cases you set the [RelativePanel.Above](/windows/winui/api/microsoft.ui.xaml.controls.relativepanel#xaml-attached-properties) XAML attached property in XAML and won't need this identifier.

To access the [RelativePanel.Above](/windows/winui/api/microsoft.ui.xaml.controls.relativepanel#xaml-attached-properties) attached property in code, you can use the dependency property system, calling either [GetValue](/uwp/api/windows.ui.xaml.dependencyobject.getvalue(windows.ui.xaml.dependencyproperty)) or [SetValue](/uwp/api/windows.ui.xaml.dependencyobject.setvalue(windows.ui.xaml.dependencyproperty,system.object)) and passing RelativePanel.AboveProperty as the dependency property identifier. Another way to get or set the value in code is to use [GetAbove](relativepanel_getabove_215982182.md) and [SetAbove](relativepanel_setabove_1227504112.md).

## -examples
```csharp

// To remove a value, pass null.
Button1.SetValue(RelativePanel.AboveProperty, null);

// To set a value. (Sets Button1 above Button2.)
Button1.SetValue(RelativePanel.AboveProperty, Button2); 

// To get a value. (elementName == "Button2" when set as shown previously.)
string elementName = (string)Button1.GetValue(RelativePanel.AboveProperty);
```



## -see-also
[RelativePanel.Above](/windows/winui/api/microsoft.ui.xaml.controls.relativepanel#xaml-attached-properties), [Attached properties overview](/windows/uwp/xaml-platform/attached-properties-overview)
