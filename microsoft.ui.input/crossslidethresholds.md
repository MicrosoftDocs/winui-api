---
-api-id: T:Microsoft.UI.Input.CrossSlideThresholds
-api-type: winrt struct
---

# Microsoft.UI.Input.CrossSlideThresholds

<!--
public struct CrossSlideThresholds
-->

## -description

Contains the distance thresholds for a [CrossSliding](gesturerecognizer_crosssliding.md) interaction.

## -struct-fields

### -field RearrangeStart

The distance, in device-independent pixel (DIP), from the initial point of contact until the rearrange action is initiated.

### -field SelectionStart

The distance, in device-independent pixel (DIP), from the initial point of contact until the selection action is initiated.

### -field SpeedBumpEnd

The distance, in device-independent pixel (DIP), from the initial point of contact until the end of the speed bump.

### -field SpeedBumpStart

The distance, in device-independent pixel (DIP), from the initial point of contact until the speed bump is initiated.

## -remarks

A speed bump is a [CrossSliding](gesturerecognizer_crosssliding.md) region in which the user experiences a slight drag (or friction) during a swipe or slide gesture.

## -see-also

## -examples
