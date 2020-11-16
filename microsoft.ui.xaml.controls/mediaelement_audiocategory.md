---
-api-id: P:Microsoft.UI.Xaml.Controls.MediaElement.AudioCategory
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Media.AudioCategory AudioCategory { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.MediaElement.AudioCategory

## -description

Gets or sets a value that describes the purpose of the audio information in an audio stream.

## -xaml-syntax

```xaml
<MediaElement AudioCategory="audioCategoryMemberName" /.
```

## -property-value

A value of the enumeration.

## -remarks

For hardware audio offload to be automatically applied, the audio category must be set to **ForegroundOnlyMedia** or **BackgroundCapableMedia**. Hardware audio offload optimizes audio rendering which can improve functionality and battery life.

## -examples

## -see-also

[Audio categories sample](https://github.com/Microsoft/Windows-universal-samples/tree/dev/Samples/AudioCategory)
