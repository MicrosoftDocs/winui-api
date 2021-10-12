---
-api-id: T:Microsoft.UI.Input.MouseWheelParameters
-api-type: winrt class
---

# Microsoft.UI.Input.MouseWheelParameters

<!--
public sealed class MouseWheelParameters
-->

## -description

Provides properties associated with the button wheel of a mouse device.

## -remarks

The properties exposed through MouseWheelParameters are used in conjunction with the **Wheel** settings in the **Mouse** control panel to define the UI experience when using the button wheel.

The mouse wheel button has discrete, evenly spaced notches or distance thresholds (also called detents). When you rotate or tilt the wheel, a wheel message is sent as each detent is encountered.

> [!NOTE]
> This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](/cpp/cppcx/threading-and-marshaling-c-cx) and [Using Windows Runtime objects in a multithreaded environment (.NET)](/windows/uwp/threading-async/using-windows-runtime-objects-in-a-multithreaded-environment).

## -see-also

[Windows.UI.Input.GestureRecognizer.mouseWheelParameters](gesturerecognizer_mousewheelparameters.md)

## -examples
