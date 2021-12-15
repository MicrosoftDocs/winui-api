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

> [!NOTE]
> `Window.Dispatcher` may be altered or unavailable in future releases. Use [Window.DispatcherQueue](window_dispatcherqueue.md) instead.

## -property-value

An object that references the UI thread for the [Window](window.md).

## -remarks

When running as a Desktop app, this property will be null.

Most members of the Window class can only be accessed when running on the thread the object was created on. However, this property can be called from any thread.

## -examples

## -see-also
