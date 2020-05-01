---
-api-id: M:Microsoft.UI.Xaml.Controls.ItemsRepeater.GetOrCreateElement(System.Int32)
-api-type: winrt method
---

# Microsoft.UI.Xaml.Controls.ItemsRepeater.GetOrCreateElement(System.Int32)

<!--
public Windows.UI.Xaml.UIElement GetOrCreateElement (int index);
-->

## -description

Retrieves the UIElement that corresponds to the item at the specified index in the data source.

## -parameters

### -param index

The index of the item.

## -returns

A UIElement that corresponds to the item at the specified index. If the item is not realized, a new UIElement is created.

## -remarks

This method does two things:

1. Gets a UIElement that corresponds to the item in the data source at the specified _index_. If necessary, this method causes a virtualized item to be realized and creates a new UIElement for it.
1. Queues that element on the next layout pass as the suggested anchor for the layout to use as a starting point.

## -see-also

[GetElementIndex](itemsrepeater_getelementindex_553435906.md), [TryGetElement](itemsrepeater_trygetelement_2086043841.md)

## -examples

