---
-api-id: P:Microsoft.UI.Xaml.Window.Dispatcher
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Core.CoreDispatcher Dispatcher { get; }
-->

# Microsoft.UI.Xaml.Window.Dispatcher

## -description


Gets the [CoreDispatcher](/uwp/api/windows.ui.core.coredispatcher) object for the [Window](window.md) when called from a UWP app. Returns null when called from a Desktop app.

## -property-value
An object that references the UI thread for the [Window](window.md).

## -remarks

When running as a Desktop app, this property will be null.

Most members of the Window class can only be accessed when running on the thread the object was
created on. This property, though, can be called from any thread.


> [!NOTE]
> `Window.Dispatcher` may be altered or unavailable for future releases. Instead, use [Windows.DispatcherQueue](window_dispatcherqueue.md) which is available for UWP and Desktop apps. 

## -examples

## -see-also
