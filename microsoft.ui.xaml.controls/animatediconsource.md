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

> [!TIP]
> For more info, design guidance, and code examples, see [Animated icon](/windows/apps/design/controls/animated-icon).
>
> The **WinUI 3 Gallery** and **WinUI 2 Gallery** apps include interactive examples of most WinUI 3 and WinUI 2 controls, features, and functionality.
>
> If installed already, open them by clicking the following links: [**WinUI 3 Gallery**](winui3gallery:/item/AnimatedIcon) or [**WinUI 2 Gallery**](winui2gallery:/item/AnimatedIcon).
>
> If they are not installed, you can download the [**WinUI 3 Gallery**](https://www.microsoft.com/store/productId/9P3JFPWWDZRC) and the [**WinUI 2 Gallery**](https://www.microsoft.com/store/productId/9MSVH128X2ZT) from the Microsoft Store.
>
> You can also get the source code for both from [GitHub](https://github.com/Microsoft/WinUI-Gallery) (use the *main* branch for WinUI 3 and the *winui2* branch for WinUI 2).

## -see-also

[Animated icon overview](/windows/apps/design/controls/animated-icon), [AnimatedVisualPlayer](animatedvisualplayer.md), [VisualStateManager](../microsoft.ui.xaml/visualstatemanager.md), [Lottie-Windows](/windows/communitytoolkit/animations/lottie), [IAnimatedVisual2](ianimatedvisual2.md)
