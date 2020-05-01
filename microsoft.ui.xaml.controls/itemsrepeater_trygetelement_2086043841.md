---
-api-id: M:Microsoft.UI.Xaml.Controls.ItemsRepeater.TryGetElement(System.Int32)
-api-type: winrt method
---

# Microsoft.UI.Xaml.Controls.ItemsRepeater.TryGetElement(System.Int32)

<!--
public Windows.UI.Xaml.UIElement TryGetElement (int index);
-->

## -description

Retrieves the realized UIElement that corresponds to the item at the specified index in the data source.

## -parameters

### -param index

The index of the item.

## -returns

The UIElement that corresponds to the item at the specified index if the item is realized, or **null** if the item is not realized.

## -remarks

An item is _realized_ when a UIElement has been prepared to display it. Requesting the element for an item that is not realized does not cause it to be realized; instead it is reported as **null**.

## -see-also

[GetOrCreateElement](itemsrepeater_getorcreateelement_982168620.md), [GetElementIndex](itemsrepeater_getelementindex_553435906.md)

## -examples

