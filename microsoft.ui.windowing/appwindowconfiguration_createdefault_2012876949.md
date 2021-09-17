---
-api-id: M:Microsoft.UI.Windowing.AppWindowConfiguration.CreateDefault
-api-type: winrt method
---

# Microsoft.UI.Windowing.AppWindowConfiguration.CreateDefault

<!--
public static Microsoft.UI.Windowing.AppWindowConfiguration CreateDefault ();
-->

## -description

Creates a configuration object pre-populated with the values for a default window.

## -returns

A configuration object pre-populated with the values for a default window.

## -remarks

This table shows how configuration properties are set when you create an `AppWindowConfiguration` object from the `CreateDefault` method.

| Configuration property | Value |
| -- | -- |
| [HasFrame](appwindowconfiguration_hasframe.md) | `true` |
| [HasTitleBar](appwindowconfiguration_hastitlebar.md) | `true` |
| [IsAlwaysOnTop](appwindowconfiguration_isalwaysontop.md) | `false` |
| [IsMaximizable](appwindowconfiguration_ismaximizable.md) | `true` |
| [IsMinimizable](appwindowconfiguration_isminimizable.md) | `true` |
| [IsModal](appwindowconfiguration_ismodal.md) | `false` |
| [IsResizable](appwindowconfiguration_resizable.md) | `true` |
| [IsShownInSwitchers](appwindowconfiguration_isshowninswitchers.md) | `true` |

## -see-also

[AppWindowConfiguration](appwindowconfiguration.md)

## -examples
