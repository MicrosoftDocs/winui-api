---
-api-id: M:Microsoft.UI.Xaml.Controls.VirtualizingLayoutContext.GetItemAtCore(System.Int32)
-api-type: winrt method
---

# Microsoft.UI.Xaml.Controls.VirtualizingLayoutContext.GetItemAtCore(System.Int32)

<!--
protected virtual object GetItemAtCore (int index);
-->

## -description

When implemented in a derived class, retrieves the data item in the source found at the specified index.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -parameters

### -param index

The index of the data item to retrieve.

## -returns

The data item at the specified index.

## -remarks

This method provides the behavior when [GetItemAt](virtualizinglayoutcontext_getitemat_1630001961.md) is called.

The base implementation throws a [NotImplementedException](/dotnet/api/system.notimplementedexception?view=dotnet-uwp-10.0&preserve-view=true) ([winrt::hresult_not_implemented](/uwp/cpp-ref-for-winrt/error-handling/hresult-not-implemented)).

## -see-also

## -examples

