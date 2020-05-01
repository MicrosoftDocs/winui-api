---
-api-id: M:Microsoft.UI.Xaml.Controls.Layout.Measure(Microsoft.UI.Xaml.Controls.LayoutContext,Windows.Foundation.Size)
-api-type: winrt method
---

# Microsoft.UI.Xaml.Controls.Layout.Measure(Microsoft.UI.Xaml.Controls.LayoutContext,Windows.Foundation.Size)

<!--
public Windows.Foundation.Size Measure (Microsoft.UI.Xaml.Controls.LayoutContext context, Windows.Foundation.Size availableSize);
-->

## -description

Suggests a DesiredSize for a container element. A container element that supports attached layouts should call this method from their own MeasureOverride implementations to form a recursive layout update. The attached layout is expected to call the Measure for each of the container’s UIElement children.  

## -parameters

### -param context

The context object that facilitates communication between the layout and its host container.

### -param availableSize

The available space that a container can allocate to a child object. A child object can request a larger space than what is available; the provided size might be accommodated if scrolling or other resize behavior is possible in that particular container.

## -returns

The size that this object determines it needs during layout, based on its calculations of the allocated sizes for child objects or based on other considerations such as a fixed container size.

## -remarks

Override [NonVirtualizingLayout.MeasureOverride](nonvirtualizinglayout_measureoverride_2074690008.md) or [VirtualizingLayout.MeasureOverride](virtualizinglayout_measureoverride_1645510569.md) to provide the behavior for this method in a derived class.

## -see-also

## -examples

