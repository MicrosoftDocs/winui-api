---
-api-id: T:Microsoft.UI.Windowing.FullScreenPresenter
-api-type: winrt class
---

# Microsoft.UI.Windowing.FullScreenPresenter

<!--
public sealed class FullScreenPresenter : Microsoft.UI.Windowing.AppWindowPresenter
-->

## -description

Displays an app window using a full-screen configuration.

## -remarks

Full-screen mode is not the same as maximized. When an app is in full-screen mode, it takes up the entirety of the screen. System elements, like title bars, status bars, or the taskbar, are hidden by default. The user can swipe from the bottom to invoke the taskbar, from the left to invoke Task View, from the right to invoke Action Center, and from the top to invoke the title bar. You can suppress edge swipes by setting [IsExclusive](fullscreenpresenter_isexclusive.md) to true.

When the user switches away from the app to use another app, the full-screen nature of the app is preserved. When the user switches to the app again, it is full-screen.

## -see-also

## -examples
