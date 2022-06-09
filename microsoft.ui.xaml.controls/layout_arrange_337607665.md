---
-api-id: M:Microsoft.UI.Xaml.Controls.Layout.Arrange(Microsoft.UI.Xaml.Controls.LayoutContext,Windows.Foundation.Size)
-api-type: winrt method
---

# Microsoft.UI.Xaml.Controls.Layout.Arrange(Microsoft.UI.Xaml.Controls.LayoutContext,Windows.Foundation.Size)

<!--
public Windows.Foundation.Size Arrange (Microsoft.UI.Xaml.Controls.LayoutContext context, Windows.Foundation.Size finalSize);
-->

## -description

Positions child elements and determines a size for a container UIElement. Container elements that support attached layouts should call this method from their layout override implementations to form a recursive layout update.  

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -parameters

### -param context

The context object that facilitates communication between the layout and its host container.

### -param finalSize

The final size that the container computes for the child in layout.

## -returns

The actual size that is used after the element is arranged in layout.

## -remarks

Override [NonVirtualizingLayout.ArrangeOverride](nonvirtualizinglayout_arrangeoverride_1338397335.md) or [VirtualizingLayout.ArrangeOverride](virtualizinglayout_arrangeoverride_1450929382.md) to provide the behavior for this method in a derived class.

## -see-also

## -examples

