---
-api-id: E:Microsoft.UI.Xaml.UIElement.LosingFocus
-api-type: winrt event
---

<!-- Event syntax.
public event TypedEventHandler LosingFocus<UIElement, LosingFocusEventArgs>
-->

# Microsoft.UI.Xaml.UIElement.LosingFocus

## -description

Occurs before a [UIElement](uielement.md) loses focus. This event is raised synchronously to ensure focus isn't moved while the event is bubbling.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -xaml-syntax

```xaml
<uiElement LosingFocus="eventhandler"/>
```

## -remarks

We recommend using the [UIElement](../microsoft.ui.xaml/uielement.md) focus routed events instead of [FocusManager](../microsoft.ui.xaml.input/focusmanager.md) events whenever possible.

Only a single UI element at a time can have focus.

A control can lose focus when another control gets focus, the application view changes, the user switches applications, or the user interacts with the system such that the application is no longer in the foreground.

When programmatically navigating between elements, [FocusNavigationDirection.Previous](../microsoft.ui.xaml.input/focusnavigationdirection.md) and [FocusNavigationDirection.Next](../microsoft.ui.xaml.input/focusnavigationdirection.md) cannot be used with [FindNextElementOptions](../microsoft.ui.xaml.input/findnextelementoptions.md). Only [FocusNavigationDirection.Up](../microsoft.ui.xaml.input/focusnavigationdirection.md), [FocusNavigationDirection.Down](../microsoft.ui.xaml.input/focusnavigationdirection.md), [FocusNavigationDirection.Left](../microsoft.ui.xaml.input/focusnavigationdirection.md), or [FocusNavigationDirection.Right](../microsoft.ui.xaml.input/focusnavigationdirection.md) are valid.

LosingFocus is a routed event. For more info on the routed event concept, see [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview).

## -see-also

[LosingFocusEventArgs](../microsoft.ui.xaml.input/losingfocuseventargs.md), [LostFocus](uielement_lostfocus.md), [LosingFocusEvent](uielement_losingfocusevent.md), [GotFocus](uielement_gotfocus.md), [GettingFocusEvent](uielement_gettingfocusevent.md), [GettingFocus](uielement_gettingfocus.md), [Control.Focus](/uwp/api/windows.ui.xaml.controls.control.focus(windows.ui.xaml.focusstate)), [AddHandler](uielement_addhandler_1350394113.md), [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview), [Keyboard interactions](/windows/apps/design/input/keyboard-interactions), [Focus navigation for keyboard, gamepad, remote control, and accessibility tools](/windows/apps/design/input/focus-navigation), [Programmatic focus navigation](/windows/apps/design/input/focus-navigation-programmatic)

## -examples
