---
-api-id: M:Microsoft.UI.Xaml.Controls.VirtualizingLayoutContext.RecycleElementCore(Windows.UI.Xaml.UIElement)
-api-type: winrt method
---

# Microsoft.UI.Xaml.Controls.VirtualizingLayoutContext.RecycleElementCore(Windows.UI.Xaml.UIElement)

<!--
protected virtual void RecycleElementCore (Windows.UI.Xaml.UIElement element);
-->

## -description

When implemented in a derived class, clears the specified UIElement and allows it to be either re-used or released.

## -parameters

### -param element

The element to clear.

## -remarks

This method provides the behavior when [RecycleElement](virtualizinglayoutcontext_recycleelement_37257770.md) is called.

The base implementation throws a [NotImplementedException](/dotnet/api/system.notimplementedexception?view=dotnet-uwp-10.0&preserve-view=true) ([winrt::hresult_not_implemented](/uwp/cpp-ref-for-winrt/error-handling/hresult-not-implemented)).

## -see-also

## -examples

