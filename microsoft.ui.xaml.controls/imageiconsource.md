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
>
> If you have the **XAML Controls Gallery** app installed, [open the app and see the ImageIcon in action](xamlcontrolsgallery:/item/AppBarButton).
>
> - [Get the XAML Controls Gallery app (Microsoft Store)](https://www.microsoft.com/store/productId/9MSVH128X2ZT)
> - [Get the source code (GitHub)](https://github.com/Microsoft/Xaml-Controls-Gallery)

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
