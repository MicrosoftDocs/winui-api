---
-api-id: E:Microsoft.UI.Xaml.Media.ImageBrush.ImageOpened
-api-type: winrt event
---

<!-- Event syntax
public event Windows.UI.Xaml.RoutedEventHandler ImageOpened
-->

# Microsoft.UI.Xaml.Media.ImageBrush.ImageOpened

## -description
Occurs when the image source is downloaded and decoded with no failure. You can use this event to determine the size of an image before rendering it.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -xaml-syntax
```xaml
<ImageBrush ImageOpened="eventhandler"/>
```


## -remarks
For the scenario of checking the size of an image before rendering, that info isn't part of the ImageOpened event data. Instead, the fact that the event fired is the notification that the [PixelHeight](../microsoft.ui.xaml.media.imaging/bitmapsource_pixelheight.md) and [PixelWidth](../microsoft.ui.xaml.media.imaging/bitmapsource_pixelwidth.md) values of the image source ([ImageSource](imagebrush_imagesource.md) value) are available.

## -examples

## -see-also
