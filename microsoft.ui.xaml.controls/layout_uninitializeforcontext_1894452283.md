---
-api-id: M:Microsoft.UI.Xaml.Controls.Layout.UninitializeForContext(Microsoft.UI.Xaml.Controls.LayoutContext)
-api-type: winrt method
---

# Microsoft.UI.Xaml.Controls.Layout.UninitializeForContext(Microsoft.UI.Xaml.Controls.LayoutContext)

<!--
public void UninitializeForContext (Microsoft.UI.Xaml.Controls.LayoutContext context);
-->

## -description

Removes any state the layout previously stored on the UIElement container.  

**This documentation applies to WinUI 2 for UWP** for [WinUI]/windows/apps/winui/winui3/ in the [Windows App SDK]/windows/apps/windows-app-sdk/, see the **[Windows App SDK namespaces]/windows/windows-app-sdk/api/winrt/**.

## -parameters

### -param context

The context object that facilitates communication between the layout and its host container.

## -remarks

Container elements that support attached layouts should call this method when a layout instance is disassociated with the container. The container is expected to give the attached layout instance a way to store and retrieve any per-container state by way of the provided context.

Override [NonVirtualizingLayout.UninitializeForContextCore](nonvirtualizinglayout_uninitializeforcontextcore_1948629673.md) or [VirtualizingLayout.UninitializeForContextCore](virtualizinglayout_uninitializeforcontextcore_1838712024.md) to provide the behavior for this method in a derived class.

## -see-also

[InitializeForContext](layout_initializeforcontext_1797632824.md)

## -examples

