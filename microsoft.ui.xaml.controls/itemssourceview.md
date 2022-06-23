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

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -remarks

Components written to work with [ItemsRepeater](itemsrepeater.md) should consume the [ItemsSource](itemsrepeater_itemssource.md) via ItemsSourceView since this provides a normalized view of the ItemsSource. That way, each component does not need to know if the source is an [IEnumerable](/dotnet/api/system.collections.generic.ienumerable-1?view=dotnet-uwp-10.0&preserve-view=true), an [IVector](/uwp/api/windows.foundation.collections.ivector_t_), or something else.

## -see-also

[ItemsRepeater.ItemsSourceView](itemsrepeater_itemssourceview.md)

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Items repeater](/windows/apps/design/controls/items-repeater).

> [!div class="nextstepaction"]
> [Open the WinUI 2 Gallery app and see the ItemsRepeater in action](winui2gallery:/item/ItemsRepeater).

> The **WinUI 2 Gallery** app includes interactive examples of most WinUI 2 controls, features, and functionality. Get the app from the [Microsoft Store](https://www.microsoft.com/store/productId/9MSVH128X2ZT) or get the source code on [GitHub](https://github.com/Microsoft/WinUI-Gallery/tree/winui2).
