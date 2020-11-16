---
-api-id: T:Microsoft.UI.Xaml.ExceptionRoutedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class ExceptionRoutedEventArgs : Windows.UI.Xaml.RoutedEventArgs, Windows.UI.Xaml.IExceptionRoutedEventArgs
-->

# Microsoft.UI.Xaml.ExceptionRoutedEventArgs

## -description
Provides event data for exceptions that are raised as events by asynchronous operations, such as [ImageFailed](../microsoft.ui.xaml.controls/image_imagefailed.md).

## -remarks
Don't display [ErrorMessage](exceptionroutedeventargs_errormessage.md) strings to end users. Instead, use substrings and codes within the string to positively identify the error condition, and have your app take appropriate action or display user-appropriate information in the app UI.

ExceptionRoutedEventArgs is the event data for several events that use the [ExceptionRoutedEventHandler](exceptionroutedeventhandler.md) delegate. These include:
+ [Image.ImageFailed](../microsoft.ui.xaml.controls/image_imagefailed.md)
+ [ImageBrush.ImageFailed](../microsoft.ui.xaml.media/imagebrush_imagefailed.md)
+ [BitmapImage.ImageFailed](../microsoft.ui.xaml.media.imaging/bitmapimage_imagefailed.md)
+ [MediaElement.MediaFailed](../microsoft.ui.xaml.controls/mediaelement_mediafailed.md); for this event you can cast the event data to the more specific [MediaFailedRoutedEventArgs](mediafailedroutedeventargs.md) result.


### **ExceptionRoutedEventArgs** derived classes

ExceptionRoutedEventArgs is the parent class for [MediaFailedRoutedEventArgs](mediafailedroutedeventargs.md).

## -examples
This example shows use of ExceptionRoutedEventArgs in a handler in order to get the **HResult** and error message.



[!code-csharp[MediaPlayer_MediaFailedHandlers](../microsoft.ui.xaml/code/MediaPlayerQuickStart/csharp/MainPage.xaml.cs#SnippetMediaPlayer_MediaFailedHandlers)]

## -see-also
[RoutedEventArgs](routedeventargs.md), [MediaFailed](../microsoft.ui.xaml.controls/mediaelement_mediafailed.md), [ImageFailed](../microsoft.ui.xaml.controls/image_imagefailed.md)
