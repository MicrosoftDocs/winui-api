---
-api-id: M:Microsoft.UI.Xaml.Controls.FlowLayout.ShouldBreakLine(System.Int32,System.Double)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
virtual protected bool FlowLayout.ShouldBreakLine(Int32 index, Double remainingSpace)
-->

# Microsoft.UI.Xaml.Controls.FlowLayout.ShouldBreakLine

## -description

Determines whether the element at the specified index should be on a new line.

## -parameters
### -param index

The position of the element in the collection.

### -param remainingSpace

The amount of space available in the line.

## -returns

**true** if the item should be placed in a new line; otherwise, **false**.

## -remarks

The default implementation returns **true** if _remainingSpace_ is less than zero. 

## -see-also

## -examples

