---
-api-id: P:Microsoft.UI.Input.Experimental.ExpGestureRecognizer.CrossSlideExact
-api-type: winrt property
---

# Microsoft.UI.Input.Experimental.ExpGestureRecognizer.CrossSlideExact

<!--
public bool CrossSlideExact { get; set; }
-->

## -description

> [!CAUTION]
> This API is in development and considered experimental in the WinUI version selected. It might be altered or unavailable in other versions.

Gets or sets a value that indicates whether the exact distance from initial contact to end of the cross-slide interaction is reported.

> [!NOTE]
> By default, a small distance threshold is subtracted from the first position reported by the system for cross-slide interactions. This distance threshold is intended to account for any slight movement of the contact after initial detection. It helps the system differentiate between cross-sliding and panning, and helps ensure that a tap gesture is not interpreted as either. If this flag is set, the distance threshold is not subtracted from the initial position.

## -property-value

## -remarks

## -see-also

## -examples
