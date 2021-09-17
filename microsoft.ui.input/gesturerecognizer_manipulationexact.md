---
-api-id: P:Microsoft.UI.Input.GestureRecognizer.ManipulationExact
-api-type: winrt property
---

# Microsoft.UI.Input.GestureRecognizer.ManipulationExact

<!--
public bool ManipulationExact { get; set; }
-->

## -description

Gets or sets a value that indicates whether the exact distance from initial contact to end of the interaction is reported.

For more details on this API, please see the the UWP WinRT [ManipulationExact](/uwp/api/windows.ui.input.gesturerecognizer.manipulationexact) topic.

## -property-value

True, if the distance threshold is subtracted. Otherwise false. The default value is false.

## -remarks

By default, a small distance threshold is subtracted from the first delta reported by the system. This distance threshold is intended to account for slight movements of the contact when processing a tap gesture. If this flag is set, the distance threshold is not subtracted from the first delta.

## -see-also

## -examples
