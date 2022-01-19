---
-api-id: M:Microsoft.UI.Xaml.Controls.VirtualizingLayoutContext.GetOrCreateElementAtCore(System.Int32,Microsoft.UI.Xaml.Controls.ElementRealizationOptions)
-api-type: winrt method
---

# Microsoft.UI.Xaml.Controls.VirtualizingLayoutContext.GetOrCreateElementAtCore(System.Int32,Microsoft.UI.Xaml.Controls.ElementRealizationOptions)

<!--
protected virtual Windows.UI.Xaml.UIElement GetOrCreateElementAtCore (int index, Microsoft.UI.Xaml.Controls.ElementRealizationOptions options);
-->

## -description

When implemented in a derived class, retrieves a [UIElement](../microsoft.ui.xaml/uielement.md) that represents the data item in the source found at the specified index using the specified options.

## -parameters

### -param index

The index of the data item to retrieve a [UIElement](../microsoft.ui.xaml/uielement.md) for.

### -param options

Specifies whether to suppress automatic recycling of the retrieved element or force creation of a new element.

## -returns

A [UIElement](../microsoft.ui.xaml/uielement.md) that represents the data item.

## -remarks

This method is called by [GetOrCreateElementAt(System.Int32)](virtualizinglayoutcontext_getorcreateelementat_171326460.md) and [GetOrCreateElementAt(System.Int32,Microsoft.UI.Xaml.Controls.ElementRealizationOptions)](virtualizinglayoutcontext_getorcreateelementat_1708765960.md).

When you request an element for the specified index, you can optionally specify whether to suppress automatic recycling of the retrieved element or force creation of a new element. Elements retrieved with automatic recycling suppressed (**SuppressAutoRecycle**) are ignored by the automatic recycling logic that clears realized elements that were not retrieved as part of the current layout pass. You must explicitly recycle these elements by passing them to the [RecycleElementCore(Microsoft.UI.Xaml.UIElement)](virtualizinglayoutcontext_recycleelementcore_1253021773.md) method to avoid memory leaks.

These options are intended for more advanced layouts that choose to explicitly manage the realization and recycling of elements as a performance optimization.

## -see-also

## -examples
