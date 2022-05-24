---
-api-id: T:Microsoft.UI.Xaml.Controls.ImageIconSource
-api-type: winrt class
---

# Microsoft.UI.Xaml.Controls.ImageIconSource

<!--
public class ImageIconSource : Microsoft.UI.Xaml.Controls.IconSource
-->

## -description

Represents an icon source that uses an image type as its content. The image types currently supported are .bmp, .gif, .jpg, .png, .wdp, and .tiff.

## -remarks

ImageIconSource is similar to [ImageIcon](imageicon.md). However, because it is not a FrameworkElement, it can be shared.

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Icons for Windows apps](/windows/apps/design/style/icons).
>
> The **WinUI 3 Gallery** and **WinUI 2 Gallery** apps include interactive examples of most WinUI 3 and WinUI 2 controls, features, and functionality.
>
> If installed already, open them by clicking the following links: [**WinUI 3 Gallery**](winui3gallery:/item/IconElement) or [**WinUI 2 Gallery**](winui2gallery:/item/IconElement).
>
> If they are not installed, you can download the [**WinUI 3 Gallery**](https://www.microsoft.com/store/productId/9P3JFPWWDZRC) and the [**WinUI 2 Gallery**](https://www.microsoft.com/store/productId/9MSVH128X2ZT) from the Microsoft Store.
>
> You can also get the source code for both from [GitHub](https://github.com/Microsoft/WinUI-Gallery) (use the *main* branch for WinUI 3 and the *winui2* branch for WinUI 2).

The following example shows an [AppBarButton](appbarbutton.md) with an ImageIconSource. [ImageSource](../microsoft.ui.xaml.media/imagesource.md) specifies an image that's included in the app package.

```xaml
<!--
xmlns:muxc="using:Microsoft.UI.Xaml.Controls"
-->

<AppBarButton >
    <AppBarButton.Icon>
        <IconSourceElement>
            <muxc:ImageIconSource ImageSource="ms-appx:///Assets/globe.png"/>
        </IconSourceElement>
    </AppBarButton.Icon>
</AppBarButton>
```

Here we show how to load an ImageIconSource from a bitmap stream.

```csharp
// using muxc = Microsoft.UI.Xaml.Controls;

var bitmapSource = new BitmapSource();
await bitmapSource.SetSourceAsync(bitmapStream);
var icon = new muxc.ImageIconSource() { ImageSource = bitmapSource };
```

## -see-also

[IconElement](iconelement.md), [AppBarButton](appbarbutton.md), [Image](image.md), [Icons for UWP apps](/windows/uwp/style/icons)
