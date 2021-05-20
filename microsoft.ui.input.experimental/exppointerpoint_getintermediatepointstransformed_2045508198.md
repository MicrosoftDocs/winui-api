---
-api-id: M:Microsoft.UI.Input.Experimental.ExpPointerPoint.GetIntermediatePointsTransformed(System.UInt32,Windows.UI.Input.IPointerPointTransform)
-api-type: winrt method
---

# Microsoft.UI.Input.Experimental.ExpPointerPoint.GetIntermediatePointsTransformed(System.UInt32,Windows.UI.Input.IPointerPointTransform)

<!--
public static System.Collections.Generic.IList<Microsoft.UI.Input.Experimental.ExpPointerPoint> GetIntermediatePointsTransformed (uint pointerId, Windows.UI.Input.IPointerPointTransform transform);
-->

## -description

Retrieves the transformed position and state information for the specified pointer (from the last pointer event to the current pointer event, inclusive).

## -parameters

### -param pointerId

> [!CAUTION]
> This API is in development and considered experimental in the WinUI version selected. It might be altered or unavailable in other versions.

The ID of the pointer.

### -param transform

The transform to apply to the pointer.

## -returns

The transformed pointer properties (current and historic).

## -remarks

## -see-also

## -examples
