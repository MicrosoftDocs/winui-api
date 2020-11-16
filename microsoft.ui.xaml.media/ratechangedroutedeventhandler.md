---
-api-id: T:Microsoft.UI.Xaml.Media.RateChangedRoutedEventHandler
-api-type: winrt delegate
---
<!-- Delegate syntax.
public delegate void RateChangedRoutedEventHandler(System.Object sender, Windows.UI.Xaml.Media.RateChangedRoutedEventArgs e)
-->
# Microsoft.UI.Xaml.Media.RateChangedRoutedEventHandler

## -description
Represents the method that will handle the [RateChanged](../microsoft.ui.xaml.controls/mediaelement_ratechanged.md) event. This event fires when [PlaybackRate](../microsoft.ui.xaml.controls/mediaelement_playbackrate.md) or [DefaultPlaybackRate](../microsoft.ui.xaml.controls/mediaelement_defaultplaybackrate.md) change either via user interaction or from code.

## -parameters
### -param sender
The object where the handler is attached.

### -param e
The event data.


## -remarks

## -examples
This example uses C# code-behind to add a handler to a [MediaElement](../microsoft.ui.xaml.controls/mediaelement.md) named "myMediaElement" defined in XAML (not shown). The handler gets the [PlaybackRate](../microsoft.ui.xaml.controls/mediaelement_playbackrate.md) from the [MediaElement](../microsoft.ui.xaml.controls/mediaelement.md). That information could be presented in UI as a number, or could be part of logic that displays different UI for normal playback or accelerated/slowed playback. Note that the current rate is obtainable from the [MediaElement](../microsoft.ui.xaml.controls/mediaelement.md) event source, it isn't carried in the event data. 

> [!NOTE]
> myMediaElement_RateChanged is raised when either the [PlaybackRate](../microsoft.ui.xaml.controls/mediaelement_playbackrate.md) or the [DefaultPlaybackRate](../microsoft.ui.xaml.controls/mediaelement_defaultplaybackrate.md) changes, so it is possible that myMediaElement.PlaybackRate queried below is unchanged from previous value.

```csharp
public MainPage()
        {
            this.InitializeComponent();
            myMediaElement.RateChanged += myMediaElement_RateChanged;
        }

        void myMediaElement_RateChanged(object sender, RateChangedRoutedEventArgs e)
        {
            Double CurrentPlayBackRate = myMediaElement.PlaybackRate;
        }

```



## -see-also
