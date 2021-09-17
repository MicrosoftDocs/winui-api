---
-api-id: M:Microsoft.UI.Input.PointerEventArgs.GetIntermediateTransformedPoints(Microsoft.UI.Input.IPointerPointTransform)
-api-type: winrt method
---

# Microsoft.UI.Input.PointerEventArgs.GetIntermediateTransformedPoints(Microsoft.UI.Input.IPointerPointTransform)

<!--
public System.Collections.Generic.IList<Microsoft.UI.Input.PointerPoint> GetIntermediateTransformedPoints (Microsoft.UI.Input.IPointerPointTransform transform);
-->

## -description

Retrieves the pointer data for up to the last 64 pointer locations since the last pointer event, transformed by the application-defined transform.

## -parameters

### -param transform

The application-defined transform.

## -returns

The collection of transformed pointer data or an empty collection, if the application-defined transform fails.

## -remarks

## -see-also

## -examples
