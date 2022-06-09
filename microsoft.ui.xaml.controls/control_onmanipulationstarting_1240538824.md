---
-api-id: M:Microsoft.UI.Xaml.Controls.Control.OnManipulationStarting(Microsoft.UI.Xaml.Input.ManipulationStartingRoutedEventArgs)
-api-type: winrt method
---

<!-- Method syntax
virtual protected void OnManipulationStarting(Windows.UI.Xaml.Input.ManipulationStartingRoutedEventArgs e)
-->

# Microsoft.UI.Xaml.Controls.Control.OnManipulationStarting

## -description
Called before the [ManipulationStarting](../microsoft.ui.xaml/uielement_manipulationstarting.md) event occurs.

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -parameters
### -param e
Event data for the event.

## -remarks
<!--The following remark is relevant for Windows 8 > 8.1 migration. See WBB 458026-->
### Windows 8 behavior

Windows 8 had an issue with firing this event if multiple gestures happened in a short period of time. For example, Windows 8 might only fire [ManipulationStarting](../microsoft.ui.xaml/uielement_manipulationstarting.md) for the first gesture and not the second. The issue is fixed starting with Windows 8.1; multiple starting gestures processed by the input system each fire a distinct [ManipulationStarting](../microsoft.ui.xaml/uielement_manipulationstarting.md) event.

Apps that were compiled for Windows 8 but running on Windows 8.1 continue to use the Windows 8 behavior.

## -examples

## -see-also
[UIElement.ManipulationStarting](../microsoft.ui.xaml/uielement_manipulationstarting.md), [ManipulationStartingRoutedEventArgs](../microsoft.ui.xaml.input/manipulationstartingroutedeventargs.md), [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview), [Custom user interactions](/windows/apps/design/layout/index), [Handle pointer input](/windows/uwp/input-and-devices/handle-pointer-input)
