---
-api-id: T:Microsoft.UI.Xaml.Input.ManipulationStartingEventHandler
-api-type: winrt delegate
---
<!-- Delegate syntax.
public delegate void ManipulationStartingEventHandler(System.Object sender, Windows.UI.Xaml.Input.ManipulationStartingRoutedEventArgs e)
-->
# Microsoft.UI.Xaml.Input.ManipulationStartingEventHandler

## -description
Represents the method that will handle the [ManipulationStarting](../microsoft.ui.xaml/uielement_manipulationstarting.md) event.

## -parameters
### -param sender
The object where the event handler is attached.

### -param e
Event data for the event.


## -remarks

## -examples
The following code example shows scenario 4 from the [Input sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/411c271e537727d737a53fa2cbe99eaecac00cc0/Official%20Windows%20Platform%20Sample/Input%20XAML%20user%20input%20events%20sample). This code shows some usage patterns for direct manipulation using the [ManipulationStarting](../microsoft.ui.xaml/uielement_manipulationstarting.md), [ManipulationStarted](../microsoft.ui.xaml/uielement_manipulationstarted.md), [ManipulationDelta](../microsoft.ui.xaml/uielement_manipulationdelta.md), [ManipulationInertiaStarting](../microsoft.ui.xaml/uielement_manipulationinertiastarting.md), and [ManipulationCompleted](../microsoft.ui.xaml/uielement_manipulationcompleted.md) events.



[!code-csharp[Scenario4Code](../microsoft.ui.xaml/code/input/csharp/Scenario4.xaml.cs#SnippetScenario4Code)]

[!code-vb[Scenario4Code](../microsoft.ui.xaml/code/input/vbnet/Scenario4.xaml.vb#SnippetScenario4Code)]


## -see-also
