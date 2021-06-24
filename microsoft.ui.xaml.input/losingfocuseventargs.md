---
-api-id: T:Microsoft.UI.Xaml.Input.LosingFocusEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class LosingFocusEventArgs : RoutedEventArgs, RoutedEventArgs
-->

# Microsoft.UI.Xaml.Input.LosingFocusEventArgs

## -description

Provides data for the [FocusManager.LosingFocus](focusmanager_losingfocus.md) and [UIElement.LosingFocus](../microsoft.ui.xaml/uielement_losingfocus.md) events.

## -remarks

Only a single UI element at a time can have focus.

A control can lose focus when another control gets focus, the application view changes, the user switches applications, or the user interacts with the system such that the application is no longer in the foreground.

## -see-also

 [LosingFocusEvent](uielement_losingfocusevent.md), [LosingFocus](uielement_losingfocus.md), [LostFocus](uielement_lostfocus.md), [Control.Focus](/uwp/api/windows.ui.xaml.controls.control.focus(windows.ui.xaml.focusstate)), [AddHandler](uielement_addhandler_2121467075.md), [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview), [Keyboard interactions](/windows/apps/design/input/keyboard-interactions), [Focus navigation for keyboard, gamepad, remote control, and accessibility tools](/windows/apps/design/input/focus-navigation), [Programmatic focus navigation](/windows/apps/design/input/focus-navigation-programmatic)


## -examples

