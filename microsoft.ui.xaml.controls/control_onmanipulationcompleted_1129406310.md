---
-api-id: M:Microsoft.UI.Xaml.Controls.Control.OnManipulationCompleted(Microsoft.UI.Xaml.Input.ManipulationCompletedRoutedEventArgs)
-api-type: winrt method
---

<!-- Method syntax
virtual protected void OnManipulationCompleted(Windows.UI.Xaml.Input.ManipulationCompletedRoutedEventArgs e)
-->

# Microsoft.UI.Xaml.Controls.Control.OnManipulationCompleted

## -description
Called before the [ManipulationCompleted](../microsoft.ui.xaml/uielement_manipulationcompleted.md) event occurs.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -parameters
### -param e
Event data for the event.

## -remarks
<!--The following remark is relevant for Windows 8 > 8.1 migration. See WBB 467590-->
### Windows 8 behavior

Windows 8 doesn't fire [ManipulationCompleted](../microsoft.ui.xaml/uielement_manipulationcompleted.md) in cases where the inertial phase has started (and [ManipulationInertiaStarting](../microsoft.ui.xaml/uielement_manipulationinertiastarting.md) has fired) but the user has tapped on the item before it's finished scrolling, which cancels the inertial phase visually. The issue is fixed starting with Windows 8.1; [ManipulationCompleted](../microsoft.ui.xaml/uielement_manipulationcompleted.md) is fired as soon as the tap action cancels the inertial phase.

Apps that were compiled for Windows 8 but running on Windows 8.1 continue to use the Windows 8 behavior.

## -examples

## -see-also
[UIElement.ManipulationCompleted](../microsoft.ui.xaml/uielement_manipulationcompleted.md), [ManipulationCompletedRoutedEventArgs](../microsoft.ui.xaml.input/manipulationcompletedroutedeventargs.md), [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview), [Custom user interactions](/windows/apps/design/layout/index), [Handle pointer input](/windows/uwp/input-and-devices/handle-pointer-input)
