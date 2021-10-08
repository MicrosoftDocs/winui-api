---
-api-id: M:Microsoft.UI.Dispatching.DispatcherQueue.TryEnqueue(Microsoft.UI.Dispatching.DispatcherQueueHandler)
-api-type: winrt method
---

# Microsoft.UI.Dispatching.DispatcherQueue.TryEnqueue(Microsoft.UI.Dispatching.DispatcherQueueHandler)

<!--
public bool TryEnqueue (Microsoft.UI.Dispatching.DispatcherQueueHandler callback);
-->

## -description

Adds a task to the [DispatcherQueue](dispatcherqueue.md) that will be executed on the thread associated with the DispatcherQueue.

## -parameters

### -param callback

A delegate to the task to execute.

## -returns

**True** if the task was added to the queue. Otherwise, **false**.

## -remarks

The queue will invoke **callback** serially.

Once [ShutdownQueueAsync()](dispatcherqueuecontroller_shutdownqueueasync_542547627.md) has been called, the queue will not queue new tasks and this method will return **false**.

## -see-also

## -examples

The following example shows how to create a new thread and initialize a [DispatcherQueueController](dispatcherqueuecontroller.md) and run a DispatcherQueue event loop on it.

```csharp
// Create a new thread and initialize a DispatcherQueueController
// and run a DispatcherQueue event loop on it.
_queueController =
    DispatcherQueueController.CreateOnDedicatedThread();
_queue = _queueController.DispatcherQueue;

// This is the first TryEnqueue() after creating the DispatcherQueue. The
// first TryEnqueue task is guaranteed to be invoked first on the new
// thread.
bool isQueued = _queue.TryEnqueue(
        () =>
        {
            // task to perform on another thread.
        });
```
