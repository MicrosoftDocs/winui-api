---
-api-id: M:Microsoft.UI.Windowing.AppWindowConfiguration.CreateForToolWindow
-api-type: winrt method
---

# Microsoft.UI.Windowing.AppWindowConfiguration.CreateForToolWindow

<!--
public static Microsoft.UI.Windowing.AppWindowConfiguration CreateForToolWindow ();
-->

## -description

Creates a configuration object pre-populated with the values for a tool window.

## -returns

A configuration object pre-populated with the values for a tool window.

## -remarks

A tool window is intended to be used as a floating toolbar. It does not appear in the taskbar or in the dialog that appears when the user presses ALT+TAB.

This table shows how configuration properties are set when you create an `AppWindowConfiguration` object from the `CreateForToolWindow` method.

| Configuration property | Value |
| -- | -- |
| [HasFrame](appwindowconfiguration_hasframe.md) | `true` |
| [HasTitleBar](appwindowconfiguration_hastitlebar.md) | `true` |
| [IsAlwaysOnTop](appwindowconfiguration_isalwaysontop.md) | `false` |
| [IsMaximizable](appwindowconfiguration_ismaximizable.md) | `true` |
| [IsMinimizable](appwindowconfiguration_isminimizable.md) | `true` |
| [IsModal](appwindowconfiguration_ismodal.md) | `false` |
| [IsResizable](appwindowconfiguration_resizable.md) | `true` |
| [IsShownInSwitchers](appwindowconfiguration_isshowninswitchers.md) | `false` |

### Ownership

If you want to set an owner for a Dialog, you have to do so at the time of creating your [AppWindow](appwindow.md). If you set or change the [OwnerWindowId](appwindowconfiguration_ownerwindowid.md) on the `AppWindowConfiguration` object at a later time, the [AppWindow.ApplyConfiguration](appwindow_applyconfiguration_2040805655.md) call will fail.

## -see-also

[AppWindowConfiguration](appwindowconfiguration.md)

## -examples
