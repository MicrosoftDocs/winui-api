---
-api-id: T:Microsoft.UI.Xaml.Input.GettingFocusEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class GettingFocusEventArgs : RoutedEventArgs, RoutedEventArgs
-->

# Microsoft.UI.Xaml.Input.GettingFocusEventArgs

## -description

Provides data for the [FocusManager.GettingFocus](focusmanager_gettingfocus.md) and [UIElement.GettingFocus](../microsoft.ui.xaml/uielement_gettingfocus.md) events.

## -remarks

Only a single UI element at a time can have focus.

A control can get focus when another control loses focus, the application view changes, the user switches applications, or the user interacts with the system such that the application is no longer in the foreground.

## -see-also

 [GettingFocusEvent](uielement_gettingfocusevent.md), [GettingFocus](uielement_gettingfocus.md), [GotFocus](uielement_gotfocus.md), [Control.Focus](/uwp/api/windows.ui.xaml.controls.control.focus(windows.ui.xaml.focusstate)), [AddHandler](uielement_addhandler_2121467075.md), [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview), [Keyboard interactions](/windows/apps/design/input/keyboard-interactions), [Focus navigation for keyboard, gamepad, remote control, and accessibility tools](/windows/apps/design/input/focus-navigation), [Programmatic focus navigation](/windows/apps/design/input/focus-navigation-programmatic)

## -examples
