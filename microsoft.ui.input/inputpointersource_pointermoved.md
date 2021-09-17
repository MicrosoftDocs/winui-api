---
-api-id: E:Microsoft.UI.Input.InputPointerSource.PointerMoved
-api-type: winrt event
---

# Microsoft.UI.Input.InputPointerSource.PointerMoved

<!--
public event Windows.Foundation.TypedEventHandler<Microsoft.UI.Input.InputPointerSource,Microsoft.UI.Input.PointerEventArgs> PointerMoved;
-->

## -description

Occurs when a pointer moves while within the bounds of this [InputPointerSource](inputpointersource.md).

## -remarks

Mouse and pen devices fire PointerMoved events more frequently than touch. A touch point is only detectable if a finger is touching the surface, while a mouse has an onscreen cursor that is always visible, even if no mouse button is pressed, and a pen can hover over a digitizer surface without touching it.

Mouse input is associated with a single pointer assigned when mouse input is first detected, and all mouse-initiated interactions have the same PointerId. Clicking a mouse button (left, wheel, or right) creates a secondary association between the pointer and that button through the PointerPressed event. The PointerReleased event is fired only when that same mouse button is released (no other button can be associated with the pointer until this event is complete). Because of this exclusive association, other mouse button clicks are routed through the PointerMoved event.

## -see-also

## -examples
