---
-api-id: M:Microsoft.UI.Xaml.Controls.ElementFactory.GetElementCore(Microsoft.UI.Xaml.Controls.ElementFactoryGetArgs)
-api-type: winrt method
---

# Microsoft.UI.Xaml.Controls.ElementFactory.GetElementCore(Microsoft.UI.Xaml.Controls.ElementFactoryGetArgs)

<!--
protected virtual Windows.UI.Xaml.UIElement GetElementCore (Microsoft.UI.Xaml.Controls.ElementFactoryGetArgs args);
-->

## -description

When implemented in a derived class, prepares a UIElement to display data.

## -parameters

### -param args

The data to display, and the parent element.

## -returns

A UIElement prepared to display the data specified in the _args_.

## -remarks

Override this method in a derived class to provide the behavior when [GetElement](elementfactory_getelement_845667019.md) is called.

The base implementation throws a [NotImplementedException](/dotnet/api/system.notimplementedexception) ([winrt::hresult_not_implemented](/uwp/cpp-ref-for-winrt/error-handling/hresult-not-implemented)).

## -see-also

## -examples

