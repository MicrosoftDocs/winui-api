---
-api-id: M:Microsoft.UI.Xaml.Controls.FlowLayout.OnElementMeasured(Windows.UI.Xaml.UIElement,System.Int32,Windows.Foundation.Size,Windows.Foundation.Size,Windows.Foundation.Size,Windows.Foundation.Size,Microsoft.UI.Xaml.Controls.VirtualizingLayoutContext)
-api-type: winrt method
---

# Microsoft.UI.Xaml.Controls.FlowLayout.OnElementMeasured(Windows.UI.Xaml.UIElement,System.Int32,Windows.Foundation.Size,Windows.Foundation.Size,Windows.Foundation.Size,Windows.Foundation.Size,Microsoft.UI.Xaml.Controls.VirtualizingLayoutContext)

<!--
protected virtual void OnElementMeasured (Windows.UI.Xaml.UIElement element, int index, Windows.Foundation.Size availableSize, Windows.Foundation.Size measureSize, Windows.Foundation.Size desiredSize, Windows.Foundation.Size provisionalArrangeSize, Microsoft.UI.Xaml.Controls.VirtualizingLayoutContext context);
-->

## -description

Called when an element has been measured.

## -parameters

### -param element

The measured element.

### -param index

The position of the element in the collection.

### -param availableSize

The amount of space available for the element.

### -param measureSize

The measure size of the element.

### -param desiredSize

The preferred size of the element.

### -param provisionalArrangeSize

The size intended to eventually arrange the element.

### -param context

The context object that facilitates communication between the layout and its host container.

## -remarks

This method lets a subclass maintain its own estimation information. 

## -see-also

## -examples

