---
-api-id: M:Microsoft.UI.Input.GestureRecognizer.ProcessMoveEvents(Windows.Foundation.Collections.IVector{Microsoft.UI.Input.PointerPoint})
-api-type: winrt method
---

# Microsoft.UI.Input.GestureRecognizer.ProcessMoveEvents(Windows.Foundation.Collections.IVector{Microsoft.UI.Input.PointerPoint})

<!--
public void ProcessMoveEvents (System.Collections.Generic.IList<Microsoft.UI.Input.PointerPoint> value);
-->

## -description

Processes pointer input and raises the [ExpGestureRecognizer](expgesturerecognizer.md) events appropriate to a pointer move action (for the gestures and manipulations specified by the [GestureSettings](expgesturerecognizer_gesturesettings.md) property).

For more details on this API, please see the the UWP WinRT [ProcessMoveEvents](/uwp/api/windows.ui.input.gesturerecognizer.processmoveevents) topic.

## -parameters

### -param value

The pointer location history based on the [Microsoft.UI.Input.Experimental.ExpPointerPoint.PointerId](exppointerpoint_pointerid.md). If no history is available then the value is the current location of the input pointer.

## -remarks

## -see-also

## -examples
