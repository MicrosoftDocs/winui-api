---
-api-id: T:Microsoft.UI.Windowing.AppWindowConfiguration
-api-type: winrt class
---

# Microsoft.UI.Windowing.AppWindowConfiguration

<!--
public sealed class AppWindowConfiguration
-->

## -description

Represents the configuration of an app window.

## -remarks

When you create an `AppWindowConfiguration` object from one of the static _Create_ methods, the properties are pre-populated according to the method called. This table shows how these properties are set for each pre-configured window type.

| Configuration property | Default | ContextMenu | Dialog | ToolWindow |
| -- | -- | -- | -- | -- |
| [HasFrame](appwindowconfiguration_hasframe.md) | `true` | `true` | `true` | `true` |
| [HasTitleBar](appwindowconfiguration_hastitlebar.md) | `true` | `false` | `true` | `true` |
| [IsAlwaysOnTop](appwindowconfiguration_isalwaysontop.md) | `false` | `false` | `false` | `false` |
| [IsMaximizable](appwindowconfiguration_ismaximizable.md) | `true` | `false` | `false` | `true` |
| [IsMinimizable](appwindowconfiguration_isminimizable.md) | `true` | `false` | `false` | `true` |
| [IsModal](appwindowconfiguration_ismodal.md) | `false` | `false` | `false` | `false` |
| [IsResizable](appwindowconfiguration_resizable.md) | `true` | `false` | `false` | `true` |
| [IsShownInSwitchers](appwindowconfiguration_isshowninswitchers.md) | `true` | `false` | `false` | `false` |

### Ownership

If you want to set an owner for a ContextMenu, Dialog, or ToolWindow, you have to do so at the time of creating your [AppWindow](appwindow.md). If you set or change the [OwnerWindowId](appwindowconfiguration_ownerwindowid.md) on the `AppWindowConfiguration` object at a later time, the [AppWindow.ApplyConfiguration](appwindow_applyconfiguration_2040805655.md) call will fail.

## -see-also

## -examples
