---
-api-id: E:Microsoft.UI.Xaml.Window.Activated
-api-type: winrt event
---

<!-- Event syntax
public event Windows.UI.Xaml.WindowActivatedEventHandler Activated
-->

# Microsoft.UI.Xaml.Window.Activated

## -description

Occurs when the window has successfully been activated.

## -remarks

This event occurs when a [Window](window.md) has been activated or deactivated by the system. An app can determine what the status of the [Window](window.md) activation is by checking the [WindowActivatedEventArgs.WindowActivationState](/uwp/api/windows.ui.core.windowactivatedeventargs.windowactivationstate) property. A [Window](window.md) could be visible on screen but not be active (for example, in snapped apps). Additionally, if any other parts of the system takes focus away from the window, this event will occur. This could happen as a result of user interaction or code, and the [WindowActivationState](/uwp/api/windows.ui.core.windowactivatedeventargs.windowactivationstate) will indicate which action has taken place.

## -examples

The following code example demonstrates a typical usage pattern for this event.

```csharp
void Current_Activated(object sender, WindowActivatedEventArgs e)
{
    if (e.WindowActivationState == WindowActivationState.Deactivated)
    {
        // Show the "paused" UI. 
        VisualStateManager.GoToState(this, "PauseUI", false);
    }
    else if (e.WindowActivationState == WindowActivationState.PointerActivated 
    || e.WindowActivationState == WindowActivationState.CodeActivated)
    {
        // Show the "active" UI. 
        VisualStateManager.GoToState(this, "ActivateUI", false);
    }
}

```

## -see-also

[WindowActivatedEventArgs](windowactivatedeventargs.md)