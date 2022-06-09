---
-api-id: T:Microsoft.UI.Xaml.PropertyChangedCallback
-api-type: winrt delegate
---
<!-- Delegate syntax.
public delegate void PropertyChangedCallback(Windows.UI.Xaml.DependencyObject d, Windows.UI.Xaml.DependencyPropertyChangedEventArgs e)
-->
# Microsoft.UI.Xaml.PropertyChangedCallback

## -description
Represents the callback that is invoked when the effective property value of a dependency property changes.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -parameters
### -param d
The [DependencyObject](dependencyobject.md) on which the property has changed value.

### -param e
Event data that is issued by any event that tracks changes to the effective value of this property.


## -remarks
You implement callbacks based on this delegate to provide the property-changed behavior for a custom dependency property. You might use this callback to provide value constraints, or to initiate value changes in other properties that depend on the value of the property that is being changed. For more info see [Custom dependency properties](/windows/uwp/xaml-platform/custom-dependency-properties).

## -examples

## -see-also
[Register](dependencyproperty_register_928563513.md), [RegisterAttached](dependencyproperty_registerattached_518296660.md), [Custom dependency properties](/windows/uwp/xaml-platform/custom-dependency-properties), [Dependency properties overview](/windows/uwp/xaml-platform/dependency-properties-overview)
