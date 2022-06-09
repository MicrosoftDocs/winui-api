---
-api-id: M:Microsoft.UI.Xaml.Controls.AnimatedVisualPlayer.SetProgress(System.Double)
-api-type: winrt method
---

<!-- Method syntax.
public void AnimatedVisualPlayer.SetProgress(Double progress)
-->

# Microsoft.UI.Xaml.Controls.AnimatedVisualPlayer.SetProgress

## -description

Moves the progress of the animated visual to the given value, or does nothing if no animated visual is loaded.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -parameters

### -param progress

A value from 0 to 1 that represents the progress of the animated visual.

## -remarks

If the animated visual was playing it will behave as if [Stop](animatedvisualplayer_stop_1201535524.md) was called first.

## -see-also

## -examples

