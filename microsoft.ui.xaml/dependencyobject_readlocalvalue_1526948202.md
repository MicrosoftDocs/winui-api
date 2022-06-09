---
-api-id: M:Microsoft.UI.Xaml.DependencyObject.ReadLocalValue(Microsoft.UI.Xaml.DependencyProperty)
-api-type: winrt method
---

<!-- Method syntax
public object ReadLocalValue(Windows.UI.Xaml.DependencyProperty dp)
-->

# Microsoft.UI.Xaml.DependencyObject.ReadLocalValue

## -description
Returns the local value of a dependency property, if a local value is set.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -parameters
### -param dp
The [DependencyProperty](dependencyproperty.md) identifier of the property for which to retrieve the local value.

## -returns
Returns the local value, or returns the sentinel value [UnsetValue](dependencyproperty_unsetvalue.md) if no local value is set.

## -remarks
The local value is not always the effective value. For more info, see [Dependency properties overview](/windows/uwp/xaml-platform/dependency-properties-overview).

## -examples

## -see-also
[Dependency properties overview](/windows/uwp/xaml-platform/dependency-properties-overview)
