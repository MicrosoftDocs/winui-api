---
-api-id: M:Microsoft.UI.Xaml.Controls.ItemsRepeater.GetElementIndex(Windows.UI.Xaml.UIElement)
-api-type: winrt method
---

# Microsoft.UI.Xaml.Controls.ItemsRepeater.GetElementIndex(Windows.UI.Xaml.UIElement)

<!--
public int GetElementIndex (Windows.UI.Xaml.UIElement element);
-->

## -description

Retrieves the index of the item from the data source that corresponds to the specified UIElement.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

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
