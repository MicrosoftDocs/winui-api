---
-api-id: P:Microsoft.UI.Input.PointerPointProperties.IsCanceled
-api-type: winrt property
---

# Microsoft.UI.Input.PointerPointProperties.IsCanceled

<!--
public bool IsCanceled { get; }
-->

## -description

Gets a value that indicates whether the input was canceled by the pointer device.

## -property-value

True if the input was canceled. Otherwise, false.

## -remarks

Pointer input can be canceled for various reasons, including:

- Palm rejection
- Input arbitration (such as pen/stylus proximity overriding touch input)
- Device removal
- Invalid state transition
- Screen rotation
- Desktop switching

## -see-also

## -examples
