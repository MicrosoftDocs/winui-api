---
-api-id: T:Microsoft.UI.Xaml.Controls.MediaPlayerElement
-api-type: winrt class
---

<!-- Class syntax.
public class MediaPlayerElement : Windows.UI.Xaml.Controls.Control, Windows.UI.Xaml.Controls.IMediaPlayerElement
-->

# Microsoft.UI.Xaml.Controls.MediaPlayerElement

## -description

Represents an object that uses a [MediaPlayer](/uwp/api/windows.media.playback.mediaplayer) to render audio and video to the display.

## -xaml-syntax

```xaml
<MediaPlayerElement .../>
```

## -remarks

> [!TIP]
> For more info, design guidance, and code examples, see [Media playback](/windows/uwp/design/controls-and-patterns/media-playback).

For info about the media formats that MediaPlayerElement supports, see [Supported codecs](/windows/uwp/audio-video-camera/supported-codecs).

### Architectural overview

MediaPlayerElement is a lightweight XAML control that serves as a rendering surface for the robust [MediaPlayer](/uwp/api/windows.media.playback.mediaplayer) class, which is part of the [Windows.Media.Playback](/uwp/api/windows.media.playback) namespace. The majority of the media functionality is located on the underlying [MediaPlayer](/uwp/api/windows.media.playback.mediaplayer) class, which you can access through the [MediaPlayerElement.MediaPlayer](mediaplayerelement_mediaplayer.md) property. To change the underlying [MediaPlayer](/uwp/api/windows.media.playback.mediaplayer) for an instance of MediaPlayerElement, use the [SetMediaPlayer](mediaplayerelement_setmediaplayer_932380017.md) method.

For more information about the [MediaPlayer](/uwp/api/windows.media.playback.mediaplayer) class, including guidelines on how to transition from [MediaElement](mediaelement.md) to MediaPlayerElement, see the [Media playback](/windows/uwp/audio-video-camera/media-playback) page.

### Set the media source

Set the [Source](mediaplayerelement_source.md) property of the MediaPlayerElement to point to an audio or video file. You can set it to a [MediaSource](/uwp/api/windows.media.core.mediasource), [MediaPlaybackItem](/uwp/api/windows.media.playback.mediaplaybackitem), or [MediaPlaybackList](/uwp/api/windows.media.playback.mediaplaybacklist). The media files can be included with the app package or be on a network.

By default, the media that is defined by the [Source](mediaplayerelement_source.md) property does not immediately play after the MediaPlayerElement object has loaded. To start media playback automatically, set the [AutoPlay](mediaelement_autoplay.md) property to **true**.

Here’s how to create a MediaPlayerElement in XAML with the [Source](mediaplayerelement_source.md) set to the path of a video file that is included in the app and the [AutoPlay](mediaelement_autoplay.md) property explicitly set to **true**.

```xaml
<MediaPlayerElement Source="ms-appx:///Media/video1.mp4" AutoPlay="True"/>
```

Here’s how to create the MediaPlayerElement in code.

```xaml
MediaPlayerElement mediaPlayerElement1 = new MediaPlayerElement();
mediaPlayerElement1.Source = MediaSource.CreateFromUri(new Uri("ms-appx:///Media/video1.mp4"));
mediaPlayerElement1.AutoPlay = true;
```

### Handle media events

You can respond to common media events located on the underlying [MediaPlayer](/uwp/api/windows.media.playback.mediaplayer) such as [MediaOpened](/uwp/api/windows.media.playback.mediaplayer.mediaopened), [MediaEnded](/uwp/api/windows.media.playback.mediaplayer.mediaended), and [MediaFailed](/uwp/api/windows.media.playback.mediaplayer.mediafailed). If you have set the source to a [MediaPlaybackItem](/uwp/api/windows.media.playback.mediaplaybackitem) or [MediaPlaybackList](/uwp/api/windows.media.playback.mediaplaybacklist), you should respond to the media events on those classes instead as they provide more information.

### Transport controls

Set the [AreTransportControlsEnabled](mediaplayerelement_aretransportcontrolsenabled.md) property to programmatically enable and disable the built in transport controls for the MediaPlayerElement. The built in transport controls provide UI for playing, stopping, pausing, and seeking the media as well as UI for volume, mute, full window, track selection, closed captions and remaining time.

