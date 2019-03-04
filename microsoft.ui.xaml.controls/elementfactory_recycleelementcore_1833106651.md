---
-api-id: M:Microsoft.UI.Xaml.Controls.ElementFactory.RecycleElementCore(Microsoft.UI.Xaml.Controls.ElementFactoryRecycleArgs)
-api-type: winrt method
---

## -description

When implemented in a derived class, clears a UIElement to be re-used to display a new data item.

## -parameters

### -param args

The element to recycle, and the parent element.

## -remarks

Override this method in a derived class to provide the behavior when [RecycleElement](elementfactory_recycleelement_1565526931.md) is called.

The base implementation throws a [NotImplementedException](/dotnet/api/system.notimplementedexception) ([winrt::hresult_not_implemented](/uwp/cpp-ref-for-winrt/error-handling/hresult-not-implemented)).

## -see-also

## -examples

