---
-api-id: E:Microsoft.UI.Xaml.Controls.MediaElement.MarkerReached
-api-type: winrt event
---

<!-- Event syntax
public event Windows.UI.Xaml.Media.TimelineMarkerRoutedEventHandler MarkerReached
-->

# Microsoft.UI.Xaml.Controls.MediaElement.MarkerReached

## -description
Occurs when a timeline marker is encountered during media playback.

## -xaml-syntax
```xaml
<MediaElement MarkerReached="eventhandler"/>
```


## -remarks

## -examples
The following example creates a [MediaElement](mediaelement.md) object and responds to its MarkerReached event. Each time a timeline marker is reached, the example displays the timeline marker's [Time](../microsoft.ui.xaml.media/timelinemarker_time.md), [Type](../microsoft.ui.xaml.media/timelinemarker_type.md), and [Text](../microsoft.ui.xaml.media/timelinemarker_text.md) values.



[!code-xaml[TimelineMarkerXAML](../microsoft.ui.xaml.media/code/MediaXamlSnippets/csharp/MainPage.xaml#SnippetTimelineMarkerXAML)]

[!code-csharp[TimelineMarker](../microsoft.ui.xaml.media/code/MediaXamlSnippets/csharp/MainPage.xaml.cs#SnippetTimelineMarker)]

## -see-also
