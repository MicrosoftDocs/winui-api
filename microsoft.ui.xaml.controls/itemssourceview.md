---
-api-id: T:Microsoft.UI.Xaml.Controls.ItemsSourceView
-api-type: winrt class
---

# Microsoft.UI.Xaml.Controls.ItemsSourceView

<!--
public class ItemsSourceView : System.Collections.Specialized.INotifyCollectionChanged
-->

## -description

Represents a standardized view of the supported interactions between a given ItemsSource object and an ItemsRepeater control.

## -remarks

Components written to work with [ItemsRepeater](itemsrepeater.md) should consume the [ItemsSource](itemsrepeater_itemssource.md) via ItemsSourceView since this provides a normalized view of the ItemsSource. That way, each component does not need to know if the source is an [IEnumerable](/dotnet/api/system.collections.generic.ienumerable-1), an [IVector](/uwp/api/windows.foundation.collections.ivector_t_), or something else.

## -see-also

[ItemsRepeater.ItemsSourceView](itemsrepeater_itemssourceview.md)

## -examples

See the **XAML Controls Gallery** sample app for examples of WinUI features and controls.

If you have the **XAML Controls Gallery** app installed, see the [ItemsRepeater](xamlcontrolsgallery:/item/ItemsRepeater) in action.

If you don't have the XAML Controls Gallery app installed, get the WinUI 2.x version from the [Microsoft Store](https://www.microsoft.com/p/xaml-controls-gallery/9msvh128x2zt).

You can also view, clone, and build the XAML Controls Gallery source code from [GitHub](https://github.com/Microsoft/Xaml-Controls-Gallery) (switch to the [WinUI 3 Preview branch](https://github.com/microsoft/Xaml-Controls-Gallery/tree/winui3preview) for WinUI 3 Preview controls and features).
