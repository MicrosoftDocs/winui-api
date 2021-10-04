---
-api-id: E:Microsoft.UI.Dispatching.DispatcherQueue.ShutdownStarting
-api-type: winrt event
---

# Microsoft.UI.Dispatching.DispatcherQueue.ShutdownStarting

<!--
public event Windows.Foundation.TypedEventHandler<Microsoft.UI.Dispatching.DispatcherQueue,Microsoft.UI.Dispatching.DispatcherQueueShutdownStartingEventArgs> ShutdownStarting;
-->

## -description

Occurs before the [DispatcherQueue](dispatcherqueue.md) initiates an exit from its event loop.

## -remarks

The event is fired on the thread running the DispatcherQueue event loop.

This event fires before the DispatcherQueue initiates the exit from the event loop. Event handlers for this event can queue work from within the handler. The event handler can take a deferral and continue to post work to the DispatcherQueue until the deferral completes. Once the deferral completes, no new work will be accepted by the DispatcherQueue.

## -see-also

## -examples