You can create your own media transport controls by setting [AreTransportControlsEnabled](mediaplayerelement_aretransportcontrolsenabled.md) to **false**, and using the [Play](/uwp/api/windows.media.playback.mediaplayer.play) and [Pause](/uwp/api/windows.media.playback.mediaplayer.pause) methods on [MediaPlayer](/uwp/api/windows.media.playback.mediaplayer). You can also control a rich set of properties by using the underlying [MediaPlayer](/uwp/api/windows.media.playback.mediaplayer) such as [Position](/uwp/api/windows.media.playback.mediaplayer.position), [Volume](/uwp/api/windows.media.playback.mediaplayer.volume), [IsMuted](/uwp/api/windows.media.playback.mediaplayer.ismuted), [IsLoopingEnabled](/uwp/api/windows.media.playback.mediaplayer.isloopingenabled), and [PlaybackRate](/uwp/api/windows.media.playback.mediaplayer.playbackrate).

> [!TIP]
> For better performance, avoid data binding to the [Position](/uwp/api/windows.media.playback.mediaplayer.position) property to reflect frequent position updates (for example with a progress bar). Instead, use the [DispatcherTimer](../microsoft.ui.xaml/dispatchertimer.md) to query the [Position](/uwp/api/windows.media.playback.mediaplayer.position) property.

For more info and examples, see [Create custom transport controls](/windows/uwp/controls-and-patterns/custom-transport-controls).

### Full window playback

Use the [IsFullWindow](mediaplayerelement_isfullwindow.md) property to enable and disable full window rendering. When in full-window mode the display is automatically prevented from being deactivated when user action is no longer detected.

> [!NOTE]
> We recommend that you not use MediaPlayerElement in a [Popup](../microsoft.ui.xaml.controls.primitives/popup.md) control. If a MediaPlayerElement hosted in a [Popup](../microsoft.ui.xaml.controls.primitives/popup.md) is switched to full-window mode, the [Popup](../microsoft.ui.xaml.controls.primitives/popup.md) is rendered on top of the MediaPlayerElement. If you must use a MediaPlayerElement in a [Popup](../microsoft.ui.xaml.controls.primitives/popup.md), you should collapse the [Popup](../microsoft.ui.xaml.controls.primitives/popup.md) when the MediaPlayerElement enters full-window mode, and restore the [Popup](../microsoft.ui.xaml.controls.primitives/popup.md) when the MediaPlayerElement exits full-window mode. Use [DependencyProperty.RegisterPropertyChangedCallback](/uwp/api/windows.ui.xaml.dependencyobject.registerpropertychangedcallback(windows.ui.xaml.dependencyproperty,windows.ui.xaml.dependencypropertychangedcallback)) to be notified when the [MediaPlayerElement.IsFullWindow](mediaplayerelement_isfullwindow.md) property changes. For an example, see the Examples section.

### Keep media playing

To prevent the display from being deactivated when MediaPlayerElement is not in full-window mode, you can call [DisplayRequest.RequestActive](/uwp/api/windows.system.display.displayrequest.requestactive). To conserve power and battery life, you should call [DisplayRequest.RequestRelease](/uwp/api/windows.system.display.displayrequest.requestrelease) to release the display request as soon as it is no longer required.

Here are some situations when you should release the display request:

+ Video playback is paused, for example by user action, buffering, or adjustment due to limited bandwidth.
+ Playback stops. For example, the video is done playing or the presentation is over.
+ A playback error has occurred. For example, network connectivity issues or a corrupted file.

Here, you use the [PlaybackStateChanged](/uwp/api/windows.media.playback.mediaplaybacksession.playbackstatechanged) event to detect these situations. Then, use the [NaturalVideoHeight](/uwp/api/windows.media.playback.mediaplaybacksession.naturalvideoheight) property of the [MediaPlayer.PlaybackSession](/uwp/api/windows.media.playback.mediaplayer.playbacksession) to determine whether an audio or video file is playing, and keep the screen active only if video is playing.

```xaml
<MediaPlayerElement x:Name="mpe" Source="ms-appx:///Media/video1.mp4"/>
```

```csharp

// Create this variable at a global scope. Set it to null.
private DisplayRequest appDisplayRequest = null;

protected override void OnNavigatedTo(NavigationEventArgs e)
{
    mpe.MediaPlayer.PlaybackSession.PlaybackStateChanged += MediaPlayerElement_CurrentStateChanged;
    base.OnNavigatedTo(e);
}

private void MediaPlayerElement_CurrentStateChanged(MediaPlaybackSession sender, object args)
{
    MediaPlaybackSession playbackSession = sender as MediaPlaybackSession;
    if (playbackSession != null && playbackSession.NaturalVideoHeight != 0)
    {
        if(playbackSession.PlaybackState == MediaPlaybackState.Playing)
        {
            if(appDisplayRequest == null)
            {
                // This call creates an instance of the DisplayRequest object
                appDisplayRequest = new DisplayRequest();
                appDisplayRequest.RequestActive();
            }
        }
        else // PlaybackState is Buffering, None, Opening, or Paused.
        {
            if(appDisplayRequest != null)
            {
                // Deactivate the display request and set the var to null.
                appDisplayRequest.RequestRelease();
                appDisplayRequest = null;
            }
        }
    }
}

```

