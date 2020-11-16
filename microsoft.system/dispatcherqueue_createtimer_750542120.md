---
-api-id: M:Microsoft.System.DispatcherQueue.CreateTimer
-api-type: winrt method
---

<!-- Method syntax.
public DispatcherQueueTimer DispatcherQueue.CreateTimer()
-->

# Microsoft.System.DispatcherQueue.CreateTimer

## -description
Creates a **DispatcherQueueTimer** on the **DispatcherQueue** to execute a task periodically after a time interval has elapsed.

## -returns
An **DispatcherQueueTimer** that can queue tasks on a timed basis to the current **DispatcherQueue**.

## -remarks
By default, a repeating timer is created. Set **IsRepeating** to **false** to make it non-repeating.

## -see-also

## -examples
