---
-api-id: T:Microsoft.UI.Xaml.Controls.StackPanel
-api-type: winrt class
---

<!-- Class syntax.
public class StackPanel : Windows.UI.Xaml.Controls.Panel, Windows.UI.Xaml.Controls.IInsertionPanel, Windows.UI.Xaml.Controls.IStackPanel, Windows.UI.Xaml.Controls.IStackPanel2, Windows.UI.Xaml.Controls.Primitives.IScrollSnapPointsInfo
-->

# Microsoft.UI.Xaml.Controls.StackPanel

## -description
Arranges child elements into a single line that can be oriented horizontally or vertically.

## -xaml-syntax
```xaml
<StackPanel .../>
-or-
<StackPanel ...>
  oneOrMoreChildren
</StackPanel>

```


## -remarks

> [!TIP]
> For more info, design guidance, and code examples, see [Layout panels](/windows/apps/design/layout/layout-panels#stackpanel).

StackPanel is a layout panel that arranges child elements into a single line that can be oriented horizontally or vertically.

<img alt="Stack panel layout control" src="images/controls/StackPanel.png" />

By default, StackPanel stacks items vertically from top to bottom in the order they are declared. You can set the [Orientation](stackpanel_orientation.md) property to **Horizontal** to stack items from left to right.

You can insert items into a StackPanel at a specific location using the [Insert](uielementcollection_insert.md) method in code-behind.

### Border properties

StackPanel defines border properties that let you draw a border around the StackPanel without using an additional [Border](border.md) element. The properties are [StackPanel.BorderBrush](stackpanel_borderbrush.md), [StackPanel.BorderThickness](stackpanel_borderthickness.md), [StackPanel.CornerRadius](stackpanel_cornerradius.md), and [StackPanel.Padding](stackpanel_padding.md).

```xaml
<StackPanel BorderBrush="Red" BorderThickness="2" CornerRadius="10" Padding="12">
    <TextBlock Text="Hello World!"/>
</StackPanel>
```

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Layout panels](/windows/apps/design/layout/layout-panels#stackpanel).
>
> The **WinUI 3 Gallery** and **WinUI 2 Gallery** apps include interactive examples of most WinUI 3 and WinUI 2 controls, features, and functionality.
>
> If installed already, open them by clicking the following links: [**WinUI 3 Gallery**](winui3gallery:/item/StackPanel) or [**WinUI 2 Gallery**](winui2gallery:/item/StackPanel).
>
> If they are not installed, you can download the [**WinUI 3 Gallery**](https://www.microsoft.com/store/productId/9P3JFPWWDZRC) and the [**WinUI 2 Gallery**](https://www.microsoft.com/store/productId/9MSVH128X2ZT) from the Microsoft Store.
>
> You can also get the source code for both from [GitHub](https://github.com/Microsoft/WinUI-Gallery) (use the *main* branch for WinUI 3 and the *winui2* branch for WinUI 2).


The following example shows how to create a StackPanel of items.

[!code-xaml[LayoutOvwStackPanel_1](../microsoft.ui.xaml/code/layout_ovw_all/CSharp/MainPage.xaml#SnippetLayoutOvwStackPanel_1)]

[!code-xaml[02](../microsoft.ui.xaml.controls/code/StackPanel1/csharp/Page.xaml#Snippet02)]

[!code-csharp[01](../microsoft.ui.xaml.controls/code/StackPanel1/csharp/Page.xaml.cs#Snippet01)]

[!code-vb[01](../microsoft.ui.xaml.controls/code/StackPanel1/vbnet/Page.xaml.vb#Snippet01)]

## -see-also
[Panel](panel.md), [IScrollSnapPointsInfo](../microsoft.ui.xaml.controls.primitives/iscrollsnappointsinfo.md), [Define layouts](/windows/uwp/layout/layouts-with-xaml), [Alignment, margin, and padding](/windows/uwp/layout/alignment-margin-padding), [Canvas](canvas.md), [Grid](grid.md), [ItemsStackPanel](itemsstackpanel.md), [VariableSizedWrapGrid](variablesizedwrapgrid.md), [VirtualizingStackPanel](virtualizingstackpanel.md), [Controls list](/windows/apps/design/controls/), [Controls by function](/windows/uwp/controls-and-patterns/controls-by-function)
347b-91d6-4659-91f2-80ecf7bbb596)
