---
-api-id: M:Microsoft.UI.Xaml.Controls.VirtualizingLayout.InitializeForContextCore(Microsoft.UI.Xaml.Controls.VirtualizingLayoutContext)
-api-type: winrt method
---

# Microsoft.UI.Xaml.Controls.VirtualizingLayout.InitializeForContextCore(Microsoft.UI.Xaml.Controls.VirtualizingLayoutContext)

<!--
protected virtual void InitializeForContextCore (Microsoft.UI.Xaml.Controls.VirtualizingLayoutContext context);
-->

## -description

When overridden in a derived class, initializes any per-container state the layout requires when it is attached to a UIElement container.

## -parameters

### -param context

The context object that facilitates communication between the layout and its host container.

## -remarks

Override this method in a derived class to provide the behavior for calls to [InitializeForContext](layout_initializeforcontext_1797632824.md).

Container elements that support attached layouts should call InitializeForContext when a layout instance is first assigned. The container is expected to give the attached layout instance a way to store and retrieve any per-container state by way of the provided context. It is also the responsibility of the container to not reuse the context, or otherwise expose the state from one layout to another.

When an attached layout is removed the container should release any reference to the layout state it stored.

## -see-also

[UninitializeForContextCore](virtualizinglayout_uninitializeforcontextcore_1838712024.md)

## -examples

