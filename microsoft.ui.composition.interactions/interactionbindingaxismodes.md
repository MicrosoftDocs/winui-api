---
-api-id: T:Microsoft.UI.Composition.Interactions.InteractionBindingAxisModes
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum InteractionBindingAxisModes : uint 
-->

# Microsoft.UI.Composition.Interactions.InteractionBindingAxisModes

## -description

Defines constants that specify which axis is bound between two interaction trackers.

## -enum-fields
### -field Scale:4

The binding affects scale.

### -field PositionY:2

The binding affects the Y axis.

### -field PositionX:1

The binding affects the X axis.

### -field None:0

The binding does not affect any axis.

## -remarks

Pass **None** to [InteractionTracker.SetBindingMode](interactiontracker_setbindingmode_2058258409.md) to remove an existing binding mode.

## -see-also

## -examples

