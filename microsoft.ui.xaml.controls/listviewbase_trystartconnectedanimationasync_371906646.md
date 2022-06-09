---
-api-id: M:Microsoft.UI.Xaml.Controls.ListViewBase.TryStartConnectedAnimationAsync(Microsoft.UI.Xaml.Media.Animation.ConnectedAnimation,System.Object,System.String)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<bool> ListViewBase.TryStartConnectedAnimationAsync(ConnectedAnimation animation, Object item, String elementName)
-->

# Microsoft.UI.Xaml.Controls.ListViewBase.TryStartConnectedAnimationAsync

## -description
Attempts to start the animation.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -parameters
## -param animation
The animation to start.

### -param item
The data item that is animated into view.

### -param elementName
The name of the element in the ItemTemplate that provides the animated visual.

## -returns
**true** if the animation started; **false** if the animation has already been started, if it is no longer active, or if the destination element is the same as the source element.

## -remarks

## -see-also
[ConnectedAnimation.TryStart](./../windows.ui.xaml.media.animation/connectedanimation_trystart_323048605.md)

## -examples

