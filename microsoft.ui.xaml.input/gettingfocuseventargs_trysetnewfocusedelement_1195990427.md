---
-api-id: M:Microsoft.UI.Xaml.Input.GettingFocusEventArgs.TrySetNewFocusedElement(Microsoft.UI.Xaml.DependencyObject)
-api-type: winrt method
---

<!-- Method syntax.
public bool GettingFocusEventArgs.TrySetNewFocusedElement(DependencyObject element)
-->

# Microsoft.UI.Xaml.Input.GettingFocusEventArgs.TrySetNewFocusedElement

## -description
Attempts to redirect focus to the specified element instead of the original targeted element.

## -parameters
### -param element
The object on which to set focus.

## -returns
True, if the focus action is redirected; otherwise, false.

## -remarks
The [GotFocus](../microsoft.ui.xaml/uielement_gotfocus.md) routed event is raised on an element after it receives focus, while the [LostFocus](../microsoft.ui.xaml/uielement_lostfocus.md) routed event is raised on an element after it loses focus. 

The [GettingFocus](../microsoft.ui.xaml/uielement_gettingfocus.md) and [LosingFocus](../microsoft.ui.xaml/uielement_losingfocus.md) routed events occur before the focus change takes place, which enables your application to modify or cancel the focus change behavior.   

[GettingFocus](../microsoft.ui.xaml/uielement_gettingfocus.md) and [LosingFocus](../microsoft.ui.xaml/uielement_losingfocus.md) are raised synchronously, while [GotFocus](../microsoft.ui.xaml/uielement_gotfocus.md) and [LostFocus](../microsoft.ui.xaml/uielement_lostfocus.md) are raised asynchronously. For example, if your app calls the [Focus](../windows.ui.xaml.controls.control#Windows_UI_Xaml_Controls_Control_Focus_Windows_UI_Xaml_FocusState_) method of a control, GettingFocus is raised during the call, but GotFocus is raised after the call completes. 

If focus is moved while these events are still bubbling, an exception is thrown.

## -see-also

[GettingFocusEventArgs.TryCancel](gettingfocuseventargs_trycancel_50138317.md), [Keyboard interactions](/windows/apps/design/input/keyboard-interactions), [Focus navigation for keyboard, gamepad, remote control, and accessibility tools](/windows/apps/design/input/focus-navigation), [Programmatic focus navigation](/windows/apps/design/input/focus-navigation-programmatic)

## -examples

