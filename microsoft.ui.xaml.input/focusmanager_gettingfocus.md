---
-api-id: E:Microsoft.UI.Xaml.Input.FocusManager.GettingFocus
-api-type: winrt event
---

<!-- Event syntax.
static public event EventHandler GettingFocus<GettingFocusEventArgs>
-->

# Microsoft.UI.Xaml.Input.FocusManager.GettingFocus

## -description

Occurs before an element actually receives focus. This event is raised synchronously to ensure focus isn't moved while the event is bubbling.

## -remarks

We recommend using the [UIElement](../microsoft.ui.xaml/uielement.md) focus routed events instead of [FocusManager](focusmanager.md) events whenever possible.

[FocusNavigationDirection.Previous](focusnavigationdirection.md) and [FocusNavigationDirection.Next](focusnavigationdirection.md) cannot be used with [FindNextElementOptions](findnextelementoptions.md). Only [FocusNavigationDirection.Up](focusnavigationdirection.md), [FocusNavigationDirection.Down](focusnavigationdirection.md), [FocusNavigationDirection.Left](focusnavigationdirection.md), or [FocusNavigationDirection.Right](focusnavigationdirection.md) are valid.

UIElement focus events bubble up to the FocusManager in the following order:

1. [UIElement.LosingFocus](../microsoft.ui.xaml/uielement_losingfocus.md)/[FocusManager.LosingFocus](focusmanager_losingfocus.md)
2. [UIElement.GettingFocus](../microsoft.ui.xaml/uielement_gettingfocus.md)/FocusManager.GettingFocus
3. [UIElement.LostFocus](../microsoft.ui.xaml/uielement_lostfocus.md) routed event is raised by the element that lost focus and the event bubbles up
4. [FocusManager.LostFocus](focusmanager_lostfocus.md) is raised (even if the routed event is marked handled)
5. [UIElement.GotFocus](../microsoft.ui.xaml/uielement_gotfocus.md) routed event is raised by the element that received focus and the event bubbles up
6. [FocusManager.GotFocus](focusmanager_gotfocus.md) is raised (even if the routed event is marked handled)

## -see-also

[GettingFocusEventArgs](../microsoft.ui.xaml.input/gettingfocuseventargs.md), [UIElement.GettingFocus](../microsoft.ui.xaml/uielement_gettingfocus.md), [UIElement.GettingFocusEvent](../microsoft.ui.xaml/uielement_gettingfocusevent.md), [Keyboard interactions](/windows/apps/design/input/keyboard-interactions), [Focus navigation for keyboard, gamepad, remote control, and accessibility tools](/windows/apps/design/input/focus-navigation), [Programmatic focus navigation](/windows/apps/design/input/focus-navigation-programmatic)

## -examples

