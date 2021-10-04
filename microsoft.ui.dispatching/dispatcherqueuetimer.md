---
-api-id: T:Microsoft.UI.Dispatching.DispatcherQueueTimer
-api-type: winrt class
---

# Microsoft.UI.Dispatching.DispatcherQueueTimer

<!--
public sealed class DispatcherQueueTimer
-->

## -description

Executes a task in a [DispatcherQueue](dispatcherqueue.md) periodically after a time interval has elapsed.

## -remarks

The system guarantees to invoke the event handler only after the specified duration expires. However, there may be some delay before the tick handler is invoked if there are other pending work items in the queue.

Timer tasks run at a priority lower than idle.

Timers don’t keep the **DispatcherQueue** event loop alive. Timers created after the **DispatcherQueue** event loop has stopped will not be processed.

## -see-also

## -examples

```csharp
public void ConfigureRepeatingTimer()
{
    _queueController = DispatcherQueueController.CreateOnDedicatedThread();
    _queue = _queueController.DispatcherQueue;

    _repeatingTimer = _queue.CreateTimer ();
    _repeatingTimer.Interval = TimeSpan.FromSeconds(5);

    // The tick handler will be invoked repeatedly after every 5
    // seconds on the dedicated thread.
    _repeatingTimer.Tick += (s, e) =>
    {
        DoWork();
    };

    // Start the Timer
    _repeatingTimer.Start();
}

private DispatcherQueue _queue;
private DispatcherQueueController _queueController;
private DispatcherQueueTimer _repeatingTimer;
```
