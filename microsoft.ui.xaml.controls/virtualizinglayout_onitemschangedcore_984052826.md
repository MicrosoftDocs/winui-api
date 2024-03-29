---
-api-id: M:Microsoft.UI.Xaml.Controls.VirtualizingLayout.OnItemsChangedCore(Microsoft.UI.Xaml.Controls.VirtualizingLayoutContext,System.Object,Windows.UI.Xaml.Interop.NotifyCollectionChangedEventArgs)
-api-type: winrt method
---

# Microsoft.UI.Xaml.Controls.VirtualizingLayout.OnItemsChangedCore(Microsoft.UI.Xaml.Controls.VirtualizingLayoutContext,System.Object,Windows.UI.Xaml.Interop.NotifyCollectionChangedEventArgs)

<!--
protected virtual void OnItemsChangedCore (Microsoft.UI.Xaml.Controls.VirtualizingLayoutContext context, object source, System.Collections.Specialized.NotifyCollectionChangedEventArgs args);
-->

## -description

Notifies the layout when the data collection assigned to the container element (ItemsSource) has changed.  

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

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

