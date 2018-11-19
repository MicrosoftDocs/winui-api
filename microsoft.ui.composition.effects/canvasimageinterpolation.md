---
-api-id: T:Microsoft.UI.Composition.Effects.CanvasImageInterpolation
-api-type: winrt enum
ms.custom: RS5
---

<!-- Enumeration syntax.
public enum CanvasImageInterpolation : int 
-->

# Microsoft.UI.Composition.Effects.CanvasImageInterpolation

## -description
Specifies the quality used for image resizing and transforms.

## -enum-fields
### -field NearestNeighbor:0
Samples the nearest single point and uses that exact color. This option is the fastest, but outputs the lowest quality image.

### -field MultiSampleLinear:3
Uses 4 linear samples within a single pixel for good edge anti-aliasing. This mode is good for scaling down by small amounts on images with few pixels.

### -field Linear:1
Uses a four point sample and linear interpolation. Compared to NearestNeighbor, this option is slower but outputs a higher quality image.

### -field HighQualityCubic:5
Uses a variable size high quality cubic kernel to perform a pre-downscale the image if downscaling is involved in the transform matrix. Then uses the cubic interpolation mode for the final output.

### -field Cubic:2
Uses a 16 sample cubic kernel for interpolation. This mode uses the most processing time, but outputs a higher quality image.

### -field Anisotropic:4
Uses anisotropic filtering to sample a pattern according to the transformed shape of the image.

## -remarks

## -see-also

## -examples

