---
-api-id: M:Microsoft.UI.Input.InputLightDismissAction.GetForWindowId(Microsoft.UI.WindowId)
-api-type: winrt method
---

# Microsoft.UI.Input.InputLightDismissAction.GetForWindowId(Microsoft.UI.WindowId)

<!--
public static Microsoft.UI.Input.InputLightDismissAction GetForWindowId (Microsoft.UI.WindowId windowId);
-->

## -description

Retrieves the [InputLightDismissAction](inputlightdismissaction.md) object for the specified window.

## -parameters

### -param windowId

The window identifier.

## -returns

The InputLightDismissAction object for the specified window. Otherwise, null.

## -remarks

**GetForWindowId** only supports top-level windows on the same thread as the caller.

If *windowId* is invalid, is owned by a different thread than the calling thread, or is a child window, GetForWindowId returns null.

Otherwise, GetForWindowId returns a previously created InputLightDismissAction associated with the Window ID or a newly created InputLightDismissAction associated with the Window ID. Calling GetForWindowId multiple times will return the same object each time.

In all cases there can only be a single InputLightDismissAction associated with a particular Window ID.

## -see-also

[InputLightDismissEventArgs](inputlightdismisseventargs.md)

## -examples
