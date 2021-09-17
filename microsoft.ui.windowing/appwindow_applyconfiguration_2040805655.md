---
-api-id: M:Microsoft.UI.Windowing.AppWindow.ApplyConfiguration(Microsoft.UI.Windowing.AppWindowConfiguration)
-api-type: winrt method
---

# Microsoft.UI.Windowing.AppWindow.ApplyConfiguration(Microsoft.UI.Windowing.AppWindowConfiguration)

<!--
public void ApplyConfiguration (Microsoft.UI.Windowing.AppWindowConfiguration appWindowConfiguration);
-->

## -description

Configures the window to a set of selected properties as defined in the specified `AppWindowConfiguration`.

## -parameters

### -param appWindowConfiguration

An `AppWindowConfiguration` object that specifies property values to apply to the window.

## -remarks

You can use this method to override any individually configurable properties of the window even after a specific templated configuration has been used.

If you want to set an owner for a ContextMenu, Dialog, or ToolWindow, you have to do so at the time of creating your [AppWindow](appwindow.md). If you set or change the [OwnerWindowId](appwindowconfiguration_ownerwindowid.md) on the `AppWindowConfiguration` object at a later time, the `ApplyConfiguration` call will fail.

## -see-also

[AppWindow](appwindow.md), [AppWindow.Configuration](appwindow_configuration.md)

## -examples
