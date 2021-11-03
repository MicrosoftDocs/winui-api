---
-api-id: T:Microsoft.UI.Input.InputLightDismissAction
-api-type: winrt class
---

# Microsoft.UI.Input.InputLightDismissAction

<!--
public sealed class InputLightDismissAction : Microsoft.UI.Input.InputObject
-->

## -description

Enables dismissal of the current window based on the detection of interaction events anywhere outside of the current window or from specific keyboard input.

## -remarks

Examples of actions that trigger a light dismiss include:

- The window loses activation.
- The user presses the 'escape' key while the window has focus.
- The user presses the 'alt' key while the window has focus.
- The window receives app commands such as `APPCOMMAND_BROWSER_HOME`, `APPCOMMAND_BROWSER_BACKWARD`, `APPCOMMAND_BROWSER_FORWARD`, or `APPCOMMAND_BROWSER_REFRESH`.
- The window receives a `WM_HOTKEY` message.

If the window associated with an InputLightDismissAction is destroyed, the InputLightDismissAction object will be implicitly disposed. See [InputObject](inputobject.md) for more detail.

## -see-also

## -examples

The following example shows how to create a context-menu-styled  AppWindow and close it when the light dismiss event is raised.

```csharp
AppWindow appWindow = AppWindow.Create(AppWindowConfiguration.CreateForContextMenu());
appWindow.Show();

InputLightDismissAction inputLightDismissAction = InputLightDismissAction.GetForWindowId(appWindow.Id);
inputLightDismissAction.Dismissed += (sender, args) => appWindow.Destroy();
```
