---
-api-id: T:Microsoft.UI.Xaml.Window
-api-type: winrt class
---

<!-- Class syntax.
public class Window : Windows.UI.Xaml.IWindow, Windows.UI.Xaml.IWindow2
-->

# Microsoft.UI.Xaml.Window

## -description

Represents the window of the current [Application](application.md).

## -remarks

This object can be used in both Desktop and UWP applications.

**WinUI 3 in the [Windows App SDK experimental release channel](/windows/apps/windows-app-sdk/experimental-channel)**: For desktop apps, you can create more than one Window per thread. For UWP apps, you can create only a single Window per thread. See [Create a new Window](#create-a-new-window) in [Examples](#-examples).

In a UWP app, each UI thread already has a Window that can be retrieved using the static [Window.Current](window_current.md) property. Additional windows can be created with [CoreApplicationView](/uwp/api/Windows.ApplicationModel.Core.CoreApplicationView) objects, which are always created on a new thread, and which automatically create an [ApplicationView](/uwp/api/Windows.UI.ViewManagement.ApplicationView), [CoreWindow](/uwp/api/windows.ui.core.corewindow), and Window for the new thread.

For Desktop apps, Window implements [IWindowNative](/windows/apps/winui/reference/iwindownative) to enable interop through the Window's HWND ([WindowHandle](/windows/apps/winui/reference/iwindownative-windowhandle)).

For UWP apps, both the static [Application](application_application_1221375020.md) property and the static [Current](application_current.md) property return the Window object. From this object, an app can use the [Dispatcher](window_dispatcher.md) object or determine the size of the Window from the [Bounds](window_bounds.md) property.

Typically, Window is used to set a [UIElement](uielement.md) to the [Content](window_content.md) that represents the app UI. This is usually done as part of app activation (for example in the [OnLaunched](application_onlaunched_859642554.md) override) and allows you to change the window content throughout the lifetime of the window.

Ensure you call [Activate](window_activate_1797342875.md) on any Window used on initial activation. If you use the default app templates from Microsoft Visual Studio, [Window.Activate](window_activate_1797342875.md) is included in the app.xaml code-behind file.

## -see-also

[IWindowNative](/windows/apps/winui/reference/iwindownative), [Handle app activation](/windows/uwp/launch-resume/activate-an-app), [CoreWindow](/uwp/api/windows.ui.core.corewindow), [CoreApplicationView](/uwp/api/Windows.ApplicationModel.Core.CoreApplicationView), [ApplicationView](/uwp/api/Windows.UI.ViewManagement.ApplicationView)

## -examples

> [!NOTE]
> Building UWP apps is currently only supported in Experimental versions of WinUI 3.

### OnLaunched

The following code example shows the [OnLaunched](application_onlaunched_1344752508.md) method override generated for the **WinUI in UWP (Experimental)** template in Microsoft Visual Studio. This code demonstrates typical usage patterns for the [Current](window_current.md) and [Content](window_content.md) properties and the [Activate](window_activate_1797342875.md) method.  

```csharp
protected override void OnLaunched(Microsoft.UI.Xaml.LaunchActivatedEventArgs e)
{
    Frame rootFrame = Window.Current.Content as Frame;

    // Do not repeat app initialization when the Window already has content,
    // just ensure that the window is active.
    if (rootFrame == null)
    {
        // Create a Frame to act as the navigation context and navigate to the first page.
        rootFrame = new Frame();

        rootFrame.NavigationFailed += OnNavigationFailed;

        if (e.UWPLaunchActivatedEventArgs.PreviousExecutionState == ApplicationExecutionState.Terminated)
        {
            //TODO: Load state from previously suspended application.
        }

        // Place the frame in the current Window.
        Window.Current.Content = rootFrame;
    }

    if (e.UWPLaunchActivatedEventArgs.PrelaunchActivated == false)
    {
        if (rootFrame.Content == null)
        {
            // When the navigation stack isn't restored navigate to the first page,
            // configuring the new page by passing required information as a navigation
            // parameter.
            rootFrame.Navigate(typeof(MainPage), e.Arguments);
        }
        // Ensure the current window is active.
        Window.Current.Activate();
    }
}
```

For comparison, here's the same override generated for the **WinUI in Desktop** template showing the desktop Window object.

``` csharp
        protected override void OnLaunched(Microsoft.UI.Xaml.LaunchActivatedEventArgs args)
        {
            m_window = new MainWindow();
            m_window.Activate();
        }

        private Window m_window;
```

### Create a new Window

In a Desktop app you can create each Window explicitly. Creating more than one Window requires the 1.0.1 update to WindowsAppSDK, and is limited to a single thread.

```csharp
Window window = new Window();
window.Content = new TextBlock() { Text = "Hello" };
window.Activate();
```

You can also define a new Window in markup:

```xaml
<Window 
    x:Class="MainWindow"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml">
    <TextBlock>Hello</TextBlock>
</Window>
```

with corresponding code-behind:

```c#
public partial class MainWindow : Window
{
  public MainWindow()
  {
    InitializeComponent();
  }
}

...

MainWindow window = new MainWindow();
window.Activate();
```

### Create a new Window on a new thread

In a UWP app, each UI thread already has a Window that can be retrieved with the static [Window.Current](window_current.md) property. You can create additional windows using [CoreApplicationView](/uwp/api/Windows.ApplicationModel.Core.CoreApplicationView), which is always created on a new thread (along with corresponding [ApplicationView](/uwp/api/Windows.UI.ViewManagement.ApplicationView), [CoreWindow](/uwp/api/windows.ui.core.corewindow), and Window objects).

Note that creating multiple windows requires the 1.0.1 update to WindowsAppSDK, and is limited to a single thread.

```csharp
_ = CoreApplication.CreateNewView().DispatcherQueue.TryEnqueue(() =>
{
    // This code runs on the new thread
    Window.Current.Content = new TextBlock() { Text = "Hello" };
    Window.Current.Activate();
});
```

To create a new Window on a new thread in a Desktop app, create the thread first and then use the DispatcherQueueSynchronizationContext to queue work to another thread.

```csharp
var thread = new Thread(() =>
{
    Window window = new Window();
    window.Content = new TextBlock() { Text = "Hello" };
    window.Activate();
    window.Closed += (_, __) => w.DispatcherQueue.InvokeShutdown();

    var syncContext = new DispatcherQueueSyncronizationContext();
    SynchronizationContext.SetSynchronizationContext(syncContext);

    this.ProcessEvents(); // Message pump
});

thread.SetApartmentState(ApartmentState.STA);
thread.Start(); 
```
