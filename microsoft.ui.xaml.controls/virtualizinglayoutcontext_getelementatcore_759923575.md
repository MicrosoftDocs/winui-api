---
-api-id: M:Microsoft.UI.Xaml.Controls.VirtualizingLayoutContext.GetElementAtCore(System.Int32,Microsoft.UI.Xaml.Controls.ElementRealizationOptions)
-api-type: winrt method
---

## -description

When implemented in a derived class, retrieves a UIElement that represents the data item in the source found at the specified index using the specified options.

## -parameters

### -param index

The index of the data item to retrieve a UIElement for.

### -param options

A value of [ElementRealizationOptions](elementrealizationoptions.md) that specifies whether to suppress automatic recycling of the retrieved element or force creation of a new element.

## -returns

A UIElement that represents the data item.

## -remarks

This method provides the behavior when [GetOrCreateElementAt](/uwp/api/microsoft.ui.xaml.controls.virtualizinglayoutcontext.getorcreateelementat) is called.

The base implementation throws a [NotImplementedException](/dotnet/api/system.notimplementedexception) ([winrt::hresult_not_implemented](/uwp/cpp-ref-for-winrt/error-handling/hresult-not-implemented)).

## -see-also

## -examples

