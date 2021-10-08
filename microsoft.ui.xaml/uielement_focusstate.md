---
-api-id: P:Microsoft.UI.Xaml.UIElement.FocusState
-api-type: winrt property
---

# Microsoft.UI.Xaml.UIElement.FocusState

<!--
public Microsoft.UI.Xaml.FocusState FocusState { get; }
-->

## -description

Gets a value that specifies whether this control has focus, and the mode by which focus was obtained.

## -property-value

A value of the enumeration. A value of **Unfocused** indicates that the control does not have focus.

## -remarks

This property supports controls that use different visual styles depending on whether the control was focused by the keyboard or by other means. Some controls use visual states that show a visible focus indicator if the control was focused by a keyboard action, but do not show the indicator if the control was focused by a pointer action. The internal logic of such a control implements [OnGotFocus](../microsoft.ui.xaml.controls/control_ongotfocus_2110871543.md) and then gets the value of FocusState from the sender. If FocusState is **Keyboard**, then a different named visual state that includes a focus rectangle is loaded, by calling [GoToState](visualstatemanager_gotostate_51722231.md). Typically, focus-related visual states are grouped together in the default control template XAML. Custom controls that want to use different focus visuals depending on the means of focus can implement this same logic themselves. See [OnGotFocus](../microsoft.ui.xaml.controls/control_ongotfocus_2110871543.md).

Another way to use this property is to use [FocusManager](../microsoft.ui.xaml.input/focusmanager.md) to determine which element in the overall UI has focus, and then call this method on that element to get information on how the control received focus.

## -see-also

## -examples
