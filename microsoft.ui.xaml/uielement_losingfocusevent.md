---
-api-id: P:Microsoft.UI.Xaml.UIElement.LosingFocusEvent
-api-type: winrt property
---

<!-- Property syntax.
public RoutedEvent LosingFocusEvent { get; }
-->

# Microsoft.UI.Xaml.UIElement.LosingFocusEvent

## -description

Gets the identifier for the [LosingFocus](uielement_losingfocus.md) routed event.

## -property-value

The identifier for the [LosingFocus](uielement_losingfocus.md) routed event.

## -remarks

We recommend using the [UIElement](../microsoft.ui.xaml/uielement.md) focus routed events instead of [FocusManager](../microsoft.ui.xaml.input/focusmanager.md) events whenever possible.

Only a single UI element at a time can have focus.

A control can lose focus when another control gets focus, the application view changes, the user switches applications, or the user interacts with the system such that the application is no longer in the foreground.

## -examples

## -see-also

[LosingFocusEventArgs](../microsoft.ui.xaml.input/losingfocuseventargs.md), [LosingFocus](uielement_losingfocus.md), [LostFocus](uielement_lostfocus.md), [GotFocus](uielement_gotfocus.md), [GettingFocusEvent](uielement_gettingfocusevent.md), [GettingFocus](uielement_gettingfocus.md), [Control.Focus](/uwp/api/windows.ui.xaml.controls.control.focus(windows.ui.xaml.focusstate)), [AddHandler](uielement_addhandler_1350394113.md), [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview), [Keyboard interactions](/windows/apps/design/input/keyboard-interactions), [Focus navigation for keyboard, gamepad, remote control, and accessibility tools](/windows/apps/design/input/focus-navigation), [Programmatic focus navigation](/windows/apps/design/input/focus-navigation-programmatic)
