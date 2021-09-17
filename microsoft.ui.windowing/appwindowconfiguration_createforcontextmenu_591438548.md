---
-api-id: M:Microsoft.UI.Windowing.AppWindowConfiguration.CreateForContextMenu
-api-type: winrt method
---

# Microsoft.UI.Windowing.AppWindowConfiguration.CreateForContextMenu

<!--
public static Microsoft.UI.Windowing.AppWindowConfiguration CreateForContextMenu ();
-->

## -description

Creates a configuration object pre-populated with the values for a context menu.

## -returns

A configuration object pre-populated with the values for a context menu.

## -remarks

This table shows how configuration properties are set when you create an `AppWindowConfiguration` object from the `CreateForContextMenu` method.

| Configuration property | Value |
| -- | -- |
| [HasFrame](appwindowconfiguration_hasframe.md) | `true` |
| [HasTitleBar](appwindowconfiguration_hastitlebar.md) | `false` |
| [IsAlwaysOnTop](appwindowconfiguration_isalwaysontop.md) | `false` |
| [IsMaximizable](appwindowconfiguration_ismaximizable.md) | `false` |
| [IsMinimizable](appwindowconfiguration_isminimizable.md) | `false` |
| [IsModal](appwindowconfiguration_ismodal.md) | `false` |
| [IsResizable](appwindowconfiguration_resizable.md) | `false` |
| [IsShownInSwitchers](appwindowconfiguration_isshowninswitchers.md) | `false` |

### Ownership

If you want to set an owner for a ContextMenu, you have to do so at the time of creating your [AppWindow](appwindow.md). If you set or change the [OwnerWindowId](appwindowconfiguration_ownerwindowid.md) on the `AppWindowConfiguration` object at a later time, the [AppWindow.ApplyConfiguration](appwindow_applyconfiguration_2040805655.md) call will fail.

## -see-also

[AppWindowConfiguration](appwindowconfiguration.md)

## -examples
