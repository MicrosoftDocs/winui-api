---
-api-id: P:Microsoft.UI.Xaml.UIElement.PointerCaptures
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVectorView<Windows.UI.Xaml.Input.Pointer> PointerCaptures { get; }
-->

# Microsoft.UI.Xaml.UIElement.PointerCaptures

## -description
Gets the set of all captured pointers, represented as [Pointer](../microsoft.ui.xaml.input/pointer.md) values.

## -property-value
The collection of captured pointers, each represented as a [Pointer](../microsoft.ui.xaml.input/pointer.md) object.
## -remarks
For more info on how to capture a pointer and why you might want to do so, see [CapturePointer](uielement_capturepointer_1027273898.md).

Because there are input scenarios such as manipulations that involve more than one pointer point, the Windows Runtime enables capturing more than one pointer at a time. The PointerCaptures property exposes a view of which pointer points are currently captured by the [UIElement](uielement.md).

This property's value is calculated based on the results of other actions. Calling [CapturePointer](uielement_capturepointer_1027273898.md) adds to the internal collection that PointerCaptures provides a read-only view of. Calling [ReleasePointerCapture](uielement_releasepointercapture_851958174.md) removes from the collection. [ReleasePointerCaptures](uielement_releasepointercaptures_190109337.md) clears the collection. User action that invalidates pointer capture such as releasing from a pointer point also changes capture state and thus the collection. For more info, see [Mouse interactions](/windows/uwp/input-and-devices/mouse-interactions) and [Handle pointer input](/windows/apps/design/input/handle-pointer-input).

The collection is not necessarily indexed by [PointerId](../microsoft.ui.xaml.input/pointer_pointerid.md). To find a specific [PointerId](../microsoft.ui.xaml.input/pointer_pointerid.md), you must check the items in the collection and reference a specific [Pointer](../microsoft.ui.xaml.input/pointer.md).

## -examples

## -see-also
[CapturePointer](uielement_capturepointer_1027273898.md), PointerCaptures, [Pointer](../microsoft.ui.xaml.input/pointer.md), [Handle pointer input](/windows/apps/design/input/handle-pointer-input), [Relative mouse movement and CoreWindow](/en-us/windows/uwp/gaming/relative-mouse-movement)
