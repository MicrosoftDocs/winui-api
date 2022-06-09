---
-api-id: M:Microsoft.UI.Xaml.Controls.NonVirtualizingLayout.ArrangeOverride(Microsoft.UI.Xaml.Controls.NonVirtualizingLayoutContext,Windows.Foundation.Size)
-api-type: winrt method
---

# Microsoft.UI.Xaml.Controls.NonVirtualizingLayout.ArrangeOverride(Microsoft.UI.Xaml.Controls.NonVirtualizingLayoutContext,Windows.Foundation.Size)

<!--
protected virtual Windows.Foundation.Size ArrangeOverride (Microsoft.UI.Xaml.Controls.NonVirtualizingLayoutContext context, Windows.Foundation.Size finalSize);
-->

## -description

When implemented in a derived class, provides the behavior for the "Arrange" pass of layout. Classes can override this method to define their own "Arrange" pass behavior.

**This documentation applies to WinUI 2 for UWP** (for [WinUI](/windows/apps/winui/winui3/) in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -parameters

### -param context

The context object that facilitates communication between the layout and its host container.

### -param finalSize

The final area within the container that this object should use to arrange itself and its children.

## -returns

The actual size that is used after the element is arranged in layout.

## -remarks

Override this method to provide the behavior for the _arrange_ pass of the layout cycle on a container element.

The attached layout is expected to call [Arrange](layout_arrange_337607665.md) for each of the container's children, which can be accessed through the provided NonVirtualizingLayoutContext.

## -see-also

## -examples

