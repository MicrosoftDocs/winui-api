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

Element obtained focus through a deliberate call to [UIElement.Focus(Microsoft.UI.Xaml.FocusState)](uielement_focus_1914077590.md) or a related API.

## -remarks

If used as an input parameter for [UIElement.Focus(Microsoft.UI.Xaml.FocusState)](uielement_focus_1914077590.md), you can't use **Unfocused**. The FocusState value to pass to a [UIElement.Focus(Microsoft.UI.Xaml.FocusState)](uielement_focus_1914077590.md) call depends on the input scenario and which user interaction your control or app code is responding to.

The exact meaning of the FocusState values depends on whether you're reading it from [UIElement.FocusState](uielement_focusstate.md), or using a value to send to [UIElement.Focus(Microsoft.UI.Xaml.FocusState)](uielement_focus_1914077590.md). If you are setting [UIElement.Focus(Microsoft.UI.Xaml.FocusState)](uielement_focus_1914077590.md) you're informing other callers (like the control templates) about how that control obtained focus.

## -examples

## -see-also

[UIElement.FocusState](uielement_focusstate.md), [Hyperlink.FocusState](../microsoft.ui.xaml.documents/hyperlink_focusstate.md), [Keyboard interactions](/windows/uwp/input-and-devices/keyboard-interactions)
