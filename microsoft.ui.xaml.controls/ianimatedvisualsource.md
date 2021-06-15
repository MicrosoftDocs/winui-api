---
-api-id: T:Microsoft.UI.Xaml.Controls.IAnimatedVisualSource
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IAnimatedVisualSource 
-->

# Microsoft.UI.Xaml.Controls.IAnimatedVisualSource

## -description

 An animated [Visual](/uwp/api/windows.ui.composition.visual) that can be used by other objects, such as an [AnimatedVisualPlayer](animatedvisualplayer.md).

## -remarks

Call the [IAnimatedVisualSource.TryCreateAnimatedVisual](ianimatedvisualsource_trycreateanimatedvisual_646476001.md) method to retrieve an [IAnimatedVisual](ianimatedvisual.md) object. This `IAnimatedVisual` can then be used to get a [Composition.Visual](../microsoft.ui.composition/visual.md), which can be added to a XAML element tree using the methods of [ElementCompositionPreview](../microsoft.ui.xaml.hosting/elementcompositionpreview.md).

## -see-also

## -examples
