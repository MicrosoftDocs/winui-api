---
-api-id: M:Microsoft.UI.Xaml.Controls.MediaPlayerElement.SetMediaPlayer(Windows.Media.Playback.MediaPlayer)
-api-type: winrt method
---

<!-- Method syntax
public void SetMediaPlayer(Windows.Media.Playback.MediaPlayer mediaPlayer)
-->

# Microsoft.UI.Xaml.Controls.MediaPlayerElement.SetMediaPlayer

## -description
Sets the [MediaPlayer](/uwp/api/windows.media.playback.mediaplayer) instance used to render media.

## -parameters
### -param mediaPlayer
The new [MediaPlayer](/uwp/api/windows.media.playback.mediaplayer) instance used to render media.

## -remarks
You can use the SetMediaPlayer method to change the underlying [MediaPlayer](/uwp/api/windows.media.playback.mediaplayer) instance. Calling this method to change the [MediaPlayer](/uwp/api/windows.media.playback.mediaplayer) can cause non-trivial side effects because it can change other properties of the [MediaPlayerElement](mediaplayerelement.md).

Use the [MediaPlayer](mediaplayerelement_mediaplayer.md) property to get the current instance of [MediaPlayer](/uwp/api/windows.media.playback.mediaplayer).

## -examples

## -see-also
