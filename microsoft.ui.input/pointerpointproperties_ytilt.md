---
-api-id: P:Microsoft.UI.Input.PointerPointProperties.YTilt
-api-type: winrt property
---

# Microsoft.UI.Input.PointerPointProperties.YTilt

<!--
public float YTilt { get; }
-->

## -description

Gets the plane angle between the X-Z plane and the plane that contains the X axis and the axis of the input device (typically a pen/stylus).

## -property-value

The value is 0.0 when the finger or pen is perpendicular to the digitizer surface, between 0.0 and 90.0 when tilted towards the user, and between 0.0 and -90.0 when tilted away from the user. The default value is 0.0.

## -remarks

This property is used in conjunction with [XTilt](pointerpointproperties_xtilt.md) to indicate the tilt away from normal of the input device.

## -see-also

## -examples
