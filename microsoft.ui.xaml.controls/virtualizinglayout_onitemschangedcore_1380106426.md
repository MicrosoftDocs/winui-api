---
-api-id: M:Microsoft.UI.Xaml.Controls.VirtualizingLayout.OnItemsChangedCore(Microsoft.UI.Xaml.Controls.VirtualizingLayoutContext,System.Object,Microsoft.UI.Xaml.Interop.NotifyCollectionChangedEventArgs)
-api-type: winrt method
---

# Microsoft.UI.Xaml.Controls.VirtualizingLayout.OnItemsChangedCore(Microsoft.UI.Xaml.Controls.VirtualizingLayoutContext,System.Object,Microsoft.UI.Xaml.Interop.NotifyCollectionChangedEventArgs)

<!--
protected virtual void OnItemsChangedCore (Microsoft.UI.Xaml.Controls.VirtualizingLayoutContext context, object source, Microsoft.UI.Xaml.Interop.NotifyCollectionChangedEventArgs args);
-->

## -description

Notifies the layout when the data collection assigned to the container element (ItemsSource) has changed.  

## -parameters

### -param context

The context object that facilitates communication between the layout and its host container.

### -param source

The data source.

### -param args

Data about the collection change.

## -remarks

A layout that chooses to maintain its own record for the bounds of elements in the viewport can use this to update its records as changes occur in the data. This is useful for more complex virtualizing layouts that must measure the content of each item as part of the layout.

## -see-also

## -examples

