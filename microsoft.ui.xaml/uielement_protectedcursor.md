---
-api-id: P:Microsoft.UI.Xaml.UIElement.ProtectedCursor
-api-type: winrt property
---

# Microsoft.UI.Xaml.UIElement.ProtectedCursor

<!--
protected Windows.UI.Core.CoreCursor ProtectedCursor { get; set; }
-->

## -description

Gets or sets the cursor that displays when the pointer is over this element. Defaults to null, indicating no change to the cursor.

## -property-value

The cursor that displays when the pointer is over this element.

## -remarks

If an element and any of its descendant elements have this property set, when the pointer is over the descendent, the descendant's value is used.

A pointer is 'over' an element if it hit-tests to either the element or a descendent element.

An exception to this is if the pointer has been captured using the [UIElement.CapturePointer](uielement_capturepointer_1027273898.md) method, which sends pointer input to the capturing element regardless of where it's located. If pointer input is captured to an element or its tree, the pointer is "over" that element.

> [!NOTE]
> Even if a child of the element marks a pointer event [Handled](../microsoft.ui.input/pointereventargs_handled.md), the **ProtectedCursor** property will still be used.

## -see-also

## -examples
