---
-api-id: P:Microsoft.UI.Composition.Interactions.InteractionTrackerInertiaMotion.Condition
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Composition.ExpressionAnimation Condition { get;  set; }
-->

# Microsoft.UI.Composition.Interactions.InteractionTrackerInertiaMotion.Condition

## -description
An [ExpressionAnimation](../microsoft.ui.composition/expressionanimation.md) describing when the modifier should be applied.

The Condition property is an [ExpressionAnimation](../microsoft.ui.composition/expressionanimation.md) that defines when the specified motion equation is utilized by [InteractionTracker](interactiontracker.md) during Inertia. This expression gets evaluated once after the interaction occurs and must resolve to a type Bool, otherwise an error will be thrown when the condition is evaluated. See the [ExpressionAnimation](../microsoft.ui.composition/expressionanimation.md) class page for more details on building expressions.

## -property-value
An [ExpressionAnimation](../microsoft.ui.composition/expressionanimation.md) describing when the modifier should be applied.

## -remarks

## -examples

## -see-also
