---
-api-id: P:Microsoft.UI.Input.GestureRecognizer.CrossSlideExact
-api-type: winrt property
---

# Microsoft.UI.Input.GestureRecognizer.CrossSlideExact

<!--
public bool CrossSlideExact { get; set; }
-->

## -description

Gets or sets a value that indicates whether the exact distance from initial contact to end of the cross-slide interaction is reported.

For more details on this API, please see the the UWP WinRT [CrossSlideExact](/uwp/api/windows.ui.input.gesturerecognizer.crossslideexact) topic.

## -property-value

A value that indicates whether the exact distance from initial contact to end of the cross-slide interaction is reported.

## -remarks

By default, a small distance threshold is subtracted from the first position reported by the system for cross-slide interactions. This distance threshold is intended to account for any slight movement of the contact after initial detection. It helps the system differentiate between cross-sliding and panning, and helps ensure that a tap gesture is not interpreted as either. If this flag is set, the distance threshold is not subtracted from the initial position.

## -see-also

## -examples
