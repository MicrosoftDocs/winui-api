---
-api-id: P:Microsoft.UI.Xaml.VisualStateGroup.CurrentState
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.VisualState CurrentState { get; }
-->

# Microsoft.UI.Xaml.VisualStateGroup.CurrentState

## -description
Gets the most recently set [VisualState](visualstate.md) from a successful call to the [GoToState](visualstatemanager_gotostate_51722231.md) method.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -property-value
The most recently set [VisualState](visualstate.md) from a successful call to the [GoToState](visualstatemanager_gotostate_51722231.md) method, or **null**.

## -remarks
If [GoToState](visualstatemanager_gotostate_51722231.md) has never been called for the states in a particular [VisualStateGroup](visualstategroup.md), CurrentState is **null**. With correct design of controls and visual state, this shouldn't happen. The control logic for a control should always be able to select one state from a given [VisualStateGroup](visualstategroup.md), even if that state is a named state with no specific storyboarded behavior.

Because there are potentially multiple [VisualStateGroup](visualstategroup.md) sets of visual states for a control, each such [VisualStateGroup](visualstategroup.md) can report a CurrentState. For example, if you click on a [Button](../microsoft.ui.xaml.controls/button.md) with a default control template, the "CommonStates"  [VisualStateGroup](visualstategroup.md) reports a CurrentState of "Pressed", and the "FocusStates"  [VisualStateGroup](visualstategroup.md) reports a CurrentState of "PointerFocused".

## -examples

## -see-also
[VisualState](visualstate.md), [GoToState](visualstatemanager_gotostate_51722231.md), [CurrentStateChanged](visualstategroup_currentstatechanged.md), [Quickstart: Control templates](/previous-versions/windows/apps/hh465374(v=win.10))
