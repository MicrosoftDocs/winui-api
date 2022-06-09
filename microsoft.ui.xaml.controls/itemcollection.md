---
-api-id: T:Microsoft.UI.Xaml.Controls.ItemCollection
-api-type: winrt class
---

<!-- Class syntax.
public class ItemCollection : Windows.Foundation.Collections.IIterable<System.Object>, Windows.Foundation.Collections.IObservableVector<System.Object>, Windows.Foundation.Collections.IVector<System.Object>
-->

# Microsoft.UI.Xaml.Controls.ItemCollection

## -description
Holds the list of items that represent the content of an [ItemsControl](itemscontrol.md).

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -xaml-syntax
```xaml
<ItemsControl>
  oneOrMoreFrameworkElements
</ItemsControl>
```


## -remarks
<!--Begin NET note for IEnumerable support-->
### Enumerating the collection in C# or Microsoft Visual Basic

An ItemCollection is enumerable, so you can use language-specific syntax such as **foreach** in C# to enumerate the items in the collection. The compiler does the type-casting for you and you won't need to cast to `IEnumerable` explicitly. If you do need to cast explicitly, for example if you want to call [GetEnumerator](/dotnet/api/system.collections.ienumerable.getenumerator?view=dotnet-uwp-10.0&preserve-view=true), cast to [IEnumerable<T>](/dotnet/api/system.collections.generic.ienumerable-1?view=dotnet-uwp-10.0&preserve-view=true)with an [Object](/dotnet/api/system.object?view=dotnet-uwp-10.0&preserve-view=true) or [FrameworkElement](../microsoft.ui.xaml/frameworkelement.md) constraint.


<!--End NET note for IEnumerable support-->

## -examples

## -see-also
[ItemsControl](itemscontrol.md), [IObservableVector&lt;T&gt;](/uwp/api/windows.foundation.collections.iobservablevector`1), [IVector&lt;T&gt;](/uwp/api/windows.foundation.collections.ivector`1), [IIterable<T>](/uwp/api/windows.foundation.collections.iiterable_t_), [IList<T>](/dotnet/api/system.collections.generic.ilist-1?view=dotnet-uwp-10.0&preserve-view=true)
