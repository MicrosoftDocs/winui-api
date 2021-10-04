---
-api-id: M:Microsoft.UI.Dispatching.DispatcherQueue.CreateTimer
-api-type: winrt method
---

# Microsoft.UI.Dispatching.DispatcherQueue.CreateTimer

<!--
public Microsoft.UI.Dispatching.DispatcherQueueTimer CreateTimer ();
-->

## -description

Creates a [DispatcherQueueTimer](dispatcherqueuetimer.md) on the [DispatcherQueue](dispatcherqueue.md) to execute a task periodically after a time interval has elapsed.

## -returns

An DispatcherQueueTimer that can queue tasks on a timed basis to the current DispatcherQueue.

## -remarks

By default, a repeating timer is created. To make it non-repeating, set [IsRepeating](dispatcherqueuetimer_isrepeating.md) to false.

## -see-also

## -examples
