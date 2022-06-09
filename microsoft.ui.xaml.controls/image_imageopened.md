---
-api-id: E:Microsoft.UI.Xaml.Controls.Image.ImageOpened
-api-type: winrt event
---

<!-- Event syntax
public event Windows.UI.Xaml.RoutedEventHandler ImageOpened
-->

# Microsoft.UI.Xaml.Controls.Image.ImageOpened

## -description
Occurs when the image source is downloaded and decoded with no failure. You can use this event to determine the natural size of the image source.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -xaml-syntax
```xaml
<Image ImageOpened="eventhandler"/>
```


## -remarks
When ImageOpened fires, that serves as the notification that any asynchronous operations have completed and all the properties of the object used as the image source are ready for use. For example, to determine the size of the image, handle ImageOpened, and check the value of the [PixelWidth](../microsoft.ui.xaml.media.imaging/bitmapsource_pixelwidth.md) and [PixelHeight](../microsoft.ui.xaml.media.imaging/bitmapsource_pixelheight.md) properties on the object referenced as [Image.Source](image_source.md). The event data for the ImageOpened event isn't typically useful.

When the Image element isn’t in the live visual tree, the Image element will not fire ImageOpened or [ImageFailed](image_imagefailed.md) events.  If you need to receive these events while the element isn’t in the live tree, use the BitmapImage.[ImageOpened](../microsoft.ui.xaml.media.imaging/bitmapimage_imageopened.md)/[ImageFailed](../microsoft.ui.xaml.media.imaging/bitmapimage_imagefailed.md) events.

<!--The following remark is relevant for Windows 8 > 8.1 migration. See WBB 459121-->
### Windows 8 behavior

For Windows 8, resources can use a resource qualifier pattern to load different resources depending on device-specific scaling. However, resources aren't automatically reloaded if the scaling factor changes while the app is running. In this case apps would have to take care of reloading resources, by handling the [DpiChanged](/uwp/api/windows.graphics.display.displayinformation.dpichanged) event (or the deprecated [LogicalDpiChanged](/uwp/api/windows.graphics.display.displayproperties.logicaldpichanged) event) and using [ResourceManager](/uwp/api/windows.applicationmodel.resources.core.resourcemanager)  API to manually reload the resource that's appropriate for the new scaling factor. Starting with Windows 8.1, any resource that was originally retrieved for your app is automatically re-evaluated if the scaling factor changes while the app is running. In addition, when that resource is the image source for an [Image](image.md) object, then one of the source-load events (ImageOpened or [ImageFailed](image_imagefailed.md)) is fired as a result of the system's action of requesting the new resource and then applying it to the [Image](image.md). The scenario where a run-time scale change might happen is if the user moves your app to a different monitor when more than one is available.

If you migrate your app code from Windows 8 to Windows 8.1 you may want to account for this behavior change, because it results in ImageOpened or [ImageFailed](image_imagefailed.md) events that happen at run-time when the scale change is handled, even in cases where the [Source](image_source.md) is set in XAML. Also, if you did have code that handled [DpiChanged](/uwp/api/windows.graphics.display.displayinformation.dpichanged)/[LogicalDpiChanged](/uwp/api/windows.graphics.display.displayproperties.logicaldpichanged) and reset the resources, you should examine whether that code is still needed given the new Windows 8.1 automatic reload behavior.

Apps that were compiled for Windows 8 but running on Windows 8.1 continue to use the Windows 8 behavior.

## -examples

## -see-also
[ImageFailed](image_imagefailed.md), [Image and ImageBrush](/windows/uwp/controls-and-patterns/images-imagebrushes)
