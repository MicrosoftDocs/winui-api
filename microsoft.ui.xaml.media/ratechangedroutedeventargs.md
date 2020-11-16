---
-api-id: T:Microsoft.UI.Xaml.Media.RateChangedRoutedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class RateChangedRoutedEventArgs : Windows.UI.Xaml.RoutedEventArgs, Windows.UI.Xaml.Media.IRateChangedRoutedEventArgs
-->

# Microsoft.UI.Xaml.Media.RateChangedRoutedEventArgs

## -description
Provides event data for the [RateChanged](../microsoft.ui.xaml.controls/mediaelement_ratechanged.md) event.

## -remarks
[RateChanged](../microsoft.ui.xaml.controls/mediaelement_ratechanged.md) event fires when [PlaybackRate](../microsoft.ui.xaml.controls/mediaelement_playbackrate.md) or [DefaultPlaybackRate](../microsoft.ui.xaml.controls/mediaelement_defaultplaybackrate.md) change.

The new [PlaybackRate](../microsoft.ui.xaml.controls/mediaelement_playbackrate.md) or [DefaultPlaybackRate](../microsoft.ui.xaml.controls/mediaelement_defaultplaybackrate.md) value, whichever property has changed, is not provided in the event data. Applications should query [PlaybackRate](../microsoft.ui.xaml.controls/mediaelement_playbackrate.md) or [DefaultPlaybackRate](../microsoft.ui.xaml.controls/mediaelement_defaultplaybackrate.md) inside the [RateChangedRoutedEventHandler](ratechangedroutedeventhandler.md) to obtain the new rate.

## -examples

## -see-also
[RoutedEventArgs](../microsoft.ui.xaml/routedeventargs.md)
