---
-api-id: P:Microsoft.UI.Xaml.DependencyObject.Dispatcher
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Core.CoreDispatcher Dispatcher { get; }
-->

# Microsoft.UI.Xaml.DependencyObject.Dispatcher

## -description
Gets the [CoreDispatcher](/uwp/api/windows.ui.core.coredispatcher) that this object is associated with. The [CoreDispatcher](/uwp/api/windows.ui.core.coredispatcher) represents a facility that can access the [DependencyObject](dependencyobject.md) on the UI thread even if the code is initiated by a non-UI thread.

## -property-value
The [CoreDispatcher](/uwp/api/windows.ui.core.coredispatcher) that [DependencyObject](dependencyobject.md) object is associated with, which represents the UI thread.

## -remarks
The Dispatcher property provides the [CoreDispatcher](/uwp/api/windows.ui.core.coredispatcher) reference that can be used to marshal calls coming from non-UI threads, using [RunAsync](/uwp/api/windows.ui.core.coredispatcher.runasync(windows.ui.core.coredispatcherpriority,windows.ui.core.dispatchedhandler)) and an awaitable function. For more info on awaitable functions, see [Call asynchronous APIs in C# or Visual Basic](/windows/uwp/threading-async/call-asynchronous-apis-in-csharp-or-visual-basic). See also "**DependencyObject** and threading" section of the [DependencyObject](dependencyobject.md) reference topic.

A [DependencyObject](dependencyobject.md) must be created on a UI thread and has affinity to the UI thread. Because it's an entry point that enables getting across threads, DependencyObject.Dispatcher is the only instance API of [DependencyObject](dependencyobject.md) or any of its subclasses that can be accessed from a non-UI thread without throwing a cross-thread exception. All other [DependencyObject](dependencyobject.md) APIs throw an exception if you attempt to call them from a worker thread or other non-UI thread.

Specifically, the Dispatcher property gets the [CoreDispatcher](/uwp/api/windows.ui.core.coredispatcher) that is associated with the app UI thread. Running code through the [RunAsync](/uwp/api/windows.ui.core.coredispatcher.runasync(windows.ui.core.coredispatcherpriority,windows.ui.core.dispatchedhandler)) method of the [CoreDispatcher](/uwp/api/windows.ui.core.coredispatcher) is necessary if you intend to query or change the value of any dependency property, even if that object isn't yet associated with the XAML visual tree or the visible UI (the visual root of the app window). 

[Window.Dispatcher](window_dispatcher.md) also references a [CoreDispatcher](/uwp/api/windows.ui.core.coredispatcher) that is associated with the UI thread. [Window.Dispatcher](window_dispatcher.md) is basically just a wrapper around [CoreWindow.Dispatcher](/uwp/api/windows.ui.core.corewindow.dispatcher) so that a [Window](window.md) class has easy access to it.



> [!NOTE]
> The connection for a Dispatcher value is not available in a design-time view. This can cause issues if you've created a custom control that uses Dispatcher values and that code is accessed by a design-time environment through code paths that a design view uses, such as constructors and [Loaded](frameworkelement_loaded.md) handlers. If you're writing a custom control and you encounter this issue, consider introducing a guard conditional in your code such as not calling that code when [DesignModeEnabled](/uwp/api/windows.applicationmodel.designmode.designmodeenabled) is **true**.

## -examples
This example shows a usage of Dispatcher for the implicit **this** of a code-behind file for a [Page](../microsoft.ui.xaml.controls/page.md). This example uses a lambda expression to add the [DispatchedHandler](/uwp/api/windows.ui.core.dispatchedhandler) implementation. The handler itself is handling the [Accelerometer.ReadingChanged](/uwp/api/windows.devices.sensors.accelerometer.readingchanged) event, which won't be executed on the UI thread.

```csharp
        private async void ReadingChanged(object sender, AccelerometerReadingChangedEventArgs e)
        {
            await Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                AccelerometerReading reading = e.Reading;
                ScenarioOutput_X.Text = String.Format("{0,5:0.00}", reading.AccelerationX);
                ScenarioOutput_Y.Text = String.Format("{0,5:0.00}", reading.AccelerationY);
                ScenarioOutput_Z.Text = String.Format("{0,5:0.00}", reading.AccelerationZ);
            });
        }
```



## -see-also
