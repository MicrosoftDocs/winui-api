---
-api-id: T:Microsoft.UI.Input.Interop.PenDeviceInterop
-api-type: winrt class
---

# Microsoft.UI.Input.Interop.PenDeviceInterop

<!--
public static class PenDeviceInterop
-->

## -description

Supports the ability to identify and track an active system [PenDevice](/uwp/api/windows.devices.input.pendevice) object through interop.

## -remarks

## -see-also

## -examples

The following code shows how to relate a [PointerPoint](../microsoft.ui.input/pointerpoint.md) to a system [PenDevice](/uwp/api/windows.devices.input.pendevice):

```csharp
private void PointerInputSource_PointerEntered(InputPointerSource sender, PointerEventArgs args)
{
    var penDevice = PenDeviceInterop.PenDeviceFromPointerPoint(args.CurrentPoint);
}
```
