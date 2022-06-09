---
-api-id: E:Microsoft.UI.Xaml.UIElement.ManipulationStarted
-api-type: winrt event
---

<!-- Event syntax
public event Windows.UI.Xaml.Input.ManipulationStartedEventHandler ManipulationStarted
-->

# Microsoft.UI.Xaml.UIElement.ManipulationStarted

## -description

Occurs when an input device begins a manipulation on the [UIElement](uielement.md).

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -xaml-syntax

```xaml
<uiElement ManipulationStarted="eventhandler"/>
```

## -remarks

For custom controls and interaction experiences, see [GestureRecognizer.ManipulationStarted](../microsoft.ui.input/gesturerecognizer_manipulationstarted.md).

ManipulationStarted represents that the manipulation recognition logic has detected pointer movement. In this case it's the second manipulation event to fire in a typical sequence, firing after ManipulationStarting, but before ManipulationDelta or other events such as ManipulationInertiaStarting.

An element must have a [ManipulationMode](uielement_manipulationmode.md) value other than **None** or **System** to be a manipulation event source. The default value of [ManipulationMode](uielement_manipulationmode.md) is **System**, which enables built-in control logic to process manipulations, but doesn't permit app code to handle manipulation events. If you want to handle manipulations, set [ManipulationMode](uielement_manipulationmode.md) to **All**, or to specific [ManipulationModes](../microsoft.ui.xaml.input/manipulationmodes.md) values. For more info, see [ManipulationMode](uielement_manipulationmode.md).

ManipulationStarted is a routed event. If the event is permitted to bubble up to parent elements because it goes unhandled, then it is possible to handle the event on parent elements even if [ManipulationMode](uielement_manipulationmode.md) is **None** or **System** on the parent element. For more info on the routed event concept, see [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview).

For touch actions and also for interaction-specific or manipulation events that are consequences of a touch action, an element must be hit-test visible in order to be the event source and fire the event that is associated with the action. [UIElement.Visibility](uielement_visibility.md) must be [Visible](visibility.md). Other properties of derived types also affect hit-test visibility. For more info, see [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview).

ManipulationStarted supports the ability to attach event handlers to the route that will be invoked even if the event data for the event is marked [Handled](../microsoft.ui.xaml.input/manipulationstartedroutedeventargs_handled.md). See [AddHandler](uielement_addhandler_1350394113.md).

## -examples

## -see-also

[ManipulationStartedRoutedEventArgs](../microsoft.ui.xaml.input/manipulationstartedroutedeventargs.md), [OnManipulationStarted](/uwp/api/windows.ui.xaml.controls.control.onmanipulationstarted(windows.ui.xaml.input.manipulationstartedroutedeventargs)), [ManipulationStarting](uielement_manipulationstarting.md), [Using manipulation events](/previous-versions/windows/apps/hh465387(v=win.10)), [XAML user input events sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Input%20XAML%20user%20input%20events%20sample)
