---
-api-id: M:Microsoft.UI.Xaml.Controls.VirtualizingLayout.ArrangeOverride(Microsoft.UI.Xaml.Controls.VirtualizingLayoutContext,Windows.Foundation.Size)
-api-type: winrt method
---

# Microsoft.UI.Xaml.Controls.VirtualizingLayout.ArrangeOverride(Microsoft.UI.Xaml.Controls.VirtualizingLayoutContext,Windows.Foundation.Size)

<!--
protected virtual Windows.Foundation.Size ArrangeOverride (Microsoft.UI.Xaml.Controls.VirtualizingLayoutContext context, Windows.Foundation.Size finalSize);
-->

## -description

When implemented in a derived class, provides the behavior for the "Arrange" pass of layout. Classes can override this method to define their own "Arrange" pass behavior.

## -parameters

### -param context

The context object that facilitates communication between the layout and its host container.

### -param finalSize

The final area within the container that this object should use to arrange itself and its children.

## -returns

The actual size that is used after the element is arranged in layout.

## -remarks

Override this method to provide the behavior for the _arrange_ pass of the layout cycle on a container element.

The attached layout is expected to call [Arrange](layout_arrange_337607665.md) for each of the container's children, which can be accessed through the provided VirtualizingLayoutContext.

## -examples

