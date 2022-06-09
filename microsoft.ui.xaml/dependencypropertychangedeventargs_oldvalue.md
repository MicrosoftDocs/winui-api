---
-api-id: P:Microsoft.UI.Xaml.DependencyPropertyChangedEventArgs.OldValue
-api-type: winrt property
---

<!-- Property syntax
public object OldValue { get; }
-->

# Microsoft.UI.Xaml.DependencyPropertyChangedEventArgs.OldValue

## -description
Gets the value of the dependency property before the reported change.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -property-value
The dependency property value before the change.

## -remarks
The OldValue value is often used as the value that the property is set to from within the callback, in case the [NewValue](dependencypropertychangedeventargs_newvalue.md) value is not considered a valid value for your property's logic . For example, if you are using the callback for validation of an input value for a property that the user can set in UI, the previous value is typically a better value to use as the current value rather than resetting the value to a default. The callback is effectively canceling a change.

## -examples

## -see-also
[Dependency properties overview](/windows/uwp/xaml-platform/dependency-properties-overview)
