---
-api-id: M:Microsoft.UI.Composition.Interactions.InteractionTracker.TryUpdatePositionBy(Windows.Foundation.Numerics.Vector3,Microsoft.UI.Composition.Interactions.InteractionTrackerClampingOption)
-api-type: winrt method
---

<!-- Method syntax.
public int InteractionTracker.TryUpdatePositionBy(Vector3 amount, InteractionTrackerClampingOption option)
-->

# Microsoft.UI.Composition.Interactions.InteractionTracker.TryUpdatePositionBy

## -description

Tries to adjust the position of the [InteractionTracker](interactiontracker.md) by the specified amount using the specified clamping option.

## -parameters

### -param amount

The value to add to the current position.

### -param option

A value that specifies how values are clamped to the maximum and minimum.

## -returns

Returns the request ID. On state transitions, the request which caused the change in state will be included in the args. These IDs will start at 1 and increase with each try call during the lifetime of the application.

## -remarks

## -see-also

## -examples

