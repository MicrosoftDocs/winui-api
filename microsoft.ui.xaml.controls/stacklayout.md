---
-api-id: T:Microsoft.UI.Xaml.Controls.StackLayout
-api-type: winrt class
---

<!-- Class syntax.
public class StackLayout : VirtualizingLayoutBase, VirtualizingLayoutBase
-->

# Microsoft.UI.Xaml.Controls.StackLayout

## -description

Arranges the child elements of an [ItemsRepeater](itemsrepeater.md) into a single line that can be oriented horizontally or vertically.

## -remarks

> [!NOTE]
> StackLayout is used exclusively with [ItemsRepeater](itemsrepeater.md). For similar page layout functionality, see [StackPanel](/uwp/api/Windows.UI.Xaml.Controls.StackPanel).

StackLayout supports virtualization when attached to a host that supports virtualization.

By default, StackLayout stacks items vertically from top to bottom in the order they are declared. You can set the [StackLayout.Orientation](stacklayout_orientation.md) property to **Horizontal** to stack items from left to right.

## -see-also

[ItemsRepeater overview](/windows/uwp/design/controls-and-patterns/items-repeater), [StackLayout with ItemsRepeater](/uwp/design/controls-and-patterns/items-repeater#stacklayout), [StackLayoutState](stacklayoutstate.md)

## -examples

This example shows how to set the [ItemsRepeater.Layout](itemsrepeater_layout.md) property to a StackLayout with horizontal orientation and spacing of 8 pixels.

```xaml
<!-- xmlns:muxc="using:Microsoft.UI.Xaml.Controls" -->
<muxc:ItemsRepeater ItemsSource="{x:Bind Items}" ItemTemplate="{StaticResource MyTemplate}">
    <muxc:ItemsRepeater.Layout>
        <muxc:StackLayout Orientation="Horizontal" Spacing="8"/>
    </muxc:ItemsRepeater.Layout>
</muxc:ItemsRepeater>
```

See the **XAML Controls Gallery** sample app for examples of WinUI features and controls.

If you have the **XAML Controls Gallery** app installed, see the [ItemsRepeater](xamlcontrolsgallery:/item/ItemsRepeater) in action.

If you don't have the XAML Controls Gallery app installed, get the WinUI 2.x version from the [Microsoft Store](https://www.microsoft.com/p/xaml-controls-gallery/9msvh128x2zt).

You can also view, clone, and build the XAML Controls Gallery source code from [GitHub](https://github.com/Microsoft/Xaml-Controls-Gallery) (switch to the [WinUI 3 Preview branch](https://github.com/microsoft/Xaml-Controls-Gallery/tree/winui3preview) for WinUI 3 Preview controls and features).
