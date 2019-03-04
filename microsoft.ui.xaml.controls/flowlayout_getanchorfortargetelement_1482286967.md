---
-api-id: M:Microsoft.UI.Xaml.Controls.FlowLayout.GetAnchorForTargetElement(System.Int32,Windows.Foundation.Size,Microsoft.UI.Xaml.Controls.VirtualizingLayoutContext)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
virtual protected FlowLayoutAnchorInfo FlowLayout.GetAnchorForTargetElement(Int32 targetIndex, Size availableSize, VirtualizingLayoutContext context)
-->

# Microsoft.UI.Xaml.Controls.FlowLayout.GetAnchorForTargetElement

## -description

Retrives an anchor for a target.

## -parameters
### -param targetIndex

The index of the element that is the target of scrolling.

### -param availableSize

The amount of space available.

### -param context

The context object that facilitates communication between the layout and its host container.

## -returns

The anchor for the target element.

## -remarks

When scrolling to a _targetIndex_, this method gives the FlowLayout the anchor for the target. The anchor is the first element on the line that contains the target.

## -see-also

## -examples

