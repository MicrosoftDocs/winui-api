---
-api-id: M:Microsoft.UI.Xaml.Controls.VirtualizingLayoutContext.GetOrCreateElementAt(System.Int32,Microsoft.UI.Xaml.Controls.ElementRealizationOptions)
-api-type: winrt method
---

# Microsoft.UI.Xaml.Controls.VirtualizingLayoutContext.GetOrCreateElementAt(System.Int32,Microsoft.UI.Xaml.Controls.ElementRealizationOptions)

<!--
public Windows.UI.Xaml.UIElement GetOrCreateElementAt (int index, Microsoft.UI.Xaml.Controls.ElementRealizationOptions options);
-->

## -description

Retrieves a UIElement that represents the data item in the source found at the specified index using the specified options.

## -parameters

### -param index

The index of the data item to retrieve a UIElement for.

### -param options

A value of [ElementRealizationOptions](elementrealizationoptions.md) that specifies whether to suppress automatic recycling of the retrieved element or force creation of a new element.

## -returns

A UIElement that represents the data item.

## -remarks

This method calls [GetOrCreateElementAtCore(System.Int32,Microsoft.UI.Xaml.Controls.ElementRealizationOptions)](virtualizinglayoutcontext_getorcreateelementatcore_440237553.md), which must be implemented in a derived class.

When you request an element for the specified index, you can optionally specify whether to suppress automatic recycling of the retrieved element or force creation of a new element. Elements retrieved with automatic recycling suppressed (**SuppressAutoRecycle**) are ignored by the automatic recycling logic that clears realized elements that were not retrieved as part of the current layout pass. You must explicitly recycle these elements by passing them to the [RecycleElement](virtualizinglayoutcontext_recycleelement_37257770.md) method to avoid memory leaks.

These options are intended for more advanced layouts that choose to explicitly manage the realization and recycling of elements as a performance optimization.

## -see-also

## -examples

