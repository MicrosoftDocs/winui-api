---
-api-id: P:Microsoft.UI.Xaml.UIElement.GettingFocusEvent
-api-type: winrt property
---

<!-- Property syntax.
public RoutedEvent GettingFocusEvent { get; }
-->

# Microsoft.UI.Xaml.UIElement.GettingFocusEvent

## -description

Gets the identifier for the [GettingFocus](uielement_gettingfocus.md) routed event.

## -property-value

The identifier for the [GettingFocus](uielement_gettingfocus.md) routed event.

## -remarks

We recommend using the [UIElement](../microsoft.ui.xaml/uielement.md) focus routed events instead of [FocusManager](../microsoft.ui.xaml.input/focusmanager.md) events whenever possible.

Only a single UI element at a time can have focus.

A control can get focus when another control loses focus, the application view changes, the user switches applications, or the user interacts with the system such that the application is no longer in the foreground.

## -examples

## -see-also

[GettingFocusEventArgs](../microsoft.ui.xaml.input/gettingfocuseventargs.md), [GettingFocus](uielement_gettingfocus.md), [GotFocus](uielement_gotfocus.md), [LostFocus](uielement_lostfocus.md), [LosingFocusEvent](uielement_losingfocusevent.md), [LosingFocus](uielement_losingfocus.md), [Control.Focus](/uwp/api/windows.ui.xaml.controls.control.focus(windows.ui.xaml.focusstate)), [AddHandler](uielement_addhandler_1350394113.md), [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview), [Keyboard interactions](/windows/apps/design/input/keyboard-interactions), [Focus navigation for keyboard, gamepad, remote control, and accessibility tools](/windows/apps/design/input/focus-navigation), [Programmatic focus navigation](/windows/apps/design/input/focus-navigation-programmatic)
