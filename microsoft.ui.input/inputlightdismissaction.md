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

If the window associated with an InputLightDismissAction is destroyed, the InputLightDismissAction object will be implicitly disposed. See the [InputObject](inputobject.md#behavior-when-disposed) for more detail.

## -see-also

## -examples

The following example shows how to create a context-menu-styled AppWindow and close it when the light dismiss event is raised.

```csharp
AppWindow appWindow = AppWindow.Create(AppWindowConfiguration.CreateForContextMenu());
appWindow.Show();

InputLightDismissAction inputLightDismissAction = InputLightDismissAction.GetForWindowId(appWindow.Id);
inputLightDismissAction.Dismissed += (sender, args) => appWindow.Destroy();
```
