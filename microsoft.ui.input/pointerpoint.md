---
-api-id: T:Microsoft.UI.Input.PointerPoint
-api-type: winrt class
---

# Microsoft.UI.Input.PointerPoint

<!--
public sealed class PointerPoint
-->

## -description

Provides basic properties for the input pointer associated with a single mouse, pen/stylus, or touch contact.

## -remarks

See [PointerPointProperties](pointerpointproperties.md) for extended properties accessible through `Properties`.

The `PointerPoint` coordinate space is dependent on the context in which it is retrieved. When retrieved from [PointerRoutedEventArgs.GetCurrentPoint](../microsoft.ui.xaml.input/pointerroutedeventargs_getcurrentpoint_293890010.md), the coordinates of the pointer will be relative to the provided `UIElement` in device independent pixels.

> [!NOTE]
> The  [PointerDevice](/uwp/api/windows.devices.input.pointerdevice) is not directly accessible from the `PointerPoint` object. See the examples for how to retrieve the `PointerDevice` if needed.

## -see-also

[PointerPointProperties](pointerpointproperties.md), [Microsoft.UI.Xaml.Input.PointerRoutedEventArgs](../microsoft.ui.xaml.input/pointerroutedeventargs.md)

## -examples

In the following example, we query various pointer properties using a PointerPoint object.

```csharp
String queryPointer(PointerPoint ptrPt)
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

In this example we demonstrate how to find the system [PointerDevice](/uwp/api/windows.devices.input.pointerdevice) associated with an `PointerPoint` object:

```csharp
Windows.Devices.Input.PointerDevice getPointerDeviceFromPointPoint(PointerPoint ptrPt)
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
