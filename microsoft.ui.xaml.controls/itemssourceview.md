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

Components written to work with [ItemsRepeater](itemsrepeater.md) should consume the [ItemsSource](itemsrepeater_itemssource.md) via ItemsSourceView since this provides a normalized view of the ItemsSource. That way, each component does not need to know if the source is an [IEnumerable](/dotnet/api/system.collections.generic.ienumerable-1?view=dotnet-uwp-10.0&preserve-view=true), an [IVector](/uwp/api/windows.foundation.collections.ivector_t_), or something else.

## -see-also

[ItemsRepeater.ItemsSourceView](itemsrepeater_itemssourceview.md)

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [ItemsRepeater](/windows/apps/design/controls/items-repeater).
>
> The **WinUI 3 Gallery** and **WinUI 2 Gallery** apps include interactive examples of most WinUI 3 and WinUI 2 controls, features, and functionality.
>
> If installed already, open them by clicking the following links: [**WinUI 3 Gallery**](winui3gallery:/item/ItemsRepeater) or [**WinUI 2 Gallery**](winui2gallery:/item/ItemsRepeater).
>
> If they are not installed, you can download the [**WinUI 3 Gallery**](https://www.microsoft.com/store/productId/9P3JFPWWDZRC) and the [**WinUI 2 Gallery**](https://www.microsoft.com/store/productId/9MSVH128X2ZT) from the Microsoft Store.
>
> You can also get the source code for both from [GitHub](https://github.com/Microsoft/WinUI-Gallery) (use the *main* branch for WinUI 3 and the *winui2* branch for WinUI 2).
