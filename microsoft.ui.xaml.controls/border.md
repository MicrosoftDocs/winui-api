---
-api-id: T:Microsoft.UI.Xaml.Controls.Border
-api-type: winrt class
---

<!-- Class syntax.
public class Border : Windows.UI.Xaml.FrameworkElement, Windows.UI.Xaml.Controls.IBorder
-->

# Microsoft.UI.Xaml.Controls.Border

## -description
Draws a border, background, or both, around another object.

## -xaml-syntax
```xaml
<Border>
  singleChild
</Border>

```


## -remarks
Border is a container control that draws a border, background, or both, around another object. Here's a gray border around two rectangles.

<img alt="A border around 2 rectangles" src="images/controls/Border.png" />

You can specify basic properties of a Border by setting its [Width](../microsoft.ui.xaml/frameworkelement_width.md), [Height](../microsoft.ui.xaml/frameworkelement_height.md), [BorderBrush](border_borderbrush.md), [BorderThickness](border_borderthickness.md), and [Background](border_background.md) color. In addition, you can round the border corners by setting the [CornerRadius](border_cornerradius.md) property, and you can position the object inside the Border by setting the [Padding](border_padding.md) property.

A Border can contain only one child object. If you want to put a border around multiple objects, wrap them in a container object such as [StackPanel](stackpanel.md).

## -examples

> [!TIP]
> The **WinUI 3 Gallery** and **WinUI 2 Gallery** apps include interactive examples of most WinUI 3 and WinUI 2 controls, features, and functionality.
>
> If installed already, open them by clicking the following links: [**WinUI 3 Gallery**](winui3gallery:/item/Border) or [**WinUI 2 Gallery**](winui2gallery:/item/Border).
>
> If they are not installed, you can download the [**WinUI 3 Gallery**](https://www.microsoft.com/store/productId/9P3JFPWWDZRC) and the [**WinUI 2 Gallery**](https://www.microsoft.com/store/productId/9MSVH128X2ZT) from the Microsoft Store.
>
> You can also get the source code for both from [GitHub](https://github.com/Microsoft/WinUI-Gallery) (use the *main* branch for WinUI 3 and the *winui2* branch for WinUI 2).

This example shows how to put a Border around several [Rectangle](../microsoft.ui.xaml.shapes/rectangle.md) objects contained in a [StackPanel](stackpanel.md).

[!code-xaml[BasicBorderXAML](../microsoft.ui.xaml.controls/code/BasicLayoutSnippets/CS/BlankPage.xaml#SnippetBasicBorderXAML)]

[!code-xaml[LayoutOvwBorder](../microsoft.ui.xaml/code/layout_ovw_all/CSharp/MainPage.xaml#SnippetLayoutOvwBorder)]

## -see-also
[FrameworkElement](../microsoft.ui.xaml/frameworkelement.md), [Alignment, margin, and padding](/windows/uwp/layout/alignment-margin-padding)
