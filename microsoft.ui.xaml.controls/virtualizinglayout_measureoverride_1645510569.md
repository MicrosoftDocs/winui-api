---
-api-id: M:Microsoft.UI.Xaml.Controls.VirtualizingLayout.MeasureOverride(Microsoft.UI.Xaml.Controls.VirtualizingLayoutContext,Windows.Foundation.Size)
-api-type: winrt method
---

# Microsoft.UI.Xaml.Controls.VirtualizingLayout.MeasureOverride(Microsoft.UI.Xaml.Controls.VirtualizingLayoutContext,Windows.Foundation.Size)

<!--
protected virtual Windows.Foundation.Size MeasureOverride (Microsoft.UI.Xaml.Controls.VirtualizingLayoutContext context, Windows.Foundation.Size availableSize);
-->

## -description

Provides the behavior for the "Measure" pass of the layout cycle. Classes can override this method to define their own "Measure" pass behavior.

## -parameters

### -param context

The context object that facilitates communication between the layout and its host container.

### -param availableSize

The available size that this object can give to child objects. Infinity can be specified as a value to indicate that the object will size to whatever content is available.

## -returns

The size that this object determines it needs during layout, based on its calculations of the allocated sizes for child objects or based on other considerations such as a fixed container size.

## -remarks

Override this method to provide the behavior for the _measure_ pass of the layout cycle on a container element.

The attached layout is expected to call [Measure](layout_measure_880955323.md) for each of the container's children, which can be accessed through the provided VirtualizingLayoutContext.

## -examples