### Poster source

You can use the [PosterSource](mediaplayerelement_postersource.md) property to provide your MediaPlayerElement with a visual representation before the media is loaded or while audio-only media is playing. . A [PosterSource](mediaplayerelement_postersource.md) is an image, such as a screen shot, movie poster, or album cover, that is displayed in place of the media. The [PosterSource](mediaplayerelement_postersource.md) is displayed in the following situations:

+ When a valid source is not set. For example, [Source](mediaplayerelement_source.md) is not set, [Source](mediaplayerelement_source.md) was set to **Null**, or the source is invalid (as is the case when a [MediaFailed](/uwp/api/windows.media.playback.mediaplayer.mediafailed) event fires).
+ While media is loading. For example, a valid source is set, but the [MediaOpened](/uwp/api/windows.media.playback.mediaplayer.mediaopened) event has not fired yet.
+ When media is streaming to another device.
+ When the media is audio only.

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Media playback](/windows/uwp/design/controls-and-patterns/media-playback).
>
> If you have the **XAML Controls Gallery** app installed, click here to [open the app and see the MediaPlayerElement in action](xamlcontrolsgallery:/item/MediaPlayerElement).
> + [Get the XAML Controls Gallery app (Microsoft Store)](https://www.microsoft.com/store/productId/9MSVH128X2ZT)
> + [Get the source code (GitHub)](https://github.com/Microsoft/Xaml-Controls-Gallery)

This code creates a MediaPlayerElement with the [AutoPlay](mediaplayerelement_autoplay.md) property explicitly set to **true** and the [Source](mediaplayerelement_source.md) set to the path of a video file that is included in the app.

```xaml
<MediaPlayerElement Source="ms-appx:///Media/video1.mp4" AutoPlay="True" />
```

This example creates a MediaPlayerElement with the transport controls enabled.

```xaml
<MediaPlayerElement x:Name="mediaPlayer"
              Source="ms-appx:///Media/video1.mp4"
              AreTransportControlsEnabled="True" />
```

This example shows how to use a MediaPlayerElement in a Popup.

```xaml
<Grid>
    <Button Content="Show Popup" Click="ShowPopupClicked"/>
    <Popup x:Name="mediaPlayerPopup">
        <StackPanel Height="1400" Width="1400" Background="Blue">
            <MediaPlayerElement x:Name="mediaPlayer"
                  AreTransportControlsEnabled="True"
                  Source="ms-appx:///Media/Intro.wmv"/>
            <TextBlock Text="Simple Popup"/>
            <Button Content="Close" Click="ClosePopupClicked"/>
        </StackPanel>
    </Popup>
</Grid>
```

```csharp

long token;

protected override void OnNavigatedTo(NavigationEventArgs e)
{
    token = mediaPlayer.RegisterPropertyChangedCallback(MediaPlayerElement.IsFullWindowProperty, OnMPEFullWindowChanged);
    base.OnNavigatedTo(e);
}

protected override void OnNavigatedFrom(NavigationEventArgs e)
{
    mediaPlayer.UnregisterPropertyChangedCallback(MediaPlayerElement.IsFullWindowProperty, token);
}

private void OnMPEFullWindowChanged(DependencyObject sender, DependencyProperty dp)
{
    MediaPlayerElement mpe = (MediaPlayerElement)sender;

    if (mpe != null && dp == MediaPlayerElement.IsFullWindowProperty)
    {
        if (mpe.IsFullWindow == true)
        {
            mediaPlayerPopup.Visibility = Visibility.Collapsed;
        }
        else
        {
            mediaPlayerPopup.Visibility = Visibility.Visible;
        }
    }  
}

private void ClosePopupClicked(object sender, RoutedEventArgs e)
{
    // If the Popup is open, then close it. 
    if (mediaPlayerPopup.IsOpen) { mediaPlayerPopup.IsOpen = false; }
}

// Handles the Click event on the Button on the page and opens the Popup. 
private void ShowPopupClicked(object sender, RoutedEventArgs e)
{
    // Open the Popup if it isn't open already.
    if (!mediaPlayerPopup.IsOpen) { mediaPlayerPopup.IsOpen = true; }
}
```

## -see-also

[Control](control.md), [Media playback overview](/windows/uwp/design/controls-and-patterns/media-playback), [Audio categories sample](https://github.com/Microsoft/Windows-universal-samples/tree/dev/Samples/AudioCategory), [Media transport controls sample](https://github.com/Microsoft/Windows-universal-samples/tree/dev/Samples/XamlCustomMediaTransportControls), [Version adaptive code sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/VersionAdaptiveCode)
