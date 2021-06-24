---
-api-id: T:Microsoft.UI.Xaml.Controls.AnimatedIconSource
-api-type: winrt class
---

# Microsoft.UI.Xaml.Controls.AnimatedIconSource

<!--
public class AnimatedIconSource : Microsoft.UI.Xaml.Controls.IconSource
-->

## -description

Represents a shareable object used to create an icon that displays and controls a visual that can animate in response to user interaction and visual state changes.

## -remarks

> [!NOTE]
> `AnimatedIconSource` is similar to [AnimatedIcon](animatedicon.md). However, because it is not a [FrameworkElement](/uwp/api/windows.ui.xaml.frameworkelement), it can be shared.

You don't set the state directly on an `AnimatedIconSource`. Instead, set the [AnimatedIcon.State](animatedicon_state.md) attached property on an ancestor element of the `AnimatedIconSource`.

## -examples

> [!Tip]
> For more info, design guidance, and code examples, see the [Animated icon](/windows/apps/design/controls/animated-icon) guidance topic.
>
> If you have the **XAML Controls Gallery** app installed, [open the app to see the controls in action](xamlcontrolsgallery:).
>
> If you don't have the XAML Controls Gallery app installed, get the WinUI 2.x version from the [Microsoft Store](https://www.microsoft.com/p/xaml-controls-gallery/9msvh128x2zt).
>
> You can also view, clone, and build the XAML Controls Gallery source code from [GitHub](https://github.com/Microsoft/Xaml-Controls-Gallery) (switch to the [WinUI 3 Preview branch](https://github.com/microsoft/Xaml-Controls-Gallery/tree/winui3preview) for WinUI 3 Preview controls and features).

## -see-also

[Animated icon overview](/windows/apps/design/controls/animated-icon), [AnimatedVisualPlayer](animatedvisualplayer.md), [VisualStateManager](../microsoft.ui.xaml/visualstatemanager.md), [Lottie-Windows](/windows/communitytoolkit/animations/lottie), [IAnimatedVisual2](ianimatedvisual2.md)
