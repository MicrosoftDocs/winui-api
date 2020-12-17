---
-api-id: T:Microsoft.UI.Xaml.Data.ICollectionView
-api-type: winrt interface
---

<!-- Interface syntax.
public interface ICollectionView : Windows.Foundation.Collections.IIterable<System.Object>, Windows.Foundation.Collections.IObservableVector<System.Object>, Windows.Foundation.Collections.IVector<System.Object>
-->

# Microsoft.UI.Xaml.Data.ICollectionView

## -description
Enables collections to support current record management, grouping, and incremental loading (data virtualization).

## -remarks
ICollectionView is an interface used to represent a collection. It serves to maintain currency for properties like item selection.

To implement custom behavior for selection currency in your data source, your data source should implement [ICollectionViewFactory](icollectionviewfactory.md) instead of implementing ICollectionView directly. You can set the [CollectionViewSource.Source](collectionviewsource_source.md) property to an [ICollectionViewFactory](icollectionviewfactory.md), but if you set it to an ICollectionView, it will throw an exception.

The [CollectionGroups](icollectionview_collectiongroups.md) property is of type [IObservableVector<object>](/uwp/api/windows.foundation.collections.iobservablevector`1), but these objects should implement [ICollectionViewGroup](icollectionviewgroup.md).

### Interface inheritance

ICollectionView inherits [IObservableVector](/uwp/api/windows.foundation.collections.iobservablevector`1), [IVector](/uwp/api/windows.foundation.collections.ivector`1) and [IIterable](/uwp/api/windows.foundation.collections.iiterable`1) . Types that implement ICollectionView also implement the interface members of [IObservableVector](/uwp/api/windows.foundation.collections.iobservablevector`1), and either [IVector](/uwp/api/windows.foundation.collections.ivector`1) and [IIterable](/uwp/api/windows.foundation.collections.iiterable`1) for C++ usage or [IList](/dotnet/api/system.collections.generic.ilist-1?view=dotnet-uwp-10.0&preserve-view=true) and [IEnumerable](/dotnet/api/system.collections.generic.ienumerable-1?view=dotnet-uwp-10.0&preserve-view=true) for Microsoft .NET usage.

## -examples

## -see-also
[IObservableVector&lt;T&gt;](/uwp/api/windows.foundation.collections.iobservablevector`1), [IVector&lt;T&gt;](/uwp/api/windows.foundation.collections.ivector`1), [IIterable&lt;T&gt;](/uwp/api/windows.foundation.collections.iiterable`1), [CollectionViewSource](collectionviewsource.md), [Binding](binding.md), [XAML data binding sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlBind), [Data binding in depth](/windows/uwp/data-binding/data-binding-in-depth)
