---
-api-id: E:Microsoft.UI.Input.InputLightDismissAction.Dismissed
-api-type: winrt event
---

# Microsoft.UI.Input.InputLightDismissAction.Dismissed

<!--
public event Windows.Foundation.TypedEventHandler<Microsoft.UI.Input.InputLightDismissAction,Microsoft.UI.Input.InputLightDismissEventArgs> Dismissed;
-->

## -description

Occurs when the user taps or clicks outside of the associated window.

## -remarks

Examples of actions that trigger the [Dismissed](inputlightdismissaction_dismissed.md) event include the following:

- The window loses activation.
- The user presses the **Esc** key while the window has focus.
- The user presses the **Alt** key while the window has focus.
- The window receives a WM_HOTKEY message.
- The window receives app commands such as APPCOMMAND_BROWSER_HOME, APPCOMMAND_BROWSER_BACKWARD, APPCOMMAND_BROWSER_FORWARD, or APPCOMMAND_BROWSER_REFRESH.

## -see-also

## -examples
