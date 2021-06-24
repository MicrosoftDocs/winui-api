---
-api-id: E:Microsoft.UI.Xaml.UIElement.LostFocus
-api-type: winrt event
---

<!-- Event syntax
public event Windows.UI.Xaml.RoutedEventHandler LostFocus
-->

# Microsoft.UI.Xaml.UIElement.LostFocus

## -description

Occurs when a [UIElement](uielement.md) loses focus. This event is raised asynchronously, so focus can move again before bubbling is complete.

## -xaml-syntax

```xaml
<uiElement LostFocus="eventhandler"/>
```

## -remarks

We recommend using the [UIElement](../microsoft.ui.xaml/uielement.md) focus routed events instead of [FocusManager](../microsoft.ui.xaml.input/focusmanager.md) events whenever possible.

Only a single UI element at a time can have focus.

A control can lose focus when another control gets focus, the application view changes, the user switches applications, or the user interacts with the system such that the application is no longer in the foreground.

LostFocus is raised before [GotFocus](uielement_gotfocus.md).

Keyboard focus is particularly relevant for keyboard event handling, because only the currently keyboard-focused [UIElement](uielement.md) can be the source of the [KeyUp](uielement_keyup.md) and [KeyDown](uielement_keydown.md) key events. Applications might call [Focus](/uwp/api/windows.ui.xaml.controls.control.focus(windows.ui.xaml.focusstate)) as an initialization action so that the key events in the app as a whole can be used to detect access or accelerator keys. For more info, see [Keyboard interactions](/windows/uwp/input-and-devices/keyboard-interactions).

LostFocus is a routed event. For more info on how class-based handling for events works, see [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview).

Specific Windows Runtime controls may have class-based handling for the LostFocus event. If so, the control probably has an override for the method [OnLostFocus](/uwp/api/windows.ui.xaml.controls.control.onlostfocus(windows.ui.xaml.routedeventargs)). Typically the event is marked handled by the class handler, and the LostFocus event is not raised for handling by any user code handlers on that control. Controls might handle the event in order to unload a visual state that displayed a focus rectangle in response to [OnGotFocus](/uwp/api/windows.ui.xaml.controls.control.ongotfocus(windows.ui.xaml.routedeventargs)).

A control's focus rectangle is an important visual component that aids accessibility by identifying the current focused element and indicating where the user is within the tab sequence of the application UI. In some cases, the [FocusState](focusstate.md) of the focus action is relevant for whether a visible focus indicator should display.

For more info on tab sequences and accessibility, see [Keyboard accessibility](/windows/uwp/accessibility/keyboard-accessibility).

## -examples

## -see-also

[RoutedEventArgs](routedeventargs.md), [LosingFocus](uielement_losingfocus.md), [LosingFocusEvent](uielement_losingfocusevent.md), [GotFocus](uielement_gotfocus.md), [GettingFocusEvent](uielement_gettingfocusevent.md), [GettingFocus](uielement_gettingfocus.md), [Control.Focus](/uwp/api/windows.ui.xaml.controls.control.focus(windows.ui.xaml.focusstate)), [AddHandler](uielement_addhandler_1350394113.md), [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview), [Keyboard interactions](/windows/apps/design/input/keyboard-interactions), [Focus navigation for keyboard, gamepad, remote control, and accessibility tools](/windows/apps/design/input/focus-navigation), [Programmatic focus navigation](/windows/apps/design/input/focus-navigation-programmatic)
