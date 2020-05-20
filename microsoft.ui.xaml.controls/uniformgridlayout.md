---
-api-id: T:Microsoft.UI.Xaml.Controls.UniformGridLayout
-api-type: winrt class
---

# Microsoft.UI.Xaml.Controls.UniformGridLayout

<!--
public class UniformGridLayout : Microsoft.UI.Xaml.Controls.VirtualizingLayout
-->

## -description

Positions elements sequentially from left to right or top to bottom in a wrapping layout.

## -remarks

Items are layed out in order from left-to-right when the [Orientation](uniformgridlayout_orientation.md) is `Horizontal`, and layed out top-to-bottom when the [Orientation](uniformgridlayout_orientation.md) is `Vertical`.

Every item in a UniformGridLayout is sized equally.

UniformGridLayout supports virtualization when attached to a host that supports virtualization.

## -examples

If you have the **XAML Controls Gallery** app installed, see the [ItemsRepeater](xamlcontrolsgallery:/item/ItemsRepeater) in action.

Otherwise, download the [XAML Controls Gallery app](https://www.microsoft.com/store/productId/9MSVH128X2ZT) from the Microsoft Store or see the [XAML Controls Gallery app source code](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlUIBasics) on GitHub.

The following example shows how to set the [ItemsRepeater.Layout](itemsrepeater_layout.md) property to a UniformGridLayout.

```xaml
<!--
    xmlns:muxc="using:Microsoft.UI.Xaml.Controls"
-->
...
<muxc:ItemsRepeater ItemsSource="{x:Bind Items}"
                    ItemTemplate="{StaticResource MyTemplate}">
    <muxc:ItemsRepeater.Layout>
        <muxc:UniformGridLayout MinItemWidth="200"
                                MinColumnSpacing="28"
                                ItemsJustification="SpaceAround"/>
    </muxc:ItemsRepeater.Layout>
</muxc:ItemsRepeater>
```

## -see-also

[UniformGridLayout](/windows/uwp/design/controls-and-patterns/items-repeater#uniformgridlayout) in the ItemsRepeater guidelines
