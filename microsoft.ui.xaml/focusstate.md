---
-api-id: T:Microsoft.UI.Xaml.FocusState
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Xaml.FocusState : int
-->

# FocusState

## -description

Describes how an element obtained focus.

## -enum-fields

### -field Unfocused:0

Element is not currently focused.

### -field Pointer:1

Element obtained focus through a pointer action.

### -field Keyboard:2

Element obtained focus through a keyboard action, such as tab sequence traversal.

### -field Programmatic:3

Element obtained focus through a deliberate call to [Focus](/uwp/api/windows.ui.xaml.controls.control.focus(windows.ui.xaml.focusstate)) or a related API.

## -remarks

FocusState is used as a value by the [Control.FocusState](/uwp/api/windows.ui.xaml.controls.control.focusstate) property. It's also used as an input by the [Control.Focus](/uwp/api/windows.ui.xaml.controls.control.focus(windows.ui.xaml.focusstate)) method.

If used as an input parameter for [Control.Focus](/uwp/api/windows.ui.xaml.controls.control.focus(windows.ui.xaml.focusstate)), you can't use **Unfocused**. Which value of FocusState to pass to a [Control.Focus](/uwp/api/windows.ui.xaml.controls.control.focus(windows.ui.xaml.focusstate)) call depends on the input scenario and which user interaction your control or app code is responding to. For more info, see Remarks in [Control.Focus](/uwp/api/windows.ui.xaml.controls.control.focus(windows.ui.xaml.focusstate)).

The exact meaning of the FocusState values depends on whether you're reading it from [Control.FocusState](/uwp/api/windows.ui.xaml.controls.control.focusstate), or using a value to send to [Control.Focus](/uwp/api/windows.ui.xaml.controls.control.focus(windows.ui.xaml.focusstate)). If you are setting [Control.Focus](/uwp/api/windows.ui.xaml.controls.control.focus(windows.ui.xaml.focusstate)) you're informing other callers (like the control templates) about how that control obtained focus.

## -examples

## -see-also

[Control.FocusState](/uwp/api/windows.ui.xaml.controls.control.focusstate), [Control.Focus](/uwp/api/windows.ui.xaml.controls.control.focus(windows.ui.xaml.focusstate)), [Keyboard interactions](/windows/uwp/input-and-devices/keyboard-interactions)
