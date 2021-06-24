---
-api-id: M:Microsoft.UI.Xaml.Input.GettingFocusEventArgs.TryCancel
-api-type: winrt method
---

<!-- Method syntax.
public bool GettingFocusEventArgs.TryCancel()
-->

# Microsoft.UI.Xaml.Input.GettingFocusEventArgs.TryCancel

## -description
Attempts to cancel the ongoing focus action.

## -returns
True, if the focus action is canceled; otherwise, false.

## -remarks
Apps that target Windows 10, version 1803 or later should use this property instead of [Cancel](gettingfocuseventargs_cancel.md). If your app also supports previous versions, see [Version adaptive apps: Use new APIs while maintaining compatibility with previous versions](/windows/uwp/debug-test-perf/version-adaptive-apps) for more info.

The [GotFocus](../microsoft.ui.xaml/uielement_gotfocus.md) routed event is raised on an element after it receives focus, while the [LostFocus](../microsoft.ui.xaml/uielement_lostfocus.md) routed event is raised on an element after it loses focus. 

The [GettingFocus](../microsoft.ui.xaml/uielement_gettingfocus.md) and [LosingFocus](../microsoft.ui.xaml/uielement_losingfocus.md) routed events occur before the focus change takes place, which enables your application to modify or cancel the focus change behavior.   

[GettingFocus](../microsoft.ui.xaml/uielement_gettingfocus.md) and [LosingFocus](../microsoft.ui.xaml/uielement_losingfocus.md) are raised synchronously, while [GotFocus](../microsoft.ui.xaml/uielement_gotfocus.md) and [LostFocus](../microsoft.ui.xaml/uielement_lostfocus.md) are raised asynchronously. For example, if your app calls the [Focus](../windows.ui.xaml.controls.control#Windows_UI_Xaml_Controls_Control_Focus_Windows_UI_Xaml_FocusState_) method of a control, GettingFocus is raised during the call, but GotFocus is raised after the call completes. 

If focus is moved while these events are still bubbling, an exception is thrown.

## -see-also
[GettingFocusEventArgs.TrySetNewFocusedElement](gettingfocuseventargs_trysetnewfocusedelement_1195990427.md), [Keyboard interactions](/windows/apps/design/input/keyboard-interactions), [Focus navigation for keyboard, gamepad, remote control, and accessibility tools](/windows/apps/design/input/focus-navigation), [Programmatic focus navigation](/windows/apps/design/input/focus-navigation-programmatic)


## -examples

