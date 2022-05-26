---
-api-id: T:Microsoft.UI.Xaml.Controls.Viewbox
-api-type: winrt class
---

<!-- Class syntax.
public class Viewbox : Windows.UI.Xaml.FrameworkElement, Windows.UI.Xaml.Controls.IViewbox
-->

# Microsoft.UI.Xaml.Controls.Viewbox

## -description
Defines a content decorator that can stretch and scale a single child to fill the available space.

## -xaml-syntax
```xaml
<ViewBox .../>
-or-
<ViewBox ...>
  child
</ViewBox>

```


## -remarks
Viewbox is a container control that scales its content to a specified size.

<img alt="Viewbox control" src="images/controls/Viewbox.png" />

## -examples

> [!TIP]
> The **WinUI 3 Gallery** and **WinUI 2 Gallery** apps include interactive examples of most WinUI 3 and WinUI 2 controls, features, and functionality.
>
> If installed already, open them by clicking the following links: [**WinUI 3 Gallery**](winui3gallery:/item/ViewBox) or [**WinUI 2 Gallery**](winui2gallery:/item/ViewBox).
>
> If they are not installed, you can download the [**WinUI 3 Gallery**](https://www.microsoft.com/store/productId/9P3JFPWWDZRC) and the [**WinUI 2 Gallery**](https://www.microsoft.com/store/productId/9MSVH128X2ZT) from the Microsoft Store.
>
> You can also get the source code for both from [GitHub](https://github.com/Microsoft/WinUI-Gallery) (use the *main* branch for WinUI 3 and the *winui2* branch for WinUI 2).


The following example shows what happens when you change the [StretchDirection](viewbox_stretchdirection.md) and [Stretch](viewbox_stretch.md) properties of a Viewbox. The example includes three Viewbox controls that have different sizes. The same image is displayed in the Viewbox controls so that you can compare the differences. You can manipulate the stretching and scaling of the image by clicking the buttons that correspond to the values for the [Stretch](viewbox_stretch.md) and [StretchDirection](viewbox_stretchdirection.md) enumerations.

[!code-xaml[ViewBoxXAML](../microsoft.ui.xaml/code/ViewBoxSnippet/csharp/MainPage.xaml#SnippetViewBoxXAML)]

[!code-csharp[ViewBoxCode](../microsoft.ui.xaml/code/ViewBoxSnippet/csharp/MainPage.xaml.cs#SnippetViewBoxCode)]

[!code-vb[ViewBoxCode](../microsoft.ui.xaml/code/ViewBoxSnippet/vbnet/MainPage.xaml.vb#SnippetViewBoxCode)]

## -see-also
[FrameworkElement](../microsoft.ui.xaml/frameworkelement.md)
