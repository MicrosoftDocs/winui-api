---
-api-id: T:Microsoft.UI.Input.ManipulationDelta
-api-type: winrt struct
---

# Microsoft.UI.Input.ManipulationDelta

<!--
public struct ManipulationDelta
-->

## -description

Contains the accumulated transformations for the current manipulation.

## -struct-fields

### -field Expansion

The change in x-y screen coordinates, in device-independent pixels (DIP).

### -field Rotation

The change in angle of rotation, in degrees.

### -field Scale

The change in distance between touch contacts, as a percentage. For example, if the distance between two contacts changes from 100 device-independent pixel (DIP) to 200 device-independent pixel (DIP) during a manipulation, the value of **Scale** would be 2.0.

### -field Translation

The change in x-y screen coordinates, in device-independent pixels (DIP).

## -remarks

## -see-also

[Touch interactions - Manipulation events](/windows/uwp/design/input/touch-interactions#manipulation-events), [Basic input sample](https://github.com/microsoft/Windows-universal-samples/tree/main/Samples/BasicInput), [Low latency input sample](https://github.com/microsoft/Windows-universal-samples/tree/main/Samples/LowLatencyInput)

## -examples
