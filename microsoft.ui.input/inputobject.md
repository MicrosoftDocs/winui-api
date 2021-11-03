---
-api-id: T:Microsoft.UI.Input.InputObject
-api-type: winrt class
---

# Microsoft.UI.Input.InputObject

<!--
public class InputObject
-->

## -description

Base class for all input objects.

## -remarks

All input APIs in the Windows App SDK derive from the common InputObject base class.

### InputObject threading model

An InputObject can only be accessed from the thread where it was created. Any property access or function call on a different thread will return RPC_E_WRONG_THREAD (or the equivalent projected error type). The only exception to this is when accessing the InputObject [DispatcherQueue](inputobject_dispatcherqueue.md) property. The DispatcherQueue lets you check if the current thread has access and, if not, to queue work to the affined thread.

All event callbacks are raised on the DispatcherQueue thread associated with the InputObject.

The following example shows how to determine if the InputObject belongs to the current thread.

```csharp
bool OnThread(Microsoft.UI.Input.InputObject inputObject)
{
    return inputObject.DispatcherQueue.HasThreadAccess();
}
```

### Behavior when disposed

When an InputObject is disposed, all associated event handlers are unregistered automatically. Subsequent calls to unregister an event handler will succeed but are not required.

All subsequent function or property calls, including the DispatcherQueue property, will return RO_E_CLOSED (or the equivalent projected error).

> [!Note]
> The InputObject memory remains valid until all references have been released, but all resources are released when disposed.

## -see-also

## -examples
