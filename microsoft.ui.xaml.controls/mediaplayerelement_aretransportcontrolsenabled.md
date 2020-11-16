---
-api-id: P:Microsoft.UI.Xaml.Controls.MediaPlayerElement.AreTransportControlsEnabled
-api-type: winrt property
---

<!-- Property syntax
public bool AreTransportControlsEnabled { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.MediaPlayerElement.AreTransportControlsEnabled

## -description
Gets or sets a value that determines whether the standard transport controls are enabled.

## -xaml-syntax
```xaml
<MediaPlayerElement AreTransportControlsEnabled="bool"/>
```


## -property-value
**true** if the standard transport controls are enabled; otherwise, **false**. The default is **false**.

## -remarks
The transport controls are exposed as a [MediaTransportControls](mediatransportcontrols.md) object that you can access through the [MediaPlayerElement.TransportControls](mediaplayerelement_transportcontrols.md) property. See [MediaTransportControls](mediatransportcontrols.md) for more info.

If AreTransportControlsEnabled is **true**, the standard transport controls are enabled and displayed on the [MediaPlayerElement](mediaplayerelement.md). If AreTransportControlsEnabled is **false**, the standard transport controls are not enabled and are not displayed.

The transport controls hide themselves after a short period of no user interaction with the [MediaPlayerElement](mediaplayerelement.md). They reappear when the user interacts with the [MediaPlayerElement](mediaplayerelement.md).

If the [Width](../microsoft.ui.xaml/frameworkelement_width.md) of [MediaPlayerElement](mediaplayerelement.md) is not sufficient to display all of the transport controls, a subset of the controls are displayed.

> [!NOTE]
> If you disable the [MediaPlaybackCommandManager](/uwp/api/windows.media.playback.mediaplaybackcommandmanager) by setting [IsEnabled](/uwp/api/windows.media.playback.mediaplaybackcommandmanager.isenabled) to **false**, it will break the link between the [MediaPlayer](/uwp/api/windows.media.playback.mediaplayer) the [TransportControls](mediaplayerelement_transportcontrols.md) provided by the MediaPlayerElement, so the built-in transport controls will no longer automatically control the playback of the player. Instead, you must implement your own controls to control the **MediaPlayer**.

## -examples

## -see-also
