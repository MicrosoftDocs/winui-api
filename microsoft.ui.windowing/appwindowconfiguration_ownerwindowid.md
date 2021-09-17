---
-api-id: P:Microsoft.UI.Windowing.AppWindowConfiguration.OwnerWindowId
-api-type: winrt property
---

# Microsoft.UI.Windowing.AppWindowConfiguration.OwnerWindowId

<!--
public Microsoft.UI.WindowId OwnerWindowId { get; set; }
-->

## -description

Gets or sets the identifier of the owner of this window; or 0 if not owned.

## -property-value

The identifier of the owner of this window; 0 if not owned.

## -remarks

To make this window an owned window, set this property to the [Id](appwindow_id.md) of the window you want to be its owner. The `OwnerWindowId` must be a [WindowId](/uwp/api/windows.ui.windowid) from the same process as the window that has the configuration applied to it.

ContextMenu, Dialog, and ToolWindow configurations require this property to be set when the window is created in order to be applied successfully. If you set or change the [OwnerWindowId](appwindowconfiguration_ownerwindowid.md) on the `AppWindowConfiguration` object at a later time, the [AppWindow.ApplyConfiguration](appwindow_applyconfiguration_2040805655.md) call will fail.

## -see-also

[AppWindowConfiguration](appwindowconfiguration.md)

## -examples
