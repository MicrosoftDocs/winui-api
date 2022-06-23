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

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -remarks

> [!NOTE]
> `AnimatedIconSource` is similar to [AnimatedIcon](animatedicon.md). However, because it is not a [FrameworkElement](/uwp/api/windows.ui.xaml.frameworkelement), it can be shared.

You don't set the state directly on an `AnimatedIconSource`. Instead, set the [AnimatedIcon.State](animatedicon_state.md) attached property on an ancestor element of the `AnimatedIconSource`.

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Animated icon](/windows/apps/design/controls/animated-icon).

> [!div class="nextstepaction"]
> [Open the WinUI 2 Gallery app and see the AnimatedIcon in action](winui2gallery:/item/AnimatedIcon).

> The **WinUI 2 Gallery** app includes interactive examples of most WinUI 2 controls, features, and functionality. Get the app from the [Microsoft Store](https://www.microsoft.com/store/productId/9MSVH128X2ZT) or get the source code on [GitHub](https://github.com/Microsoft/WinUI-Gallery/tree/winui2).



## -see-also

[Animated icon overview](/windows/apps/design/controls/animated-icon), [AnimatedVisualPlayer](animatedvisualplayer.md), [VisualStateManager](../microsoft.ui.xaml/visualstatemanager.md), [Lottie-Windows](/windows/communitytoolkit/animations/lottie), [IAnimatedVisual2](ianimatedvisual2.md)
