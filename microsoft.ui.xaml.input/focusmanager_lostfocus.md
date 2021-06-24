---
-api-id: E:Microsoft.UI.Xaml.Input.FocusManager.LostFocus
-api-type: winrt event
---

<!-- Event syntax.
static public event EventHandler LostFocus<FocusManagerLostFocusEventArgs>
-->

# Microsoft.UI.Xaml.Input.FocusManager.LostFocus

## -description

Occurs when an element within a container element (a focus scope) loses focus. This event is raised asynchronously, so focus might move again before bubbling is complete.

## -remarks

We recommend using the [UIElement](../microsoft.ui.xaml/uielement.md) focus routed events instead of [FocusManager](focusmanager.md) events whenever possible.

UIElement focus events bubble up to the FocusManager in the following order:

1. [UIElement.LosingFocus](../microsoft.ui.xaml/uielement_losingfocus.md)/[FocusManager.LosingFocus](focusmanager_losingfocus.md)
2. [UIElement.GettingFocus](../microsoft.ui.xaml/uielement_gettingfocus.md)/[FocusManager.GettingFocus](focusmanager_gettingfocus.md)
3. [UIElement.LostFocus](../microsoft.ui.xaml/uielement_lostfocus.md) routed event is raised by the element that lost focus and the event bubbles up
4. FocusManager.LostFocus is raised (even if the routed event is marked handled)
5. [UIElement.GotFocus](../microsoft.ui.xaml/uielement_gotfocus.md) routed event is raised by the element that received focus and the event bubbles up
6. [FocusManager.GotFocus](focusmanager_gotfocus.md) is raised (even if the routed event is marked handled)

## -see-also

[LostFocus](../microsoft.ui.xaml/uielement_lostfocus.md), [Keyboard interactions](/windows/apps/design/input/keyboard-interactions), [Focus navigation for keyboard, gamepad, remote control, and accessibility tools](/windows/apps/design/input/focus-navigation), [Programmatic focus navigation](/windows/apps/design/input/focus-navigation-programmatic)

## -examples
