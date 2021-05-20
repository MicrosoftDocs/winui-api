---
-api-id: M:Microsoft.UI.Input.Experimental.ExpGestureRecognizer.ProcessMoveEvents(Windows.Foundation.Collections.IVector{Microsoft.UI.Input.Experimental.ExpPointerPoint})
-api-type: winrt method
---

# Microsoft.UI.Input.Experimental.ExpGestureRecognizer.ProcessMoveEvents(Windows.Foundation.Collections.IVector{Microsoft.UI.Input.Experimental.ExpPointerPoint})

<!--
public void ProcessMoveEvents (System.Collections.Generic.IList<Microsoft.UI.Input.Experimental.ExpPointerPoint> value);
-->

## -description

> [!CAUTION]
> This API is in development and considered experimental in the WinUI version selected. It might be altered or unavailable in other versions.

Processes pointer input and raises the [ExpGestureRecognizer](expgesturerecognizer.md) events appropriate to a pointer move action (for the gestures and manipulations specified by the [GestureSettings](expgesturerecognizer_gesturesettings.md) property).

## -parameters

### -param value

The pointer location history based on the [Microsoft.UI.Input.Experimental.ExpPointerPoint.PointerId](exppointerpoint_pointerid.md). If no history is available then the value is the current location of the input pointer.

## -remarks

## -see-also

## -examples
