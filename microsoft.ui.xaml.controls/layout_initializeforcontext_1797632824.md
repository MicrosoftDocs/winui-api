---
-api-id: M:Microsoft.UI.Xaml.Controls.Layout.InitializeForContext(Microsoft.UI.Xaml.Controls.LayoutContext)
-api-type: winrt method
---

# Microsoft.UI.Xaml.Controls.Layout.InitializeForContext(Microsoft.UI.Xaml.Controls.LayoutContext)

<!--
public void InitializeForContext (Microsoft.UI.Xaml.Controls.LayoutContext context);
-->

## -description

Initializes any per-container state the layout requires when it is attached to a UIElement container.  

## -parameters

### -param context

The context object that facilitates communication between the layout and its host container.

## -remarks

Container elements that support attached layouts should call this method when a layout instance is first assigned. The container is expected to give the attached layout instance a way to store and retrieve any per-container state by way of the provided context. It is also the responsibility of the container to not reuse the context, or otherwise expose the state from one layout to another.

When an attached layout is removed the container should release any reference to the layout state it stored.

Override [NonVirtualizingLayout.InitializeForContextCore](nonvirtualizinglayout_initializeforcontextcore_198433946.md) or [VirtualizingLayout.InitializeForContextCore](virtualizinglayout_initializeforcontextcore_309256937.md) to provide the behavior for this method in a derived class.

## -see-also

[Layout.UninitializeForContext(Microsoft.UI.Xaml.Controls.LayoutContext)](layout_uninitializeforcontext_1894452283.md)

## -examples
