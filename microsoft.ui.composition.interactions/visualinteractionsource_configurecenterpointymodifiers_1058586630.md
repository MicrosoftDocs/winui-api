---
-api-id: M:Microsoft.UI.Composition.Interactions.VisualInteractionSource.ConfigureCenterPointYModifiers(Windows.Foundation.Collections.IIterable{Microsoft.UI.Composition.Interactions.CompositionConditionalValue})
-api-type: winrt method
---

<!-- Method syntax.
public void VisualInteractionSource.ConfigureCenterPointYModifiers(IIterable<CompositionConditionalValue> conditionalValues)
-->

# Microsoft.UI.Composition.Interactions.VisualInteractionSource.ConfigureCenterPointYModifiers

## -description
Takes an ordered list of CompositionConditionalValue. In a frame, the first CompositionConditionalValue to have its “.Condition” evaluate to true replaces the zoom CenterPointY value the VisualInteractionSource provides with its “.Value”. If none evaluate to true, the CenterPointY is not replaced that frame.

## -parameters

### -param conditionalValues

## -remarks

## -see-also

## -examples

