---
-api-id: M:Microsoft.UI.Xaml.Controls.ItemsRepeater.GetElementIndex(Microsoft.UI.Xaml.UIElement)
-api-type: winrt method
---

# Microsoft.UI.Xaml.Controls.ItemsRepeater.GetElementIndex(Microsoft.UI.Xaml.UIElement)

<!--
public int GetElementIndex (Microsoft.UI.Xaml.UIElement element);
-->

## -description

Retrieves the index of the item from the data source that corresponds to the specified UIElement.

## -parameters

### -param element

The element that corresponds to the item to get the index of.

## -returns

The index of the item from the data source that corresponds to the specified UIElement, or -1 if the element is not supported.

## -remarks

Only UIElements that are direct children of the ItemsRepeater are supported. A value of -1 is returned for unsupported elements.

## -see-also

[GetOrCreateElement](itemsrepeater_getorcreateelement_982168620.md), [TryGetElement](itemsrepeater_trygetelement_2086043841.md)

## -examples
