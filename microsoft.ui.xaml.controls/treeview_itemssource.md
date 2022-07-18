---
-api-id: P:Microsoft.UI.Xaml.Controls.TreeView.ItemsSource
-api-type: winrt property
---
<!-- Property syntax.
public object ItemsSource { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.TreeView.ItemsSource


## -description

Gets or sets an object source used to generate the content of the TreeView.


**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -property-value

The object that is used to generate the content of the TreeView. The default is **null**.


## -remarks

The ItemsSource property value must implement one of these interfaces:

| C++ | .NET |
| -- | -- |
| [IIterable](/uwp/api/windows.foundation.collections.iiterable_t_)&lt;[IInspectable](/windows/win32/api/inspectable/nn-inspectable-iinspectable)&gt; | [IEnumerable&lt;Object&gt;](/dotnet/api/system.collections.generic.ienumerable-1?view=dotnet-uwp-10.0&preserve-view=true) |
| [IBindableIterable](/uwp/api/windows.ui.xaml.interop.ibindableiterable) | [IEnumerable](/dotnet/api/system.collections.ienumerable?view=dotnet-uwp-10.0&preserve-view=true) |

The ItemsControl can provide better performance if the ItemsSource property value also implements a random-access list interface:

| C++ | .NET |
| -- | -- |
| [IVector](/uwp/api/windows.foundation.collections.ivector_t_)&lt;[IInspectable](/windows/win32/api/inspectable/nn-inspectable-iinspectable)&gt; | [IList&lt;Object&gt;](/dotnet/api/system.collections.generic.ilist-1?view=dotnet-uwp-10.0&preserve-view=true) |
| [IVectorView](/uwp/api/windows.foundation.collections.ivectorview_t_)&lt;[IInspectable](/windows/win32/api/inspectable/nn-inspectable-iinspectable)&gt; | [IReadOnlyCollection&lt;Object&gt;](/dotnet/api/system.collections.generic.ireadonlylist-1?view=dotnet-uwp-10.0&preserve-view=true) |
| [IBindableVector](/uwp/api/windows.ui.xaml.interop.ibindablevector) | [IList](/dotnet/api/system.collections.ilist?view=dotnet-uwp-10.0&preserve-view=true) |
| [IBindableVectorView](/uwp/api/windows.ui.xaml.interop.ibindablevectorview) | IList |

The ItemsControl can respond to changes if the ItemsSource property value also implements a change notification interface:

| C++ | .NET |
| -- | -- |
| [IObservableVector](/uwp/api/windows.foundation.collections.iobservablevector_t_)&lt;[IInspectable](/windows/win32/api/inspectable/nn-inspectable-iinspectable)&gt; | [INotifyCollectionChanged](/dotnet/api/system.collections.specialized.inotifycollectionchanged?view=dotnet-uwp-10.0&preserve-view=true) |

## -see-also


## -examples


## -xaml-syntax

```xaml
<TreeView ItemsSource="bindingDeclaration"/>
-or-
<TreeView ItemsSource="resourceReferenceToSource"/>
```


## -xaml-values

<dl><dt>bindingDeclaration</dt><dd>bindingDeclarationA Binding declaration using a {Binding ....} markup extension. For more information, see {Binding} markup extension.</dd>
<dt>resourceReferenceToSource</dt><dd>resourceReferenceToSourceA resource reference to an existing iterable/enumerable items source from a resources collection. The resource reference must specify the desired items source by key.</dd>
</dl>


