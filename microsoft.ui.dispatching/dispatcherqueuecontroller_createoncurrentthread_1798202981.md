---
-api-id: M:Microsoft.UI.Dispatching.DispatcherQueueController.CreateOnCurrentThread
-api-type: winrt method
---

# Microsoft.UI.Dispatching.DispatcherQueueController.CreateOnCurrentThread

<!--
public static Microsoft.UI.Dispatching.DispatcherQueueController CreateOnCurrentThread ();
-->

## -description

Creates a [DispatcherQueue](dispatcherqueue.md) on the calling thread which will interop with a USER32 message loop.

## -returns

The [DispatcherQueue](dispatcherqueue.md) on the calling thread.

## -remarks

You can access the created DispatcherQueue through [DispatcherQueueController.DispatcherQueue](dispatcherqueuecontroller_dispatcherqueue.md).

## -see-also

## -examples
