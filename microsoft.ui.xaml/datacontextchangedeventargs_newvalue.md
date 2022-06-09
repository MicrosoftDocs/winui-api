---
-api-id: P:Microsoft.UI.Xaml.DataContextChangedEventArgs.NewValue
-api-type: winrt property
---

<!-- Property syntax
public object NewValue { get; }
-->

# Microsoft.UI.Xaml.DataContextChangedEventArgs.NewValue

## -description
Gets the new [DataContext](frameworkelement_datacontext.md) value for the element where the [DataContextChanged](frameworkelement_datacontextchanged.md) event fired.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -property-value
An object representing the new [DataContext](frameworkelement_datacontext.md) value for the element where the [DataContextChanged](frameworkelement_datacontextchanged.md) event fired.

## -remarks
The NewValue value is only guaranteed to have a correct value during the invocation of your handler. You can't save the [DataContextChangedEventArgs](datacontextchangedeventargs.md) object and expect to be able to use the NewValue property on it in a meaningful way outside of the scope of a handler.

## -examples

## -see-also
