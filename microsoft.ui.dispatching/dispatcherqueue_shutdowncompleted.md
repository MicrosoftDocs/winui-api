---
-api-id: E:Microsoft.UI.Dispatching.DispatcherQueue.ShutdownCompleted
-api-type: winrt event
---

# Microsoft.UI.Dispatching.DispatcherQueue.ShutdownCompleted

<!--
public event Windows.Foundation.TypedEventHandler<Microsoft.UI.Dispatching.DispatcherQueue,object> ShutdownCompleted;
-->

## -description

Occurs after the [DispatcherQueue](dispatcherqueue.md) event loop stops, which is the last step in the DispatcherQueue shutdown process.

## -remarks

The event is fired on the thread running the DispatcherQueue event loop. After this event is fired, any work posted to the DispatcherQueue will not be scheduled.

## -see-also

## -examples
