---
-api-id: T:Microsoft.UI.Composition.Effects.CanvasAlphaMode
-api-type: winrt enum
ms.custom: RS5
---

<!-- Enumeration syntax.
public enum CanvasAlphaMode : int 
-->

# Microsoft.UI.Composition.Effects.CanvasAlphaMode

## -description
Specifies the way in which an alpha channel affects color channels.

## -enum-fields
### -field Straight:1
The alpha channel indicates the transparency of the color.

### -field Premultiplied:0
The alpha value has been premultiplied. In blending, each color is scaled by the alpha value. Note that the alpha value itself is the same in both straight and premultiplied alpha. Typically, no color channel value is greater than the alpha channel value.

### -field Ignore:2
The alpha value is ignored.

## -remarks

## -see-also

## -examples

