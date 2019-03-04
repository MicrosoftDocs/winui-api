---
-api-id: T:Microsoft.UI.Xaml.Controls.ItemsSourceView
-api-type: winrt class
---

## -description

Represents a standardized view of the supported interactions between a given ItemsSource object and an ItemsRepeater control.

## -remarks

Components written to work with [ItemsRepeater](itemsrepeater.md) should consume the [ItemsSource](itemsrepeater_itemssource.md) via ItemsSourceView since this provides a normalized view of the ItemsSource. That way, each component does not need to know if the source is an [IEnumerable](/dotnet/api/system.collections.generic.ienumerable-1), an [IVector](/uwp/api/windows.foundation.collections.ivector_t_), or something else.

## -see-also

[ItemsRepeater.ItemsSourceView](itemsrepeater_itemssourceview.md)

## -examples

