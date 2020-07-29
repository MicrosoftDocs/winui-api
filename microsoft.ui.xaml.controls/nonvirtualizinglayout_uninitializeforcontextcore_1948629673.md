---
-api-id: M:Microsoft.UI.Xaml.Controls.NonVirtualizingLayout.UninitializeForContextCore(Microsoft.UI.Xaml.Controls.NonVirtualizingLayoutContext)
-api-type: winrt method
---

# Microsoft.UI.Xaml.Controls.NonVirtualizingLayout.UninitializeForContextCore(Microsoft.UI.Xaml.Controls.NonVirtualizingLayoutContext)

<!--
protected virtual void UninitializeForContextCore (Microsoft.UI.Xaml.Controls.NonVirtualizingLayoutContext context);
-->

## -description

When overridden in a derived class, removes any state the layout previously stored on the UIElement container.  

## -parameters

### -param context

The context object that facilitates communication between the layout and its host container.

## -remarks

Override this method in a derived class to provide the behavior for calls to [Layout.UninitializeForContext(Microsoft.UI.Xaml.Controls.LayoutContext)](layout_uninitializeforcontext_1894452283.md).

Container elements that support attached layouts should call UninitializeForContext when a layout instance is disassociated with the container. The container is expected to give the attached layout instance a way to store and retrieve any per-container state by way of the provided context.

## -see-also

[InitializeForContextCore](nonvirtualizinglayout_initializeforcontextcore_198433946.md)

## -examples

