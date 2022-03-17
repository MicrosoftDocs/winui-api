---
-api-id: T:Microsoft.UI.Xaml.Controls.ImageIcon
-api-type: winrt class
---

# Microsoft.UI.Xaml.Controls.ImageIcon

<!--
public class ImageIcon : Windows.UI.Xaml.Controls.IconElement
-->

## -description

Represents an icon that uses an [Image](image.md) as its content.

## -remarks

Supported image types are .bmp, .gif, .jpg, .png, .wdp, and .tiff.

The image should be solid on a transparent background.

Only the first frame of a multi-frame image is used. To use animated icons, see [AnimatedIcon](animatedicon.md).

Due to the file types supported, `ImageIcon` ignores the [Foreground](iconelement_foreground.md) property, so you can't change the foreground color like you can on other [IconElement](iconelement.md) derived controls.

`ImageIcon` is typically used with an [AppBarButton](appbarbutton.md), but it can be used wherever an `IconElement` can be used.

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Command bar](/windows/uwp/controls-and-patterns/app-bars).
>
> If you have the **XAML Controls Gallery** app installed, [open the app and see the ImageIcon in action](xamlcontrolsgallery:/item/AppBarButton).
>
> - [Get the XAML Controls Gallery app (Microsoft Store)](https://www.microsoft.com/store/productId/9MSVH128X2ZT)
> - [Get the source code (GitHub)](https://github.com/Microsoft/Xaml-Controls-Gallery)

The following example shows an [AppBarButton](appbarbutton.md) with an `ImageIcon`. [Source](imageicon_source.md) specifies an image that's included in the app package.

```xaml
<!--
xmlns:muxc="using:Microsoft.UI.Xaml.Controls"
-->

<AppBarButton Label="ImageIcon">
    <AppBarButton.Icon>
        <muxc:ImageIcon Source="ms-appx:///Assets/globe.png"/>
    </AppBarButton.Icon>
</AppBarButton>
```

Here we show how to load an `ImageIcon` from a bitmap stream.

```csharp
// using muxc = Microsoft.UI.Xaml.Controls;

var bitmapSource = new BitmapSource();
await bitmapSource.SetSourceAsync(bitmapStream);
var icon = new muxc.ImageIcon() { Source = bitmapSource };
```

## -see-also

[IconElement](iconelement.md), [AppBarButton](appbarbutton.md), [Image](image.md), [Icons for UWP apps](/windows/uwp/style/icons)
