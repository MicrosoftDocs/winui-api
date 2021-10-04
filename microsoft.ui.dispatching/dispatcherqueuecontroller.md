---
-api-id: T:Microsoft.UI.Dispatching.DispatcherQueueController
-api-type: winrt class
---

# Microsoft.UI.Dispatching.DispatcherQueueController

<!--
public sealed class DispatcherQueueController
-->

## -description

Manages the lifetime of a [DispatcherQueue](dispatcherqueue.md).

## -remarks

### Object and Thread Lifetime

**DispatcherQueueController** and its associated **DispatcherQueue** will be kept alive while the event loop is running. When **Shutdown** is completed, the loop is terminated and the dedicated thread will unwind. However,
**DispatcherQueueController** and the associated **DispatcherQueue** object can outlive thread’s lifetime and will be disposed when all their references are released.

## -see-also

## -examples
