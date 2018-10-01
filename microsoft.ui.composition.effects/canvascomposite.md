---
-api-id: T:Microsoft.UI.Composition.Effects.CanvasComposite
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum CanvasComposite : int 
-->

# Microsoft.UI.Composition.Effects.CanvasComposite

## -description
Specifies the composite mode used for the effect.

## -enum-fields
### -field Xor:8
Union of source and destination bitmaps with xor function for pixels that overlap. Equation: O = (1 - DA) * S + (1 - SA) * D.

### -field SourceOver:0
Union of source and destination bitmaps. Equation: O = S + (1 - SA) * D.

### -field SourceOut:4
Region of the source bitmap. Equation: O = (1 - DA) * S.

### -field SourceIn:2
Intersection of source and destination bitmaps. Equation: O = DA * S

### -field SourceAtop:6
Region of the destination bitmap. Equation: O = DA * S + (1 - SA) * D.

### -field MaskInvert:12
Union of source and destination bitmaps with unchanged alpha. Equation: O = (1 - D) * S + (1 - SA) * D.

### -field DestinationOver:1
Union of source and destination bitmaps. Equation: O = (1 - DA) * S + D.

### -field DestinationOut:5
Region of the destination bitmap. Equation: O = (1 - SA) * D.

### -field DestinationIn:3
Intersection of source and destination bitmaps. Equation: O = SA * D.

### -field DestinationAtop:7
Region of the source bitmap. Equation: O = (1 - DA) * S + SA * D.

### -field Copy:10
Region of the source bitmap. Equation: O = S.

### -field BoundedCopy:11
Union of source and destination bitmaps with no destination override. Equation: O = S (only where source exists).

### -field Add:9
Union of source and destination bitmaps. Equation: O = S + D.

## -remarks

## -see-also

## -examples

