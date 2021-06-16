---
-api-id: T:Microsoft.UI.Input.Experimental.ExpPointerPoint
-api-type: winrt class
---

# Microsoft.UI.Input.Experimental.ExpPointerPoint

<!--
public sealed class ExpPointerPoint
-->

## -description

> [!CAUTION]
> This API is in development and considered experimental in the WinUI version selected. It might be altered or unavailable in other versions.

Provides basic properties for the input pointer associated with a single mouse, pen/stylus, or touch contact.

## -remarks

See [ExpPointerPointProperties](exppointerpointproperties.md) for extended properties accessible through `Properties`.

The `ExpPointerPoint` coordinate space is dependent on the context in which it is retrieved. When retrieved from [Microsoft.UI.Xaml.Input.PointerRoutedEventArgs.GetCurrentPoint](../microsoft.ui.xaml.input/pointerroutedeventargs_getcurrentpoint_293890010.md), the coordinates of the pointer will be relative to the provided `UIElement` in device independent pixels.

> [!NOTE]
> The [PointerDevice](/uwp/api/windows.devices.input.pointerdevice) is not directly accessible from the `ExpPointerPoint` object. See the examples for how to retrieve the `PointerDevice` if needed.

> [!NOTE]
> This class is not agile, which means its functions and properties may only be accessed on the UI thread from where it was retrieved. Access on a different thread will return `RPC_E_WRONG_THREAD` or the equivalent projected error type.

## -see-also

[ExpPointerPointProperties](exppointerpointproperties.md), [Microsoft.UI.Xaml.Input.PointerRoutedEventArgs](../microsoft.ui.xaml.input/pointerroutedeventargs.md)

## -examples

In the following example, we query various pointer properties using a PointerPoint object.

```csharp
String queryPointer(ExpPointerPoint ptrPt)
{
    String details = "";

    switch (ptrPt.PointerDeviceType)
    {
        case Windows.Devices.Input.PointerDeviceType.Mouse:
            details += "\nPointer type: mouse";
            break;
        case Windows.Devices.Input.PointerDeviceType.Pen:
            details += "\nPointer type: pen";
            if (ptrPt.IsInContact)
            {
                details += "\nPressure: " + ptrPt.Properties.Pressure;
                details += "\nrotation: " + ptrPt.Properties.Orientation;
                details += "\nTilt X: " + ptrPt.Properties.XTilt;
                details += "\nTilt Y: " + ptrPt.Properties.YTilt;
                details += "\nBarrel button pressed: " + ptrPt.Properties.IsBarrelButtonPressed;
            }
            break;
        case Windows.Devices.Input.PointerDeviceType.Touch:
            details += "\nPointer type: touch";
            details += "\nrotation: " + ptrPt.Properties.Orientation;
            details += "\nTilt X: " + ptrPt.Properties.XTilt;
            details += "\nTilt Y: " + ptrPt.Properties.YTilt;
            break;
        default:
            details += "\nPointer type: n/a";
            break;
    }

    details += "\nPointer Id: " + ptrPt.PointerId.ToString() +
        "\nPointer location: " + ptrPt.Position.X + ", " + ptrPt.Position.Y;

    return details;
}
```

In this example we demonstrate how to find the system [PointerDevice](/uwp/api/windows.devices.input.pointerdevice) associated with an `ExpPointerPoint` object:

```csharp
Windows.Devices.Input.PointerDevice getPointerDeviceFromPointPoint(ExpPointerPoint ptrPt)
{
    var pointerDeviceList = Windows.Devices.Input.PointerDevice.GetPointerDevices(); 

    foreach (Windows.Devices.Input.PointerDevice pointerDevice in pointerDeviceList) 
    { 
        if (pointerDevice.PointerDeviceType == ptrPt.PointerDeviceType)
        {
            return pointerDevice;
        }
    }  

    return null;
}
```
