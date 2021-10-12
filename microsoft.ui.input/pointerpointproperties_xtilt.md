---
-api-id: P:Microsoft.UI.Input.PointerPointProperties.XTilt
-api-type: winrt property
---

# Microsoft.UI.Input.PointerPointProperties.XTilt

<!--
public float XTilt { get; }
-->

## -description

Gets the plane angle between the Y-Z plane and the plane that contains the Y axis and the axis of the input device (typically a pen/stylus).

## -property-value

The value is 0.0 when the finger or pen is perpendicular to the digitizer surface, between 0.0 and 90.0 when tilted to the right of perpendicular, and between 0.0 and -90.0 when tilted to the left of perpendicular. The default value is 0.0.

## -remarks

This property is used in conjunction with [YTilt](pointerpointproperties_ytilt.md) to indicate the tilt away from normal of the input device.

## -see-also

## -examples
