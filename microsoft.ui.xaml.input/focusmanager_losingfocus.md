---
-api-id: E:Microsoft.UI.Xaml.Input.FocusManager.LosingFocus
-api-type: winrt event
---

<!-- Event syntax.
static public event EventHandler LosingFocus<LosingFocusEventArgs>
-->

# Microsoft.UI.Xaml.Input.FocusManager.LosingFocus

## -description

Occurs before focus moves from the current element with focus to the target element. This event is raised synchronously to ensure focus isn't moved while the event is bubbling.

## -xaml-syntax

```xaml
<uiElement LosingFocus="eventhandler"/>
```

## -remarks

We recommend using the [UIElement](../microsoft.ui.xaml/uielement.md) focus routed events instead of [FocusManager](focusmanager.md) events whenever possible.

[FocusNavigationDirection.Previous](focusnavigationdirection.md) and [FocusNavigationDirection.Next](focusnavigationdirection.md) cannot be used with [FindNextElementOptions](findnextelementoptions.md). Only [FocusNavigationDirection.Up](focusnavigationdirection.md), [FocusNavigationDirection.Down](focusnavigationdirection.md), [FocusNavigationDirection.Left](focusnavigationdirection.md), or [FocusNavigationDirection.Right](focusnavigationdirection.md) are supported.

UIElement focus events bubble up to the FocusManager in the following order:

1. [UIElement.LosingFocus](../microsoft.ui.xaml/uielement_losingfocus.md)/FocusManager.LosingFocus
2. [UIElement.GettingFocus](../microsoft.ui.xaml/uielement_gettingfocus.md)/[FocusManager.GettingFocus](focusmanager_gettingfocus.md)
3. [UIElement.LostFocus](../microsoft.ui.xaml/uielement_lostfocus.md) routed event is raised by the element that lost focus and the event bubbles up
4. [FocusManager.LostFocus](focusmanager_lostfocus.md) is raised (even if the routed event is marked handled)
5. [UIElement.GotFocus](../microsoft.ui.xaml/uielement_gotfocus.md) routed event is raised by the element that received focus and the event bubbles up
6. [FocusManager.GotFocus](focusmanager_gotfocus.md) is raised (even if the routed event is marked handled)

## -see-also

[LosingFocusEventArgs](../microsoft.ui.xaml.input/losingfocuseventargs.md), [UIElement.LosingFocus](../microsoft.ui.xaml/uielement_losingfocus.md), [UIElement.LosingFocusEvent](../microsoft.ui.xaml/uielement_losingfocusevent.md), [Keyboard interactions](/windows/apps/design/input/keyboard-interactions), [Focus navigation for keyboard, gamepad, remote control, and accessibility tools](/windows/apps/design/input/focus-navigation), [Programmatic focus navigation](/windows/apps/design/input/focus-navigation-programmatic)

## -examples
