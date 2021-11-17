---
-api-id: P:Microsoft.UI.Xaml.Window.DispatcherQueue
-api-type: winrt property
---

# Microsoft.UI.Xaml.Window.DispatcherQueue

<!--
public Microsoft.System.DispatcherQueue DispatcherQueue { get; }
-->

## -description

Gets the `DispatcherQueue` object for the window.

## -property-value

The `DispatcherQueue` object for the window.

## -remarks

The `DispatcherQueue` represents a facility that can access the `DependencyObject` on the UI thread even if the code is initiated by a non-UI thread.

Most members of the `Window` class can only be accessed when running on the thread the object was created on. However, this property can be called from any thread.

## -see-also

## -examples


