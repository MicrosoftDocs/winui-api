---
-api-id: M:Microsoft.UI.Xaml.DependencyObject.UnregisterPropertyChangedCallback(Microsoft.UI.Xaml.DependencyProperty,System.Int64)
-api-type: winrt method
---

<!-- Method syntax
public void UnregisterPropertyChangedCallback(Windows.UI.Xaml.DependencyProperty dp, System.Int64 token)
-->

# Microsoft.UI.Xaml.DependencyObject.UnregisterPropertyChangedCallback

## -description
Cancels a change notification that was previously registered by calling [RegisterPropertyChangedCallback](dependencyobject_registerpropertychangedcallback_2003721961.md).

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -parameters
### -param dp
The dependency property identifier of the property to unregister for property-changed notification.

### -param token
A token that represents the callback (returned by [RegisterPropertyChangedCallback](dependencyobject_registerpropertychangedcallback_2003721961.md)).

## -remarks

## -examples

## -see-also
[RegisterPropertyChangedCallback](dependencyobject_registerpropertychangedcallback_2003721961.md), [DependencyPropertyChangedCallback](dependencypropertychangedcallback.md)
