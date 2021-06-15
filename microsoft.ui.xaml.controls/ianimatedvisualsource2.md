---
-api-id: T:Microsoft.UI.Xaml.Controls.IAnimatedVisualSource2
-api-type: winrt interface
---

# Microsoft.UI.Xaml.Controls.IAnimatedVisualSource2

<!--
public interface IAnimatedVisualSource2 : Microsoft.UI.Xaml.Controls.IAnimatedVisualSource
-->

## -description

 An animated [Visual](/uwp/api/windows.ui.composition.visual) that can be used by other objects, such as an [AnimatedIcon](animatedicon.md).

## -remarks

Call the [IAnimatedVisualSource.TryCreateAnimatedVisual](ianimatedvisualsource_trycreateanimatedvisual_646476001.md) method to retrieve an [IAnimatedVisual](ianimatedvisual.md) object. This `IAnimatedVisual` can then be used to get a [Composition.Visual](../microsoft.ui.composition/visual.md), which can be added to a XAML element tree using the methods of [ElementCompositionPreview](../microsoft.ui.xaml.hosting/elementcompositionpreview.md).

## -see-also

## -examples

This example displays and animates an object that implements IAnimatedVisualSource2:

```cpp
void AddVisualAndShowStartAnimation(
    const winrt::Border& element,
    const& winrt::IAnimatedVisualSource2 source,
    const winrt::hstring& initialState,
    const winrt::hstring& steadyState,
    const winrt::Color& themeColor )
{
    winrt::IAnimatedVisual animatedVisual = source.TryCreateAnimatedIconVisual();

    // Find the playback positions in the animation of the two states
    auto const markers = source.Markers();
    auto const fromProgress = static_cast<float>(markers.Lookup(initialState));
    auto const toProgress = static_cast<float>(markers.Lookup(steadyState));

    // Set the theme color as the animated visual's foreground.
    source.SetColorProperty("Foreground", themeColor);

    // Helper that uses TryCreateAnimatedVisual to add the source to the XAML element tree.
    // See IAnimatedVisualSource.TryCreateAnimatedVisual for more information.
    AddVisualToElement(element, animatedVisual);

    // Helper to play an animation.
    // See IAnimatedVisual for more information.
    PlaySegment(animatedVisual.RootVisual(), fromProgress, toProgress);
}
```
